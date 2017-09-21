using System;
using CoreGraphics;

using Foundation;
using UIKit;

namespace AutoLayoutButton
{
	public partial class AutoLayoutButtonViewController : UIViewController
	{
		public AutoLayoutButtonViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			this.View.RemoveConstraint (constButtonBottom);

			var newConstraint = NSLayoutConstraint.Create (this.View, NSLayoutAttribute.Top,
				                    NSLayoutRelation.Equal, 
				                    btnClickHere, NSLayoutAttribute.Top,
				                    1, -50);

			this.View.AddConstraint (newConstraint);
		}
	}
}

