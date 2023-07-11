using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIButton"), DesignTimeVisible(true)]
    public class ThemedUIButton : UIButton
    {
        public UIColor NormalBackgroundColor { get; set; }
        public UIColor HighlightedBackgroundColor { get; set; }
        public UIColor DisabledBackgroundColor { get; set; }
        public UIColor SelectedBackgroundColor { get; set; }

        public override bool Enabled
        {
            get { return base.Enabled; }
            set
            {
                base.Enabled = value;
                var state = value ? UIControlState.Normal : UIControlState.Disabled;
                SetBackgroundColorForState(state);
            }
        }

        public override bool Highlighted
        {
            get { return base.Highlighted; }
            set
            {
                base.Highlighted = value;
                var state = value ? UIControlState.Highlighted : Selected ? UIControlState.Selected : UIControlState.Normal;
                SetBackgroundColorForState(state);
            }
        }

        public override bool Selected
        {
            get { return base.Selected; }
            set
            {
                base.Selected = value;
                var state = value ? UIControlState.Selected : Highlighted ? UIControlState.Highlighted : UIControlState.Normal;
                SetBackgroundColorForState(state);
            }
        }

        public ThemedUIButton() : base()
        {
            Initialize();
        }

        public ThemedUIButton(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        public ThemedUIButton(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIButton(UIButtonType type) : base(type)
        {
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIButtonStyle);
        }

        protected void SetBackgroundColorForState(UIControlState state)
        {
            switch (state)
            {
                case UIControlState.Normal:
                    if (NormalBackgroundColor != null)
                    {
                        BackgroundColor = NormalBackgroundColor;
                    }
                    break;
                case UIControlState.Highlighted:
                    if (HighlightedBackgroundColor != null)
                    {
                        BackgroundColor = HighlightedBackgroundColor;
                    }
                    break;
                case UIControlState.Selected:
                    if (SelectedBackgroundColor != null)
                    {
                        BackgroundColor = SelectedBackgroundColor;
                    }
                    break;
                case UIControlState.Disabled:
                    if (DisabledBackgroundColor != null)
                    {
                        BackgroundColor = DisabledBackgroundColor;
                    }
                    break;
            }
        }
    }
}