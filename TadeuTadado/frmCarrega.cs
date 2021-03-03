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
    public partial class frmCarrega : Form
    {
        public frmCarrega()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCarrega.Value < 100)
            {
                pbCarrega.Value = pbCarrega.Value + 4;

            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmHome form = new frmHome();
                form.Show();
            }
        }

        private void frmCarrega_Load(object sender, EventArgs e)
        {

        }

        private void pbCarrega_Click(object sender, EventArgs e)
        {

        }
    }
}
