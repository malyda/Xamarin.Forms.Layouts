using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Layouts.Views
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Choose one of pages"
                        },
                        new Button
                        {
                            Text = "StackLayout",
                             Command = showPageCommand(new StackLayoutPage())
                        },
                        new Button
                        {
                            Text = "AbsoluteLayout",
                            Command = showPageCommand(new AbsolutePage())
                        },
                        new Button
                        {
                            Text = "RelativeLayout",
                             Command = showPageCommand(new RelativeLayoutPage())
                        },
                        new Button
                        {
                            Text = "Handle user actions",
                             Command = showPageCommand(new ViewModel())
                        }
                    }
            };
    }

        Command showPageCommand(Page page)
        {
           return new Command((() =>
           {
               Navigation.PushAsync(page);
           }));
                
               
        }
    }
}
