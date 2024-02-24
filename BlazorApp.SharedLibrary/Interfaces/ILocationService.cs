using BlazorApp.SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Interfaces
{
    public interface ILocationService
    {
        Task<ICollection<Location>> GetLocations();
        Task<Location> GetLocationById(int locationId);
        Task<bool> AnyPremiseHas(int locationId);
        Task CreateLocation(Location location);            
        Task DeleteLocation(Location location);
        bool LocationExists(string city, string country);
        Task UpdateLocation(Location location);
    }
}
