using BlazorApp.SharedLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Helper
{
    public class FeatureBool
    {
        public Feature Feature { get; set; }
        public string FeatureName { get; set; }
        public bool IsChecked { get; set; }
    }
}
