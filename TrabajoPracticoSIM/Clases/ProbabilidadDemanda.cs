using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoSIM.Clases
{
    public class ProbabilidadDemanda
    {
        public decimal probDemanda0;
        public decimal probDemanda1;
        public decimal probDemanda2;
        public decimal probDemanda3;
        public decimal probDemanda4;
        public decimal probDemanda5;
        public decimal probDemanda6;

        public ProbabilidadDemanda(decimal prob0, decimal prob1, decimal prob2, decimal prob3, decimal prob4, decimal prob5, decimal prob6)
        {
            this.probDemanda0 = prob0;
            this.probDemanda1 = prob1;
            this.probDemanda2 = prob2;
            this.probDemanda3 = prob3;
            this.probDemanda4 = prob4;
            this.probDemanda5 = prob5;
            this.probDemanda6 = prob6;
        }

        public int GetDemanda(decimal rnd)
        {
            int resultado = rnd < probDemanda0 ? 0 : (rnd < probDemanda1 ? 1 : (rnd < probDemanda2 ? 2 : (rnd < probDemanda3 ? 3 : (rnd < probDemanda4 ? 4 : (rnd < probDemanda5 ? 5 : 6)))));
            return resultado;
        }
    }
}
