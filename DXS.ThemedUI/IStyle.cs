using System;
using System.Collections.Generic;
using UIKit;

namespace DXS.ThemedUI
{
    public interface IStyle<in T> : IEnumerable<Action<T>> where T : UIView { }
}