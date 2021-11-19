using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoSIM.Clases
{
    public class ProbabilidadDemanda
    {
        public double probDemanda0;
        public double probDemanda1;
        public double probDemanda2;
        public double probDemanda3;
        public double probDemanda4;
        public double probDemanda5;
        public double probDemanda6;

        public ProbabilidadDemanda(double prob0, double prob1, double prob2, double prob3, double prob4, double prob5, double prob6)
        {
            this.probDemanda0 = prob0;
            this.probDemanda1 = prob1;
            this.probDemanda2 = prob2;
            this.probDemanda3 = prob3;
            this.probDemanda4 = prob4;
            this.probDemanda5 = prob5;
            this.probDemanda6 = prob6;
        }

        public int GetDemanda(double rnd)
        {
            int resultado = rnd < probDemanda0 ? 0 : (rnd < probDemanda1 ? 1 : (rnd < probDemanda2 ? 2 : (rnd < probDemanda3 ? 3 : (rnd < probDemanda4 ? 4 : (rnd < probDemanda5 ? 5 : 6)))));
            return resultado;
        }
    }
}
