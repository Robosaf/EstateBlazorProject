using BlazorApp.SharedLibrary.Helper;
using BlazorApp.SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Interfaces
{
    public interface IPremiseService
    {
        Task<ICollection<Premise>> GetPremises();
        Task<Premise> GetPremiseById(int premiseId);
        Task CreatePremise(List<FeatureBool> featureBool, Premise premise);
        Task UpdatePremise(List<FeatureBool> featureBool, Premise premise);
        Task DeletePremise(int premiseId);

    }
}
