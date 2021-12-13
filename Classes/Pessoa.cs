using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Desafio1.Classes
{
    class Pessoa
    {
        public string Nome;
        public string Telefone;
        public string Cidade;
        public string Rg;
        public string Cpf;
        public string NomeCurso;

        public void ApresentarDados()
        {
            Console.WriteLine($"Z - {Nome} - {Telefone} - {Cidade} - {Rg} - {Cpf}");
        }

        public bool gravarPessoa()
        {

            banco Banco = new banco();
            
            SqlConnection cn = Banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Pessoas" + " values (@Nome, @Telefone, @Cidade, @Rg, @Cpf, @NomeCurso);";
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Telefone", SqlDbType.VarChar);
            command.Parameters.Add("@Cidade", SqlDbType.VarChar);
            command.Parameters.Add("@Rg", SqlDbType.VarChar);
            command.Parameters.Add("@Cpf", SqlDbType.VarChar);
            command.Parameters.Add("@NomeCurso", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Telefone;
            command.Parameters[2].Value = Cidade;
            command.Parameters[3].Value = Rg;
            command.Parameters[4].Value = Cpf;
            command.Parameters[5].Value = NomeCurso;
            

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                return false;

            }
            finally
            {
                Banco.fecharConexao();
            }

        }

    }
}
