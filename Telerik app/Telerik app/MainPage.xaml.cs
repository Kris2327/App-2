namespace Telerik_app;

public partial class MainPage : ContentPage
{

    

	public MainPage()
	{
		InitializeComponent();
    }

	private async void UserInterfaceBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new UserInterface());
	}

	private async void FundamentalsBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Fundaments());
	}

	private void CountinueBtn_Clicked(object sender, EventArgs e)
	{
        ContinueGrid.IsVisible = false;
        SelectionsGrid.IsVisible = true;
    }

	private async void ProfileBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Profile());
	}

	private async void SettingsBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Settings());
	}
}



