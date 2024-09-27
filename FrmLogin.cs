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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgenda frmAgenda= new FrmAgenda();
            frmAgenda.Show();
            Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
