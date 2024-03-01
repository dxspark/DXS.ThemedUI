﻿using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIProgressView"), DesignTimeVisible(true)]
    public class ThemedUIProgressView : UIProgressView
    {
        public ThemedUIProgressView() : base()
        {
            Initialize();
        }

        public ThemedUIProgressView(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIProgressView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIProgressViewStyle);
        }
    }
}