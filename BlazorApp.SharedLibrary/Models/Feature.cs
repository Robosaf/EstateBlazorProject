using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required, MinLength(5)]
        public string Name { get; set; }
        public ICollection<PremiseFeature> PremiseFeatures { get; set; }

    }
}
