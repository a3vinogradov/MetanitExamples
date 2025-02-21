namespace ImageLocal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Image image = new Image
            {
                Source = ImageSource.FromFile("Mir.jfif")
            };

            Content = image;
        }
    }

}
