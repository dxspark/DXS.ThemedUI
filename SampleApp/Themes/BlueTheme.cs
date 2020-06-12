using DXS.ThemedUI;
using DXS.ThemedUI.Views;
using Foundation;
using UIKit;

namespace SampleApp.Themes
{
    public class BlueTheme : ITheme
    {
        UIColor _primaryColor = UIColor.Blue;
        UIColor _backgroundColor = UIColor.LightGray;

        public IStyle<ThemedUIView> ThemedUIViewStyle => new Style<ThemedUIView>(view =>
        {
            view.BackgroundColor = _backgroundColor;
        });

        public IStyle<ThemedUIActivityIndicatorView> ThemedUIActivityIndicatorViewStyle => new Style<ThemedUIActivityIndicatorView>(activityIndicatorView =>
        {
            activityIndicatorView.Color = _primaryColor;
        });

        public IStyle<ThemedUIButton> ThemedUIButtonStyle => new Style<ThemedUIButton>(button =>
        {
            button.TintColor = _primaryColor;
        });

        public IStyle<ThemedUILabel> ThemedUILabelStyle => new Style<ThemedUILabel>(label =>
        {
            label.TextColor = _primaryColor;
        });

        public IStyle<ThemedUIPageControl> ThemedUIPageControlStyle => new Style<ThemedUIPageControl>(pageControl =>
        {
            pageControl.PageIndicatorTintColor = _primaryColor;
        });

        public IStyle<ThemedUIProgressView> ThemedUIProgressViewStyle => new Style<ThemedUIProgressView>(progressView =>
        {
            progressView.TintColor = _primaryColor;
        });

        public IStyle<ThemedUISegmentedControl> ThemedUISegmentedControlStyle => new Style<ThemedUISegmentedControl>(segmentedControl =>
        {
            segmentedControl.TintColor = _primaryColor;
        });

        public IStyle<ThemedUISlider> ThemedUISliderStyle => new Style<ThemedUISlider>(slider =>
        {
            slider.TintColor = _primaryColor;
        });

        public IStyle<ThemedUIStepper> ThemedUIStepperStyle => new Style<ThemedUIStepper>(stepper =>
        {
            stepper.TintColor = _primaryColor;
        });

        public IStyle<ThemedUISwitch> ThemedUISwitchStyle => new Style<ThemedUISwitch>(uiSwitch =>
        {
            uiSwitch.TintColor = _primaryColor;
            uiSwitch.OnTintColor = _primaryColor;
        });

        public IStyle<ThemedUITextField> ThemedUITextFieldStyle => new Style<ThemedUITextField>(textField =>
        {
            textField.TintColor = _primaryColor;
            textField.TextColor = _primaryColor;
        });

        public IStyle<ThemedUITextView> ThemedUITextViewStyle => new Style<ThemedUITextView>(textView =>
        {
            textView.TintColor = _primaryColor;
            textView.TextColor = _primaryColor;
        });

        public IStyle<ThemedUIDatePicker> ThemedUIDatePickerStyle => new Style<ThemedUIDatePicker>(datePicker =>
        {
            datePicker.SetValueForKey(_primaryColor, new NSString("textColor"));
        });

        public IStyle<ThemedUIPickerView> ThemedUIPickerViewStyle => new Style<ThemedUIPickerView>(pickerView =>
        {
            pickerView.SetValueForKey(_primaryColor, new NSString("textColor"));
        });

    }
}