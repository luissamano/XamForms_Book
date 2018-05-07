using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace Surveys.Android
{
    [Activity(Label = "Surveys", MainLauncher = true)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new Core.App());

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);
        }
    }
}

