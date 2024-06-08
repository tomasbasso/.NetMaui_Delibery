using RETO_10.Views;

namespace Reto_Nº10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StoresView());
        }
    }
}
