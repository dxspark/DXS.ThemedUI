using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUISwitch"), DesignTimeVisible(true)]
    public class ThemedUISwitch : UISwitch
    {
        public ThemedUISwitch() : base()
        {
            Initialize();
        }

        public ThemedUISwitch(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUISwitch(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUISwitchStyle);
        }
    }
}