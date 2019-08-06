using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViagemApp
{
    class Viagem
    {
        private double distancia;
        private double tempo;
        public void SetDistancia(double d)
        {
            distancia = d;
        }
        public void SetTempo(double t)
        {
            tempo = t;
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public double GetTempo()
        {
            return tempo;
        }
        public double CalcVelocidade()
        {
            return distancia / tempo;
        }
    }
}
