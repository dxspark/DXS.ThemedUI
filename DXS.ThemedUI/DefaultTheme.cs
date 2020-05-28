using DXS.ThemedUI.Views;
using UIKit;

namespace DXS.ThemedUI
{
    public class DefaultTheme : ITheme
    {
        public virtual IStyle<ThemedUIView> ThemedUIViewStyle => new Style<ThemedUIView>(view =>
        {
            view.BackgroundColor = UIColor.DarkGray;
        });

        public virtual IStyle<ThemedUIActivityIndicatorView> ThemedUIActivityIndicatorViewStyle => new Style<ThemedUIActivityIndicatorView>(activityIndicatorView =>
        {
            activityIndicatorView.Color = UIColor.Red;
        });

        public virtual IStyle<ThemedUIButton> ThemedUIButtonStyle => new Style<ThemedUIButton>(button =>
        {
            button.TintColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUILabel> ThemedUILabelStyle => new Style<ThemedUILabel>(label =>
        {
            label.TextColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUIPageControl> ThemedUIPageControlStyle => new Style<ThemedUIPageControl>(pageControl =>
        {
            pageControl.PageIndicatorTintColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUISegmentedControl> ThemedUISegmentedControlStyle => new Style<ThemedUISegmentedControl>(segmentedControl =>
        {
            segmentedControl.TintColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUISlider> ThemedUISliderStyle => new Style<ThemedUISlider>(slider =>
        {
            slider.TintColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUIStepper> ThemedUIStepperStyle => new Style<ThemedUIStepper>(stepper =>
        {
            stepper.TintColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUISwitch> ThemedUISwitchStyle => new Style<ThemedUISwitch>(uiSwitch =>
        {
            uiSwitch.TintColor = UIColor.Red;
            uiSwitch.OnTintColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUITextField> ThemedUITextFieldStyle => new Style<ThemedUITextField>(textField =>
        {
            textField.TintColor = UIColor.Red;
            textField.TextColor = UIColor.Red;
        });

        public virtual IStyle<ThemedUITextView> ThemedUITextViewStyle => new Style<ThemedUITextView>(textView =>
        {
            textView.TintColor = UIColor.Red;
            textView.TextColor = UIColor.Red;
        });
    }
}
