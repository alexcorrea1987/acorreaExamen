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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
           string usuario = txtUsuario.Text;
           string contraseña = txtContraseña.Text;

            if (usuario == "estudiante2023" && contraseña == "uisrael2023")
            {
                Navigation.PushAsync(new registro());
            }
            else
            {
                DisplayAlert("ALERTA", "usuario/contraseña incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }

        
    }
}