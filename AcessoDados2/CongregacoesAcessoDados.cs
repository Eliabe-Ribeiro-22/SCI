using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AcessoDados2
{
    public class CongregacoesAcessoDados
    {
        SqlCommand ComandoSql = new SqlCommand();
        StringBuilder Sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();
        public void SalvarCongregacao(int idCongregacao, string congregacao, int idSetor, string nomeSetor, string Dirigente1, string Dirigente2)
        {
            try
            {

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    
                    conexao.Open();

                    

                    Sql.Append("INSERT INTO Congregacao");
                    Sql.Append("(ID_CONGREGACAO, CONGREGACAO, ID_SETOR, SETOR_CONGREGACAO,");
                    Sql.Append("DIRIGENTE1_CONGREGACAO, DIRIGENTE2_CONGREGACAO)");

                    Sql.Append("VALUES (@idCongregacao, @congregacao, @idSetor, @nomeSetor, @Dirigente1, @Dirigente2)");

                    ComandoSql.Parameters.Add(new SqlParameter("@idCongregacao", idCongregacao));
                    ComandoSql.Parameters.Add(new SqlParameter("@congregacao", congregacao));
                    ComandoSql.Parameters.Add(new SqlParameter("@idSetor", idSetor));
                    ComandoSql.Parameters.Add(new SqlParameter("@nomeSetor", nomeSetor));
                    ComandoSql.Parameters.Add(new SqlParameter("@Dirigente1", Dirigente1));
                    ComandoSql.Parameters.Add(new SqlParameter("@Dirigente2", Dirigente2));

                    ComandoSql.CommandText = Sql.ToString();
                    ComandoSql.Connection = conexao;
                    ComandoSql.ExecuteNonQuery();
                   
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCongregacao(int idCongregacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("DELETE FROM Congregacao");
                    Sql.Append("WHERE (ID_CONGREGACAO = @idCongregacao");

                    ComandoSql.Parameters.Add(new SqlParameter("@idCongregacao", idCongregacao));

                    ComandoSql.CommandText = Sql.ToString();
                    ComandoSql.Connection = conexao;
                    ComandoSql.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no Método Excluir Congregação Acesso dos Dados \n" + " \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ListarCongregacao()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("SELECT * FROM Congregacao");
                    Sql.Append("ORDER BY ID_CONGREGACAO DESC");

                    ComandoSql.CommandText = Sql.ToString();
                    ComandoSql.Connection = conexao;

                    dadosTabela = new DataTable();

                    dadosTabela.Load(ComandoSql.ExecuteReader());
                   
                    return dadosTabela;
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show("Ocorreu um erro no Método Listar Congregação Acesso dos Dados \n" + " \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dadosTabela;
        }
    
        public void AlterarCongregacao(int idCongregacao, string congregacao, int idSetor, string nomeSetor, string Dirigente1, string Dirigente2)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("UPDATE Congregacao");
                    Sql.Append("SET NOME_CONGREGACAO = @congregacao, ");
                    Sql.Append("ID_SETOR = @idSetor, NOME_SETOR = @nomeSetor, DIRIGENTE1_CONGREGACAO = @Dirigente1, ");
                    Sql.Append("DIRIGENTE2_CONGREGACAO = @Dirigente2");
                    Sql.Append("WHERE (ID_CONGREGACAO = @idCongregacao");

                    ComandoSql.Parameters.Add(new SqlParameter("@idCongregacao", idCongregacao));
                    ComandoSql.Parameters.Add(new SqlParameter("@congregacao", congregacao));
                    ComandoSql.Parameters.Add(new SqlParameter("@idSetor", idSetor));
                    ComandoSql.Parameters.Add(new SqlParameter("@nomeSetor", nomeSetor));
                    ComandoSql.Parameters.Add(new SqlParameter("@Dirigente1", Dirigente1));
                    ComandoSql.Parameters.Add(new SqlParameter("@Dirigente2", Dirigente2));

                    ComandoSql.CommandText = Sql.ToString();
                    ComandoSql.Connection = conexao;
                    ComandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no Método Alterar Congregação Acesso dos Dados \n" + " \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
