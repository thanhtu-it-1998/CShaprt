using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GoNuts
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            string _roast = selected.Text;
            displayResult(_roast);
        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
             string _sweetener = selected.Text;
            displayResult(_sweetener);
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            string _cream = selected.Text;
            displayResult(_cream);
        }
         private void displayResult(String _key)
        {
            if(_key == "None" || String.IsNullOrEmpty(_key))
            {
                ResulTextBlock.Text = "None";
                return;
            }
            ResulTextBlock.Text = _key;
            if (_key != "None" && !String.IsNullOrEmpty(_key))
            {
                ResulTextBlock.Text += "+"+ _key;
                return;
            }
        }
    }
}
