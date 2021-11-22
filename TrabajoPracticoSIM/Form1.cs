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
            this.gridSimulacion.RowsDefaultCellStyle.BackColor = Color.White;
            this.gridSimulacion.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

        }

        private void onCheck(object sender, EventArgs e)
        {
            txtPuntoReposicion.Enabled = checkReposicion.Checked;

        }

        private void limpiarDemanda()
        {
            txtProbAcumDemanda0.Text = null;
            txtProbAcumDemanda1.Text = null;
            txtProbAcumDemanda2.Text = null;
            txtProbAcumDemanda3.Text = null;
            txtProbAcumDemanda4.Text = null;
            txtProbAcumDemanda5.Text = null;
            txtProbAcumDemanda6.Text = null;
        }

        private void OnClickAplicarDemanda(object sender, EventArgs e)
        {
            try
            {
                if (!Decimal.TryParse(txtProbDemanda0.Text, out decimal probDemanda0))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 0");
                }
                if (!Decimal.TryParse(txtProbDemanda1.Text, out decimal probDemanda1))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 1");
                }
                if (!Decimal.TryParse(txtProbDemanda2.Text, out decimal probDemanda2))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 2");
                }
                if (!Decimal.TryParse(txtProbDemanda3.Text, out decimal probDemanda3))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 3");
                }
                if (!Decimal.TryParse(txtProbDemanda4.Text, out decimal probDemanda4))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 4");
                }
                if (!Decimal.TryParse(txtProbDemanda5.Text, out decimal probDemanda5))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 5");
                }
                if (!Decimal.TryParse(txtProbDemanda6.Text, out decimal probDemanda6))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demanda 6");
                }

                if (probDemanda0 + probDemanda1 + probDemanda2 + probDemanda3 + probDemanda4 + probDemanda5 + probDemanda6 != 1)
                {
                    limpiarDemanda();
                    throw new ArgumentException("La suma de las probabilidades debe ser igual a 1");
                }

                decimal probAcumDemanda0 = probDemanda0;
                decimal probAcumDemanda1 = probAcumDemanda0 + probDemanda1;
                decimal probAcumDemanda2 = probAcumDemanda1 + probDemanda2;
                decimal probAcumDemanda3 = probAcumDemanda2 + probDemanda3;
                decimal probAcumDemanda4 = probAcumDemanda3 + probDemanda4;
                decimal probAcumDemanda5 = probAcumDemanda4 + probDemanda5;
                decimal probAcumDemanda6 = probAcumDemanda5 + probDemanda6;

                txtProbAcumDemanda0.Text = probAcumDemanda0.ToString();
                txtProbAcumDemanda1.Text = probAcumDemanda1.ToString();
                txtProbAcumDemanda2.Text = probAcumDemanda2.ToString();
                txtProbAcumDemanda3.Text = probAcumDemanda3.ToString();
                txtProbAcumDemanda4.Text = probAcumDemanda4.ToString();
                txtProbAcumDemanda5.Text = probAcumDemanda5.ToString();
                txtProbAcumDemanda6.Text = probAcumDemanda6.ToString();

                probDemanda = new ProbabilidadDemanda(probAcumDemanda0, probAcumDemanda1, probAcumDemanda2, probAcumDemanda3, probAcumDemanda4, probAcumDemanda5, probAcumDemanda6);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpiarDemora()
        {
            txtProbAcumDemora0.Text = null;
            txtProbAcumDemora1.Text = null;
            txtProbAcumDemora2.Text = null;
            txtProbAcumDemora3.Text = null;
            txtProbAcumDemora4.Text = null;
            txtProbAcumDemora5.Text = null;
        }

        private void OnClickAplicarDemora(object sender, EventArgs e)
        {
            try
            {
                if (!Decimal.TryParse(txtProbDemora0.Text, out decimal probDemora0))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 0");
                }
                if (!Decimal.TryParse(txtProbDemora1.Text, out decimal probDemora1))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 1");
                }
                if (!Decimal.TryParse(txtProbDemora2.Text, out decimal  probDemora2))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 2");
                }
                if (!Decimal.TryParse(txtProbDemora3.Text, out decimal probDemora3))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 3");
                }
                if (!Decimal.TryParse(txtProbDemora4.Text, out decimal probDemora4))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 4");
                }
                if (!Decimal.TryParse(txtProbDemora5.Text, out decimal probDemora5))
                {
                    throw new ArgumentException("Debe ingresar una probabilidad de demora 5");
                }

                if ((probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4 + probDemora5).CompareTo(1m) != 0)
                {
                    limpiarDemora();
                    throw new ArgumentException("La suma de las probabilidades debe ser igual a 1"); 
                }

                decimal probAcumDemora0 = probDemora0;
                decimal probAcumDemora1 = probAcumDemora0 + probDemora1;
                decimal probAcumDemora2 = probAcumDemora1 + probDemora2;
                decimal probAcumDemora3 = probAcumDemora2 + probDemora3;
                decimal probAcumDemora4 = probAcumDemora3 + probDemora4;
                decimal probAcumDemora5 = probAcumDemora4 + probDemora5;

                txtProbAcumDemora0.Text = probAcumDemora0.ToString();
                txtProbAcumDemora1.Text = probAcumDemora1.ToString();
                txtProbAcumDemora2.Text = probAcumDemora2.ToString();
                txtProbAcumDemora3.Text = probAcumDemora3.ToString();
                txtProbAcumDemora4.Text = probAcumDemora4.ToString();
                txtProbAcumDemora5.Text = probAcumDemora5.ToString();

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
                if (String.IsNullOrEmpty(txtProbAcumDemanda0.Text) || String.IsNullOrEmpty(txtProbAcumDemora0.Text)) 
                {
                    throw new ArgumentException("Debe ingresar las probabilidades de demora y demanda para generar la simulacion");
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

                Fila anterior = new Fila(inventarioInicial);
                Fila actual = null;

                if(diaDesde == 0)
                {
                    gridSimulacion.Rows.Add(anterior.agregarFila());
                }
                
                    for (int dia = 1; dia <= cantidadDiasaGenerar; dia++)
                    {

                        actual = new Fila()
                        {
                            dia = dia,
                            RNDDemanda = Math.Truncate(random.NextDouble() * 100) / 100,
                            demanda = 0,
                            RNDDemora = null,
                            demora = null,
                            orden = false,
                            llegadaPedido = anterior.llegadaPedido,
                            disponible = 0,
                            stock = anterior.stock,
                            costoPedido = 0,
                            costoAlmacenamiento = 0,
                            costoFaltante = 0,
                            costoTotal = 0,
                            costoAcum = 0,
                        };


                        actual.demanda = probDemanda.GetDemanda((decimal)actual.RNDDemanda);

                        
                        if (anterior.llegadaPedido <= actual.dia)
                        {
                            actual.disponible = lotePedido;
                            actual.llegadaPedido = null;
                        }

                        int faltante;

                        if (anterior.stock + actual.disponible - actual.demanda <= 0)
                        {
                            actual.stock = 0;
                            faltante = (int)-(anterior.stock + actual.disponible - actual.demanda);
                            actual.costoFaltante = faltante * costoFaltante;
                        }
                        else
                        {
                            actual.stock = (int)(anterior.stock + actual.disponible - actual.demanda);
                            actual.costoFaltante = 0;
                        }
                        if (checkReposicion.Checked)
                        {
                            if (actual.stock <= puntoReposicion && actual.llegadaPedido==null)
                        {
                            actual.RNDDemora = Math.Truncate(random.NextDouble() * 100) / 100;
                            actual.demora = probDemora.GetDemora((decimal)actual.RNDDemora);
                            actual.orden = true;
                            actual.llegadaPedido = actual.demora + dia;
                            actual.disponible = 0;
                            actual.costoPedido = costoPedido;

                            if (actual.demora == 0)
                            {
                                actual.disponible = lotePedido;
                            }
                        }

                        }
                        else
                        {
                            if (dia % 7 == 1)
                            {
                                actual.RNDDemora = Math.Truncate(random.NextDouble() * 100) / 100;
                                actual.demora = probDemora.GetDemora((decimal)actual.RNDDemora);
                                actual.orden = true;
                                actual.llegadaPedido = actual.demora + dia;
                                actual.disponible = 0;
                                actual.costoPedido = costoPedido;

                                if (actual.demora == 0)
                                {
                                    actual.disponible = lotePedido;
                                }
                            }
                        }
                        

                        actual.costoAlmacenamiento = actual.stock * costoAlmacenamiento;
                        actual.costoTotal = actual.costoPedido + actual.costoAlmacenamiento + actual.costoFaltante;

                        if (dia == 1)
                        {
                            actual.costoAcum = actual.costoTotal;
                        }
                        else
                        {
                            actual.costoAcum += anterior.costoAcum + actual.costoTotal;
                        }



                        if ((dia >= diaDesde && dia < diaHasta) || dia == cantidadDiasaGenerar)
                        {

                            gridSimulacion.Rows.Add(actual.agregarFila());


                        }
                        anterior = actual;
                    }
               
                

                this.gridSimulacion.Rows[this.gridSimulacion.Rows.Count-1].DefaultCellStyle.BackColor = Color.Gold;

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
