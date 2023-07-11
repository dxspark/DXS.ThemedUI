using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIButton"), DesignTimeVisible(true)]
    public class ThemedUIButton : UIButton
    {
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
    }
}