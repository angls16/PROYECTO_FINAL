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
        private void copiar_Clicked(object sender, EventArgs e)
        {
        }
    }
}