using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsWithXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var login = new LoginPage();
            NavigationPage.SetHasNavigationBar(login, false);
            MainPage = new NavigationPage(login);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
