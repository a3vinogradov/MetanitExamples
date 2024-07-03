namespace DinamicXAML
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                "<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n" +
                "xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\n" +
                "x:Class=\"HelloApp.StartPage\">\n" +
                "<Label Text=\"Hello METANIT.COM\" FontSize=\"22\" />" +
                "</ContentPage>";

            this.LoadFromXaml(pageXAML);
        }
    }
}
