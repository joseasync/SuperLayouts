using System;
namespace SuperLayouts.Views
{
	public partial class AccountPage
	{
		public AccountPage()
		{
			InitializeComponent();
		}
		private void OnCounterClicked(object sender, EventArgs e)
		{
			Shell.Current.DisplayAlert("Alert", "Account Validated", "Ok");
		}
	}
}

