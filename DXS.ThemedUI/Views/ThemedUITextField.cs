using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUITextField"), DesignTimeVisible(true)]
    public class ThemedUITextField : UITextField
    {
        public ThemedUITextField() : base()
        {
            Initialize();
        }

        public ThemedUITextField(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUITextField(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUITextFieldStyle);
        }
    }
}