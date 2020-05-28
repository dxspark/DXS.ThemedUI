using System;
using DXS.ThemedUI;
using DXS.ThemedUI.Views;
using UIKit;

namespace SampleApp
{
    public class Theme : DefaultTheme
    {
        public Theme()
        {
        }

        public IStyle<ThemedUILabel> YellowThemedUILabelStyle => new Style<ThemedUILabel>(base.ThemedUILabelStyle, label => label.TextColor = UIColor.Yellow);

    }
}
