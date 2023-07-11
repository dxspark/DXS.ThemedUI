using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIPageControl"), DesignTimeVisible(true)]
    public class ThemedUIPageControl : UIPageControl
    {
        public ThemedUIPageControl() : base()
        {
            Initialize();
        }

        public ThemedUIPageControl(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIPageControl(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIPageControlStyle);
        }
    }
}