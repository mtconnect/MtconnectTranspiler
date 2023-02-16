using ConsoulLibrary;
using ConsoulLibrary.Views;

namespace MtconnectTranspiler.Console.Views
{
    internal class MainView : StaticView
    {
        public MainView()
        {
            Title = (new BannerEntry($"MTConnect Transpiler")).Message;
        }
    }
}
