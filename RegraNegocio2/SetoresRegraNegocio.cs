using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegraNegocio2
{
    public class SetoresRegraNegocio
    {
        AcessoDados2.SetoresAcessoDados novoSetor;
        AcessoDados2.Conexao novaConexao;
        DataTable dadosTabela = new DataTable();
        public void RetornarConexao()
        {
            try
            {
                novaConexao = new AcessoDados2.Conexao();

                using (SqlConnection conexao = new SqlConnection(novaConexao.RetornarConexao()))
                {
                    conexao.Open();

                    MessageBox.Show("O Sistema conseguiu conectar-se ao Banco de Dados", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //Os códigos abaixo só serão usados ao "Fechar" o Sistema de maneira Oficial.
                MessageBox.Show(/*"Não foi possível conectar-se ao Banco de Dados \nPor favor, Tente acessar o Sistema novamente."  + */ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            }
        }




        public void SalvarSetor(string setor, string supervisor, int idSetor)
        {
            try
            {
                Validar(idSetor, setor, supervisor);

                novoSetor = new AcessoDados2.SetoresAcessoDados();
                novoSetor.SalvarSetor(setor, supervisor, idSetor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        public void Validar(int idSetor, string setor, string supervisor)
        {
            try
            {
                if (Convert.ToString(idSetor).Trim().Length == 0)
                {
                    MessageBox.Show("Clique no botão Novo para incluir um novo Setor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (setor.Trim().Length == 0)
                {
                    MessageBox.Show("O campo Setor não pode ser vazio", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (supervisor.Trim().Length == 0)
                {
                    MessageBox.Show("O campo Supervisor não pode ser vazio", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no Método Validar do Setor Camada Regra Negocio \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExcluirSetor(int idSetor)
        {
            try
            {
                novoSetor = new AcessoDados2.SetoresAcessoDados();
                novoSetor.ExcluirSetor(idSetor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public void AlterarSetor(int idSetor, string setor, string supervisor)
        {
            try
            {
                Validar(idSetor, setor, supervisor);

                novoSetor = new AcessoDados2.SetoresAcessoDados();
                novoSetor.AlterarSetor(setor, supervisor, idSetor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarSetores() 
        {
            try
            {
                novoSetor = new AcessoDados2.SetoresAcessoDados();
                dadosTabela = novoSetor.ListarSetor();
                return dadosTabela;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


       
    
    }
}
