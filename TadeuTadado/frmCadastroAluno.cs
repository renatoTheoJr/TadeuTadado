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
using System.Globalization;

namespace TadeuTadado
{
    public partial class frmCadastroAluno : Form
    {
        private NpgsqlConnection cn;

        private string stringConexao = "Server= 127.0.0.1;" +
                                     "Port=5432;" +
                                    "Database=postgres;" +
                                    "User Id=postgres;" +
                                     "Password=postgres;";
        public frmCadastroAluno()
        {

            InitializeComponent();
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                List<object> param = new List<object>();            
                param.Add(txtNome.Text);
                param.Add(txtSobrenome.Text);
                param.Add(Convert.ToInt64(txtRA.Text));
                string sexo = "";
                if (radFem.Checked)
                    sexo = "F";
                else
                    sexo = "M";
                param.Add(sexo);
                param.Add(txtTelefone.Text);
                param.Add(txtLogin.Text);
                param.Add(txtSenha.Text);
                string sql;
                sql = "insert into aluno " +
                              "(nome,sobrenome,ra,sexo,celular,login,senha, excluido) " +
                              "values(@1, @2, @3, @4, @5, @6, @7, 'n')";
                Conexao.executar(sql, param);
                MessageBox.Show("Dados salvos com sucesso!", "Tadeu Tadado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaTela();
           

                btnLimpar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando!" + "\n\nMais detalhes: " +
                               ex.Message, "TadeuTadado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LimpaTela(bool limpaID = true)
        {
            if (limpaID)
            {

            }
            txtNome.Clear();
            txtSobrenome.Clear();
            txtRA.Clear();
            txtSenha.Clear();
            txtLogin.Clear();
            txtTelefone.Clear();





        }
        private void radOutro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTadeuTadado_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new NpgsqlConnection();
                cn.ConnectionString = stringConexao;
                cn.Open();

                btnLimpar.Enabled = true;
             
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar no Banco de Dados!" + "\n\nMais detalhes: " +
                                 ex.Message, "Tadeu Tadado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
