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
    public partial class FrmAgregarContacto : Form
    {
        public FrmAgregarContacto()
        {
            InitializeComponent();
        }

        private void FrmAgregarContactocs_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmAgenda frmAgenda = new FrmAgenda();
            frmAgenda.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén completos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(cmbCategoria.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string correo = txtEmail.Text;
            string categoria = cmbCategoria.Text;

            // conectamos con base
            DbContactos dbContactos = new DbContactos();
            // usamos el metodo para agregar
            dbContactos.AgregarContacto(nombre, apellido, telefono, correo, categoria);

            // Limpiar los campos después de agregar
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbCategoria.SelectedIndex = -1;
        }
    }
}
