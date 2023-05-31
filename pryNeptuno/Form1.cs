using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryNeptuno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CDatos datos = new CDatos();
                   
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                datos.ConectarBase();
                MessageBox.Show("Conección exitosa");
                datos.CargarGrilla(dgvClientes, cmbPais, cmbCiudad);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            datos.CargarGrilla(dgvClientes, cmbPais, cmbCiudad);
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos.FiltrarCiudadesPorPais(cmbPais.Text.ToString(), cmbCiudad);
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
