using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
