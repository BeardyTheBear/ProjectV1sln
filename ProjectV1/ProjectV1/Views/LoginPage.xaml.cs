using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectV1.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectV1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);

            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "OK");

            }
            else
            {
                DisplayAlert("Login", "Login Failed, empty username or password", "OK");
            }

        }
    }
}