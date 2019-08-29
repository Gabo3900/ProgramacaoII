using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVeiculoApp
{
    class Veiculo
    {
        private string placa;
        private string fabricante;
        private string modelo;
        private int ano;
        private decimal preco;
        private bool vendido;
        public Veiculo(string placa, string fabricante, string modelo, int ano, decimal preco)
        {
            this.placa = placa;
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.ano = ano;
            this.preco = preco;
        }
        public void Vender() { vendido = true; }
        public decimal GetPreco() { return preco; }
        public bool GetVendido() { return vendido; }
    }
}
