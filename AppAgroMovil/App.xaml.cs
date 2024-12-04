using AppAgroMovil.MVVM.View;

namespace AppAgroMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
