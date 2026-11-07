using appclima.Models;
using appclima.ViewModels;

namespace appclima.Views;

public partial class ClimaView : ContentPage
{
	public ClimaView()
	{
		InitializeComponent();

        BindingContext = new ClimaViewModel();
    }
}