using System.Threading.Tasks;
using Android.App;
using Android.OS;

namespace XamarinFormsSplashscreenRecipe.Droid
{
    [Activity(Icon = "@mipmap/icon", Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            
            //Disable animation style, add this line to style
            //<item name="android:windowAnimationStyle">@null</item>
            Finish();
            OverridePendingTransition(0,0);
        }

        protected override void OnResume()
        {
            base.OnResume();
            // new Task(() =>
            // {
            //     StartActivity(typeof(MainActivity));
            // }).Start();
        }

        // Prevent the back button from canceling the startup process
        public override void OnBackPressed()
        {
        }
    }
}