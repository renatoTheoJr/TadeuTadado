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
    public partial class frmAreaProfessor : Form
    {
        int id_professor;
        public frmAreaProfessor(int id_professor)
        {
            this.id_professor = id_professor;
            InitializeComponent();
        }

        private void frmAreaProfessor_Load(object sender, EventArgs e)
        {
            try
            {
                List<object> param = new List<object>();
                param.Add(id_professor);
                string sql = "select * from professor where id_professor = @1";
                NpgsqlDataReader dr = Conexao.selecionar(sql, param);
                if(dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtSobrenome.Text = dr["sobrenome"].ToString();
                    txtCpf.Text = dr["Cpf"].ToString();
                    txtTelefone.Text = dr["celular"].ToString();
                    txtLogin.Text = dr["login"].ToString();
                    txtSenha.Text = dr["senha"].ToString();
                    if (dr["sexo"].ToString().Equals("M"))
                        radMasc.Checked = true;
                    else
                        radFem.Checked = true;
                    cmbMateria.SelectedIndex = Convert.ToInt16(dr["id_materia"]) - 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando!" + "\n\nMais detalhes: " +
                             ex.Message, "TadeuTadado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAreaProfessor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
