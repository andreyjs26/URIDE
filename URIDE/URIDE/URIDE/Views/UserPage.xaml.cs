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
using URIDE.Services;
using URIDE.Models;

namespace URIDE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserPage : ContentPage
	{
        private UserDataAccess dataAccess;
        public UserPage(User user)
		{
			InitializeComponent ();
            // An instance of the UserDataAccess
            // that is used for data-binding and data access
            this.dataAccess = new UserDataAccess();
            if(user != null)
            {
                txtName.Text = user.name;
                txtLastName.Text = user.lastName;
                txtEmail.Text = user.email;
                txtPass.Text = user.password;
                txtDestination.Text = user.destination;
                txtResidence.Text = user.residence;
                entrancePicker.Time = user.entrance;
                exitPicker.Time = user.exit;
                swhDiscapacity.IsToggled = user.discapacity;
                
            }
            

        }

        // An event that is raised when the page is shown
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // The instance of CustomersDataAccess
            // is the data binding source
            this.BindingContext = this.dataAccess;

            IEnumerable<User> all = dataAccess.GetUsers();
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            //Validations
            bool IsValid = true;

            lblName.IsVisible = txtName.Text != null ? false : true;
            lblLastName.IsVisible = txtLastName.Text != null ? false : true;
            lblEmail.IsVisible = txtEmail.Text != null ? false : true;
            lblPass.IsVisible = txtPass.Text != null ? false : true;
            lblResidence.IsVisible = txtResidence.Text != null ? false : true;
            lblDestination.IsVisible = txtDestination.Text != null ? false : true;

            IsValid = txtName.Text != null || txtLastName.Text != null || txtEmail.Text != null || txtPass.Text != null || txtResidence.Text != null || txtDestination.Text != null ? true : false;
            if (!IsValid) {
                return;
            }

            //Call the DB
            User newUser = new User();
            newUser.name = txtName.Text;
            newUser.lastName = txtLastName.Text;
            newUser.email = txtEmail.Text;
            newUser.password = txtPass.Text;
            newUser.residence = txtResidence.Text;
            newUser.destination = txtDestination.Text;
            newUser.entrance = entrancePicker.Time;
            newUser.exit = exitPicker.Time;
            newUser.discapacity = swhDiscapacity.IsToggled;

            this.dataAccess.SaveUser(newUser);
            DisplayAlert("Validacion","Usuario guardado satisfactoriamente","Aceptar");

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