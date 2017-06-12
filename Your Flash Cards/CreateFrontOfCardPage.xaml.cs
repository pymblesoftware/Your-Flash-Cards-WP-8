using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Your_Flash_Cards
{
    public partial class CreateFrontOfCardPage : PhoneApplicationPage
    {
        public CreateFrontOfCardPage()
        {
            InitializeComponent();

            Loaded += new RoutedEventHandler(CreateFrontOfCardPage_Loaded);
        }


        void CreateFrontOfCardPage_Loaded(object sender, RoutedEventArgs e)
        {
            FrontCardTextBox.Focus();
            DisplayState();
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {

            // Save Text for writing
            TextCard curr = (TextCard) CardSet.currentCard();
            curr.setFront( FrontCardTextBox.Text );
            NavigationService.Navigate(new Uri("/CreateBackOfCardPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear back stack...
            // NavigationService.BackStack.
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
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
                NextPageButton.Content = createImage;


                Uri upUri = new Uri("/Up-Arrow-icon-1a-dark.png", UriKind.Relative);
                BitmapImage upimgSource = new BitmapImage(upUri);
                Image upImage = new Image();
                upImage.Source = upimgSource;
                MenuButton.Content = upImage;

            }

        }
    }
}