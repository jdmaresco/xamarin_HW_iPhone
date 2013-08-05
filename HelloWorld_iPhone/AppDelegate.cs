using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld_iPhone
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;									// window declared here represents the actual app window
		HelloWorld_iPhoneViewController viewController;		// controller declared here is responsible for displaying a view in our window
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);			// create the window at the exact size of the screen
			
			viewController = new HelloWorld_iPhoneViewController ();	// create a new view controller
			window.RootViewController = viewController;					// set the new view controller as root (main screen)
			window.MakeKeyAndVisible ();								// make the window key (from os x programming model - sets window with focus) and visible
			
			return true;												// returns from the method
		}
	}
}

