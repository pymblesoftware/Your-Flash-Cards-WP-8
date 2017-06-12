using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using System.Windows.Media.Imaging;

using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;


namespace Your_Flash_Cards
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //System.Diagnostics.Debug.WriteLine("here");

            DisplayState();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Createpage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TestPage.xaml", UriKind.RelativeOrAbsolute));

        }

        private void ShareButton_Click(object sender, RoutedEventArgs e)
        {
 //           NavigationService.Navigate(new Uri("/SharePage.xaml", UriKind.RelativeOrAbsolute));
            EmailComposeTask task = new EmailComposeTask
            {
                // To = "info@pymblesoftware.com",
                Subject = "an interesting app ",
                Body = "Hey there, \n       I just found this app you might be interested in...Your Flash Cards on Windows Phone"
            };

            task.Show();
        }

        private void TrainingButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TrainingPage.xaml", UriKind.RelativeOrAbsolute));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask
            {
                To = "info@pymblesoftware.com",
                Subject = "Feedback on Your Flash Cards on Windows Phone"
            };

            task.Show();

        }


        private Color lightThemeBackground = Color.FromArgb(255, 255, 255, 255);
        private Color darkThemeBackground = Color.FromArgb(255, 0, 0, 0);



        private void DisplayState()
        {
            SolidColorBrush backgroundBrush = Application.Current.Resources["PhoneBackgroundBrush"] as SolidColorBrush;

            if (backgroundBrush.Color == lightThemeBackground)
            {
                // you are in the light theme
                // MessageBox.Show("Light");
                // CreateButton.
                Uri createUri = new Uri("/create-1a-dark.png", UriKind.Relative);
                BitmapImage imgSource = new BitmapImage(createUri);
                Image createImage = new Image();
                createImage.Source = imgSource;                
                CreateButton.Content = createImage;

                // Training button.
                Uri trainingUri = new Uri("/training-1a-dark.png", UriKind.Relative);
                BitmapImage trainImgSource = new BitmapImage(trainingUri);
                Image trainingImage = new Image();
                trainingImage.Source = trainImgSource;
                TrainingButton.Content = trainingImage;

                // Feedback
                Uri feedbackUri = new Uri("/critisism-2a-dark.png", UriKind.Relative);
                BitmapImage feedbackImgSource = new BitmapImage(feedbackUri);
                Image feedbackImage = new Image();
                feedbackImage.Source = feedbackImgSource;
                FeedbackButton.Content = feedbackImage;

                // Share
                Uri shareUri = new Uri("/giving-hands-dark.png", UriKind.Relative);
                BitmapImage shareImgSource = new BitmapImage(shareUri);
                Image shareImage = new Image();
                shareImage.Source = shareImgSource;
                this.ShareButton.Content = shareImage;
            }
            else
            {
                // you are in the dark theme
                // MessageBox.Show("Dark");
            }
        }


    }




}