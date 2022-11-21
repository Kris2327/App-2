namespace Telerik_app;

public partial class FS_UserInterface : ContentPage
{
	public string[] headText = {"First steps", "Label","Button", "Image"};

	public string[] mainText = {".Net Maui", "Label displays single-line and multi-line text. Text displayed by a Label can be colored, spaced, and can have text decorations. The properties of the label are backed by BindableProperty objects, which means that they can be targets of data bindings, and styled.", "Button displays text and responds to a tap or click that directs the app to carry out a task. Button defines Clicked, Pressed, and Released events. The Clicked event is raised when a Button tap with a finger or mouse pointer is released from the button's surface. The Pressed event is raised when a finger presses on a Button, or a mouse button is pressed with the pointer positioned over the Button. The Released event is raised when the finger or mouse button is released.", "Image displays an image that can be loaded from a local file, a URI, an embedded resource, or a stream. The standard platform image formats are supported, including animated GIFs, and local SVG files are also supported. Image defines Aspect, IsAnimationPlaying, IsLoading, IsOpaque, Source." };

	public int clicks = 0;

	public string[] img = new string[4];


    public FS_UserInterface()
	{
		InitializeComponent();

		img[0] = "page_img.png";
		img[1] = "label.png";
        img[2] = "button.png";
        img[3] = "button.png";
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();

		IMage1.Source = img[0];		
	}

	private void NextBtn_Clicked(object sender, EventArgs e)
	{
		clicks ++;

        progressBar.Progress += clicks / 5;

        Questions questions = new Questions();

		questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		clicks--;
        progressBar.Progress -= clicks / 5;

        Questions questions = new Questions();

		questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1);
	}

	private async void ToolbarItem_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Settings());
    }
}