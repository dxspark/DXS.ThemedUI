﻿using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIPickerView"), DesignTimeVisible(true)]
    public class ThemedUIPickerView : UIPickerView
    {
        public ThemedUIPickerView() : base()
        {
            Initialize();
        }

        public ThemedUIPickerView(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIPickerView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIPickerViewStyle);
        }
    }
}