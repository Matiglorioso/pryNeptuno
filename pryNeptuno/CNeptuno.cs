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
    internal class CNeptuno
    {
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



    }
}
