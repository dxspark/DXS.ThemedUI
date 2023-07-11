using DXS.ThemedUI;
using SampleApp.Themes;
using UIKit;

namespace SampleApp
{
    public class Application
    {
        static void Main(string[] args)
        {
            //Set your custom theme
            ThemedUI.Init(new BlueTheme());

            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}