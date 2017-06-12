using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using System.Diagnostics;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Your_Flash_Cards
{
    public partial class TrainFrontPage : PhoneApplicationPage
    {
        public TrainFrontPage()
        {
            InitializeComponent();

            Loaded += TrainFrontPage_Loaded;
        }

        void TrainFrontPage_Loaded(object sender, RoutedEventArgs e)
        {
            TextCard curr = (TextCard)CardSet.currentCard();
            if (curr != null)
            {
                curr.read(CardSet.currentSet());
                curr.presentFrontSP(FrontTextBlock);
            }
            else
            {
                curr = new TextCard();
                CardSet.newCard(curr);

                curr.read(CardSet.currentSet());
                curr.presentFrontSP(FrontTextBlock);
                //System.Diagnostics.Debug.WriteLine("No current card");
            }

           
            Debug.WriteLine( "( "  + FrontTextBlock.Width + " " + FrontTextBlock.ActualWidth + " " + FrontTextBlock.Text.Length + " )");
            FrontTextBlock.FontSize = FrontTextBlock.Width / FrontTextBlock.Text.Length;

            DisplayState();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TrainBackPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
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
                NextButton.Content = createImage;


                Uri upUri = new Uri("/Up-Arrow-icon-1a-dark.png", UriKind.Relative);
                BitmapImage upimgSource = new BitmapImage(upUri);
                Image upImage = new Image();
                upImage.Source = upimgSource;
                MenuButton.Content = upImage;

            }

        }
    }
}