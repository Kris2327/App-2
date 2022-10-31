namespace Telerik_app;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}

	private async void ProfileBackBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}

	private void UsernameEditBtn_Clicked(object sender, EventArgs e)
	{

	}

	private void ProfileImageEditBtn_Clicked(object sender, EventArgs e)
	{

	}
}