using SuperLayouts.ViewModels;

namespace SuperLayouts.Views;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}
}


