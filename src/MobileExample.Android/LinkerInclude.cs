// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkerInclude.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample
{
    using Android.App;
    using Android.Widget;
    using Catel.MVVM;

    public class LinkerInclude
    {
        #region Methods
        public void IncludeActivity(Activity activity)
        {
            activity.Title = activity.Title = string.Empty;
        }

        public void IncludeButton(Button button)
        {
            button.Text = button.Text + string.Empty;

            button.Click += (sender, e) => { };
        }

        public void IncludeEditText(EditText editText)
        {
            editText.Text = editText.Text + string.Empty;

            editText.TextChanged += (sender, e) => { };
        }

        public void IncludeEditText(TextView textView)
        {
            textView.Text = textView.Text + string.Empty;

            textView.TextChanged += (sender, e) => { };
        }

        public void IncludeCommand(ICatelCommand command)
        {
            command.CanExecuteChanged += (sender, e) => { };
        }
        #endregion
    }
}