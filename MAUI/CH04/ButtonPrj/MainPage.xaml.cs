namespace ButtonPrj
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            /*
            Grid grid = new Grid();

            Button button = new Button
            {
                Text = "Нажми",
                FontSize = 22,
                BorderWidth = 1,
                BackgroundColor = Colors.LightPink,
                TextColor = Colors.DarkRed,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            button.Clicked += OnButtonClicked;

            grid.Children.Add(button);
            Content = grid;
            */
        }

        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Нажато!";
        }
    }

}
