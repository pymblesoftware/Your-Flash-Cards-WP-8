﻿#pragma checksum "C:\Users\Regan\documents\visual studio 2012\Projects\Your Flash Cards\Your Flash Cards\TestQuestionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "149910927284B402637625A02B133AC9"
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
    
    
    public partial class TestQuestionPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock QuestionTextBlock;
        
        internal System.Windows.Controls.Button Answer1Button;
        
        internal System.Windows.Controls.Button NextButton;
        
        internal System.Windows.Controls.Button Answer2Button;
        
        internal System.Windows.Controls.Button Answer3Button;
        
        internal System.Windows.Controls.Button Answer4Button;
        
        internal System.Windows.Controls.Button Answer5Button;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Your%20Flash%20Cards;component/TestQuestionPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.QuestionTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("QuestionTextBlock")));
            this.Answer1Button = ((System.Windows.Controls.Button)(this.FindName("Answer1Button")));
            this.NextButton = ((System.Windows.Controls.Button)(this.FindName("NextButton")));
            this.Answer2Button = ((System.Windows.Controls.Button)(this.FindName("Answer2Button")));
            this.Answer3Button = ((System.Windows.Controls.Button)(this.FindName("Answer3Button")));
            this.Answer4Button = ((System.Windows.Controls.Button)(this.FindName("Answer4Button")));
            this.Answer5Button = ((System.Windows.Controls.Button)(this.FindName("Answer5Button")));
        }
    }
}
