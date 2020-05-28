using System;
using System.Collections;
using System.Collections.Generic;
using UIKit;

namespace DXS.ThemedUI
{
    public class Style<T> : IStyle<T> where T : UIView
    {
        List<Action<T>> styleActions;

        public IEnumerator<Action<T>> GetEnumerator() => styleActions.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => styleActions.GetEnumerator();

        public Style(Action<T> styleAction) : this(null, styleAction) { }

        public Style(IStyle<T> parent, Action<T> styleAction)
        {
            styleActions = new List<Action<T>>();
            if (parent != null)
                styleActions.AddRange(parent);
            styleActions.Add(styleAction);
        }
    }
}