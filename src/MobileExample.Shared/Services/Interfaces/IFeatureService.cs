// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFeatureService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample.Services
{
    using System.Collections.Generic;
    using Models;

    public interface IFeatureService
    {
        #region Methods
        IEnumerable<Feature> GetAvailableFeatures();
        #endregion
    }
}