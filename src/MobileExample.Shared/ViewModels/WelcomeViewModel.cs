// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WelcomeViewModel.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample.ViewModels
{
    using Catel;
    using Catel.MVVM;
    using Catel.Services;

    public class WelcomeViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public WelcomeViewModel(INavigationService navigationService)
        {
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;

            StartExample = new Command(OnStartExampleExecute);
        }

        #region Commands
        /// <summary>
        /// Gets the StartExample command.
        /// </summary>
        public Command StartExample { get; private set; }

        /// <summary>
        /// Method to invoke when the StartExample command is executed.
        /// </summary>
        private void OnStartExampleExecute()
        {
            _navigationService.Navigate<FeatureListViewModel>();
            _navigationService.RemoveBackEntry();
        }
        #endregion
    }
}