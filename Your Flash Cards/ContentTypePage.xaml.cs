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
    public partial class ContentTypePage : PhoneApplicationPage
    {
        public ContentTypePage()
        {
            InitializeComponent();
            DisplayState();
        }

        private void TextButton_Click(object sender, RoutedEventArgs e)
        {
            Card newCard = new TextCard();
            CardSet.newCard(newCard);

            NavigationService.Navigate(new Uri("/CreateFrontOfCardPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private Color lightThemeBackground = Color.FromArgb(255, 255, 255, 255);
        private Color darkThemeBackground = Color.FromArgb(255, 0, 0, 0);

        private void DisplayState()
        {
            SolidColorBrush backgroundBrush = Application.Current.Resources["PhoneBackgroundBrush"] as SolidColorBrush;

            if (backgroundBrush.Color == lightThemeBackground)
            {
                Uri createUri = new Uri("/Text-1a-dark.png", UriKind.Relative);
                BitmapImage imgSource = new BitmapImage(createUri);
                Image createImage = new Image();
                createImage.Source = imgSource;
                TextButton.Content = createImage;
                // TextBlock.
            }

        }

    }

}