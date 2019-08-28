using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoApp
{
    class Historico
    {
        private string aluno;
        private Disciplina[] discs = new Disciplina[10];
        private int k;
        public Historico(string aluno) { this.aluno = aluno; }
        public void Inserir(Disciplina d) { discs[k++] = d; }
        public Disciplina[] Listar()
        {
            Disciplina[] d = new Disciplina[k];
            Array.Copy(discs, d, k);
            return d;
        }
        public double CalcularIRA()
        {
            int soma = 0;
            foreach (Disciplina d in Listar()) { soma += d.GetMedia(); }
            return soma / k;
        }
    }
}
