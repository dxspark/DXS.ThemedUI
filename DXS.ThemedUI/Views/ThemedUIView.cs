using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIView"), DesignTimeVisible(true)]
    public class ThemedUIView : UIView
    {
        public ThemedUIView() : base()
        {
            Initialize();
        }

        public ThemedUIView(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIViewStyle);
        }
    }
}