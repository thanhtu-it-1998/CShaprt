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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProductManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(ShowAllProduct));
            TittleTextBox.Text = "All Proudct";

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HumburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (AddProduct.IsSelected)
            {
                MyFrame.Navigate(typeof(AddProduct));
                TittleTextBox.Text = "Add Proudct";
            }
            if (Home.IsSelected)
            {
                MyFrame.Navigate(typeof(ShowAllProduct));
                TittleTextBox.Text = "All Proudct";
            }
            if (Computer.IsSelected)
            {
                MyFrame.Navigate(typeof(ShowCategoryProduct));
                TittleTextBox.Text = "Computer Proudct";
            }
            if (SmaxPhone.IsSelected)
            {
                MyFrame.Navigate(typeof(ShowCategoryProduct));
                TittleTextBox.Text = "SmaxPhone Proudct";
            }
            if (Television.IsSelected)
            {
                MyFrame.Navigate(typeof(ShowCategoryProduct));
                TittleTextBox.Text = "Television Proudct";
            }
        }


    }
}
