using SciCalculator.ViewModels;

namespace SciCalculator.Views;

public partial class CalculatorPage : ContentView
{
	public CalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new CalculatorPageViewModel();
	}

}