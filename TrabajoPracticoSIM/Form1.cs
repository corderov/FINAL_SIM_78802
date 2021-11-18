using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoSIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void onCheck(object sender, EventArgs e)
        {
            puntoReposicion.Enabled = checkReposicion.Checked;

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

                    throw new ArgumentException("La suma de las probabilidades debe ser igual a 1");
                  
                }

                txtProbAcumDemora0.Text = probDemora0.ToString();
                txtProbAcumDemora1.Text = (probDemora0 + probDemora1).ToString();
                txtProbAcumDemora2.Text = (probDemora0 + probDemora1 + probDemora2).ToString();
                txtProbAcumDemora3.Text = (probDemora0 + probDemora1 + probDemora2 + probDemora3).ToString();
                txtProbAcumDemora4.Text = (probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4).ToString();
                txtProbAcumDemora5.Text = (probDemora0 + probDemora1 + probDemora2 + probDemora3 + probDemora4 + probDemora5).ToString();
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
