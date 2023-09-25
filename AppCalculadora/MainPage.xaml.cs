using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private decimal numberone;
        private string operador;
        private bool SeleccionadorOperador;

        // JOSÉ QUENTA --> Aqui me quede ....
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            string number = lblResult.Text;
            if (number != "0")
            {
                number = number.Remove(number.Length - 1);
                if (string.IsNullOrEmpty(number))
                {
                    lblResult.Text = "0";
                }
                else
                {

                    lblResult.Text = number;
                }
            }
        }

        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void BtnPorcentaje_Clicked(object sender, EventArgs e)
        {
            try
            {
                string number = lblResult.Text;
                if (number != "0")
                {
                    decimal numeroDecimal = Convert.ToDecimal(number);
                    string result = (numeroDecimal / 100).ToString("0.##");
                    lblResult.Text = result;
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private void BtnDividir_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnMultiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnRestar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSumar_Clicked(object sender, EventArgs e)
        {

        }

        private void Digitar_Clicked(object sender, EventArgs e)
        {
            //lblResult.Text = "7";
            var button = sender as Button;

            if (lblResult.Text.Length < 10)
            {
                if (lblResult.Text == "0")
                {
                    lblResult.Text = button.Text;
                }
                else
                {
                    lblResult.Text += button.Text;
                }
            }

        }

        private void DigitarPunto_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (lblResult.Text.StartsWith("0") && lblResult.Text.Length == 1)
            {
                lblResult.Text = "0" + button.Text;
            }
            else
            {
                lblResult.Text = button.Text;
            }
        }
    }
}
