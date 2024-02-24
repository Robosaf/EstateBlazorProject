
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Services
{
    public class PremiseFeatureService : IPremiseFeatureService
    {
        private readonly DataContext _context;

        public PremiseFeatureService(DataContext context)
        {
            _context = context;
        }
        public async Task<ICollection<int>> GetFeaturesIdByPremiseId(int premiseId)
        {
            return await _context
                .PremiseFeatures
                .Where(pf => pf.PremiseId == premiseId)
                .Select(pf => pf.FeatureId)
                .ToListAsync();
        }
    }
}
