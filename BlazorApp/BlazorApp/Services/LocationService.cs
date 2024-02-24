
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Services
{
    public class LocationService : ILocationService
    {
        private readonly DataContext _context;

        public LocationService(DataContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Location>> GetLocations()
        {
            return await _context.Locations.AsNoTracking().ToListAsync();
        }
        public async Task<Location> GetLocationById(int locationId)
        {
            return await _context.Locations.AsNoTracking().FirstOrDefaultAsync(l => l.Id == locationId);
        }

        public async Task<bool> AnyPremiseHas(int locationId)
        {
            return await _context.Premises.Where(p => p.LocationId == locationId).AnyAsync();
        }

        public async Task DeleteLocation(Location location)
        {
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
        }

        public async Task CreateLocation(Location location)
        {
            await _context.AddAsync(location);
            await _context.SaveChangesAsync();
        }

        public bool LocationExists(string city, string country)
        {
            return _context.Locations.AsNoTracking().Any(l =>
            l.Country.ToLower().Trim() == country.ToLower().Trim() &&
            l.City.ToLower().Trim() == city.ToLower().Trim());
        }

        public async Task UpdateLocation(Location location)
        {
            _context.Update(location);
            await _context.SaveChangesAsync();
        }
    }
}
