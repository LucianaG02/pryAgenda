using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgenda
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void buscarPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarCorreo frmBuscarCorreo = new FrmBuscarCorreo();
            frmBuscarCorreo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarContacto frmAgregarContacto = new FrmAgregarContacto();
            frmAgregarContacto.Show();
        }

        private void btnVerContactos_Click(object sender, EventArgs e)
        {
            DbContactos db = new DbContactos();
            DataTable dt = db.ObtenerContactos();
            if (dt.Rows.Count > 0)
            {
                dgvContactos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminar frmEliminar = new FrmEliminar();
            frmEliminar.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar frmModificar = new FrmModificar();
            frmModificar.Show();
        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarNombre frmBuscarNombre = new FrmBuscarNombre();
            frmBuscarNombre.Show();
        }

        private void buscarPorTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarTelefono frmBuscarTelefono = new FrmBuscarTelefono();
            frmBuscarTelefono.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
