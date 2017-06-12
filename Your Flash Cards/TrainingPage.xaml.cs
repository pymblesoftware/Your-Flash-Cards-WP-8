using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using System.IO;
using System.IO.IsolatedStorage;

namespace Your_Flash_Cards
{
    public partial class TrainingPage : PhoneApplicationPage
    {
        public TrainingPage()
        {
            InitializeComponent();
            // SetNameTextBox.Focus();

            Loaded += new RoutedEventHandler(CreatePage_Loaded);
        }


        private void initListBox()
        {
            IsolatedStorageFile isoStore;

            try
            {
                String[] cardSetDirs = CardSet.getSets();
                foreach (string curr in cardSetDirs)
                {
                    if (curr != "Shared" && curr != "PlatformData" )
                    {
                        setListBox.Items.Add(curr);
                    }
                }

            }
            catch (Exception e)
            {

            }
        }

        void CreatePage_Loaded(object sender, RoutedEventArgs e)
        {
            // SetNameTextBox.Focus();

            // Set up list box values.
            initListBox();


        }

        private void setListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // e.AddedItems.

            ListBox lstBx = (ListBox) sender;

            string selectedStr = (string) lstBx.SelectedItems[0];
            CardSet.setCurrentSet(selectedStr);
            CardSet.setCardNum(1);
            // string selectedStr = lst.ElementAt(0);
            // sender.            // CardSet.setCurrentSet( e. );
            NavigationService.Navigate(new Uri("/TrainFrontPage.xaml", UriKind.RelativeOrAbsolute));
        }


    }
}