using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace URIDE.ViewModels
{   

    public class UserViewModel : BaseViewModel
    {
        public UserViewModel()
        {
            Title = "Usuario";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }

    }
}
