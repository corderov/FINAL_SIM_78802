using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoSIM.Clases
{
    public class ProbabilidadDemora
    {
        public double probDemora0;
        public double probDemora1;
        public double probDemora2;
        public double probDemora3;
        public double probDemora4;
        public double probDemora5;
        

        public ProbabilidadDemora(double prob0, double prob1, double prob2, double prob3, double prob4, double prob5)
        {
            this.probDemora0 = prob0;
            this.probDemora1 = prob1;
            this.probDemora2 = prob2;
            this.probDemora3 = prob3;
            this.probDemora4 = prob4;
            this.probDemora5 = prob5;
            
        }

        public int GetDemora(double rnd)
        {
            int resultado = rnd < probDemora0 ? 0 : (rnd < probDemora1 ? 1 : (rnd < probDemora2 ? 2 : (rnd < probDemora3 ? 3 : (rnd < probDemora4 ? 4 :  5 ))));
            return resultado;
        }
    }
}
