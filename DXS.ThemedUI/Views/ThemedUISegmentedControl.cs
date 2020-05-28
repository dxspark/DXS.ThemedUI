using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUISegmentedControl"), DesignTimeVisible(true)]
    public class ThemedUISegmentedControl : UISegmentedControl
    {
        public ThemedUISegmentedControl() : base()
        {
            Initialize();
        }

        public ThemedUISegmentedControl(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUISegmentedControl(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUISegmentedControlStyle);
        }
    }
}