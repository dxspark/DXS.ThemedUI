using DXS.ThemedUI.Views;

namespace DXS.ThemedUI
{
    public interface ITheme
    {
        IStyle<ThemedUIView> ThemedUIViewStyle { get; }

        IStyle<ThemedUIActivityIndicatorView> ThemedUIActivityIndicatorViewStyle { get; }

        IStyle<ThemedUIButton> ThemedUIButtonStyle { get; }

        IStyle<ThemedUILabel> ThemedUILabelStyle { get; }

        IStyle<ThemedUIPageControl> ThemedUIPageControlStyle { get; }

        IStyle<ThemedUIProgressView> ThemedUIProgressViewStyle { get; }

        IStyle<ThemedUISegmentedControl> ThemedUISegmentedControlStyle { get; }

        IStyle<ThemedUISlider> ThemedUISliderStyle { get; }

        IStyle<ThemedUIStepper> ThemedUIStepperStyle { get; }

        IStyle<ThemedUISwitch> ThemedUISwitchStyle { get; }

        IStyle<ThemedUITextField> ThemedUITextFieldStyle { get; }

        IStyle<ThemedUITextView> ThemedUITextViewStyle { get; }

        IStyle<ThemedUIDatePicker> ThemedUIDatePickerStyle { get; }

        IStyle<ThemedUIPickerView> ThemedUIPickerViewStyle { get; }
    }
}