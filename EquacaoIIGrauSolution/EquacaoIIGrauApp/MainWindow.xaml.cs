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

namespace EquacaoIIGrauApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            EquacaoIIGrau eq = new EquacaoIIGrau();
            eq.SetABC(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text));
            txtD.Text = eq.Delta().ToString();
            double r, s;
            if (eq.X1(out r))
            {
                eq.X2(out s);
                txtX1.Text = r.ToString();
                txtX2.Text = s.ToString();
            }
            else
            {
                txtX1.Text = "Raiz complexa";
                txtX2.Text = "Raiz Complexa";
                MessageBox.Show("A equação não é do II grau ou não tem raízes reais");
            }
        }
    }
}
