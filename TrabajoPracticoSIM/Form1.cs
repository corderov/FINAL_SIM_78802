using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

      

                //Stopwatch watch = new Stopwatch();
                //watch.Start();
                //gridRosas.Rows.Clear();
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


                Fila anterior = null;
                Fila actual = null;

                for (int dia = 1; dia <= cantidadDiasaGenerar; dia++)
                {

                    actual = new Fila();
                    
                    if (dia == 1)
                    {
                        actual.costoAcum = actual.costoTotal;
                    }
                    else
                    {
                        actual.costoAcum += anterior.costoAcum + actual.costoTotal;
                    }
                    anterior = actual;

                    if ((dia >= diaDesde && dia < diaDesde + 100) || dia == cantidadDiasaGenerar)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        DataGridViewTextBoxCell colDia = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colRNDClima = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colClima = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colRNDDemanda = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colDemanda = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colCantVenta = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colCantSobrante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colCantFaltante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colIngresoDiario = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colIngresoSobrante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGastoCompra = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGastoFaltante = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGananciaDiariaNeta = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell colGananciaAcum = new DataGridViewTextBoxCell();

                        colDia.Value = dia;
                        colRNDClima.Value = actual.RNDClima;
                        colClima.Value = actual.GetClima();
                        colRNDDemanda.Value = actual.RNDDemanda;
                        colDemanda.Value = actual.demanda;
                        colCantVenta.Value = actual.cantVenta;
                        colCantSobrante.Value = actual.cantSobrante;
                        colCantFaltante.Value = actual.cantFaltante;
                        colIngresoDiario.Value = actual.ingresoDiario.ToString("F2") + " $";
                        colIngresoSobrante.Value = actual.ingresoSobrante.ToString("F2") + " $";
                        colGastoCompra.Value = actual.costoCompra.ToString("F2") + " $";
                        colGastoFaltante.Value = actual.costoFaltante.ToString("F2") + " $";
                        colGananciaDiariaNeta.Value = actual.gananciaDiariaNeta.ToString("F2") + " $";
                        colGananciaAcum.Value = actual.acumGanancia.ToString("F2") + " $";

                        fila.Cells.Add(colDia);
                        fila.Cells.Add(colRNDClima);
                        fila.Cells.Add(colClima);
                        fila.Cells.Add(colRNDDemanda);
                        fila.Cells.Add(colDemanda);
                        fila.Cells.Add(colCantVenta);
                        fila.Cells.Add(colCantSobrante);
                        fila.Cells.Add(colCantFaltante);
                        fila.Cells.Add(colIngresoDiario);
                        fila.Cells.Add(colIngresoSobrante);
                        fila.Cells.Add(colGastoCompra);
                        fila.Cells.Add(colGastoFaltante);
                        fila.Cells.Add(colGananciaDiariaNeta);
                        fila.Cells.Add(colGananciaAcum);

                        gridRosas.Rows.Add(fila);
                    }

                    if (chkDemandaDiaAnterior.Checked)
                    {
                        cantidadAComprar = actual.demanda;
                    }
                }

                this.gridRosas.Rows[this.gridRosas.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gold;

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
