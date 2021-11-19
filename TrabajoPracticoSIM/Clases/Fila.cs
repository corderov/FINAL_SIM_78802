using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoSIM.Clases;

namespace TrabajoPracticoSIM.Clases
{
    class Fila
    {
        public int dia { get; set; }
        public double RNDDemanda { get; }
        public int demanda { get; set; }
        public double RNDDemora { get; }
        public int demora { get; set; }
        public string orden { get; set; }
        public string stock { get; set; }
        public int costoPedido { get; set; }
        public int costoAlmacenamiento { get; set; }
        public int costoFaltante { get; set; }
        public int costoTotal { get; set; }
        public  int costoAcum { get; set; }

       

        public Fila(int dia, Random rnd, double costoPedido, double costoAlmacenamiento, double costoFaltante, int puntoReposicion, ProbabilidadDemanda probDemanda, ProbabilidadDemora probDemora)
        {
            this.dia = dia;
            this.RNDDemanda = Math.Truncate(rnd.NextDouble() * 100) / 100;
            this.demanda = probDemanda.GetDemanda(RNDDemanda);
            if(this.dia % 7 == 0 && puntoReposicion == 0)
            {
                this.RNDDemora = Math.Truncate(rnd.NextDouble() * 100) / 100;
                this.demora = probDemora.GetDemora(RNDDemora);
                this.orden = "Si";

            }


        }

    }
}
