using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class PA
    {
        private int primeiroElemento;
        private int razao;
        public void Iniciar()
        {
            primeiroElemento = 0;
        }
        public int Proximo()
        {
            primeiroElemento += razao;
            return primeiroElemento;
        }
    }
}
