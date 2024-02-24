using BlazorApp.Data;
using BlazorApp.SharedLibrary.Helper;
using BlazorApp.SharedLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;

namespace BlazorApp.Services
{
    public class PremiseService : IPremiseService
    {
        private readonly DataContext _context;

        public PremiseService(DataContext context)
        {
            _context = context;
        }

        public async Task CreatePremise(List<FeatureBool> featureBool, Premise premise)
        {            
            //Add Premise
            premise.PremiseFeatures = null!;
            await _context.Premises.AddAsync(premise);
            await _context.SaveChangesAsync();

            //Add Features to Premise
            List<string> featureNameTrue = featureBool.Where(f => f.IsChecked).Select(f => f.FeatureName).ToList();
            List<Feature> features = new List<Feature>();
            foreach (var fn in featureNameTrue)
            {
                features.Add(_context.Features.Where(f => f.Name == fn).FirstOrDefault()!);
            }

            foreach (var feature in features)
            {
                var premiseFeature = new PremiseFeature
                {
                    Premise = premise,
                    FeatureId = feature.Id
                };

                await _context.PremiseFeatures.AddAsync(premiseFeature);
                await _context.SaveChangesAsync();
            }

        }

        public async Task DeletePremise(int premiseId)
        {
            var premise = await _context.Premises.FirstOrDefaultAsync(p => p.Id == premiseId);
            _context.Premises.Remove(premise!);


            await _context.SaveChangesAsync();
        }

        public async Task<Premise> GetPremiseById(int premiseId)
        {
            var premise = await _context.Premises
                .AsNoTracking()
                .Include(p => p.Location)
                .Include(p => p.PremiseFeatures)
                .FirstOrDefaultAsync(p => p.Id == premiseId);

            return premise!;
        }

        public async Task<ICollection<Premise>> GetPremises()
        {
            var result = await _context.Premises
                    .AsNoTracking()
                    .Include(p => p.Location)
                    .ToListAsync();

            return result;
        }

        public async Task UpdatePremise(List<FeatureBool> featureBool, Premise premise)
        {

            List<FeatureBool> featuresToUpdate = new List<FeatureBool>();
            foreach (var feature in featureBool)
            {
                featuresToUpdate.Add(new FeatureBool 
                { 
                    Feature = _context.Features.AsNoTracking().Where(f => f.Name == feature.FeatureName).FirstOrDefault()!,
                    IsChecked = feature.IsChecked
                });
            }


            foreach (var fb in featuresToUpdate)
            {
                var premiseFeature = new PremiseFeature
                {
                    PremiseId = premise.Id,
                    FeatureId = fb.Feature.Id,
                    Premise = premise,
                    Feature = fb.Feature
                };

                if (_context.PremiseFeatures.Contains(premiseFeature))
                {
                    if (!fb.IsChecked)
                    {
                        _context.PremiseFeatures.Remove(new PremiseFeature 
                        { 
                            FeatureId = premiseFeature.FeatureId,
                            PremiseId = premiseFeature.PremiseId
                        });
                        _context.SaveChanges();
                    }
                }
                else
                {
                    if (fb.IsChecked)
                    {
                        _context.PremiseFeatures.Add(new PremiseFeature 
                        { 
                            FeatureId = fb.Feature.Id, 
                            PremiseId = premise.Id,
                        });
                        _context.SaveChanges();
                    }
                }
            }

            _context.Premises.Update(premise);

            await _context.SaveChangesAsync();

        }
    }
}
