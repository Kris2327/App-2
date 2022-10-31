namespace Telerik_app;

public partial class Fundaments : ContentPage
{
	public Fundaments()
	{
		InitializeComponent();
	}

	private async void FundamentalsHomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}

	private async void FundamentalsBackBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}