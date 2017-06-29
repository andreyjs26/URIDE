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
            this.dataAccess = new UserDataAccess();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            messageLabel.IsVisible = false;
            if (emailEntry.Text != null || passwordEntry.Text != null)
            {
               User user=  this.dataAccess.GetUserLogin(emailEntry.Text, passwordEntry.Text);
                if (user != null)
                {
                    App.SetMainPage();
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
            }
        }

       

    }
  


}