using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUILabel"), DesignTimeVisible(true)]
    public class ThemedUILabel : UILabel
    {
        public ThemedUILabel() : base()
        {
            Initialize();
        }

        public ThemedUILabel(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUILabel(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUILabelStyle);
        }
    }
}