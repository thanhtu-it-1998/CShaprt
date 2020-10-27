using PractiveUniversalWindowns.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PractiveUniversalWindowns
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<ImageProduct> ImageProducts;
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();
            ImageProducts = new List<ImageProduct>();

            ImageProducts.Add(new ImageProduct { ImageProductPath = "/Assets/ImageProduct/Product1.png" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "/Assets/ImageProduct/Product2.png" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "/Assets/ImageProduct/Product3.png" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "/Assets/ImageProduct/Product4.png" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "/Assets/ImageProduct/Product5.png" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "/Assets/ImageProduct/Product6.png" });

            Products = new ObservableCollection<Product>();
            Products.Add(new Product { NameProduct = "Iphone 1", DescriptionProduct = "Truong Thanh Tu da mua", ImagePath = "/Assets/ImageProduct/Product1.png" });
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((ImageProduct)ImageComboBox.SelectedValue).ImageProductPath;
            Products.Add(new Product{ NameProduct = NameProduct.Text, DescriptionProduct = DescriptionProduct.Text, ImagePath = image});
            NameProduct.Text = "";
            DescriptionProduct.Text = "";
            ImageComboBox.SelectedIndex = -1;
            NameProduct.Focus(FocusState.Programmatic);
        }
    }
}
