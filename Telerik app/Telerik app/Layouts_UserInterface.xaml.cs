namespace Telerik_app;

public partial class Layouts_UserInterface : ContentPage
{
    public string[] headText = { "StackLayout", "HorizontalStackLayout", "VerticalStackLayout", "Grid", "FlexLayout" };

    public string[] mainText = { "A StackLayout organizes elements in a one-dimensional stack, either horizontally or vertically. The Orientation property specifies the direction of the elements, and the default orientation is Vertical. StackLayout is typically used to arrange a subsection of the UI on a page. In a StackLayout, if an element's size is not explicitly set, it expands to fill the available width, or height if the Orientation property is set to Horizontal. A StackLayout is often used as a parent layout, which contains other child layouts.", "A HorizontalStackLayout organizes child views in a one-dimensional horizontal stack, and is a more performant alternative to a StackLayout. In a HorizontalStackLayout, if an element's size is not explicitly set, it expands to fill the available height.", "A VerticalStackLayout organizes child views in a one-dimensional vertical stack, and is a more performant alternative to a StackLayout. In a VerticalStackLayout, if an element's size is not explicitly set, it expands to fill the available width.", "A Grid is used for displaying elements in rows and columns, which can have proportional or absolute sizes. A grid's rows and columns are specified with the RowDefinitions and ColumnDefinitions properties.To position elements in specific Grid cells, use the Grid.Column and Grid.Row attached properties. To make elements span across multiple rows and columns, use the Grid.RowSpan and Grid.ColumnSpan attached properties.", "A FlexLayout is similar to a StackLayout in that it displays child elements either horizontally or vertically in a stack. However, a FlexLayout can also wrap its children if there are too many to fit in a single row or column, and also enables more granular control of the size, orientation, and alignment of its child elements." };

    public int clicks = 0;

    public string[] img = new string[5];

    public Layouts_UserInterface()
	{
		InitializeComponent();


        img[0] = "stacklayout.png";
        img[1] = "horizontallayout.png";
        img[2] = "verticallayout.png";
        img[3] = "grid.png";
        img[4] = "flexlayout.png";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        IMage1.Source = img[0];
    }

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
        clicks++;

        progressBar.Progress += clicks / 6;

        Questions questions = new Questions();

        questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        clicks--;
        progressBar.Progress -= clicks / 6;

        Questions questions = new Questions();

        questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1);
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Settings());
    }
}