using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;

namespace Cellenza.Quizz.Droid
{
    [Activity(Label = "Cellenza.Quizz", MainLauncher = true)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {

			///this.RequestWindowFeature (WindowFeatures.NoTitle);
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
			this.ActionBar.Hide ();
            SetPage(App.GetStartPage());
        }
    }
}

