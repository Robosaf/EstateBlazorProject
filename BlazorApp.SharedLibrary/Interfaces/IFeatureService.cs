using BlazorApp.SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Interfaces
{
    public interface IFeatureService
    {
        Task<Feature> GetFeatureById(int featureId);
        Task<ICollection<Feature>> GetFeatures();
        Task CreateFeature(Feature feature);
        bool FeatureExists(string featureName);
        Task UpdateFeature(Feature feature);
        Task DeleteFeature(Feature feature);

    }
}
