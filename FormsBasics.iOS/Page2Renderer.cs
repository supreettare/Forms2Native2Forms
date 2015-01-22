using MonoTouch.UIKit;
using Native2Forms;
using Native2Forms.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MySecondPage), typeof(Page2Renderer))]
namespace Native2Forms.iOS
{
    class Page2Renderer : PageRenderer
    { 
        UIWindow window;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var page = e.NewElement as MySecondPage;
           

            var view = NativeView;

            // create a new window instance based on the screen size
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            var nav = new UINavigationController(new MyFirstViewController());
            // If you have defined a view, add it here:
            // window.RootViewController  = navigationController;
            window.RootViewController = nav;

            // make the window visible
            window.MakeKeyAndVisible();

        }
    }
}
