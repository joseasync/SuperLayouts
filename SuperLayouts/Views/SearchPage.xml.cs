using System;
namespace SuperLayouts.Views
{
	public partial class SearchPage
	{
		int count = 0;

		public SearchPage()
		{
			InitializeComponent();
			Title = "Buscar";
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;

			if (count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		}
	}
}

