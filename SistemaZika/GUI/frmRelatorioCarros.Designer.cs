namespace GUI
{
    partial class frmRelatorioCarros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gFiltros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gResultados = new System.Windows.Forms.GroupBox();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.gFiltros.SuspendLayout();
            this.gResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // gFiltros
            // 
            this.gFiltros.Controls.Add(this.btnBuscar);
            this.gFiltros.Controls.Add(this.txtCor);
            this.gFiltros.Controls.Add(this.txtModelo);
            this.gFiltros.Controls.Add(this.txtMarca);
            this.gFiltros.Controls.Add(this.label3);
            this.gFiltros.Controls.Add(this.label2);
            this.gFiltros.Controls.Add(this.label1);
            this.gFiltros.Location = new System.Drawing.Point(13, 13);
            this.gFiltros.Name = "gFiltros";
            this.gFiltros.Size = new System.Drawing.Size(472, 131);
            this.gFiltros.TabIndex = 1;
            this.gFiltros.TabStop = false;
            this.gFiltros.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(75, 19);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(170, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(265, 71);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(365, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gResultados
            // 
            this.gResultados.Controls.Add(this.dgvCarros);
            this.gResultados.Location = new System.Drawing.Point(13, 151);
            this.gResultados.Name = "gResultados";
            this.gResultados.Size = new System.Drawing.Size(472, 198);
            this.gResultados.TabIndex = 2;
            this.gResultados.TabStop = false;
            this.gResultados.Text = "Resultado";
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarros.Location = new System.Drawing.Point(3, 16);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(466, 179);
            this.dgvCarros.TabIndex = 1;
            // 
            // frmRelatorioCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 364);
            this.Controls.Add(this.gResultados);
            this.Controls.Add(this.gFiltros);
            this.Name = "frmRelatorioCarros";
            this.Text = "Relatório de Carros";
            this.Load += new System.EventHandler(this.frmRelatorioCarros_Load);
            this.gFiltros.ResumeLayout(false);
            this.gFiltros.PerformLayout();
            this.gResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gResultados;
        private System.Windows.Forms.DataGridView dgvCarros;
    }
}