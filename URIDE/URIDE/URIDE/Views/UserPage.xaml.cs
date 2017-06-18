using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            /*if (this.Control != null)
            {
                if (this.Control.Checked)
                {
                    this.Control.ThumbDrawable.SetColorFilter(greenColor, PorterDuff.Mode.SrcAtop);
                }
                else
                {
                    this.Control.ThumbDrawable.SetColorFilter(greyColor, PorterDuff.Mode.SrcAtop);
                }
            }*/
        }
    }
}