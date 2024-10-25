using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EXAMEN_LGLA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void suma(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(Num1.Text);
            double numero2 = Convert.ToDouble(Num2.Text);
            double result = numero1 + numero2;
            Resultado.Text = $"Resultado: {result}";
        }

        public void resta (object sender, EventArgs e)
        {
            double numero1 =Convert.ToDouble(Num1.Text);
            double numero2 =Convert.ToDouble(Num2.Text);
            double result = numero1 - numero2;
            Resultado.Text= $"Resultado: {result}";
        }

        public void multiplicacion (object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(Num1.Text);
            double numero2 = Convert.ToDouble(Num2.Text);
            double result = numero1 * numero2;
            Resultado.Text = $"Resultado: {result}";
        }

        public void division (object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(Num1.Text);
            double numero2 = Convert.ToDouble(Num2.Text);
            if (numero1 != 0)
            {
                double result = numero1 / numero2;
                Resultado.Text = $"Resultado: {result}";
            }
            else
            {
                Resultado.Text = "Error se dividio entre cero";
            }
        }
    }
}
