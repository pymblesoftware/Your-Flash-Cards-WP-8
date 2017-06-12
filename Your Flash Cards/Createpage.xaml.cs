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

using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Your_Flash_Cards
{
    public partial class Createpage : PhoneApplicationPage
    {
        public Createpage()
        {
            InitializeComponent();
            SetNameTextBox.Focus();
        
            Loaded += new RoutedEventHandler(CreatePage_Loaded);
        }


        private void initListBox()
        {
            IsolatedStorageFile isoStore;

            try
            {
                String[] cardSetDirs = CardSet.getSets();
                foreach( string curr in cardSetDirs)
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
            SetNameTextBox.Focus();

            // Set up list box values.
            initListBox();

            DisplayState();
        }




        private void CreateSet()
        {
            CardSet myCardSet = new CardSet(SetNameTextBox.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (SetNameTextBox.Text.Length != 0)
            {
                CreateSet();
                NavigationService.Navigate(new Uri("/ContentTypePage.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                MessageBox.Show("Need to specify a name for the card set" );
            }
        }

        private Color lightThemeBackground = Color.FromArgb(255, 255, 255, 255);
        private Color darkThemeBackground = Color.FromArgb(255, 0, 0, 0);



        private void DisplayState()
        {
            SolidColorBrush backgroundBrush = Application.Current.Resources["PhoneBackgroundBrush"] as SolidColorBrush;

            if (backgroundBrush.Color == lightThemeBackground)
            {
                Uri createUri = new Uri("/Right-facing-Arrow-icon-1a-dark.png", UriKind.Relative);
                BitmapImage imgSource = new BitmapImage(createUri);
                Image createImage = new Image();
                createImage.Source = imgSource;
                NextButton.Content = createImage;
            }

        }
    }
}