using News.Assets;
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

namespace News
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Home));
            TitleTextBlock.Text = "Home";
            Home.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                Home.IsSelected = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var selectItem = MyListBox.Items.Cast<ListBoxItem>()
            //    .Where(item => item.IsSelected)               
            //    .Select(element => element.Content.ToString())
            //    .First();
            //Type fileSelect = Type.GetType("CShaprt.UWP.UI4.News" + selectItem);
            //BackButton.Visibility = Visibility.Collapsed;
            //MyFrame.Navigate(fileSelect);
            //TitleTextBlock.Text = selectItem.ToString();

            if (Comment.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Comment));
                TitleTextBlock.Text = "Comment";
            }
            else if (Store.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Store));
                TitleTextBlock.Text = "Store";
            }
            else if (World.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(World));
                TitleTextBlock.Text = "World";
            }
            else if (Home.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Home));
                TitleTextBlock.Text = "Home";
            }

        }

        private void Comment_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Comment));
            TitleTextBlock.Text = "Comment";
        }
    }
}
