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

namespace Ex04
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuadroMedalhas quadro = new QuadroMedalhas();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = txtNome.Text;
            int o = int.Parse(txtOuro.Text);
            int p = int.Parse(txtPrata.Text);
            int b = int.Parse(txtBronze.Text);
            Pais pais = new Pais(n, o, p, b);
            quadro.Inserir(pais);
            listQuadro.ItemsSource = quadro.Listar();
        }
    }
}
