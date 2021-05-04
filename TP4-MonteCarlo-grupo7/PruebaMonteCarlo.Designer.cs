
namespace TP4_MonteCarlo_grupo7
{
    partial class PruebaMonteCarlo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PruebaMonteCarlo));
            this.txtCantSimulaciones = new System.Windows.Forms.TextBox();
            this.lblCantSimulaciones = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grdResultados2 = new System.Windows.Forms.DataGridView();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantSimulaciones
            // 
            this.txtCantSimulaciones.Location = new System.Drawing.Point(251, 119);
            this.txtCantSimulaciones.Name = "txtCantSimulaciones";
            this.txtCantSimulaciones.Size = new System.Drawing.Size(100, 23);
            this.txtCantSimulaciones.TabIndex = 0;
            // 
            // lblCantSimulaciones
            // 
            this.lblCantSimulaciones.AutoSize = true;
            this.lblCantSimulaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantSimulaciones.Location = new System.Drawing.Point(30, 119);
            this.lblCantSimulaciones.Name = "lblCantSimulaciones";
            this.lblCantSimulaciones.Size = new System.Drawing.Size(219, 21);
            this.lblCantSimulaciones.TabIndex = 1;
            this.lblCantSimulaciones.Text = "Cantidad de Simulaciones:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesde.Location = new System.Drawing.Point(186, 164);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(63, 21);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(251, 164);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 23);
            this.txtDesde.TabIndex = 3;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(452, 165);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 23);
            this.txtHasta.TabIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHasta.Location = new System.Drawing.Point(390, 164);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(60, 21);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntervalo.Location = new System.Drawing.Point(54, 168);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(81, 21);
            this.lblIntervalo.TabIndex = 6;
            this.lblIntervalo.Text = "Intervalo";
            // 
            // grdResultados
            // 
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados.Location = new System.Drawing.Point(22, 236);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.RowTemplate.Height = 25;
            this.grdResultados.Size = new System.Drawing.Size(1472, 108);
            this.grdResultados.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(587, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 29);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grdResultados2
            // 
            this.grdResultados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados2.Location = new System.Drawing.Point(22, 380);
            this.grdResultados2.Name = "grdResultados2";
            this.grdResultados2.RowTemplate.Height = 25;
            this.grdResultados2.Size = new System.Drawing.Size(1472, 357);
            this.grdResultados2.TabIndex = 9;
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTítulo.Location = new System.Drawing.Point(18, 25);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(439, 44);
            this.lblTítulo.TabIndex = 10;
            this.lblTítulo.Text = "Inventario de bicicletas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTítulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1674, 97);
            this.panel1.TabIndex = 12;
            // 
            // PruebaMonteCarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1604, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdResultados2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grdResultados);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblCantSimulaciones);
            this.Controls.Add(this.txtCantSimulaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PruebaMonteCarlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 MonteCarlo: Inventario de bicicletas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PruebaMonteCarlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantSimulaciones;
        private System.Windows.Forms.Label lblCantSimulaciones;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView grdResultados2;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

