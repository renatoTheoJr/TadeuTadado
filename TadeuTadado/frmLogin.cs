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
    public partial class frmLogin : Form
    {
        private NpgsqlConnection cn;

        private string stringConexao = "Server= 127.0.0.1;" +
                                     "Port=5432;" +
                                    "Database=postgres;" +
                                    "User Id=postgres;" +
                                     "Password=postgres;";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new NpgsqlConnection();
                cn.ConnectionString = stringConexao;
                cn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar no Banco de Dados!" + "\n\nMais detalhes: " +
                                 ex.Message, "Tadeu Tadado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {   if (txtLogin.Text.Equals("admTadeuTadado") && txtSenha.Text.Equals("tadeutadado123"))
                {
                    this.Visible = false;
                    frmAreaAdmin form = new frmAreaAdmin();
                    form.Show();
                }
                else
                {

                    if (radAluno.Checked)
                    {


                        int id_aluno = 0;
                        List<object> param = new List<object>();
                        param.Add(txtLogin.Text);
                        param.Add(txtSenha.Text);
                        string sql = "SELECT * FROM aluno WHERE login =  @1 and senha = @2 and excluido = 'n'";
                        NpgsqlDataReader dr = Conexao.selecionar(sql,param);
                        if (dr.Read())
                        {
                            id_aluno = Convert.ToInt16(dr["id_aluno"]);
                            dr.Close();

                            frmAreaUser form = new frmAreaUser(id_aluno);
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha errados!!",
                               "Tadeu Tadado CTI - Unesp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dr.Close();
                        
                    }
                    else
                    {
                        int id_professor = 0;
                        List<object> param = new List<object>();
                        param.Add(txtLogin.Text);
                        param.Add(txtSenha.Text);
                        string sql = "select * from professor where login = @1 and senha = @2 and excluido = 'n'";
                        NpgsqlDataReader dr = Conexao.selecionar(sql, param);
                        if (dr.Read())
                        {
                            id_professor = Convert.ToInt16(dr["id_professor"]);
                            dr.Close();

                            frmAreaProfessor form = new frmAreaProfessor(id_professor);
                            form.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha errados!!",
                               "Tadeu Tadado CTI - Unesp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dr.Close();
                        

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando!" + "\n\nMais detalhes: " +
                                ex.Message, "Pet 72A", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
