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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int a;
        private int b;
        private int ope;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, RoutedEventArgs e)
        {
            a= Convert.ToInt32(tbNumero1.GetLineText(0));
            b= Convert.ToInt32(tbNumero2.GetLineText(0));
            ope= 1;
            mathe(a, b, ope);
        }

        private void restar_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(tbNumero1.GetLineText(0));
            b = Convert.ToInt32(tbNumero2.GetLineText(0));
            ope = 2;
            mathe(a, b, ope);
        }

        private void multiplicar_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(tbNumero1.GetLineText(0));
            b = Convert.ToInt32(tbNumero2.GetLineText(0));
            ope = 3;
            mathe(a, b, ope);
        }

        private void dividir_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(tbNumero1.GetLineText(0));
            b = Convert.ToInt32(tbNumero2.GetLineText(0));
            ope = 4;
            mathe(a, b, ope);
        }

        private void mathe(int a, int b, int ope) 
        {
            float result= 0;
            switch (ope) 
            {
                case 1: result = a + b;
                    break;
                case 2: result = a - b;
                    break;
                case 3: result = a * b;
                    break;
                case 4: result = (float)a/b;
                    break;
            }// switch
            Res.Text = result.ToString();
        }//operacion

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }//mainwindow
}//calculadora