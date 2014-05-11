// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolutionAssemblyInfo.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1699    // 1699 = Use command line option '/keyfile' or appropriate project settings instead of 'AssemblyKeyFile'

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

// Shared assembly info that is common for all assemblies of this project

////[assembly: AssemblyTitle("DEFINED IN ACTUAL ASSEMBLYINFO")]
////[assembly: AssemblyProduct("DEFINED IN ACTUAL ASSEMBLYINFO")]
////[assembly: AssemblyDescription("DEFINED IN ACTUAL ASSEMBLYINFO")]

[assembly: AssemblyCompany("CatenaLogic")]
[assembly: AssemblyCopyright("Copyright © CatenaLogic 2010 - 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-US")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("1.0")]
[assembly: AssemblyInformationalVersion("1.0, manually built in Visual Studio")]

#if DEBUG

#if NET40
[assembly: AssemblyConfiguration("NET40, Debug")]
#elif NET45
[assembly: AssemblyConfiguration("NET45, Debug")]
#elif NET50
[assembly: AssemblyConfiguration("NET50, Debug")]
#elif SL5
[assembly: AssemblyConfiguration("Silverlight 5, Debug")]
#elif WP80
[assembly: AssemblyConfiguration("Windows Phone 8.0, Debug")]
#elif WPSL81
[assembly: AssemblyConfiguration("Windows Phone 8.1 (Silverlight), Debug")]
#elif WPRT81
[assembly: AssemblyConfiguration("Windows Phone 8.1 (Runtime), Debug")]
#elif WIN80
[assembly: AssemblyConfiguration("Windows 8.0, Debug")]
#elif WIN81
[assembly: AssemblyConfiguration("Windows 8.1, Debug")]
#elif PCL
[assembly: AssemblyConfiguration("PCL, Debug")]
#elif XAMARIN && ANDROID
[assembly: AssemblyConfiguration("Xamarin.Android, Debug")]
#elif XAMARIN && IOS
[assembly: AssemblyConfiguration("Xamarin.iOS, Debug")]
#else
[assembly: AssemblyConfiguration("Unknown, Debug")]
#endif

#else

#if NET40
[assembly: AssemblyConfiguration("NET40, Release")]
#elif NET45
[assembly: AssemblyConfiguration("NET45, Release")]
#elif NET50
[assembly: AssemblyConfiguration("NET50, Release")]
#elif SL5
[assembly: AssemblyConfiguration("Silverlight 5, Release")]
#elif WP80
[assembly: AssemblyConfiguration("Windows Phone 8.0, Release")]
#elif WPSL81
[assembly: AssemblyConfiguration("Windows Phone 8.1 (Silverlight), Release")]
#elif WPRT81
[assembly: AssemblyConfiguration("Windows Phone 8.1 (Runtime), Release")]
#elif WIN80
[assembly: AssemblyConfiguration("Windows 8.0, Release")]
#elif WIN81
[assembly: AssemblyConfiguration("Windows 8.1, Release")]
#elif PCL
[assembly: AssemblyConfiguration("PCL, Release")]
#elif XAMARIN && ANDROID
[assembly: AssemblyConfiguration("Xamarin.Android, Release")]
#elif XAMARIN && IOS
[assembly: AssemblyConfiguration("Xamarin.iOS, Release")]
#else
[assembly: AssemblyConfiguration("Unknown, Release")]
#endif

#endif

// CLS compliant
#if !NETFX_CORE && !XAMARIN
[assembly: CLSCompliant(true)]
#endif
