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
namespace TadeuTadado
{
    public partial class frmAreaUser : Form
    {
        int id_aluno;
        public frmAreaUser(int id_aluno)
        {
            this.id_aluno = id_aluno;
            InitializeComponent();
        }

        private void frmAreaUser_Load(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = 0;
            List<object> param = new List<object>();
            param.Add(id_aluno);
            string sql = "SELECT * FROM aluno WHERE id_aluno =@1";
            NpgsqlDataReader dr = Conexao.selecionar(sql,param);
            if (dr.Read())
            {
                txtNome.Text = dr["nome"].ToString();
                txtSobrenome.Text = dr["sobrenome"].ToString();
                txtTelefone.Text = dr["celular"].ToString();
                if (dr["sexo"].ToString().Equals("M"))
                    radMasc.Checked = true;
                else
                    radFem.Checked = true;
                txtLogin.Text = dr["login"].ToString();
                txtSenha.Text = dr["senha"].ToString();
                txtRA.Text = dr["RA"].ToString();

            }
            else
            {
                MessageBox.Show("Usuário ou senha errados!!",
                   "Tadeu Tadado CTI - Unesp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void frmAreaUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btnGerarTeste_Click(object sender, EventArgs e)
        {
            
            frmTeste form = new frmTeste(cmbMateria.SelectedIndex+1);
            form.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ask;
                ask = MessageBox.Show("Deseja excluir sua conta?", "Tadeu Tadado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    string sql;
                    List<object> param = new List<object>();
                    param.Add(txtNome.Text);
                    param.Add(txtSobrenome.Text);
                    param.Add(Convert.ToInt64(txtRA.Text));
                    sql = "update aluno set " +
                            "excluido = 's' ," +
                            "where ra = @3";

                    Conexao.executar(sql, param);
                    this.Close();
                    frmLogin apre = new frmLogin();
                    apre.Show();

                }
                else
                {
                    MessageBox.Show("Conta não excluida", "Tadeu Tadado",
            MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir conta!"
                    + "\n\nMais detalhes: " + ex.Message,
                              "Tadeu Tadado",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ask;
                ask = MessageBox.Show("Deseja mesmo alterar seus dados?", "Tadeu Tadado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    string sql;
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
                    sql = "update aluno set " +
                            "nome = @1 ," +
                            "sobrenome = @2 ," +
                            "celular = @4 ," +
                            "sexo = @5 ," +
                             "login = @6 ," +
                             "senha = @7 ," +
                            "where ra = @3";

                    Conexao.executar(sql, param);
                    this.Close();
                    frmAreaUser apre = new frmAreaUser(id_aluno);
                    apre.Show();

                }
                else
                {
                    MessageBox.Show("Dados não alterados ", "Tadeu Tadado",
            MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao alterar os dados!"
                    + "\n\nMais detalhes: " + ex.Message,
                              "Tadeu Tadado",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
