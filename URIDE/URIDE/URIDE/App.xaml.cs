using URIDE.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace URIDE
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

            Current.MainPage = new NavigationPage(new Login());

           // SetMainPage();
		}

		public static void SetMainPage()
		{
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    /*new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },*/
                    new NavigationPage(new UserPage())
                    {
                        Title = "Usuario",
                        Icon = Device.OnPlatform<string>("tab about.png",null,null)
                    },
                    new NavigationPage(new DriverPage())
                    {
                        Title = "Conductor",
                        Icon = Device.OnPlatform<string>("tab about.png",null,null)
                    },   

                }
            };
        }
	}
}
