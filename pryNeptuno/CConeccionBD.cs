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
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;

        public string ConectarBase(Button conectar, OpenFileDialog ofd, ComboBox cmb)
        {
            cmb.Items.Clear();
            ofd = new OpenFileDialog();
            string connstring = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string archivo = ofd.FileName;

                if (Path.GetExtension(archivo) == ".accdb")
                {
                    connstring = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + archivo;
                }
                else
                {
                    connstring = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + archivo;
                }   

                cnn.ConnectionString = connstring;

                try
                {
                    cnn.Open();

                    DataTable tablas = cnn.GetSchema("Tables");

                    foreach (DataRow row in tablas.Rows)
                    {
                        if (row[3].ToString() == "TABLE")
                        {
                            cmb.Items.Add(row[2]).ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            return connstring;
        }

        public void CargarGrilla(ComboBox cmb, DataGridView dgv, string connstring)
        {
            if (cmb.SelectedIndex != -1)
            {
                cnn = new OleDbConnection(connstring);

                try
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = cmb.Text;
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.Connection.Open();

                    dr = cmd.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(dr);
                    dgv.DataSource = tabla;
                    cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }
        }
    }
}
    

