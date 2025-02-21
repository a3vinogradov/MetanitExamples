namespace EntryPrj
{
    public partial class MainPage : ContentPage
    {
        Label nameLabel;
        Entry nameEntry;
        public MainPage()
        {
            StackLayout stackLayout = new StackLayout();

            nameEntry = new Entry { FontSize = 22 };
            nameEntry.TextChanged += nameEntry_TextChanged;
            nameLabel = new Label { FontSize = 22 };

            stackLayout.Children.Add(nameEntry);
            stackLayout.Children.Add(nameLabel);
            Content = stackLayout;
        }

        void nameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            nameLabel.Text = nameEntry.Text;
        }
    }

}
