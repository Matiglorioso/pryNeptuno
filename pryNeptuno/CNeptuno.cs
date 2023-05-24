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
        String TablaClientes = "Clientes";

        string Coneccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =";
        public string RutaDeBaseDatos = "-";
        public void ConectarBase(string rutarchivo)
        {
            try
            {
                CNN = new OleDbConnection();
                CNN.ConnectionString = Coneccion + rutarchivo;
                CNN.Open();
                //tabla equipos
                cmdClientes = new OleDbCommand();
                cmdClientes.Connection = CNN;
                cmdClientes.CommandType = CommandType.TableDirect;
                cmdClientes.CommandText = TablaClientes;
                DAClientes = new OleDbDataAdapter(cmdClientes);
                DAClientes.Fill(DS, "Clientes");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Mostrar(DataGridView dgv)
        {
            if (DS.Tables["Clientes"].Rows.Count > 0)
            {
                foreach(DataRow dr in DS.Tables["Clientes"].Rows)
                {
                    dgv.Rows.Add(dr["IdCliente"].ToString(), dr["NombreCompañía"].ToString(),
                        dr["NombreContacto"].ToString(), dr["CargoContacto"].ToString(), dr["Dirección"].ToString(),
                        dr["Ciudad"].ToString(), dr["Región"].ToString(), dr["País"].ToString(), dr["CódPostal"].ToString(),
                        dr["Teléfono"].ToString(), dr["Fax"].ToString());
                }
            }
            CNN.Close();
        }
        public DataTable GetPaises()
        {
            if (DS != null && DS.Tables.Count == 1)
            {
                return DS.Tables["Clientes"];
            }
            return null;
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
    
}
