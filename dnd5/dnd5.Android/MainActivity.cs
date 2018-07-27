using System;
using System.IO;
using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.IO;
using Libraries;

namespace dnd5.Droid
{
    [Activity(Label = "dnd5", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            this.LoadApplication(new App());

            PhoneLibrary.Init(Application.Context.Assets.Open("classes.json"));
        }
    }
}

