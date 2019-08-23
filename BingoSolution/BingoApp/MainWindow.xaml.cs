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

namespace BingoApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bingo bingo;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txt != null) txt.Text = Slider.Value.ToString();
        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (double.TryParse(txt.Text, out value))
                Slider.Value = value;
            else
            {
                MessageBox.Show("O valor desse campo deve ser um número de 10 a 100");
                txt.Text = Slider.Value.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bingo = new Bingo();
            bingo.Iniciar(int.Parse(txt.Text));
            txtSorteado.Text = "";
            txtSorteados.Text = "";
            btnSortear.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x = bingo.Proximo();
            if (x == -1)
            {
                btnSortear.IsEnabled = false;
                txtSorteado.Text = "FIM!";
            }
            else
            {
                txtSorteado.Text = x.ToString();
                txtSorteados.Text = "";
                foreach (int i in bingo.Sorteados())
                {
                    txtSorteados.Text +=  i + " ";
                }
            }          
        }
    }
}
