using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados2
{
    public class SetoresAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder Sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void SalvarSetor(string setor, string supervisor, int idSetor)
        {
            try
            {

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();



                    Sql.Append("INSERT INTO Setor");
                    Sql.Append("(NOME_SETOR, NOME_SUPERVISOR, ID_SETOR)");

                    Sql.Append("VALUES (@setor, @supervisor, @idSetor)");

                    comandoSql.Parameters.Add(new SqlParameter("@setor", setor));
                    comandoSql.Parameters.Add(new SqlParameter("@supervisor", supervisor));
                    comandoSql.Parameters.Add(new SqlParameter("@idSetor", idSetor));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //Método Pronto
        public void ExcluirSetor(int idSetor)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("DELETE FROM Setor");
                    Sql.Append("WHERE (ID_SETOR = @idSetor)");

                    comandoSql.Parameters.Add(new SqlParameter("@idSetor", idSetor));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocorreu um erro no Método Excluir Acesso dos Dados \n" + " \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public DataTable ListarSetor()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("SELECT * FROM Setor");
                    Sql.Append("ORDER BY ID_SETOR DESC");

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                  
                    return dadosTabela;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no Método ListarSetor Acesso dos Dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dadosTabela;
        } 

        public void AlterarSetor(string setor, string supervisor, int idSetor)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("UPDATE Setor");
                    Sql.Append("SET NOME_SETOR = @nome, SUPERVISOR_SETOR = @supervisor,");
                    Sql.Append("Where (ID_SETOR = @idSetor)");

                    comandoSql.Parameters.Add(new SqlParameter("@setor", setor));
                    comandoSql.Parameters.Add(new SqlParameter("@supervisor", supervisor));
                    comandoSql.Parameters.Add(new SqlParameter("@idSetor", idSetor));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no Método Alterar Acesso dos Dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
         
    }
}
