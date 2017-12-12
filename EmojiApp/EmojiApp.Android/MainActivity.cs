
using Android.App;
using Android.Content.PM;
using Android.OS;
using EmojiApp.Infrastructure.IoC;
using Ninject;

namespace EmojiApp.Droid
{
    [Activity(Label = "EmojiApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            IoCContainerFactory.Init(new AndroidNinjectModule());
            IKernel kernel = IoCContainerFactory.GetContainer();
            //kernel.Load(new AndroidNinjectModule());
            LoadApplication(new App());
        }
    }
}

