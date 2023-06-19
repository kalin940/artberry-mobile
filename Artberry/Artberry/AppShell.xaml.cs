using Artberry.ViewModels;
using Artberry.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Artberry
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RedPage), typeof(RedPage));
            Routing.RegisterRoute(nameof(WhitePage), typeof(WhitePage));
        }

    }
}
