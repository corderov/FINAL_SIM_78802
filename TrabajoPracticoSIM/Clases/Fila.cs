using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoSIM.Clases;
using System.Windows.Forms;

namespace TrabajoPracticoSIM.Clases
{
    class Fila
    {
        public int dia { get; set; }
        public Nullable<double> RNDDemanda { get; set; }
        public Nullable<int> demanda { get; set; }
        public Nullable<double> RNDDemora { get; set; }
        public Nullable<int> demora { get; set; }
        public Nullable<bool> orden { get; set; }
        public Nullable<int> llegadaPedido { get; set; }
        public Nullable<int> disponible { get; set; }
        public int stock { get; set; }
        public double costoPedido { get; set; }
        public double costoAlmacenamiento { get; set; }
        public double costoFaltante { get; set; }
        public double costoTotal { get; set; }
        public  double costoAcum { get; set; }

       

    public Fila(int dia, double rndDemanda, int demanda, double rndDemora, int demora, bool orden, int llegada, int disponible, int stock, double costoPedido, double costoAlmacenamiento, double costoFaltante, double costoTotal, double acumCostoTotal)
        {
            this.dia = dia;
            this.RNDDemanda = rndDemanda;
            this.demanda = demanda;
            this.RNDDemora = rndDemora;
            this.demora = demora;
            this.orden = orden;
            this.llegadaPedido = llegada;
            this.disponible = disponible;
            this.stock = stock;
            this.costoPedido = costoPedido;
            this.costoAlmacenamiento = costoAlmacenamiento;
            this.costoFaltante = costoFaltante;
            this.costoTotal = costoTotal;
            this.costoAcum = acumCostoTotal;
            


        }

        public Fila (int inventarioInicial)
        {
            this.dia = 0;
            this.RNDDemanda = null;
            this.demanda = null;
            this.RNDDemora = null;
            this.demora = null;
            this.orden = null;
            this.llegadaPedido = null;
            this.disponible = null;
            this.stock = inventarioInicial ;
            this.costoPedido = 0;
            this.costoAlmacenamiento = 0;
            this.costoFaltante = 0;
            this.costoTotal = 0;
            this.costoAcum = 0;
        }
        
        public Fila()
        {

        }

        public DataGridViewRow agregarFila()
        {
            DataGridViewRow fila = new DataGridViewRow();
            DataGridViewTextBoxCell colDia = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colRNDDemanda = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colDemanda = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colRNDDemora = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colDemora = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colOrden = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colLlegadaPedido = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colDisponible = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colStock = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colCostoPedido = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colCostoAlmacenamiento = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colCostoFaltante = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colCostoTotal = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell colCostoAcum = new DataGridViewTextBoxCell();

            colDia.Value = this.dia;
            colRNDDemanda.Value = this.RNDDemanda;
            colDemanda.Value = this.demanda;
            colRNDDemora.Value = this.RNDDemora;
            colDemora.Value = this.demora;
            colOrden.Value = this.orden == true ? "Si" : "No" ;
            colLlegadaPedido.Value = this.llegadaPedido;
            colDisponible.Value = this.disponible;
            colStock.Value = this.stock;
            colCostoPedido.Value = this.costoPedido.ToString("F2") + " $";
            colCostoAlmacenamiento.Value = this.costoAlmacenamiento.ToString("F2") + " $";
            colCostoFaltante.Value = this.costoFaltante.ToString("F2") + " $";
            colCostoTotal.Value = this.costoTotal.ToString("F2") + " $";
            colCostoAcum.Value = this.costoAcum.ToString("F2") + " $";

            fila.Cells.Add(colDia);
            fila.Cells.Add(colRNDDemanda);
            fila.Cells.Add(colDemanda);
            fila.Cells.Add(colRNDDemora);
            fila.Cells.Add(colDemora);
            fila.Cells.Add(colOrden);
            fila.Cells.Add(colLlegadaPedido);
            fila.Cells.Add(colDisponible);
            fila.Cells.Add(colStock);
            fila.Cells.Add(colCostoPedido);
            fila.Cells.Add(colCostoAlmacenamiento);
            fila.Cells.Add(colCostoFaltante);
            fila.Cells.Add(colCostoTotal);
            fila.Cells.Add(colCostoAcum);


            return fila;
        }
    }
}
