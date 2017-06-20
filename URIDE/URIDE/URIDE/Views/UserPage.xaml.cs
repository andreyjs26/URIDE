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

        }

        private void swhDiscapacity_Toggled(object sender, ToggledEventArgs e)
        {
          
        }
    }
}