﻿using Lap49.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lap49
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Sound> Sounds;
        private List<MenuItem> MenuItems;
        public MainPage()
        {

            this.InitializeComponent();
            Sounds = new ObservableCollection<Sound>();
            SoundManager.GetAllSounds(Sounds);

            MenuItems = new List<MenuItem>();
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/animals.png", Category = SoundCategory.Animals });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/cartoons.png", Category = SoundCategory.Cartoons });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/taunts.png", Category = SoundCategory.Taunts });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/warnings.png", Category = SoundCategory.Warnings });
        }

        private void HemburgerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (MenuItem)e.ClickedItem;

            CategoryTextBlock.Text = menuItem.Category.ToString();
            SoundManager.GetSoundByCategory(Sounds, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sound = (Sound)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, sound.AudioFile);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            SoundManager.GetAllSounds(Sounds);
            CategoryTextBlock.Text = "All Sounds";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Visible;
        }

        private async void SoundGridView_Drop(object sender, DragEventArgs e)
        {
            if (e.DataView.Contains(StandardDataFormats.StorageItems))
            {
                var items = await e.DataView.GetStorageItemsAsync();

                if (items.Any())
                {
                    var storageFile = items[0] as StorageFile;
                    var contentType = storageFile.ContentType;
                    StorageFolder folder = ApplicationData.Current.LocalFolder;
                    if (contentType == "audio/wav" || contentType == "audio/mpeg")
                    {
                        StorageFile newFile = await storageFile.CopyAsync(folder, storageFile.Name, NameCollisionOption.GenerateUniqueName);
                        MyMediaElement.SetSource(await storageFile.OpenAsync(FileAccessMode.Read), contentType);
                        MyMediaElement.Play();
                    }

                }
            }
        }

        private void SoundGridView_DrapOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
             e.Drap
        }
    }
}
