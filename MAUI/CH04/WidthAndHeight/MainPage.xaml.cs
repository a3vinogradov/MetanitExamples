namespace WidthAndHeight
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            Button button = new Button
            {
                WidthRequest = 100,
                HeightRequest = 50,
                Text = "Click"
            };
            Content = new Grid { Children = { button } };
        }
    }
}
