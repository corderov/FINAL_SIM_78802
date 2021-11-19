using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoSIM.Clases;

namespace TrabajoPracticoSIM
{
    public partial class Form1 : Form
    {
        ProbabilidadDemanda probDemanda;
        ProbabilidadDemora probDemora;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void onCheck(object sender, EventArgs e)
        {
            txtPuntoReposicion.Enabled = checkReposicion.Checked;

        }

        private void OnClickAplicarDemanda(object sender, EventArgs e)
        {
            try
            {
                if (!Double.TryParse(txtProbDemanda0.Text, out double probDemanda0))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 0");
                }
                if (!Double.TryParse(txtProbDemanda1.Text, out double probDemanda1))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 1");
                }
                if (!Double.TryParse(txtProbDemanda2.Text, out double probDemanda2))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 2");
                }
                if (!Double.TryParse(txtProbDemanda3.Text, out double probDemanda3))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 3");
                }
                if (!Double.TryParse(txtProbDemanda4.Text, out double probDemanda4))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 4");
                }
                if (!Double.TryParse(txtProbDemanda5.Text, out double probDemanda5))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 5");
                }
                if (!Double.TryParse(txtProbDemanda6.Text, out double probDemanda6))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 6");
                }

                if (probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4 + probDemanda5 + probDemanda6 != 1)
                {
                    throw new ArgumentException("La suma de las probabilidades debe ser igual a 1");
                }

                txtProbAcumDemanda0.Text = probDemanda0.ToString();
                txtProbAcumDemanda1.Text = (probDemanda0 + probDemanda1).ToString();
                txtProbAcumDemanda2.Text = (probDemanda0 + probDemanda1 + probDemanda2).ToString();
                txtProbAcumDemanda3.Text = (probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3).ToString();
                txtProbAcumDemanda4.Text = (probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4).ToString();
                txtProbAcumDemanda5.Text = (probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4 + probDemanda5).ToString();
                txtProbAcumDemanda6.Text = (probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4 + probDemanda5 + probDemanda6).ToString();

                double probAcumDemanda0 = probDemanda0;
                double probAcumDemanda1 = probDemanda0 + probDemanda1;
                double probAcumDemanda2 = probDemanda0 + probDemanda1 + probDemanda2;
                double probAcumDemanda3 = probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3;
                double probAcumDemanda4 = probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4;
                double probAcumDemanda5 = probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4 + probDemanda5;
                double probAcumDemanda6 = probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4 + probDemanda5 + probDemanda6;

                probDemanda = new ProbabilidadDemanda(probAcumDemanda0, probAcumDemanda1, probAcumDemanda2, probAcumDemanda3, probAcumDemanda4, probAcumDemanda5, probAcumDemanda6);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OnClickAplicarDemora(object sender, EventArgs e)
        {
            try
            {
                if (!Double.TryParse(txtProbDemora0.Text, out double probDemora0))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 0");
                }
                if (!Double.TryParse(txtProbDemora1.Text, out double probDemora1))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 1");
                }
                if (!Double.TryParse(txtProbDemora2.Text, out double probDemora2))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 2");
                }
                if (!Double.TryParse(txtProbDemora3.Text, out double probDemora3))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 3");
                }
                if (!Double.TryParse(txtProbDemora4.Text, out double probDemora4))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 4");
                }
                if (!Double.TryParse(txtProbDemora5.Text, out double probDemora5))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 5");
                }
                
                

                if ((probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4 + probDemora5) != 1)
                {
                    Console.WriteLine("Sumatoria de probabilidades:" + probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4 + probDemora5);
                    Console.WriteLine("La sumatoria es distinto de 1? ->" + ((probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4 + probDemora5) != 1));
                    throw new ArgumentException("La suma de las probabilidades debe ser igual a 1");
                  
                }

                txtProbAcumDemora0.Text = probDemora0.ToString();
                txtProbAcumDemora1.Text = (probDemora0 + probDemora1).ToString();
                txtProbAcumDemora2.Text = (probDemora0 + probDemora1 + probDemora2).ToString();
                txtProbAcumDemora3.Text = (probDemora0 + probDemora1 + probDemora2 + probDemora3).ToString();
                txtProbAcumDemora4.Text = (probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4).ToString();
                txtProbAcumDemora5.Text = (probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4 + probDemora5).ToString();

                double probAcumDemora0 = probDemora0;
                double probAcumDemora1 = probDemora0 + probDemora1;
                double probAcumDemora2 = probDemora0 + probDemora1 + probDemora2;
                double probAcumDemora3 = probDemora0 + probDemora1 + probDemora2 + probDemora3;
                double probAcumDemora4 = probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4;
                double probAcumDemora5 = probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4 + probDemora5;


                probDemora = new ProbabilidadDemora(probAcumDemora0, probAcumDemora1, probAcumDemora2, probAcumDemora3, probAcumDemora4, probAcumDemora5);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnClickGenerar(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCantDias.Text))
                {
                    throw new ArgumentException("Debes ingresar la cantidad de días a generar");
                }
                if (String.IsNullOrEmpty(txtDiaDesde.Text))
                {
                    throw new ArgumentException("Debes ingresar el día desde a mostrar en la tabla");
                }

                if (String.IsNullOrEmpty(txtDiaHasta.Text))
                {
                    throw new ArgumentException("Debes ingresar el día hasta a mostrar en la tabla");
                }

                if (String.IsNullOrEmpty(txtLotePedido.Text))
                {
                    throw new ArgumentException("Debes ingresar la cantidad de lote de pedido");
                }
                if (String.IsNullOrEmpty(txtPuntoReposicion.Text) && checkReposicion.Checked)
                {
                    throw new ArgumentException("Debe ingresar el punto de reposicion");
                }
                if (String.IsNullOrEmpty(txtInventarioInicial.Text))
                {
                    throw new ArgumentException("Debes ingresar el inventario inicial");
                }
                if (String.IsNullOrEmpty(txtCostoPedido.Text))
                {
                    throw new ArgumentException("Debes ingresar el costo de pedido (Ko)");
                }
                if (String.IsNullOrEmpty(txtCostoMantenimiento.Text))
                {
                    throw new ArgumentException("Debes ingresar el costo de almacenamiento (Km)");
                }
                if (String.IsNullOrEmpty(txtCostoFaltante.Text))
                {
                    throw new ArgumentException("Debes ingresar el costo de faltante (Ks)");
                }
            



                Stopwatch watch = new Stopwatch();
                watch.Start();
                gridSimulacion.Rows.Clear();
                Random random = new Random();

                int.TryParse(txtCantDias.Text, out int cantidadDiasaGenerar);
                int.TryParse(txtDiaDesde.Text, out int diaDesde);
                int.TryParse(txtDiaHasta.Text, out int diaHasta);
                int.TryParse(txtLotePedido.Text, out int lotePedido);
                int.TryParse(txtPuntoReposicion.Text, out int puntoReposicion);
                int.TryParse(txtInventarioInicial.Text, out int inventarioInicial);
                double.TryParse(txtCostoPedido.Text, out double costoPedido);
                double.TryParse(txtCostoMantenimiento.Text, out double costoAlmacenamiento);
                double.TryParse(txtCostoFaltante.Text, out double costoFaltante);

                if (diaHasta - diaDesde > 500)
                {
                    throw new ArgumentException("La diferencia entre el dia desde y hasta debe ser menor igual a 500.");
                }

                Fila anterior = null;
                Fila actual = null;

                for (int dia = 1; dia <= cantidadDiasaGenerar; dia++)
                {

                    //actual = new Fila();

                    if (dia == 1)
                    {
                        actual.costoAcum = actual.costoTotal;
                    }
                    else
                    {
                        actual.costoAcum += anterior.costoAcum + actual.costoTotal;
                    }
                    anterior = actual;

                    if ((dia >= diaDesde && dia < diaHasta) || dia == cantidadDiasaGenerar)
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

                        colDia.Value = dia;
                        colRNDDemanda.Value = actual.RNDDemanda;
                        colDemanda.Value = actual.demanda;
                        colRNDDemora.Value = actual.RNDDemora;
                        colDemora.Value = actual.demora;
                        colOrden.Value = actual.orden;
                        colLlegadaPedido.Value = actual.llegadaPedido;
                        colDisponible.Value = actual.disponible;
                        colStock.Value = actual.stock;
                        colCostoPedido.Value = actual.costoPedido.ToString("F2") + " $";
                        colCostoAlmacenamiento.Value = actual.costoAlmacenamiento.ToString("F2") + " $";
                        colCostoFaltante.Value = actual.costoFaltante.ToString("F2") + " $";
                        colCostoTotal.Value = actual.costoTotal.ToString("F2") + " $";
                        colCostoAcum.Value = actual.costoAcum.ToString("F2") + " $";

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

                        gridSimulacion.Rows.Add(fila);
                    }
                }

                this.gridSimulacion.Rows[this.gridSimulacion.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gold;

                watch.Stop();
                lblTimer.Text = String.Format("Tiempo en generar: {0:00}:{1:00}:{2:00}.{3:00}",
                    watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds,
                    watch.Elapsed.Milliseconds / 10);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
