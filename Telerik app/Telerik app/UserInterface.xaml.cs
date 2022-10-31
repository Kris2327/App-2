namespace Telerik_app;

public partial class UserInterface : ContentPage
{
	public UserInterface()
	{
		InitializeComponent();
	}

	private async void FistStepsBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FS_UserInterface());
	}

	private async void UIHomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}

	private async void UIBackBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}