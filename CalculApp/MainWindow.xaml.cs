using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Primero, Segundo, Resultado;
        string Operador;

        public MainWindow()
        {
            InitializeComponent();
        }


        ClsOps objOps = new ClsOps();

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Image_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void btn_cerrar_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_min_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnCero_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
            }
            else
            {
                pantallaLabel.Content += "0";
            }
        }

        private void botonUno_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                pantallaLabel.Content = "1";
            }
            else
            {
                pantallaLabel.Content += "1";
            }
        }

        private void botonDos_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                pantallaLabel.Content = "2";
            }
            else
            {
                pantallaLabel.Content += "2";
            }
        }

        private void botonTres_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                pantallaLabel.Content = "3";
            }
            else
            {
                pantallaLabel.Content += "3";
            }
        }

        private void botonCuatro_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                pantallaLabel.Content = "4";
            }
            else
            {
                pantallaLabel.Content += "4";
            }
        }

        private void botonCinco_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                pantallaLabel.Content = "5";
            }
            else
            {
                pantallaLabel.Content += "5";
            }
        }

        private void botonSeis_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                pantallaLabel.Content = "6";
            }
            else
            {
                pantallaLabel.Content += "6";
            }
        }

        private void botonSiete_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                pantallaLabel.Content = "7";
            }
            else
            {
                pantallaLabel.Content += "7";
            }
        }

        private void botonOcho_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                pantallaLabel.Content = "8";
            }
            else
            {
                pantallaLabel.Content += "8";
            }
        }

        private void botonSuma_Click(object sender, RoutedEventArgs e)
        {
            Operador = "+";
            Primero = double.Parse(pantallaLabel.Content.ToString());
            pantallaLabel.Content = "0";
            puntoBoton.IsEnabled = true;
        }

        private void botonResta_Click(object sender, RoutedEventArgs e)
        {
            Operador = "-";
            Primero = double.Parse(pantallaLabel.Content.ToString());
            pantallaLabel.Content = "0";
            puntoBoton.IsEnabled = true;
        }

        private void botonMultiplicacion_Click(object sender, RoutedEventArgs e)
        {
            Operador = "*";
            Primero = double.Parse(pantallaLabel.Content.ToString());
            pantallaLabel.Content = "0";
            puntoBoton.IsEnabled = true;
        }

        private void botonDivicion_Click(object sender, RoutedEventArgs e)
        {
            Operador = "/";
            Primero = double.Parse(pantallaLabel.Content.ToString());
            pantallaLabel.Content = "0";
            puntoBoton.IsEnabled = true;
        }

        private void botonIgual_Click(object sender, RoutedEventArgs e)
        {

            RealizaOps();

        }

        private void botonPorciento_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                
            }
            else
            {
                Operador = "%";
                Primero = double.Parse(pantallaLabel.Content.ToString());
                pantallaLabel.Content = "0";
                puntoBoton.IsEnabled = true;
            }
        }

        private void botonElevar_Click(object sender, RoutedEventArgs e)
        {
            Operador = "^";
            Primero = double.Parse(pantallaLabel.Content.ToString());
            puntoBoton.IsEnabled = true;
            RealizaOps();
        }

        private void botonNegativo_Click(object sender, RoutedEventArgs e)
        {
            Operador = "!";
            Primero = double.Parse(pantallaLabel.Content.ToString());
            puntoBoton.IsEnabled = true;
            RealizaOps();
        }

        private void botonNueve_Click(object sender, RoutedEventArgs e)
        {
            if (pantallaLabel.Content.ToString() == "0")
            {
                //MessageBox.Show("works!");
                pantallaLabel.Content = "9";
            }
            else
            {
                pantallaLabel.Content += "9";
            }
        }

        private void botonAc_Click(object sender, RoutedEventArgs e)
        {
            Primero = 0;
            Segundo = 0;
            Resultado = 0;
            Operador = "";
            pantallaLabel.Content = "0";
            puntoBoton.IsEnabled = true;
        }

        private void botonPunto_Click(object sender, RoutedEventArgs e)
        {


            pantallaLabel.Content += ".";
            puntoBoton.IsEnabled = false;
            
        }

        private void RealizaOps()
        {
            double sum, res, mul, div, elev, neg, porc, resu;

            Segundo = double.Parse(pantallaLabel.Content.ToString());

            switch (Operador)
            {
                case "+":
                    sum = objOps.Sumar((Primero), (Segundo));
                    resu = sum;
                    Resultado = resu;
                    pantallaLabel.Content = $"{Resultado}";
                    break;

                case "-":
                    res = objOps.Restar((Primero), (Segundo));
                    resu = res;
                    Resultado = resu;
                    pantallaLabel.Content = $"{Resultado}";
                    break;

                case "*":
                    mul = objOps.Multiplicar((Primero), (Segundo));
                    resu = mul;
                    Resultado = resu;
                    pantallaLabel.Content = $"{Resultado}";
                    break;

                case "/":
                    div = objOps.Dividir((Primero), (Segundo));
                    resu = div;
                    Resultado = resu;
                    pantallaLabel.Content = $"{Resultado}";
                    break;

                case "%":
                    porc = objOps.PorCiento((Primero), (Segundo));
                    resu = porc;
                    Resultado = resu;
                    pantallaLabel.Content = $"{Resultado}";
                    break;

                case "^":
                    elev = objOps.Elevar((Primero));
                    resu = elev;
                    Resultado = resu;
                    pantallaLabel.Content = $"{Resultado}";
                    break;

                case "!":
                    neg = objOps.Negativo((Primero));
                    resu = neg;
                    Resultado = resu;
                    pantallaLabel.Content = $"{Resultado}";
                    break;
            }
        }
    }
}
