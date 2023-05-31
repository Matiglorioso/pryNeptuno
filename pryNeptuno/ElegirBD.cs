using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryNeptuno
{
    public partial class ElegirBD : Form
    {
        public ElegirBD()
        {
            InitializeComponent();
        }
        public string cnn;
        CConeccionBD coneccion = new CConeccionBD();
        private void ElegirBD_Load(object sender, EventArgs e)
        {
            cmbFiltrar.Items.Clear();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            cnn = coneccion.conectarBase(btnBaseDatos, openFileDialog1, cmbFiltrar);
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            coneccion.cargarGrilla(cmbFiltrar, dgvGrilla, cnn);
        }
    }
}
