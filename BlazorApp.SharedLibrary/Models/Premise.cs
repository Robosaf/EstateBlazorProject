using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Models
{
    public class Premise
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        [Required, MinLength(5)]
        public string Title { get; set; }
        public string ImgPath { get; set; }
        [Required]
        public string Description { get; set; }
        public string Street { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public ICollection<PremiseFeature> PremiseFeatures { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int Price { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int Size { get; set; }
        [Required, Range(1, int.MaxValue)]
        public int RoomsCount { get; set; }

    }
}
