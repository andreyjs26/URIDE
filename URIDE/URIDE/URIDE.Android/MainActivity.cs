﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace URIDE.Droid
{
    [Activity(Label = "URIDE", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            int ScreenWidth = (int)Resources.DisplayMetrics.WidthPixels; // real pixels
            int ScreenHeight = (int)Resources.DisplayMetrics.HeightPixels; // real pixels

            LoadApplication(new App());
        }
       
    }
}