using DXS.ThemedUI.Views;

namespace DXS.ThemedUI
{
    public class DefaultTheme : ITheme
    {
        public virtual IStyle<ThemedUIView> ThemedUIViewStyle => new Style<ThemedUIView>(view => {});

        public virtual IStyle<ThemedUIActivityIndicatorView> ThemedUIActivityIndicatorViewStyle => new Style<ThemedUIActivityIndicatorView>(activityIndicatorView => {});

        public virtual IStyle<ThemedUIButton> ThemedUIButtonStyle => new Style<ThemedUIButton>(button => {});

        public virtual IStyle<ThemedUILabel> ThemedUILabelStyle => new Style<ThemedUILabel>(label => {});

        public virtual IStyle<ThemedUIPageControl> ThemedUIPageControlStyle => new Style<ThemedUIPageControl>(pageControl => {});

        public virtual  IStyle<ThemedUIProgressView> ThemedUIProgressViewStyle => new Style<ThemedUIProgressView>(progressView => {});

        public virtual IStyle<ThemedUISegmentedControl> ThemedUISegmentedControlStyle => new Style<ThemedUISegmentedControl>(segmentedControl => {});

        public virtual IStyle<ThemedUISlider> ThemedUISliderStyle => new Style<ThemedUISlider>(slider => {});

        public virtual IStyle<ThemedUIStepper> ThemedUIStepperStyle => new Style<ThemedUIStepper>(stepper => {});

        public virtual IStyle<ThemedUISwitch> ThemedUISwitchStyle => new Style<ThemedUISwitch>(uiSwitch => {});

        public virtual IStyle<ThemedUITextField> ThemedUITextFieldStyle => new Style<ThemedUITextField>(textField => {});

        public virtual IStyle<ThemedUITextView> ThemedUITextViewStyle => new Style<ThemedUITextView>(textView => {});

        public virtual IStyle<ThemedUIDatePicker> ThemedUIDatePickerStyle => new Style<ThemedUIDatePicker>(datePicker => {});

        public virtual IStyle<ThemedUIPickerView> ThemedUIPickerViewStyle => new Style<ThemedUIPickerView>(pickerView => {});
    }
}