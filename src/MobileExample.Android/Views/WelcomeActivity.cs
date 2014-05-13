// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WelcomeActivity.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample.Views
{
    using Android.OS;
    using Catel.Android.App;

    [Android.App.Activity(Label = "WelcomeActivity", MainLauncher = true)]
    public class WelcomeActivity : Activity
    {
        #region Methods
        protected override void OnCreate(Bundle bundle)
        {
            AppInitializer.Initialize();

            base.OnCreate(bundle);
        }
        #endregion
    }
}