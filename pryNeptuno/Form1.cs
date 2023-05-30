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
        CNeptuno x = new CNeptuno();
        CDatos datos = new CDatos();
                   
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                datos.ConectarBase();
                MessageBox.Show("Conección exitosa");
                datos.CargarPaisCiudad(cmbCiudad, cmbPais);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            x.Mostrar(dgvClientes);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();

            if (cmbCiudad.Text.Length > 0 && cmbPais.Text.Length > 0)
            {
                datos.FiltrarGrillaPais(cmbPais, dgvClientes);
                datos.FiltrarGrillaCiudad(cmbCiudad, dgvClientes);
            }
            else
            {
                MessageBox.Show("No puede dejar sin seleccionar");
            }
        }
    }
}
