using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridColumnSpan
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition(),
                    new RowDefinition()
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition()
                }
            };
            BoxView blueBox = new BoxView { Color = Colors.LightBlue };
            BoxView greenBox = new BoxView { Color = Colors.Teal };
            BoxView pinkBox = new BoxView { Color = Colors.LightPink };

            grid.Add(blueBox, 0, 0);
            grid.Add(greenBox, 1, 0);
            grid.Add(pinkBox, 0, 1);
            Grid.SetColumnSpan(pinkBox, 2);   // растягиваем на два столбца

            Content = grid;
        }
    }
}
