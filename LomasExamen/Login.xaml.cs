using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LomasExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                if (txtUsuario.Text.Equals("estudiante2021") && txtClave.Text.Equals("uisrael2021"))
                {
                    //permite abrir la ventana dos
                    await Navigation.PushAsync(new Registro(usuario, clave));
                }
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("usuario/contrasenia incorrectos", ex.Message, "OK");

            }

        }
    }
}
