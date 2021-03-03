using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;
namespace TadeuTadado
{
    public partial class frmPerguntas : Form
    {
        int[] perg;
        int aux = 0;
        public frmPerguntas(int[] array)
        {
            this.perg = array;
            InitializeComponent();
        }

        private void frmPerguntas_Load(object sender, EventArgs e)
        {
            List<object> param1 = new List<object>();
            
        }
    }
}
