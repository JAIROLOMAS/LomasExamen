using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LomasExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string clave)
        {
            InitializeComponent();
           
            txtUsuario.Text = usuario;
            txtClave.Text = clave;
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                string nombre = txtNombre.Text;
                string Total = txtTotal.Text;
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
               
                await Navigation.PushAsync(new Resumen(usuario, clave, Total, nombre));


            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de Alerta", ex.Message, "ok");
               
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //almacenar en variable, lo que el usuario ingresa en las cajas de texto
            string valor1 = txtNombre.Text;
            double valor2 = Convert.ToDouble(txtValorDos.Text); ;
            double valor3 = 0;
            double valor4 = 0;
            double valor5 = 0;

            //operacion
            double suma = 1800 - valor2;

            valor3 = suma / 3;

            valor4 = valor3 * 1.05;

            valor5 = suma + valor4;

            // visualizar resultado en pantalla
            txtResultado.Text = valor3.ToString();
            txtResultadoCuota.Text = valor4.ToString();
            txtTotal.Text = valor5.ToString();
        }
    }
}