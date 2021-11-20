///using P42.Uno.Markup;
using P42.Utils.Uno;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            var items = new List<P42.Uno.Controls.MenuItemBase>
                    {
                        new P42.Uno.Controls.MenuGroup { Text = "Group A", IconSource = new FontIconSource { FontFamily = new FontFamily("Segoe MDL2 Assets"), Glyph="\uE713"  }, Items =
                            {
                                new P42.Uno.Controls.MenuItem { Text = "Item A", IconSource = new SymbolIconSource{ Symbol = Symbol.Calculator } },
                                new P42.Uno.Controls.MenuItem { Text = "Item B", IconSource = new SymbolIconSource { Symbol = Symbol.Save } },
                                new P42.Uno.Controls.MenuItem { Text = "Item C", IconSource = new SymbolIconSource { Symbol = Symbol.Scan } },
                            }
                        },
                        new P42.Uno.Controls.MenuGroup { Text = "Group B", IconSource = new SymbolIconSource { Symbol = Symbol.Send }, Items =
                            {
                                new P42.Uno.Controls.MenuItem { Text = "Item E", IconSource = new SymbolIconSource { Symbol = Symbol.Share } },
                                new P42.Uno.Controls.MenuItem { Text = "Item F", IconSource = new SymbolIconSource { Symbol = Symbol.Sort } },
                                new P42.Uno.Controls.MenuItem { Text = "Item G", IconSource = new SymbolIconSource { Symbol = Symbol.Switch } },
                            }
                        },
                        new P42.Uno.Controls.MenuGroup { Text = "Group C", IconSource = new SymbolIconSource { Symbol = Symbol.List }, Items =
                            {
                                new P42.Uno.Controls.MenuItem { Text = "Item H", IconSource = new SymbolIconSource { Symbol = Symbol.Tag } },
                                new P42.Uno.Controls.MenuItem { Text = "Item I", IconSource = new SymbolIconSource { Symbol = Symbol.Target } },
                                new P42.Uno.Controls.MenuItem { Text = "Item J", IconSource = new SymbolIconSource { Symbol = Symbol.Sync } },
                            }
                        },
                    };
            
            var popup = new P42.Uno.Controls.MenuFlyout(_button)
            {
                Items = items
            };
            
        }

    }

    /*
    [Bindable]
    public partial class CellTemplate : Grid
    {

        public CellTemplate()
        {
            this
                .Padding(0)
                .Margin(0)
                .Left()
                .Columns("auto", "*", 20, "auto");

#if WINDOWS_UWP
            DataContextChanged += CellTemplate_DataContextChanged;
#endif
            Tapped += OnItemTapped;

            PointerEntered += CellTemplate_PointerEntered;
            PointerExited += CellTemplate_PointerExited;
        }

        private void CellTemplate_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Background = Colors.Transparent.ToBrush();
        }

        private void CellTemplate_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Background = SystemColors.BaseLow.ToBrush();
        }

#if WINDOWS_UWP
        private void CellTemplate_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
#else
        protected override void OnDataContextChanged(DependencyPropertyChangedEventArgs args)
#endif
        {
            System.Diagnostics.Debug.WriteLine($"CellTemplate.DataContext = [{args.NewValue}]");
            Children.Clear();
            if (args.NewValue is P42.Uno.Controls.MenuItemBase baseItem)
            {
                if (baseItem.IconSource is IconSource iconSource && iconSource.AsIconElement() is IconElement iconElement)
                    Children.Add(iconElement.Center().Margin(5, 0));
                if (baseItem.Text is string text)
                    Children.Add(new TextBlock { Text = text }.Margin(5, 0).Column(1).CenterVertical());
                if (args.NewValue is P42.Uno.Controls.MenuGroup subItem)
                    Children.Add(new TextBlock { Text = "\uE76C", FontFamily = new FontFamily("Segoe MDL2 Assets") }.Margin(5, 0).Column(3).CenterVertical().Right());
            }
        }

        async void OnItemTapped(object sender, TappedRoutedEventArgs e)
        {
            if (DataContext is P42.Uno.Controls.MenuItem item)
                item.OnItemClicked();
            else if (DataContext is P42.Uno.Controls.MenuGroup subItem)
            {
                var popup = new P42.Uno.Controls.TargetedPopup(this)
                {
                    PreferredPointerDirection = P42.Uno.Controls.PointerDirection.Left,
                    Padding = new Thickness(1),
                    XamlContent = new P42.Uno.Controls.SimpleListView
                    {
                        ItemTemplate = typeof(CellTemplate).AsDataTemplate(),
                        ItemsSource = subItem.Items
                    }
                };
                await popup.PushAsync();
            }
        }

    }
    */
}
