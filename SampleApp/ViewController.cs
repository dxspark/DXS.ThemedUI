using System;
using UIKit;

namespace SampleApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle) {}

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            pickerView.Model = new PickerViewModel();
        }

        class PickerViewModel : UIPickerViewModel
        {
            public override nint GetComponentCount(UIPickerView pickerView) => 1;
            public override nint GetRowsInComponent(UIPickerView pickerView, nint component) => 5;
            public override string GetTitle(UIPickerView pickerView, nint row, nint component) => row.ToString();
        }
    }
}