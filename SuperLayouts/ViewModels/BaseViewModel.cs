using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace SuperLayouts.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
		public BaseViewModel()
		{
		}


		[ObservableProperty]
		private bool isBusy;

		[ObservableProperty]
		private string title;
	}
}

