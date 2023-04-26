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
    public partial class resumen : ContentPage
    {
        public resumen(string MontoInicial, string CuotaUno, string CuotaDos, string CuotaTres, string PagoTotal)
        {

            InitializeComponent();
            txtMontoInicial.Text = MontoInicial;
            txtCuotaUno.Text = CuotaUno;
            txtCuotaDos.Text = CuotaDos;
            txtCuotaTres.Text = CuotaTres;
            txtPagoTotal.Text = PagoTotal;
        }
    }
}