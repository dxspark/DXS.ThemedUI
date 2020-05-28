using DXS.ThemedUI;
using DXS.ThemedUI.Extensions;
using DXS.ThemedUI.Views;
using Foundation;
using System;
using System.Threading.Tasks;
using UIKit;


namespace SampleApp
{
    public partial class ViewController : UIViewController
    {
        UILabel label;
            

        public ViewController(IntPtr handle) : base(handle)
        {
            ThemedUI.Init(new Theme());
        }

        public override async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            label = new ThemedUILabel();

            await test();
            //label.WithStyle(new Theme().YellowThemedUILabelStyle);
        }


        public async Task test()
        {
            await Task.Delay(1000);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}