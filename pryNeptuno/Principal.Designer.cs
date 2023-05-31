namespace pryNeptuno
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gprFiltrar = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nEPTUNODataSet = new pryNeptuno.NEPTUNODataSet();
            this.nEPTUNODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEPTUNODataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nEPTUNODataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new pryNeptuno.NEPTUNODataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gprFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Fax,
            this.Column10});
            this.dgvClientes.Location = new System.Drawing.Point(12, 161);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(694, 205);
            this.dgvClientes.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id del Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Compañía";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre del contacto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cargo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dirección";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ciudad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Reg";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cod. Postal";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Pais";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Telefono";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Fax";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(67, 57);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 3;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(67, 26);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 4;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(26, 29);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "Pais:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(13, 60);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(225, 40);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gprFiltrar
            // 
            this.gprFiltrar.Controls.Add(this.lblPais);
            this.gprFiltrar.Controls.Add(this.btnFiltrar);
            this.gprFiltrar.Controls.Add(this.cmbCiudad);
            this.gprFiltrar.Controls.Add(this.cmbPais);
            this.gprFiltrar.Controls.Add(this.lblCiudad);
            this.gprFiltrar.Location = new System.Drawing.Point(27, 22);
            this.gprFiltrar.Name = "gprFiltrar";
            this.gprFiltrar.Size = new System.Drawing.Size(347, 107);
            this.gprFiltrar.TabIndex = 9;
            this.gprFiltrar.TabStop = false;
            this.gprFiltrar.Text = "Filtrar por";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "opnNeptuno";
            // 
            // nEPTUNODataSet
            // 
            this.nEPTUNODataSet.DataSetName = "NEPTUNODataSet";
            this.nEPTUNODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nEPTUNODataSetBindingSource
            // 
            this.nEPTUNODataSetBindingSource.DataSource = this.nEPTUNODataSet;
            this.nEPTUNODataSetBindingSource.Position = 0;
            // 
            // nEPTUNODataSetBindingSource1
            // 
            this.nEPTUNODataSetBindingSource1.DataSource = this.nEPTUNODataSet;
            this.nEPTUNODataSetBindingSource1.Position = 0;
            // 
            // nEPTUNODataSetBindingSource2
            // 
            this.nEPTUNODataSetBindingSource2.DataSource = this.nEPTUNODataSet;
            this.nEPTUNODataSetBindingSource2.Position = 0;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.nEPTUNODataSetBindingSource;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 429);
            this.Controls.Add(this.gprFiltrar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Principal";
            this.Text = "Filtrar por pais y ciudad:";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gprFiltrar.ResumeLayout(false);
            this.gprFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gprFiltrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource nEPTUNODataSetBindingSource;
        private NEPTUNODataSet nEPTUNODataSet;
        private System.Windows.Forms.BindingSource nEPTUNODataSetBindingSource1;
        private System.Windows.Forms.BindingSource nEPTUNODataSetBindingSource2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private NEPTUNODataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

