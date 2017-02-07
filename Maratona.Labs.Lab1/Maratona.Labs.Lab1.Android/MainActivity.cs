using Android.App;
using Android.Widget;
using Android.OS;

namespace Maratona.Labs.Lab1.Android
{
    [Activity(Label = "Maratona.Labs.Lab1.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks", count.ToString());
                count++;
            };
        }
    }
}

