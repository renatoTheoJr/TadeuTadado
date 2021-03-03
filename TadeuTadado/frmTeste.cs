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
    public partial class frmTeste : Form
    {
        int id_materia = 0;
        int acertos = 0;
        int erros = 0;
        public frmTeste(int id_materia)
        {
            this.id_materia = id_materia;
            InitializeComponent();
        }
        int[] num;
        int[] perg;
        int aux = 0;
        private void frmTeste_Load(object sender, EventArgs e)
        {
            
            try
            {

                List<object> param = new List<object>();
                param.Add(id_materia);
                string sql = "select id_perguntas from perguntas where id_materia="+id_materia.ToString()+" and excluido ='n'";
                DataTable dt = Conexao.selecionarDataTable(sql);
                   
                    int i = dt.Rows.Count;
                    num = new int[i];
                    for(int j=0; j<i; j++)
                    {
                        num[j] = Convert.ToInt16(dt.Rows[j]["id_perguntas"]);
                    }
                Random rd = new Random();

                 perg= new int[10];
                for (int j = 0; j < 10; j++)
                {
                    int sor = rd.Next(num.Length);
                    if (j == 0)
                        perg[j] = num[sor];
                    else
                    {
                        bool teste = true;
                        for(int w=0; w<=j; w++)
                        {
                            if(num[sor]==perg[w])
                            {
                                j--;
                                teste = false;
                            }
                        }
                        if(teste)
                        {
                            perg[j] = num[sor];
                        }
                    }
                }
                // dr.Close();
                List<object> param1 = new List<object>();
                param1.Add(perg[aux]);
                string sql1 = "select * from perguntas where id_perguntas = @1";
                NpgsqlDataReader dr = Conexao.selecionar(sql1, param1);
                if (dr.Read())
                {
                    picImagem.ImageLocation = Directory.GetCurrentDirectory() + "\\imagem\\" + dr["caminhoImg"];
                }




            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar no Banco de Dados!" + "\n\nMais detalhes: " +
                               ex.Message, "Tadeu Tadado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (aux < 9)
            {


                List<object> param1 = new List<object>();
                param1.Add(perg[aux]);
                string sql1 = "select * from perguntas where id_perguntas = @1";
                NpgsqlDataReader dr = Conexao.selecionar(sql1, param1);
                if (dr.Read())
                {
                    if (cmbResposta.Text.Equals(dr["resposta"].ToString()))
                        acertos++;
                    else
                        erros++;
                }
                dr.Close();
                aux++;
                List<object> param2 = new List<object>();
                param2.Add(perg[aux]);
                sql1 = "select * from perguntas where id_perguntas = @1";
                NpgsqlDataReader dr1 = Conexao.selecionar(sql1, param1);
                if (dr1.Read())
                {
                    picImagem.ImageLocation = Directory.GetCurrentDirectory() + "\\imagem\\" + dr["caminhoImg"];
                }
            }
            else
            {

            }

        }
    }
}
