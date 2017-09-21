// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AutoLayoutButton
{
	[Register ("AutoLayoutButtonViewController")]
	partial class AutoLayoutButtonViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnClickHere { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		NSLayoutConstraint constButtonBottom { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnClickHere != null) {
				btnClickHere.Dispose ();
				btnClickHere = null;
			}
			if (constButtonBottom != null) {
				constButtonBottom.Dispose ();
				constButtonBottom = null;
			}
		}
	}
}
