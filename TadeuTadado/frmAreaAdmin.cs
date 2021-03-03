using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TadeuTadado
{
    public partial class frmAreaAdmin : Form
    {
        public frmAreaAdmin()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tpProfessor_Click(object sender, EventArgs e)
        {

        }

        private void frmAreaAdmin_Load(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = 0;
            cmbMateriaPergunta.SelectedIndex = 0;
            cmbRespostas.SelectedIndex = 0;
        }
        string nomeFile = "";
        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg | png|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                nomeFile = file.SafeFileName;
                picImagem.ImageLocation = file.FileName;
            }
        }

        private void frmAreaAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btnSalvarProfessor_Click(object sender, EventArgs e)
        {
            try

            {


                List<object> param = new List<object>();
                param.Add(txtNome.Text);
                param.Add(txtSobrenome.Text);

                //      DateTime dataConvertida = DateTime.ParseExact(mskDataNascimento.Text, "yyyy-MM-dd", null);


                // cmd.Parameters.AddWithValue("@3", dataConvertida);

                param.Add(txtCpf.Text);
                string sexo = "";

                if (radFem.Checked)
                    sexo = "F";
                else
                    sexo = "M";
                param.Add(sexo);
                param.Add(txtTelefone.Text);
                param.Add(cmbMateria.SelectedIndex + 1);
                param.Add(txtLogin.Text);
                param.Add(txtSenha.Text);
                string sql = "insert into professor(nome, sobrenome, cpf, sexo, celular, id_materia, login, senha, excluido) values(@1, @2, @3, @4, @5, @6, @7, @8, 'n')";
                Conexao.executar(sql, param);
                MessageBox.Show("Dados salvos com sucesso!", "Tadeu Tadado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaTela();
            }
            catch(Exception ex)
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
            txtCpf.Clear();
            txtSenha.Clear();
            txtLogin.Clear();
            txtTelefone.Clear();
            cmbMateria.SelectedIndex = 0;





        }
        private void LimpaTelaPergunta(bool limpaID = true)
        {
            if (limpaID)
            {

            }
            nomeFile = "";
            cmbMateriaPergunta.SelectedIndex = 0;
            cmbRespostas.SelectedIndex = 0;



        }
        private void btnSalvarPergunta_Click(object sender, EventArgs e)
        {
            try
            {
          
                List<object> param = new List<object>();
                param.Add(cmbMateriaPergunta.SelectedIndex + 1);
                param.Add(nomeFile);
                picImagem.Image.Save(Directory.GetCurrentDirectory() + "\\imagem\\"+nomeFile, picImagem.Image.RawFormat);
                param.Add(cmbRespostas.Text);
                string sql = "insert into perguntas(id_materia, caminhoImg, resposta, excluido) values (@1, @2, @3, 'n')";
                Conexao.executar(sql, param);
                MessageBox.Show("Dados salvos com sucesso!", "Tadeu Tadado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaTelaPergunta();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando!" + "\n\nMais detalhes: " +
                             ex.Message, "TadeuTadado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
    }
}
