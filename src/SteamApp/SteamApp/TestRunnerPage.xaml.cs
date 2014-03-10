using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Testing;

namespace SteamApp
{
    public partial class TestRunnerPage : PhoneApplicationPage
    {
        public TestRunnerPage()
        {
            InitializeComponent();
            this.Content = UnitTestSystem.CreateTestPage();
        }
    }
}