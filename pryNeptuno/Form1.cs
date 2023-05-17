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

        OleDbConnection CNN;
        OleDbDataAdapter DAClientes;
        OleDbCommand cmdClientes;
        OleDbDataReader DR;
        DataSet DS = new DataSet();
        String TablaEquipos = "Clientes";
        public void ConectarBase()
        {
            try
            {
                CNN = new OleDbConnection();
                CNN.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";
                CNN.Open();
                //tabla equipos
                cmdClientes = new OleDbCommand();
                cmdClientes.Connection = CNN;
                cmdClientes.CommandType = CommandType.TableDirect;
                cmdClientes.CommandText = TablaEquipos;
                DAClientes = new OleDbDataAdapter(cmdClientes);
                DAClientes.Fill(DS, "Clientes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            public void Mostrar()
            {
            if (DS.Tables["Clientes"].Rows.Count > 0)
            {
                foreach (DataRow dr in DS.Tables["Clientes"].Rows)
                {
                    dgvClientes.DataSource = DS.Tables["Clientes"];
                }
            }
    }
        public void GetClientes()
        {
            cmbClientes.DisplayMember = "Clientes";
            cmbClientes.ValueMember = "IdCliente";
            cmbClientes.DataSource = DS.Tables["Id. de cliente"];
            cmbClientes.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                ConectarBase();
                Mostrar();
                GetClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
