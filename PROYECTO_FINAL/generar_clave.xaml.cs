using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace PROYECTO_FINAL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class generar_clave : ContentPage
    {
        public generar_clave()
        {
            InitializeComponent();
        }
        string Permutacion = "";

        public void bloque(object sender, EventArgs e) {
            Button boton = (Button)sender;
            if(boton.Text == "8"){
                Permutacion = "1234" ;

            }
            else if (boton.Text == "10")
            {
                Permutacion = "12345";
            }
            else if (boton.Text == "12")
            {
                Permutacion= "123456";
            }
            permutacion.Text = Permutacion;
        }
        private void limpiar_Clicked(object sender, EventArgs e)
        {
            permutacion.Text = String.Empty;
            sustitucion.Text = String.Empty;
            interaciones.Text = String.Empty;
            generado.Text = String.Empty;

        }
        private void generar_Clicked(object sender, EventArgs e)
        {

        }
        private async void copiar_Clicked(object sender, EventArgs e)
        {
            if (generado.Text == "")
            {
                var text2 = Clipboard.HasText;
                await Clipboard.SetTextAsync(generado.Text);
                var text = await Clipboard.GetTextAsync();
                await DisplayAlert("Copiado", " la Clave Generada se a copiado correctamente ", "Salir");
            }
            else {
                await DisplayAlert("Error", " No se a generado correctamente ", "Salir");
            }

                
        }
    }
}