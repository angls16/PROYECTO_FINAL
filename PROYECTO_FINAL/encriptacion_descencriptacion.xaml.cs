using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PROYECTO_FINAL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class encriptacion_descencriptacion : ContentPage
    {

        public encriptacion_descencriptacion()
        {
            InitializeComponent();


        }
        private void limpiar_Clicked(object sender, EventArgs e)
        {
            Texto1.Text = String.Empty;
            Texto2.Text = String.Empty;
            encriptar.IsChecked = false;
            descencriptar.IsChecked = false;
        }

        private async void copiar_Clicked(object sender, EventArgs e)
        {
            if (Texto2.Text == "")
            {
                var text2 = Clipboard.HasText;
                await Clipboard.SetTextAsync(Texto2.Text);
                var text = await Clipboard.GetTextAsync();
            
               await DisplayAlert("Copiado"," la Clave se a copiado correctamente ","Salir");
            }else{
                await DisplayAlert("Error", " No se a generado correctamente ", "Salir");
            }
        }

        private void generar_Clicked(object sender, EventArgs e)
        {

        }
    }
}