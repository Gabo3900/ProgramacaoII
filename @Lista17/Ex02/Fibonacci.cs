using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Fibonacci : ISequencia
    {
        private int a;
        private int b;
        public void Iniciar() { a = 0; b = 1; }
        public int Proximo() {
            int aux = a;
            a = b;
            b = a + aux;
            return b;
        }
    }
}
