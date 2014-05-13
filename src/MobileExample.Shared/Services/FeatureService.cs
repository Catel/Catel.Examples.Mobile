// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample.Services
{
    using System.Collections.Generic;
    using Models;
    using ViewModels;

    public class FeatureService : IFeatureService
    {
        #region Methods
        public IEnumerable<Feature> GetAvailableFeatures()
        {
            var features = new List<Feature>();

            features.Add(new Feature
            {
                Tag = typeof(BindingsViewModel),
                Title = "Bindings",
                Description = "This page will show several ways of binding on all platforms."
            });

            features.Add(new Feature
            {
                Tag = typeof(CommandsViewModel),
                Title = "Commands",
                Description = "This page will show several ways of commanding on all platforms."
            });

            features.Add(new Feature
            {
                Tag = typeof(NavigationViewModel),
                Title = "Navigation",
                Description = "Navigation is abstracted away in a single interface for all platforms."
            });

            //features.Add(new Feature
            //{
            //    Tag = typeof(NestingViewModel),
            //    Title = "Nested controls",
            //    Description = "Nested controls allow developers to create controls / fragments that are reusable but still have their own view model."
            //});

            features.Add(new Feature
            {
                Tag = typeof(AuditingViewModel),
                Title = "Auditing",
                Description = "The auditing feature in Catel is very useful to gather analytics."
            });

            return features;
        }
        #endregion
    }
}