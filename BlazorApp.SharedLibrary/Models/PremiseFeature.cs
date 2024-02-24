using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Models
{
    public class PremiseFeature
    {
        public int PremiseId { get; set; }
        public Premise Premise { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
