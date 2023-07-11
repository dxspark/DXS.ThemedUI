using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUIActivityIndicatorView"), DesignTimeVisible(true)]
    public class ThemedUIActivityIndicatorView : UIActivityIndicatorView
    {
        public ThemedUIActivityIndicatorView() : base()
        {
            Initialize();
        }

        public ThemedUIActivityIndicatorView(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUIActivityIndicatorView(UIActivityIndicatorViewStyle style) : base(style)
        {
            Initialize();
        }

        public ThemedUIActivityIndicatorView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUIActivityIndicatorViewStyle);
        }
    }
}
