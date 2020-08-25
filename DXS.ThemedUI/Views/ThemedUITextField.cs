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
        public UIEdgeInsets EdgeInsets { get; set; } = UIEdgeInsets.Zero;

        public ThemedUITextField() : base() =>Initialize();

        public ThemedUITextField(CGRect frame) : base(frame) => Initialize();

        public ThemedUITextField(IntPtr handle) : base(handle) {}

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize() => this.WithStyle(ThemedUI.CurrentTheme.ThemedUITextFieldStyle);

        public override CGRect TextRect(CGRect forBounds) => base.TextRect(InsetRect(forBounds));

        public override CGRect EditingRect(CGRect forBounds) => base.EditingRect(InsetRect(forBounds));

        CGRect InsetRect(CGRect rect)
        {
            return new CGRect
            (
                rect.X + EdgeInsets.Left,
                rect.Y + EdgeInsets.Top,
                rect.Width - EdgeInsets.Left - EdgeInsets.Right,
                rect.Height - EdgeInsets.Top - EdgeInsets.Bottom
            );
        }
    }
}