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
           
        }

        private async void copiar_Clicked(object sender, EventArgs e)
        {
            var text2 = Clipboard.HasText;
            await Clipboard.SetTextAsync(Texto2.Text);
            var text = await Clipboard.GetTextAsync();
            DisplayAlert("Copiado"," la Clave se a copiado correctamente ","Ok");
        }
    }
}