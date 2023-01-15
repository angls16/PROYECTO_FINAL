using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PROYECTO_FINAL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menu : ContentPage
    {
        public menu()
        {
            InitializeComponent();
        }

       

        private async void btnGenerar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new generar_clave());
        }

        private async void btnCifrar_Descifrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new encriptacion_descencriptacion());
        }
    }
}