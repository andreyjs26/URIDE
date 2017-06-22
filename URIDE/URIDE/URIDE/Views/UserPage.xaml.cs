using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.Graphics.Drawables;
using URIDE.Droid;
using URIDE.ViewModels;

namespace URIDE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserPage : ContentPage
	{
		public UserPage()
		{
			InitializeComponent ();
           
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            //Validations
            bool IsValid = true;

            lblName.IsVisible = txtName.Text != null  ? false :true;
            lblLastName.IsVisible = txtLastName.Text  != null ? false : true;
            lblEmail.IsVisible = txtEmail.Text != null ? false : true;
            lblPass.IsVisible = txtPass.Text != null ? false : true;
            lblResidence.IsVisible = txtResidence.Text != null ? false : true;
            lblDestination.IsVisible = txtDestination.Text != null ? false : true;

            IsValid = txtName.Text != null || txtLastName.Text != null || txtEmail.Text != null || txtPass.Text != null || txtResidence.Text != null || txtDestination.Text != null ? true : false;
            if (!IsValid) {
                return;
            }
            
            //Call the DB
                

        }

        private void swhDiscapacity_Toggled(object sender, ToggledEventArgs e)
        {
          
        }

        private void entrancePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private void exitPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}