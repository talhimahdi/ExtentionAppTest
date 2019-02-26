/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Xamarin.Forms;
using System.Reflection;
using System.Globalization;

using ExtentionAppTest.Views;
using Xamarin.Forms.ToolKit.Extensions;

namespace ExtentionAppTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UserListView())
            {
                BarBackgroundColor = Color.FromHex("#065FD4"),
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            Application.Current.MainPage.DisplayAlert("Welcome", "Welcome back!", "OK");
        }
    }
}
