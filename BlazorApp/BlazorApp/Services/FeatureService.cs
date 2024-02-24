
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly DataContext _context;

        public FeatureService(DataContext context)
        {
            _context = context;
        }

        public async Task CreateFeature(Feature feature)
        {
            await _context.Features.AddAsync(feature);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFeature(Feature feature)
        {
            _context.Features.Remove(feature);
            await _context.SaveChangesAsync();
        }

        public bool FeatureExists(string featureName)
        {
            return _context.Features.AsNoTracking().Any(f => f.Name.Trim().ToLower() == featureName.Trim().ToLower());
        }

        public async Task<Feature> GetFeatureById(int featureId)
        {
            return await _context.Features.AsNoTracking().FirstOrDefaultAsync(f => f.Id == featureId);
        }

        public async Task<ICollection<Feature>> GetFeatures()
        {
            return await _context.Features.AsNoTracking().ToListAsync();
        }

        public async Task UpdateFeature(Feature feature)
        {
            _context.Features.Update(feature);
            await _context.SaveChangesAsync();
        }
    }
}
