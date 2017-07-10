using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URIDE.Models;
using URIDE.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace URIDE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        private UserDataAccess dataAccess;
        public Login ()
		{

            InitializeComponent ();
            var myImage = new Image { Aspect = Aspect.AspectFit };
            myImage.Source = ImageSource.FromResource("5812.png");
            /* this.BackgroundImage = myImage;
             StackLayout stackLayout = new StackLayout // instantiate a StackLayout object to layout its children
             {
                 BackgroundImage = 
                 BackgroundColor = Color.Blue
             };
             this.Content = stackLayout;*/
            this.dataAccess = new UserDataAccess();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
           /* messageLabel.IsVisible = false;
            if (emailEntry.Text != null || passwordEntry.Text != null)
            {
               User user=  this.dataAccess.GetUserLogin(emailEntry.Text, passwordEntry.Text);
                if (user != null)
                {
                    App.SetMainPage(user);
                }
                else
                {
                    messageLabel.IsVisible = true;
                    messageLabel.Text = "Email y contraseña son incorrectos. Intenta nuevamente";
                    messageLabel.TextColor = Xamarin.Forms.Color.Red;
                } 
            }
            else
            {
                messageLabel.IsVisible = true;
                messageLabel.Text = "Email y contraseña son campos requeridos";
                messageLabel.TextColor = Xamarin.Forms.Color.Red;
            }*/
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.SetMainPage(null);
        }
    }
  


}