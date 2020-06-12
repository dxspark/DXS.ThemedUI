using System;
using System.ComponentModel;
using CoreGraphics;
using DXS.ThemedUI.Extensions;
using Foundation;
using UIKit;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIDatePicker"), DesignTimeVisible(true)]
    public class ThemedUIDatePicker : UIDatePicker
    {
        public ThemedUIDatePicker() : base()
        {
            Initialize();
        }

        public ThemedUIDatePicker(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIDatePicker(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIDatePickerStyle);
        }
    }
}