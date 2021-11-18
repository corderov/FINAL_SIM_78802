
namespace TrabajoPracticoSIM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lotePedido = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkReposicion = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.puntoReposicion = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.costoPedido = new System.Windows.Forms.MaskedTextBox();
            this.costoMantenimiento = new System.Windows.Forms.MaskedTextBox();
            this.costoFaltante = new System.Windows.Forms.MaskedTextBox();
            this.Simulacion = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblDesdeDias = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cantDias = new System.Windows.Forms.MaskedTextBox();
            this.diaDesde = new System.Windows.Forms.MaskedTextBox();
            this.diaHasta = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Simulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ejercicio Nro 20";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.puntoReposicion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkReposicion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lotePedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 139);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1) Condiciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lote de Pedido";
            // 
            // lotePedido
            // 
            this.lotePedido.Location = new System.Drawing.Point(124, 28);
            this.lotePedido.Mask = "99999";
            this.lotePedido.Name = "lotePedido";
            this.lotePedido.Size = new System.Drawing.Size(100, 20);
            this.lotePedido.TabIndex = 1;
            this.lotePedido.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Con Punto de Reposicion";
            // 
            // checkReposicion
            // 
            this.checkReposicion.AutoSize = true;
            this.checkReposicion.Location = new System.Drawing.Point(158, 65);
            this.checkReposicion.Name = "checkReposicion";
            this.checkReposicion.Size = new System.Drawing.Size(15, 14);
            this.checkReposicion.TabIndex = 3;
            this.checkReposicion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Punto de Reposicion";
            // 
            // puntoReposicion
            // 
            this.puntoReposicion.Location = new System.Drawing.Point(145, 97);
            this.puntoReposicion.Mask = "99999";
            this.puntoReposicion.Name = "puntoReposicion";
            this.puntoReposicion.Size = new System.Drawing.Size(100, 20);
            this.puntoReposicion.TabIndex = 5;
            this.puntoReposicion.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.costoFaltante);
            this.groupBox2.Controls.Add(this.costoMantenimiento);
            this.groupBox2.Controls.Add(this.costoPedido);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(405, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 139);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2) Costos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Costo de pedido (Ko)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Costo de mantenimiento (Km)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Costo de faltante (Ks)";
            // 
            // costoPedido
            // 
            this.costoPedido.Location = new System.Drawing.Point(151, 28);
            this.costoPedido.Mask = "99999";
            this.costoPedido.Name = "costoPedido";
            this.costoPedido.Size = new System.Drawing.Size(100, 20);
            this.costoPedido.TabIndex = 4;
            this.costoPedido.ValidatingType = typeof(int);
            // 
            // costoMantenimiento
            // 
            this.costoMantenimiento.Location = new System.Drawing.Point(178, 62);
            this.costoMantenimiento.Mask = "99999";
            this.costoMantenimiento.Name = "costoMantenimiento";
            this.costoMantenimiento.Size = new System.Drawing.Size(100, 20);
            this.costoMantenimiento.TabIndex = 5;
            this.costoMantenimiento.ValidatingType = typeof(int);
            // 
            // costoFaltante
            // 
            this.costoFaltante.Location = new System.Drawing.Point(151, 93);
            this.costoFaltante.Mask = "99999";
            this.costoFaltante.Name = "costoFaltante";
            this.costoFaltante.Size = new System.Drawing.Size(100, 20);
            this.costoFaltante.TabIndex = 6;
            this.costoFaltante.ValidatingType = typeof(int);
            // 
            // Simulacion
            // 
            this.Simulacion.Controls.Add(this.diaHasta);
            this.Simulacion.Controls.Add(this.diaDesde);
            this.Simulacion.Controls.Add(this.cantDias);
            this.Simulacion.Controls.Add(this.label9);
            this.Simulacion.Controls.Add(this.lblTimer);
            this.Simulacion.Controls.Add(this.label8);
            this.Simulacion.Controls.Add(this.btnGenerar);
            this.Simulacion.Controls.Add(this.lblDesdeDias);
            this.Simulacion.Location = new System.Drawing.Point(801, 71);
            this.Simulacion.Name = "Simulacion";
            this.Simulacion.Size = new System.Drawing.Size(494, 139);
            this.Simulacion.TabIndex = 20;
            this.Simulacion.TabStop = false;
            this.Simulacion.Text = "3) Simulacion";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(287, 66);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(99, 13);
            this.lblTimer.TabIndex = 20;
            this.lblTimer.Text = "Tiempo en generar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad dias a generar: ";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(290, 90);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(198, 40);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // lblDesdeDias
            // 
            this.lblDesdeDias.AutoSize = true;
            this.lblDesdeDias.Location = new System.Drawing.Point(19, 57);
            this.lblDesdeDias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesdeDias.Name = "lblDesdeDias";
            this.lblDesdeDias.Size = new System.Drawing.Size(94, 13);
            this.lblDesdeDias.TabIndex = 18;
            this.lblDesdeDias.Text = "Ingrese dia desde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ingrese dia hasta:";
            // 
            // cantDias
            // 
            this.cantDias.Location = new System.Drawing.Point(149, 25);
            this.cantDias.Mask = "99999";
            this.cantDias.Name = "cantDias";
            this.cantDias.Size = new System.Drawing.Size(100, 20);
            this.cantDias.TabIndex = 23;
            this.cantDias.ValidatingType = typeof(int);
            // 
            // diaDesde
            // 
            this.diaDesde.Location = new System.Drawing.Point(115, 54);
            this.diaDesde.Mask = "99999";
            this.diaDesde.Name = "diaDesde";
            this.diaDesde.Size = new System.Drawing.Size(100, 20);
            this.diaDesde.TabIndex = 24;
            this.diaDesde.ValidatingType = typeof(int);
            // 
            // diaHasta
            // 
            this.diaHasta.Location = new System.Drawing.Point(115, 90);
            this.diaHasta.Mask = "99999";
            this.diaHasta.Name = "diaHasta";
            this.diaHasta.Size = new System.Drawing.Size(100, 20);
            this.diaHasta.TabIndex = 25;
            this.diaHasta.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.rndDemanda,
            this.demanda,
            this.rndDemora,
            this.demora,
            this.orden,
            this.llegadaPedido,
            this.disponible,
            this.stock,
            this.ko,
            this.ks,
            this.km,
            this.costoTotal,
            this.costoAcum});
            this.dataGridView1.Location = new System.Drawing.Point(29, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1439, 463);
            this.dataGridView1.TabIndex = 21;
            // 
            // reloj
            // 
            this.reloj.Frozen = true;
            this.reloj.HeaderText = "Reloj (dias)";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            // 
            // rndDemanda
            // 
            this.rndDemanda.Frozen = true;
            this.rndDemanda.HeaderText = "RND Demanda";
            this.rndDemanda.Name = "rndDemanda";
            this.rndDemanda.ReadOnly = true;
            // 
            // demanda
            // 
            this.demanda.Frozen = true;
            this.demanda.HeaderText = "Demanda";
            this.demanda.Name = "demanda";
            this.demanda.ReadOnly = true;
            // 
            // rndDemora
            // 
            this.rndDemora.Frozen = true;
            this.rndDemora.HeaderText = "RND Demora";
            this.rndDemora.Name = "rndDemora";
            this.rndDemora.ReadOnly = true;
            // 
            // demora
            // 
            this.demora.Frozen = true;
            this.demora.HeaderText = "Demora";
            this.demora.Name = "demora";
            this.demora.ReadOnly = true;
            // 
            // orden
            // 
            this.orden.Frozen = true;
            this.orden.HeaderText = "Orden";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            // 
            // llegadaPedido
            // 
            this.llegadaPedido.Frozen = true;
            this.llegadaPedido.HeaderText = "Llegada Pedido";
            this.llegadaPedido.Name = "llegadaPedido";
            this.llegadaPedido.ReadOnly = true;
            // 
            // disponible
            // 
            this.disponible.Frozen = true;
            this.disponible.HeaderText = "Disponiible";
            this.disponible.Name = "disponible";
            this.disponible.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.Frozen = true;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // ko
            // 
            this.ko.Frozen = true;
            this.ko.HeaderText = "Ko";
            this.ko.Name = "ko";
            this.ko.ReadOnly = true;
            // 
            // ks
            // 
            this.ks.Frozen = true;
            this.ks.HeaderText = "Ks";
            this.ks.Name = "ks";
            this.ks.ReadOnly = true;
            // 
            // km
            // 
            this.km.Frozen = true;
            this.km.HeaderText = "Km";
            this.km.Name = "km";
            this.km.ReadOnly = true;
            // 
            // costoTotal
            // 
            this.costoTotal.Frozen = true;
            this.costoTotal.HeaderText = "Costo Total";
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.ReadOnly = true;
            // 
            // costoAcum
            // 
            this.costoAcum.Frozen = true;
            this.costoAcum.HeaderText = "Costo Acum";
            this.costoAcum.Name = "costoAcum";
            this.costoAcum.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1011);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Simulacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP-Simulacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Simulacion.ResumeLayout(false);
            this.Simulacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox puntoReposicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkReposicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox lotePedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox costoFaltante;
        private System.Windows.Forms.MaskedTextBox costoMantenimiento;
        private System.Windows.Forms.MaskedTextBox costoPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Simulacion;
        private System.Windows.Forms.MaskedTextBox diaHasta;
        private System.Windows.Forms.MaskedTextBox diaDesde;
        private System.Windows.Forms.MaskedTextBox cantDias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblDesdeDias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDemora;
        private System.Windows.Forms.DataGridViewTextBoxColumn demora;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegadaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ks;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoAcum;
    }
}

