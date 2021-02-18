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
            /*var tabbedPage = new LoginRegisterTabbedPage();
            tabbedPage.Children.Add(new Login() {Title = "Login"});
            tabbedPage.Children.Add(new Register() { Title = "Register" });*/

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
