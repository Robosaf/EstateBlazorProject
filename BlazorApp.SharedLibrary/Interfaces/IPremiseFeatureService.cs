﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.SharedLibrary.Interfaces
{
    public interface IPremiseFeatureService
    {
        Task<ICollection<int>> GetFeaturesIdByPremiseId(int premiseId);
    }
}