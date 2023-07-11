using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIView"), DesignTimeVisible(true)]
    public class ThemedUIView : UIView
    {
        public ThemedUIView() : base()
        {
            Initialize();
        }

        public ThemedUIView(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIViewStyle);
        }
    }
}