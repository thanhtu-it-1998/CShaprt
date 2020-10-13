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

namespace Lap20
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

        private void myCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBoxResultTextBlock.Text = myCheckBox.IsChecked.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonTextBlock.Text = (bool)YesRadioButton.IsChecked ? "Yes" : "No";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTexBox == null) return;
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResultTexBox.Text = item.Content.ToString();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var selectedItem = MyListBox.Items.Cast<ListBoxItem>()
                .Where(item => item.IsSelected)
                .Select(element => element.Content.ToString())
                .ToArray();
            ListBoxResultTextBox.Text = string.Join(", ", selectedItem);
        }
    }
}
