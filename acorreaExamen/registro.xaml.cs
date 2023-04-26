using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace acorreaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double MontoInicial = Convert.ToDouble(txtMontoInicial.Text) / 3;
            double MontoInicial2 = Convert.ToDouble(txtMontoInicial.Text) * 0.95;
            double suma = MontoInicial + MontoInicial2;
            txtCuotaUno.Text = MontoInicial.ToString();
            txtCuotaDos.Text = MontoInicial.ToString();
            txtCuotaTres.Text = MontoInicial.ToString();
            txtPagoTotal.Text = suma.ToString();

        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtCuotaUno.Text = "";
            txtCuotaDos.Text = "";
            txtCuotaTres.Text = "";
            txtPagoTotal.Text = "";
        }

       

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("GUARDAR", "Elemento Guardado con éxito", "Cerrar");
        }

        private void btnRegistar_Clicked(object sender, EventArgs e)
        {

        }
    }
}