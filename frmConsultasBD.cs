using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmConsultasBD : Form
    {
        public frmConsultasBD()
        {
            InitializeComponent();
        }
        clsBaseDatos bd = new clsBaseDatos();
        private void frmConsultasBD_Load(object sender, EventArgs e)
        {
            bd.Listar(dgvBaseDatosConsulta);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtQuery.Text == string.Empty)
            {
                MessageBox.Show("Inserte una consulta");
            }
            else
            {
                string query = txtQuery.Text;
                bd.Listar(dgvBaseDatosConsulta, query);
            }
            
        }
    }
}
