using System;
using UIKit;

namespace DXS.ThemedUI.Extensions
{
    public static class Extensions
    {
        public static T WithStyle<T>(this T view, IStyle<T> style) where T : UIView
        {
            foreach (Action<T> action in style)
            {
                action(view);
            }
            return view;
        }
    }
}