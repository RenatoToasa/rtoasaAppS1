using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rtoasaAppS1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSaludo_Clicked(object sender, EventArgs e)
        {
            //Almacenando en una variable, lo que el usuario ingresa en la caja de texto
            string texto = txtSaludo.Text; //hola d
            string mensaje = "Hola " + texto;
            //Alerta para el usuario con XAMARIN
            DisplayAlert("Mensaje de bienvenida", mensaje, "OK");

        }
    }
}
