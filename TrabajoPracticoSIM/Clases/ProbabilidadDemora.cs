using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoSIM.Clases
{
    public class ProbabilidadDemora
    {
        public decimal probDemora0;
        public decimal probDemora1;
        public decimal probDemora2;
        public decimal probDemora3;
        public decimal probDemora4;
        public decimal probDemora5;
        

        public ProbabilidadDemora(decimal prob0, decimal prob1, decimal prob2, decimal prob3, decimal prob4, decimal prob5)
        {
            this.probDemora0 = prob0;
            this.probDemora1 = prob1;
            this.probDemora2 = prob2;
            this.probDemora3 = prob3;
            this.probDemora4 = prob4;
            this.probDemora5 = prob5;
            
        }

        public int GetDemora(decimal rnd)
        {
            return rnd < probDemora0 ? 0 : (rnd < probDemora1 ? 1 : (rnd < probDemora2 ? 2 : (rnd < probDemora3 ? 3 : (rnd < probDemora4 ? 4 :  5 ))));
        }
    }
}
