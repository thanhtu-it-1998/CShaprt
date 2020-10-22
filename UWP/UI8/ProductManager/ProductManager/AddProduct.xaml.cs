using ProductManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
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

namespace ProductManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddProduct : Page
    {
        public List<ImageProduct> ImagesProduct;
        public ObservableCollection<Product> Products;

        public AddProduct()
        {
            this.InitializeComponent();

            ImagesProduct = new List<ImageProduct>();

            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/computer1.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/computer2.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/computer3.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/computer4.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/smaxphone1.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/smaxphone2.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/smaxphone3.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/smaxphone4.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/television1.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/television2.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/television3.jpeg" });
            ImagesProduct.Add(new ImageProduct { ImagePathProduct = "/Assets/television4.jpeg" });


        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            
            string image = ((ImageProduct)ImageProductCombox.SelectedValue).ImagePathProduct;

            ComboBoxItem cbi = (ComboBoxItem)CategoryComboBox.SelectedItem;
            string ValueCategory = cbi.Content.ToString();


            Products.Add(new Product { CategoryProduct = ValueCategory, ImagePathProduct = image,NameProduct= NameProductTextBox.Text,PriceProduct= PriceProductTextBox.Text }) ;

            NameProductTextBox.Text = "";
            PriceProductTextBox.Text = "";
            ImageProductCombox.SelectedIndex = -1;
        }
    }
}
