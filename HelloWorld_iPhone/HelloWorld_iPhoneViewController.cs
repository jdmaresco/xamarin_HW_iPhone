using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld_iPhone
{
	public partial class HelloWorld_iPhoneViewController : UIViewController
	{

		protected int _numberOfTimesClicked = 0;

		public HelloWorld_iPhoneViewController () : base ("HelloWorld_iPhoneViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			this.btnClickMe.TouchUpInside += (object sender, EventArgs e) => {
				this._numberOfTimesClicked++;
				this.lblOutput.Text = "Clicked [" +
					this._numberOfTimesClicked.ToString () + "] times!";
			};
	
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		partial void actnButtonClick (MonoTouch.Foundation.NSObject sender)
		{
			this.lblOutput.Text = "Action button " + ((UIButton)sender).CurrentTitle + " clicked.";
		}
	}
}

