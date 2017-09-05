using System;
using Foundation;
using UIKit;

namespace MonkeyInfo
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void WillRotate (UIInterfaceOrientation toInterfaceOrientation, double duration)
        {
            base.WillRotate(toInterfaceOrientation, duration);

            SetOrientation(toInterfaceOrientation == UIInterfaceOrientation.LandscapeLeft ||
                           toInterfaceOrientation == UIInterfaceOrientation.LandscapeRight);
        }

        void SetOrientation(bool isLandscape)
        {
			//remove the constraints we want to change
			this.View.RemoveConstraint(constLeftText);
			this.View.RemoveConstraint(constTopText);

			if (isLandscape == true)
			{
				constLeftText = GetConstraint(constraint: constLeftText,
				   object2: imgMonkey,
				   attribute2: NSLayoutAttribute.Trailing
				);

				constTopText = GetConstraint(constraint: constTopText,
				   object2: this.View,
				   attribute2: NSLayoutAttribute.Top
				);
			}
			else
			{
				constLeftText = GetConstraint(constraint: constLeftText,
				   object2: this.View,
				   attribute2: NSLayoutAttribute.Leading
				);

				constTopText = GetConstraint(constraint: constTopText,
				   object2: imgMonkey,
				   attribute2: NSLayoutAttribute.Bottom
				);
			}

			this.View.AddConstraint(constLeftText);
			this.View.AddConstraint(constTopText);       
        }

		//helper method to create constraints based on existing constraints
		NSLayoutConstraint GetConstraint(
		   NSLayoutConstraint constraint,
		   NSObject object1 = null,
		   NSLayoutAttribute? attribute1 = null,
		   NSLayoutRelation? relation = null,
		   NSObject object2 = null,
		   NSLayoutAttribute? attribute2 = null,
		   nfloat? multiplier = null,
		   nfloat? constant = null)
		{
			if (constraint == null)
				return null;
			return NSLayoutConstraint.Create(
					 object1 ?? constraint.FirstItem,
					 (attribute1 == null) ? constraint.FirstAttribute : attribute1.Value,
					 (relation == null) ? constraint.Relation : relation.Value,
					 object2 ?? constraint.SecondItem,
					 (attribute2 == null) ? constraint.SecondAttribute : attribute2.Value,
					 (multiplier == null) ? constraint.Multiplier : multiplier.Value,
					 (constant == null) ? constraint.Constant : constant.Value);
		}
    }
}
