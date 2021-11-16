using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        /*
        async void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            ContentDialog noWifiDialog = new ContentDialog()
            {
                Title = "No wifi connection",
                Content = "Check connection and try again.",
                CloseButtonText = "Ok"
            };

            await noWifiDialog.ShowAsync();
            */
            
        /*

            var popup = new Popup
            {
                IsOpen = true,
                Width = 300,
                Height = 300,
                IsLightDismissEnabled = true,
                VerticalOffset = 10,
                HorizontalOffset = 200,
                LightDismissOverlayMode = LightDismissOverlayMode.On,
                Child = new Border
                {
                    Background = new SolidColorBrush(Colors.DarkGray),
                    BorderBrush = new SolidColorBrush(Colors.Black),
                    BorderThickness = new Thickness(1),
                    //CornerRadius = new CornerRadius(5),
                    Child = new ListView
                    {
                        ItemsSource = new List<string> { "Item A", "Item B", "Item C" }
                    }
                }
            };

            _grid.Children.Add(popup);
            


        }
    */
    }
}
