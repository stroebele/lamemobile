using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace XApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XApp.MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("ios=6256b643-490b-49ad-b417-9c00450eb9aa;",
                typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
