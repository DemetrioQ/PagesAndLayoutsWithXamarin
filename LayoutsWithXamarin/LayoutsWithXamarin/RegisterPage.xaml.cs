using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsWithXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(confirmPassword.Text))
            {
                await DisplayAlert("Error", "Debe de llenar todos los campos", "Ok");
            }
            else if(password.Text != confirmPassword.Text)
            {
                await DisplayAlert("Error", "Las contraseñas ingresadas son diferentes", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Bienvenido", "Hola, " + name.Text, "Ok");
                var homePage = new HomeTabbedPage();
                homePage.Children.Add(new HomePage() { Title ="Home", IconImageSource="HomeIcon"});
                homePage.Children.Add(new ContentPage() { Title = "Option 1", IconImageSource = "Option1" });
                homePage.Children.Add(new ContentPage() { Title = "Option 2", IconImageSource = "Option2" });
                NavigationPage.SetHasNavigationBar(homePage, false);
                await Navigation.PushAsync(homePage);
            }
        }
    }
}