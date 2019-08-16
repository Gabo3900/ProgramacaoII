using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquacaoIIGrauApp
{
    class EquacaoIIGrau
    {
        private double a, b, c;
        public void SetABC(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a; b = this.b; c = this.c;
        }
        public bool RaizesReais()
        {
            return Delta() >= 0;
        }
        public double Delta()
        {
            return b * b - 4 * a * c;
        }
        public bool X1(out double x)
        {
            x = 0;
            if (RaizesReais() == false || a == 0) return false;
            x = (-b + Math.Sqrt(Delta())) / (2 * a);
            return true;
        }
        public bool X2(out double x)
        {
            x = 0;
            if (RaizesReais() == false || a == 0) return false;
            x = (-b - Math.Sqrt(Delta())) / (2 * a);
            return true;
        }
    }
}
