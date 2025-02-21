namespace SliderAndStepper
{
    public partial class MainPage : ContentPage
    {
        //Label header;
        Label sliderHeader;
        public MainPage()
        {
            InitializeComponent();
            //header = new Label { FontSize = 18, Margin = 5 };

            //Stepper stepper = new Stepper
            //{
            //    Minimum = 0,
            //    Maximum = 10,
            //    Increment = 0.1,
            //    VerticalOptions = LayoutOptions.Start
            //};
            //stepper.ValueChanged += OnStepperValueChanged;
            //Content = new StackLayout { Children = { stepper, header }, Orientation = StackOrientation.Horizontal };

            sliderHeader = new Label { FontSize = 18, Margin = 5 };

            Slider slider = new Slider
            {
                Maximum = 50,
                Minimum = 0,
                Value = 30,
                ThumbColor = Colors.DeepPink,
                MinimumTrackColor = Colors.DeepPink,
                MaximumTrackColor = Colors.LightPink
            };

            slider.ValueChanged += OnSliderValueChanged;
            //Content = new StackLayout { Children = { header, slider }, Padding = 20 };
            Content.AddLogicalChild(slider);
            Content.AddLogicalChild(sliderHeader);
        }
        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            header.Text = $"Выбрано: {e.NewValue:F1}";
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderHeader.Text = $"Выбрано: {e.NewValue:F1}";
        }
    }

}
