using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUISlider"), DesignTimeVisible(true)]
    public class ThemedUISlider : UISlider
    {
        public ThemedUISlider() : base()
        {
            Initialize();
        }

        public ThemedUISlider(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUISlider(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUISliderStyle);
        }
    }
}