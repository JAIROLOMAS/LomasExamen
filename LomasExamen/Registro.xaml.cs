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
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblClave.Text = clave;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double monto = 1800;

                //almacenar en variable, lo que el usuario ingresa en las cajas de texto
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);
                

                //operacion
                double suma = monto - valor1;
                         suma = suma / 3;
                
                valor2 = suma * 1.05;

                // visualizar resultado en pantalla
                txtResultado.Text = suma.ToString();
                txtResultadoCuota.Text= valor2.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "ok");
            }
        }
    }
}