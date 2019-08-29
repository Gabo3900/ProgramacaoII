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

namespace HistoricoApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Historico historico;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAluno_Click(object sender, RoutedEventArgs e)
        {
            historico = new Historico(txtAluno.Text);
            btnInserir.IsEnabled = true;
            btnExcluir.IsEnabled = true;
            btnIRA.IsEnabled = true;
        }

        private void BtnInserir_Click(object sender, RoutedEventArgs e)
        {
            Disciplina d = new Disciplina(txtDisc.Text, txtSemestre.Text, int.Parse(txtMedia.Text), cekAprovado.IsChecked.Value);
            historico.Inserir(d);
            listDiscs.ItemsSource = historico.Listar();
        }

        private void BtnIRA_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(historico.CalcularIRA().ToString());
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(listDiscs.SelectedIndex.ToString());
        }
    }
}
