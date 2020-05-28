using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIStepper"), DesignTimeVisible(true)]
    public class ThemedUIStepper : UIStepper
    {
        public ThemedUIStepper() : base()
        {
            Initialize();
        }

        public ThemedUIStepper(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIStepper(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIStepperStyle);
        }
    }
}