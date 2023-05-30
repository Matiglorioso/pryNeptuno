using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using System.Windows.Input;

namespace pryNeptuno
{
    internal class CDatos
    {
        OleDbConnection CNN;
        OleDbCommand cmdClientes;
        OleDbDataReader DR;
        String TablaClientes = "Clientes";

        string Coneccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";
        public string RutaDeBaseDatos = "-";

        
        public void ConectarBase()
        {
            try
            {
                CNN = new OleDbConnection();
                CNN.ConnectionString = Coneccion;
                CNN.Open();
                //tabla equipos
                cmdClientes = new OleDbCommand();
                cmdClientes.Connection = CNN;
                cmdClientes.CommandType = CommandType.TableDirect;
                cmdClientes.CommandText = TablaClientes;
                DR = cmdClientes.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void CargarPaisCiudad(ComboBox ciudad, ComboBox pais)
        {
            ConectarBase();

            bool resultadoC = false;
            bool resultadoP = false;
                     
            while (DR.Read())
            {
                    for (int i = 0; i < ciudad.Items.Count; i++)
                    {
                        if (DR[5].ToString() == ciudad.Items[i].ToString())
                        {
                            resultadoC = true;
                        }
                    }
                    if (resultadoC == false)
                    {
                        ciudad.Items.Add(DR[5].ToString());
                    }
                    resultadoC = false;

                    for (int i = 0; i < pais.Items.Count; i++)
                    {
                        if (DR[8].ToString() == pais.Items[i].ToString())
                        {
                            resultadoP = true;
                        }
                    }
                    if (resultadoP == false)
                    {
                        pais.Items.Add(DR[8].ToString());
                    }
                    resultadoP = false;
            }
                cmdClientes.Connection.Close();         
            
        }

        public void FiltrarGrillaPais(ComboBox pais, DataGridView grilla)
        {
            ConectarBase();
            grilla.Rows.Clear();
            //ciudad.SelectedIndex = -1;
            while(DR.Read())
            {
                if (DR[8].ToString() == pais.Text)
                {
                    grilla.Rows.Add(DR["IdCliente"].ToString(), DR["NombreCompañía"].ToString(),
                    DR["NombreContacto"].ToString(), DR["CargoContacto"].ToString(), DR["Dirección"].ToString(),
                    DR["Ciudad"].ToString(), DR["Región"].ToString(), DR["País"].ToString(), DR["CódPostal"].ToString(),
                    DR["Teléfono"].ToString(), DR["Fax"].ToString());
                }
            }
        }
        public void FiltrarGrillaCiudad(ComboBox ciudad, DataGridView grilla)
        {
            ConectarBase();
            grilla.Rows.Clear();
            //ciudad.SelectedIndex = -1;
            while (DR.Read())
            {
                if (DR[5].ToString() == ciudad.Text)
                {
                    grilla.Rows.Add(DR["IdCliente"].ToString(), DR["NombreCompañía"].ToString(),
                    DR["NombreContacto"].ToString(), DR["CargoContacto"].ToString(), DR["Dirección"].ToString(),
                    DR["Ciudad"].ToString(), DR["Región"].ToString(), DR["País"].ToString(), DR["CódPostal"].ToString(),
                    DR["Teléfono"].ToString(), DR["Fax"].ToString());
                }
            }
        }
    }
}
