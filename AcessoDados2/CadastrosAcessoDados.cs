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
    public class CadastrosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder Sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        //Método Pronto
        public void Salvar(string nome, int situacao,
         string nomeCongregacao, int idSetor, string cpf, string rg, string naturalidade, DateTime dataNascimento,
         string Nacionalidade, int profissao, int Sexo, int EstadoCivil, int GrauInstrucao, string Pai, string Mae, string Endereco,
         string numero, string Complemento, string Bairro, string Cidade, int uf,
         string CEP, string telefone, string TelefoneCelular, string Email, DateTime DataConversao,
         string BatismoAguas, DateTime DataBatismo, string BatismoEspiritoSanto,
         DateTime DataBatismoEspiritoSanto, bool dizimista, string Observacoes)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("INSERT INTO Cadastro (NOME_CADASTRO, SITUACAO, NOME_CONGREGACAO, ID_SETOR");
                    Sql.Append(" CPF, RG, NATURALIDADE, DATA_NASCIMENTO, NACIONALIDADE, PROFISSAO, SEXO,");
                    Sql.Append(" ESTADO_CIVIL, GRAU_INSTRUCAO, PAI, MAE, ENDERECO, NUMERO, COMPLEMENTO");
                    Sql.Append(" BAIRRO, CIDADE, UF, CEP, TELEFONE, CELULAR, EMAIL, DATA_CONVERSAO");
                    Sql.Append(" BATISMO_AGUAS, DATA_BATISMO, BATISMO_ESPIRITO_SANTO, DATA_BATISMO_ESPIRITO_SANTO");
                    Sql.Append(" DIZIMISTA, OBSERVACOES)");

                    Sql.Append(" VALUES (@nome, @situacao, @nomeCongregacao, @idSetor, @cpf, @rg, @naturalidade,");
                    Sql.Append("  @dataNascimento, @nacionalidade, @profissao, @sexo, @estadoCivil, @grauInstrucao");
                    Sql.Append("  @pai, @mae, @endereco, @numero, @complemento, @bairro, @cidade, @uf, @cep,");
                    Sql.Append("  @telefone, @celular, @email, @dataConversao, @batismoAguas, @dataBatismo");
                    Sql.Append("  @batismoEspiritoSanto, @dataBatismoEspiritoSanto, @dizimista,  @observacoes)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
                    comandoSql.Parameters.Add(new SqlParameter("@nomeCongracao", nomeCongregacao));
                    comandoSql.Parameters.Add(new SqlParameter("@idSetor", idSetor));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
                    comandoSql.Parameters.Add(new SqlParameter("@naturalidade", naturalidade));
                    comandoSql.Parameters.Add(new SqlParameter("@dataNascimento", dataNascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@nacionalidade", Nacionalidade));
                    comandoSql.Parameters.Add(new SqlParameter("@profissao", profissao));
                    comandoSql.Parameters.Add(new SqlParameter("@sexo", Sexo));
                    comandoSql.Parameters.Add(new SqlParameter("@estadoCivil", EstadoCivil));
                    comandoSql.Parameters.Add(new SqlParameter("@grauInstrucao", GrauInstrucao));
                    comandoSql.Parameters.Add(new SqlParameter("@pai", Pai));
                    comandoSql.Parameters.Add(new SqlParameter("@mae", Mae));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", Endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@numero", numero));
                    comandoSql.Parameters.Add(new SqlParameter("@complemento", Complemento));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", Bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", Cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@uf", uf));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", CEP));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@celular", TelefoneCelular));
                    comandoSql.Parameters.Add(new SqlParameter("@email", Email));
                    comandoSql.Parameters.Add(new SqlParameter("@dataConversao", DataConversao));
                    comandoSql.Parameters.Add(new SqlParameter("@batismoAguas", BatismoAguas));
                    comandoSql.Parameters.Add(new SqlParameter("@dataBatismo", DataBatismo));
                    comandoSql.Parameters.Add(new SqlParameter("@batismoEspiritoSanto", BatismoEspiritoSanto));
                    comandoSql.Parameters.Add(new SqlParameter("@dataBatismoEspiritoSanto", DataBatismoEspiritoSanto));
                    comandoSql.Parameters.Add(new SqlParameter("@dizimista", dizimista));
                    comandoSql.Parameters.Add(new SqlParameter("@observacoes", Observacoes));

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

        //Método Pronto.
        public void Alterar(int idCadastro, string nome, int situacao,
            string nomeCongregacao, int idSetor, string cpf, string rg, string naturalidade, DateTime dataNascimento,
            string nacionalidade, int profissao, int Sexo, int EstadoCivil, int GrauInstrucao, string Pai, string Mae, string Endereco,
            string numero, string Complemento, string Bairro, string Cidade, int uf,
            string CEP, string telefone, string TelefoneCelular, string Email, DateTime DataConversao,
            string BatismoAguas, DateTime DataBatismo, string BatismoEspiritoSanto,
            DateTime DataBatismoEspiritoSanto, bool dizimista, string Observacoes)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("UPDATE Cadastro");
                    Sql.Append(" SET (NOME_CADASTRO = @nome, SITUACAO = @situacao,");
                    Sql.Append("  NOME_CONGREGACAO = @nomeCongregacao, ID_SETOR = @idSetor, CPF = @cpf, RG = @rg, NATURALIDADE = @naturalidade, DATA_NASCIMENTO = @dataNascimento");
                    Sql.Append("  NACIONALIDADE = @nacionalidade, PROFISSAO = @profissao, SEXO = @sexo,");
                    Sql.Append("  ESTADO_CIVIL = @estadoCivil, GRAU_INSTRUCAO = @grauInstrucao, PAI = @pai, MAE = @mae, ENDERECO = @endereco, NUMERO = @numero,");
                    Sql.Append("  COMPLEMENTO = @complemento, BAIRRO = @bairro, CIDADE = @cidade, UF = @uf, CEP = cep, TELEFONE = @telefone, CELULAR = @celular, EMAIL = @email,");
                    Sql.Append("  DATA_CONVERSAO = @dataConversao");
                    Sql.Append("  BATISMO_AGUAS = @batismoAguas, DATA_BATISMO = @dataBatismo, BATISMO_ESPIRITO_SANTO = @batismoEspiritoSanto,");
                    Sql.Append("  DATA_BATISMO_ESPIRITO_SANTO = @dataBatismoEspiritoSanto");
                    Sql.Append("  DIZIMISTA = @dizimista, OBSERVACOES = @observacoes)");
                    Sql.Append("  WHERE (ID_CADASTRO = @idCadastro");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
                    comandoSql.Parameters.Add(new SqlParameter("@nomeCongregacao", nomeCongregacao));
                    comandoSql.Parameters.Add(new SqlParameter("@idSetor", idSetor));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
                    comandoSql.Parameters.Add(new SqlParameter("@naturalidade", naturalidade));
                    comandoSql.Parameters.Add(new SqlParameter("@dataNascimento", dataNascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@nacionalidade", nacionalidade));
                    comandoSql.Parameters.Add(new SqlParameter("@profissao", profissao));
                    comandoSql.Parameters.Add(new SqlParameter("@sexo", Sexo));
                    comandoSql.Parameters.Add(new SqlParameter("@estadoCivil", EstadoCivil));
                    comandoSql.Parameters.Add(new SqlParameter("@grauInstrucao", GrauInstrucao));
                    comandoSql.Parameters.Add(new SqlParameter("@pai", Pai));
                    comandoSql.Parameters.Add(new SqlParameter("@mae", Mae));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", Endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@numero", numero));
                    comandoSql.Parameters.Add(new SqlParameter("@complemento", Complemento));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", Bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", Cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@uf", uf));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", CEP));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@celular", TelefoneCelular));
                    comandoSql.Parameters.Add(new SqlParameter("@email", Email));
                    comandoSql.Parameters.Add(new SqlParameter("@dataConversao", DataConversao));
                    comandoSql.Parameters.Add(new SqlParameter("@batismoAguas", BatismoAguas));
                    comandoSql.Parameters.Add(new SqlParameter("@dataBatismo", DataBatismo));
                    comandoSql.Parameters.Add(new SqlParameter("@batismoEspiritoSanto", BatismoEspiritoSanto));
                    comandoSql.Parameters.Add(new SqlParameter("@dataBatismoEspiritoSanto", DataBatismoEspiritoSanto));
                    comandoSql.Parameters.Add(new SqlParameter("@dizimista", dizimista));
                    comandoSql.Parameters.Add(new SqlParameter("@observacoes", Observacoes));

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

        //Método Pronto.
        public void Excluir(int idCadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("DELETE FROM Cadastro");
                    Sql.Append("WHERE (ID_CADASTRO = @idCadastro)");

                    comandoSql.Parameters.Add(new SqlParameter("@idCadastro", idCadastro));

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

        //Método Pronto
        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("SELECT * FROM Cadastro");
                    
                    //Ordena os resultados por ordem alfabética A-Z.
                    Sql.Append(" ORDER BY NOME_CADASTRO ASC");

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro no Método Listar, da camada AcessoDados\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dadosTabela;
        }

        //Método Pronto
        public DataTable ListarCongregacaoCadastro(string nomeCongregacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("SELECT * FROM Cadastro");
                    Sql.Append(" WHERE (NOME_CONGREGACAO = @nomeCongregacao");

                    //Ordena os resultados por ordem alfabética A-Z.
                    Sql.Append(" ORDER BY NOME_CADASTRO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@nomeCongregacao", nomeCongregacao));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro no Método ListarCongregacaoCadastro, da camada AcessoDados\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dadosTabela;
        }

        //Método Pronto.
        public DataTable PesquisarNomeCadastro(string nomeCadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    Sql.Append("SELECT * FROM Cadastro");
                    Sql.Append(" WHERE (NOME_CADASTRO LIKE '%' + @nomeCadastro + '%')");

                    //Ordena os resultados por ordem alfabética A-Z.
                    Sql.Append(" ORDER BY NOME_CADASTRO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@nomeCadastro", nomeCadastro));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro no Método Pesquisar por Nome do Cadastro, na camada AcessoDados\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dadosTabela;
        }

        //Método quase pronto, pois falta a linha 286 - SELECT dos dados exibidos no dtgCadastro.
        public DataTable ListarSetorCadastro(int NumeroSetor)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    /* A ideia é listarmos os membros de um determinado setor, mas não temos o nome do Setor e sim somente seu código.
                     * Então vamos trazer duas tabelas: Cadastro e Setor(INNER JOIN). Como sabemos qual setor o usuário quer, faremos uma verificação para mostrarmos somente
                     * o setor pedido pelo usuário, através do NumeroSetor, então traremos todos os membros desse Setor, exibindo alguns dados do membro, junto com o nome do setor que 
                     * pertence!
                     */
                    //Sql.Append("SELECT Cadastro.*, Setor.NUMERO_SETOR");
                    Sql.Append(" FROM(Cadastro INNER JOIN Setor ON Cadastro.NUMERO_SETOR = Setor.NUMERO_SETOR)");
                    Sql.Append("WHERE (Cadastro.NUMERO_SETOR = @NumeroSetor)");
                    

                    //Ordena os resultados por ordem alfabética A-Z.
                    Sql.Append(" ORDER BY NOME_CADASTRO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@NumeroSetor", NumeroSetor));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um Erro no Método ListarSetorCadastro, da camada AcessoDados\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dadosTabela;
        
        }
            //Método quase pronto pois falta a linha 321 - SELECT
        public DataTable ListarSituacaoCadastro(string situacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Abre uma Conexao com o Banco de Dados SCI.
                    conexao.Open();

                    //Arrumar o que será exibido (Select) no resultado do pesquisar, listar e retornar.
                    Sql.Append("SELECT FROM Cadastro");
                    Sql.Append(" WHERE (SITUACAO = @situacao)");

                    //Ordena os resultados por ordem alfabética A-Z.
                    Sql.Append(" ORDER BY NOME_CADASTRO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

                    comandoSql.CommandText = Sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
            MessageBox.Show("Ocorreu um Erro no Método ListarSituacaoCadastro, da camada AcessoDados\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dadosTabela;
        }
    }
}