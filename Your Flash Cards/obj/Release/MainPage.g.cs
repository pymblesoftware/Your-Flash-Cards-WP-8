﻿#pragma checksum "C:\Users\Regan\documents\visual studio 2012\Projects\Your Flash Cards\Your Flash Cards\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ACAF34B054D1426AF3AC8FEC07D5ABA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Your_Flash_Cards {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button CreateButton;
        
        internal System.Windows.Controls.Image DesignImage;
        
        internal System.Windows.Controls.Button ShareButton;
        
        internal System.Windows.Controls.Button TrainingButton;
        
        internal System.Windows.Controls.Button FeedbackButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Your%20Flash%20Cards;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.CreateButton = ((System.Windows.Controls.Button)(this.FindName("CreateButton")));
            this.DesignImage = ((System.Windows.Controls.Image)(this.FindName("DesignImage")));
            this.ShareButton = ((System.Windows.Controls.Button)(this.FindName("ShareButton")));
            this.TrainingButton = ((System.Windows.Controls.Button)(this.FindName("TrainingButton")));
            this.FeedbackButton = ((System.Windows.Controls.Button)(this.FindName("FeedbackButton")));
        }
    }
}
