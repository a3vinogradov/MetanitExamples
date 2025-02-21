namespace MarginAndPadding
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            //InitializeComponent();
            var stackLayout = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
                Children = {
                new BoxView { Color = Colors.Green, Margin = new Thickness (20),  HeightRequest = 100 },
                new BoxView { Color = Colors.Blue, Margin = new Thickness (10, 25), HeightRequest = 100 },
                new BoxView { Color = new Color(0,255,255), Margin = new Thickness (0, 20, 15, 5), HeightRequest = 100 }
            }
            };
            Content = stackLayout;
        }

    }

}
