using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PrLocalFolder
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


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           string fileName = this.searchFile.Text;
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            if (await storageFolder.TryGetItemAsync(fileName) != null) {
                Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync(fileName);
                string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);

                if (text.Contains(TextSeach.Text))
                {
                    textAblet.Text = "File Found and text found";
                }
                else {
                    textAblet.Text = "File Found but text not found";

                }
            }
            else
            {
                textAblet.Text = "File not found ";
            }
        }
    }
}
