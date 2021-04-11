using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace XamarinFormsSplashscreenRecipe.Droid
{
    [Activity(Label = "XamarinFormsSplashscreenRecipe", Icon = "@mipmap/icon", Theme = "@style/SplashTheme",
        MainLauncher = true, NoHistory = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // To Disable animation uncomment this but there will be problem in Landscape mode.
            //StartActivity(typeof(MainActivity));
            //Disable animation style, add this line to style
            //<item name="android:windowAnimationStyle">@null</item>
            //Finish();
            //OverridePendingTransition(0,0);
        }

        protected override void OnResume()
        {
            base.OnResume();
            new Task(async () =>
            {
                // StartActivity(typeof(MainActivity));
                await Task.Delay(3000); // Simulate a bit of startup work.
                StartActivity(new Intent(Application.Context, typeof (MainActivity)));
            }).Start();
        }

        // Prevent the back button from canceling the startup process
        public override void OnBackPressed()
        {
        }
    }
}