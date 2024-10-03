using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tabbedapp.Services;
using Tabbedapp.Views;
using Tabbedapp.SimpleNav;

namespace Tabbedapp
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

