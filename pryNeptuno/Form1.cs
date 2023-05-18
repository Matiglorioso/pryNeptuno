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
                   
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                x.ConectarBase();
                cmbPais.DisplayMember = "País";
                cmbPais.ValueMember = "IdCliente";
                cmbPais.DataSource = x.GetPaises();

                x.Dispose();
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
    }
}
