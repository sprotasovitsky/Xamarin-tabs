using System;
using System.Collections.Generic;
using Tabbedapp.ViewModels;
using Tabbedapp.Views;
using Xamarin.Forms;

namespace Tabbedapp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

