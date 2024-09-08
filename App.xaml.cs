
using AppFinanc.MVVM.Views.TabbedPages;

namespace AppFinanc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabView();
        }
    }
}
