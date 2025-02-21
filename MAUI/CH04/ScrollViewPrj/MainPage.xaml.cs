namespace ScrollViewPrj
{
    public partial class MainPage : ContentPage
    {
        ScrollView scrollView = new ScrollView();

        public MainPage()
        {
            StackLayout stackLayout = new StackLayout { Padding = 20 };
            Label textLabel = new Label
            {
                FontSize = 18,
                Text = @"«Мой дядя самых честных правил,
Когда не в шутку занемог,
Он уважать себя заставил
И лучше выдумать не мог.
Его пример другим наука;
Но, боже мой, какая скука
С больным сидеть и день и ночь,
Не отходя ни шагу прочь!
Какое низкое коварство
Полуживого забавлять,
Ему подушки поправлять,
Печально подносить лекарство,
Вздыхать и думать про себя:
Когда же черт возьмет тебя!»
 
Так думал молодой повеса,
Летя в пыли на почтовых,
Всевышней волею Зевеса
Наследник всех своих родных.
Друзья Людмилы и Руслана!
С героем моего романа
Без предисловий, сей же час
Позвольте познакомить вас:
Онегин, добрый мой приятель,
Родился на брегах Невы,
Где, может быть, родились вы
Или блистали, мой читатель;
Там некогда гулял и я:
Но вреден север для меня."
            };

            Button button = new Button { Text = "В начало" };
            button.Clicked += Button_Clicked;
            stackLayout.Add(textLabel);
            stackLayout.Add(button);

            scrollView.Content = stackLayout;

            Content = scrollView;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await scrollView.ScrollToAsync(0, 20, true);
        }
    }

}
