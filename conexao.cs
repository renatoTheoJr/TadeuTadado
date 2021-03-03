using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //necessario
using Npgsql;
namespace Pet72A
{
    public static class ConexaoBanco
    {
        //Variavel que contem os dados da conexão ao banco
        //postgres utilizando o npgsql que é um drive nativo
        //para acesso ao postgres para o C#
        static string stringConexao =
            "Server = 200.145.153.175; " +
            "Port = 5432;" +
            "Database = pet_72A ;" +
            "User ID= alunocti; password = alunocti;";

        static NpgsqlConnection cn = new NpgsqlConnection();



        public static void conectar()
        {

            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open();

                }
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        public static void desconectar()
        {
            cn.Close();
            cn.Dispose();
            cn = null;
        }


        //Executa uma query no banco de dados. (Sem retorno)
        public static void executar(string sql)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                desconectar();

            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        //Executa uma query no banco de dados com parametros
        public static void executar(string sql, List<object> parametros)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;

                foreach (object parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                }

                cmd.ExecuteNonQuery();
                desconectar();
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new NpgsqlException(ex.Message);
            }

        }

        //Executa uma query no banco de dados com parametros retornando 'campoRetorno'
        public static Int64 executar(string sql, List<object> parametros, string campoRetorno)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                Int64 modificado = 0;
                cmd.CommandText = sql + " RETURNING " + campoRetorno;
                cmd.Connection = cn;
                int i = 1;

                foreach (object parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                }

                modificado = Convert.ToInt64(cmd.ExecuteScalar());

                desconectar();
                return modificado;
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        //Select simples retornando um DataReader
        public static NpgsqlDataReader selecionar(string sql)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        //Select com parametros retornando um DataReader
        public static NpgsqlDataReader selecionar(string sql, List<object> parametros)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                }

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new NpgsqlException(ex.Message);
            }

        }

        // Select retornando os dados em um DataTable
        public static DataTable selecionarDataTable(string sql)
        {
            try
            {
                conectar();
                // Cria o objeto DataTable
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                desconectar();
                return dt;
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }

        public static DataSet selecionarDataSet(string sql)
        {
            try
            {
                conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                desconectar();
                return ds;
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }

        public static DataSet selecionarDataSet(string tabela, string campos, string where = "", string orderBy = "")
        {
            try
            {
                conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                string sql = @"select " + campos + " from " + tabela;
                if (where != "")
                    sql += @" where " + where + " ";
                if (orderBy != "")
                    sql += @" order by " + orderBy + " ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds, tabela);
                desconectar();
                return ds;
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }

    }
}
