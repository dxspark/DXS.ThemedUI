using System.ComponentModel;
using DXS.ThemedUI.Extensions;

namespace DXS.ThemedUI.Views
{
    [Register("ThemedUITextView"), DesignTimeVisible(true)]
    public class ThemedUITextView : UITextView
    {
        public ThemedUITextView() : base()
        {
            Initialize();
        }

        public ThemedUITextView(CGRect frame) : base(frame)
        {
            Initialize();
        }

        public ThemedUITextView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();
        }

        void Initialize()
        {
            this.WithStyle(ThemedUI.CurrentTheme.ThemedUITextViewStyle);
        }
    }
}