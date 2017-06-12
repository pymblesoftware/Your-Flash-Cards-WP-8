using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Your_Flash_Cards
{
    public partial class CreateQuestionsPage : PhoneApplicationPage
    {
        public CreateQuestionsPage()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CreateFrontOfCardPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}