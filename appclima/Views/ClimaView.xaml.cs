using appclima.Models;

namespace appclima.Views;

public partial class ClimaView : ContentPage
{
	public ClimaView()
	{
		InitializeComponent();

		Clima clima = new Clima();
		clima.Data = DateTime.Now;
	}
}