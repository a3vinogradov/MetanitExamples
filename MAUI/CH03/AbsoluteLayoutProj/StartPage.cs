using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteLayoutProj
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            // определяем элементы
            BoxView boxView = new BoxView { Color = Colors.LightBlue };
            Label label = new Label { Text = ".NET MAUI on METANIT.COM", FontSize = 20 };

            // добавляем элементы в AbsoluteLayout
            absoluteLayout.Add(boxView);
            absoluteLayout.Add(label);

            // определяем для элементов расположение и размеры
            absoluteLayout.SetLayoutBounds(
                boxView,
                new Rect(30, 70, 340, 100)
            );
            absoluteLayout.SetLayoutBounds(
                label,
                new Rect(50, 100, 300, 40)
            );
            Content = absoluteLayout;
        }
    }
}
