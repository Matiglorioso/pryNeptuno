using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data.Common;


namespace pryNeptuno
{
    internal class CConeccionBD
    {
        OleDbConnection conectarBd = new OleDbConnection();
        OleDbCommand comandoBd = new OleDbCommand();
        OleDbDataReader lectorBd;

        public string conectarBase(Button btnConectar, OpenFileDialog openFileDialog, ComboBox comboBoxTablas)
        {
            comboBoxTablas.Items.Clear();
            openFileDialog = new OpenFileDialog();
            string stringConn = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ArchivoElegido = openFileDialog.FileName;

                if (Path.GetExtension(ArchivoElegido) == ".accdb")
                {
                    stringConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ArchivoElegido;
                }
                else
                {
                    stringConn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + ArchivoElegido;
                }

                conectarBd.ConnectionString = stringConn;

                try
                {
                    conectarBd.Open();

                    DataTable tablas = conectarBd.GetSchema("Tables");

                    foreach (DataRow row in tablas.Rows)
                    {
                        if (row[3].ToString() == "TABLE")
                        {
                            comboBoxTablas.Items.Add(row[2]).ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            return stringConn;
        }

        public void cargarGrilla(ComboBox comboBoxTb, DataGridView dgvTb, string stringConn)
        {
            if (comboBoxTb.SelectedIndex != -1)
            {
                conectarBd = new OleDbConnection(stringConn);

                try
                {
                    comandoBd.Connection = conectarBd;
                    comandoBd.CommandText = comboBoxTb.Text;
                    comandoBd.CommandType = CommandType.TableDirect;
                    comandoBd.Connection.Open();

                    lectorBd = comandoBd.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(lectorBd);
                    dgvTb.DataSource = tabla;
                    comandoBd.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    throw;
                }

            }
        }
    }
}
    

