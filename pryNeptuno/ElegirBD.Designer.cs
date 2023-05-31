namespace pryNeptuno
{
    partial class ElegirBD
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.lblElegirBase = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mrcBasedeDatos = new System.Windows.Forms.GroupBox();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.mrcBasedeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(33, 142);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(632, 207);
            this.dgvGrilla.TabIndex = 0;
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.Location = new System.Drawing.Point(132, 31);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(99, 27);
            this.btnBaseDatos.TabIndex = 1;
            this.btnBaseDatos.Text = "Base de datos";
            this.btnBaseDatos.UseVisualStyleBackColor = true;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // lblElegirBase
            // 
            this.lblElegirBase.AutoSize = true;
            this.lblElegirBase.Location = new System.Drawing.Point(20, 38);
            this.lblElegirBase.Name = "lblElegirBase";
            this.lblElegirBase.Size = new System.Drawing.Size(106, 13);
            this.lblElegirBase.TabIndex = 2;
            this.lblElegirBase.Text = "Elegir base de datos:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mrcBasedeDatos
            // 
            this.mrcBasedeDatos.Controls.Add(this.cmbFiltrar);
            this.mrcBasedeDatos.Controls.Add(this.label1);
            this.mrcBasedeDatos.Controls.Add(this.lblElegirBase);
            this.mrcBasedeDatos.Controls.Add(this.btnBaseDatos);
            this.mrcBasedeDatos.Location = new System.Drawing.Point(33, 30);
            this.mrcBasedeDatos.Name = "mrcBasedeDatos";
            this.mrcBasedeDatos.Size = new System.Drawing.Size(632, 84);
            this.mrcBasedeDatos.TabIndex = 3;
            this.mrcBasedeDatos.TabStop = false;
            this.mrcBasedeDatos.Text = "Elegir:";
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(329, 35);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrar.TabIndex = 4;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar:";
            // 
            // ElegirBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 361);
            this.Controls.Add(this.mrcBasedeDatos);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "ElegirBD";
            this.Text = "Elija su base de datos";
            this.Load += new System.EventHandler(this.ElegirBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.mrcBasedeDatos.ResumeLayout(false);
            this.mrcBasedeDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.Label lblElegirBase;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox mrcBasedeDatos;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Label label1;
    }
}