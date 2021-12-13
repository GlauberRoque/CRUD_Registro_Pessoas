using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Classes
{
    class banco
    {

        //fazendo a conexão com o banco de dados
        private string stringConexao = "Data Source=localhost; Initial Catalog=Desafio1; User ID=usuarioDesafio; password=senha; language=portuguese";

        private SqlConnection cn;

        private void conexao() // vai vincular a string com a cn, e inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //vai tentar fazer algo
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                // faz algo se der erro no try


                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {

                return;
            }
        }

        public DataTable executarConsulta(string sql)
        {
            try
            {

                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                fecharConexao();
            }
        }

    }


}
