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
        public UIEdgeInsets EdgeInsets { get; set; } = UIEdgeInsets.Zero;

        public ThemedUILabel() : base() => Initialize();

        public ThemedUILabel(CGRect frame) : base(frame) => Initialize();

        public ThemedUILabel(IntPtr handle) : base(handle) {}

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize() => this.WithStyle(ThemedUI.CurrentTheme.ThemedUILabelStyle);

        public override CGRect TextRectForBounds(CGRect bounds, nint numberOfLines)
        {
            CGRect textRect = base.TextRectForBounds(EdgeInsets.InsetRect(bounds), numberOfLines);
            return GetInvertedInsets().InsetRect(textRect);
        }

        public override void DrawText(CGRect rect) => base.DrawText(EdgeInsets.InsetRect(rect));

        UIEdgeInsets GetInvertedInsets()
        {
            return new UIEdgeInsets
            (
                -EdgeInsets.Top,
                -EdgeInsets.Left,
                -EdgeInsets.Bottom,
                -EdgeInsets.Right
            );
        }
    }
}