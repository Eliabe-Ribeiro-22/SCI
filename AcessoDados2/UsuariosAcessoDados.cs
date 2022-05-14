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
    public class UsuariosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder Sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();
        public DataTable RetornarUsuario(int idUsuario)
        {
            //Fazer Instrução Select do Método Acima.
            return dadosTabela;
        }

        //Fazer o método Abaixo.
        public DataTable RetornarLogin(string usuario)
        {
            return dadosTabela;
        }

        public void Salvar(int idUsuario, string nome, string usuario, int nivelUsuario, string senha1,/*string senha2, */  int status, DateTime dataCadastro)
        {
            //Erro no Salvar
            try
            {

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("INSERT INTO Usuario");
                    Sql.Append("(ID_USUARIO, NOME_USUARIO, USUARIO, ID_NIVEL_USUARIO, SENHA_USUARIO, STATUS_USUARIO, DATA_CADASTRO_USUARIO)");

                    Sql.Append("VALUES (@idUsuario, @nome , @usuario, @nivelUsuario, @senha1, @status, @dataCadastro)");
                    /*@senha2*/

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@usuario", usuario));
                    comandoSql.Parameters.Add(new SqlParameter("@nivelUsuario", nivelUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@senha1", senha1));
                    // comandoSql.Parameters.Add(new SqlParameter("@senha2", senha2));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Método Pronto.
        public void Alterar(int idUsuario, string nome, string usuario, int nivelUsuario, string senha, int status, DateTime dataCadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    
                    Sql.Append("UPDATE Usuario");
                    Sql.Append(" SET NOME_USUARIO = @nome, USUARIO = @usuario, NIVEL_USUARIO = @nivelUsuario, SENHA_USUARIO = @senha,");
                    Sql.Append(" STATUS_USUARIO = @status, DATA_CADASTRO_USUARIO = @dataCadastro");
                    Sql.Append(" Where (ID_USUARIO = @idUsuario)");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@usuario", usuario));
                    comandoSql.Parameters.Add(new SqlParameter("@nivelUsuario", nivelUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));

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
        

        public DataTable PesquisarUsuario(string nome, string senha)
        {
            //Criar a Pesquisa por nome e senha no Banco de Dados.
            return dadosTabela;
        }


        public void Excluir(int idUsuario)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("DELETE FROM Usuario");
                    Sql.Append("WHERE (ID_USUARIO = @idUsuario)");

                    Sql.Append("VALUES (@idUsuario");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

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
    }
}
