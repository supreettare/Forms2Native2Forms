﻿using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Native2Forms;
using Xamarin.Forms;
using System.IO;

namespace Native2Forms
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);

			// create a new window instance based on the screen size
            //window = new UIWindow (UIScreen.MainScreen.Bounds);

            //var nav = new UINavigationController (new MyFirstViewController ());
            //// If you have defined a view, add it here:
            //// window.RootViewController  = navigationController;
            //window.RootViewController = nav;

            //// make the window visible
            //window.MakeKeyAndVisible ();

            //return true;
		}
	}
}

