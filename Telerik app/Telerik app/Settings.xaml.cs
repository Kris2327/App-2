namespace Telerik_app;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

	private async void SettingsBackBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}