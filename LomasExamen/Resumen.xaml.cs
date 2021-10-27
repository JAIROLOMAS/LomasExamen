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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string clave, string nombre, string Total)
        {
            InitializeComponent();

            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtTotal.Text = Total;

        }
    }
}