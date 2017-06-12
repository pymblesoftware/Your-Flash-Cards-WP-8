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
    public partial class CreateBackOfCardPage : PhoneApplicationPage
    {
        public CreateBackOfCardPage()
        {
            InitializeComponent();

            Loaded += new RoutedEventHandler(CreateBackOfCardPage_Loaded);
        }


        void CreateBackOfCardPage_Loaded(object sender, RoutedEventArgs e)
        {
            BackCardTextBox.Focus();
            DisplayState();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // Drop questions and test for now..
            // NavigationService.Navigate(new Uri("/CreateQuestionsPage.xaml", UriKind.RelativeOrAbsolute));
            TextCard curr = (TextCard)CardSet.currentCard();
            curr.setBack(BackCardTextBox.Text);

           
            string setName = CardSet.currentSet();
            curr.write(setName);
            CardSet.nextCard(true);
            NavigationService.Navigate(new Uri("/CreateFrontOfCardPage.xaml", UriKind.RelativeOrAbsolute));
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