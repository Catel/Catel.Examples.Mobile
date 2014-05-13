// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureListViewModel.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using Catel;
    using Catel.MVVM;
    using Catel.Services;
    using Models;
    using Services;

    public class FeatureListViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public FeatureListViewModel(IFeatureService featureService, INavigationService navigationService)
        {
            Argument.IsNotNull(() => featureService);
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;

            Features = new ObservableCollection<Feature>(featureService.GetAvailableFeatures());

            NavigateToFeature = new Command<Feature>(OnNavigateToFeatureExecute);
        }

        public ObservableCollection<Feature> Features { get; private set; }

        #region Commands
        /// <summary>
        /// Gets the NavigateToFeature command.
        /// </summary>
        public Command<Feature> NavigateToFeature { get; private set; }

        /// <summary>
        /// Method to invoke when the NavigateToFeature command is executed.
        /// </summary>
        private void OnNavigateToFeatureExecute(Feature parameter)
        {
            _navigationService.Navigate((Type)parameter.Tag);
        }
        #endregion
    }
}