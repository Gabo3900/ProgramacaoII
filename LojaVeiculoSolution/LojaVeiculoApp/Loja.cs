using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVeiculoApp
{
    class Loja
    {
        private string nome;
        private Veiculo[] veiculos;
        private int k;
        public Loja(string nome)
        {
            this.nome = nome;
        }
        public void Inserir(Veiculo v)
        {
            veiculos[k++] = v;
        }
        public Veiculo[] Listar()
        {
            Veiculo[] v = new Veiculo[k];
            Array.Copy(veiculos, v, k);
            return v;
        }
        public Veiculo[] ListarValor(decimal precoMax)
        {
            Veiculo[] valor = new Veiculo[k];
            int t = 0;
            foreach(Veiculo v in Listar())
            {
                if (!v.GetVendido() && v.GetPreco() <= precoMax) { valor[t++] = v; }
            }
            Veiculo[] l = new Veiculo[t];
            Array.Copy(valor, l, t);
            return l;
        }
        public decimal Total()
        {
            decimal soma = 0;
            foreach(Veiculo v in Listar()) { if (!v.GetVendido()) soma += v.GetPreco(); }
            return soma;
        }
    }
}
