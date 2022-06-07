using System;
namespace SuperLayouts.Views
{
	public partial class Account
	{
		public Account()
		{
			InitializeComponent();
		}
		private void OnCounterClicked(object sender, EventArgs e)
		{
			Shell.Current.DisplayAlert("Alert", "Account Validated", "Ok");
		}
	}
}

