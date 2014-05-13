// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppInitializer.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample
{
    using Catel.IoC;
    using Services;

    public static partial class AppInitializer
    {
        #region Constants
        private static bool _initialized;
        #endregion

        #region Methods
        public static void Initialize()
        {
            if (_initialized)
            {
                return;
            }

            _initialized = true;

            var serviceLocator = ServiceLocator.Default;

            serviceLocator.RegisterType<IFeatureService, FeatureService>();
        }

        static partial void PlatformInitialization();
        #endregion
    }
}