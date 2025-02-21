namespace LabelPrj
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Grid grid = new Grid();

            Label label = new Label
            {
                Text = "Hello METANIT.COM",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 22
            };

            TapGestureRecognizer tapGesture = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 2
            };

            int count = 0;  // счетчик нажатий
            tapGesture.Tapped += (s, e) =>
            {
                count++;
                label.Text = $"Вы нажали {count} раз";
            };
            label.GestureRecognizers.Add(tapGesture);

            grid.Children.Add(label);
            Content = grid;
        }
    }

}
