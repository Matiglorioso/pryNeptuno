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
        string TablaClientes = "Clientes";

        string Coneccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";

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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarGrilla(DataGridView grilla, ComboBox pais, ComboBox ciudad)
        {
            try
            {
                ConectarBase();

                List<string> paises = new List<string>(); // Lista para almacenar los países

                while (DR.Read())
                {
                    string auxPais = DR["País"].ToString();

                    if (DR[5].ToString() == ciudad.Text)
                    {
                        grilla.Rows.Add(DR[0], DR[1], DR[2], DR[3], DR[4], DR[5], DR[6], DR[7], DR[8], DR[9], DR[10]);

                    }

                    if (!paises.Contains(auxPais)) // Verificar si el país ya se encuentra en la lista
                    {
                        paises.Add(auxPais); // Agregar el país a la lista
                        pais.Items.Add(auxPais); // Agregar el país al ComboBox de países
                    }
                }

                DR.Close(); // Cierra el DataReader después de utilizarlo
                CNN.Close(); // Cierra la conexión a la base de datos

                // Seleccionar el primer país en el ComboBox de países
                if (pais.Items.Count > 0)
                {
                    pais.SelectedIndex = 0;

                    // Filtrar las ciudades según el país seleccionado
                    FiltrarCiudadesPorPais(pais.Text, ciudad);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        ////public void FiltrarGrillaPais(ComboBox pais, DataGridView grilla)
        //{
        //    try
        //    {
        //        ConectarBase();
        //        grilla.Rows.Clear();
        //        //ciudad.SelectedIndex = -1;
        //        while (DR.Read())
        //        {
        //            if (DR[8].ToString() == pais.Text)
        //            {
        //                grilla.Rows.Add(DR["IdCliente"].ToString(), DR["NombreCompañía"].ToString(),
        //                    DR["NombreContacto"].ToString(), DR["CargoContacto"].ToString(), DR["Dirección"].ToString(),
        //                    DR["Ciudad"].ToString(), DR["Región"].ToString(), DR["País"].ToString(), DR["CódPostal"].ToString(),
        //                    DR["Teléfono"].ToString(), DR["Fax"].ToString());
        //            }
        //        }

        //        DR.Close(); // Cierra el DataReader después de utilizarlo
        //        CNN.Close(); // Cierra la conexión a la base de datos
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}
        public void FiltrarCiudadesPorPais(string nombrePais, ComboBox ciudad)
        {
            try
            {
                ciudad.Items.Clear(); // Limpiar el ComboBox de ciudades
                ConectarBase();

                while (DR.Read())
                {
                    string pais = DR["País"].ToString();
                    string ciudadActual = DR["Ciudad"].ToString();

                    if (pais == nombrePais && !ciudad.Items.Contains(ciudadActual))
                    {
                        ciudad.Items.Add(ciudadActual); // Agregar la ciudad al ComboBox de ciudades
                    }
                }

                DR.Close(); // Cierra el DataReader después de utilizarlo
                CNN.Close(); // Cierra la conexión a la base de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

    //    public void FiltrarGrillaCiudad(ComboBox ciudad, DataGridView grilla)
    //    {
    //        try
    //        {
    //            ConectarBase();
    //            grilla.Rows.Clear();
    //            //ciudad.SelectedIndex = -1;
    //            while (DR.Read())
    //            {
    //                if (DR[5].ToString() == ciudad.Text)
    //                {
    //                    grilla.Rows.Add(DR["IdCliente"].ToString(), DR["NombreCompañía"].ToString(),
    //                        DR["NombreContacto"].ToString(), DR["CargoContacto"].ToString(), DR["Dirección"].ToString(),
    //                        DR["Ciudad"].ToString(), DR["Región"].ToString(), DR["País"].ToString(), DR["CódPostal"].ToString(),
    //                        DR["Teléfono"].ToString(), DR["Fax"].ToString());
    //                }
    //            }

    //            DR.Close(); // Cierra el DataReader después de utilizarlo
    //            CNN.Close(); // Cierra la conexión a la base de datos
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error: " + ex.Message);
    //        }
    //    }
    //}


