namespace DataPickerPrj
{
    public partial class MainPage : ContentPage
    {
        Label label;

        public MainPage()
        {
            label = new Label { Text = "Выберите дату" };
            DatePicker datePicker = new DatePicker
            {
                Format = "d",
                MaximumDate = DateTime.Now.AddMonths(1),
                MinimumDate = DateTime.Now.AddYears(-5)
            };
            datePicker.DateSelected += DateSelected;
            StackLayout stack = new StackLayout { Children = { label, datePicker }, Padding = 20 };
            Content = stack;
        }
        void DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text = $"Вы выбрали {e.NewDate.ToString("d")}";
        }
    }

}
