using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TadeuTadado
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroAluno form = new frmCadastroAluno();
            form.Show();
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
           
           Application.Exit();
            
        }
    }
}
