// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Main.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample.iOS
{
    using MonoTouch.UIKit;

    public class Application
    {
        #region Methods
        private static void Main(string[] args)
        {
            AppInitializer.Initialize();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
        #endregion
    }
}