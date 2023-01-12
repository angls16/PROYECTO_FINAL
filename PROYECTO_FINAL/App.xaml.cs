using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PROYECTO_FINAL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
