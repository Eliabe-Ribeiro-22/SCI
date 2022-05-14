using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RegraNegocio2
{
    public class CadastrosRegraNegocio
    {
        AcessoDados2.CadastrosAcessoDados novoCadastro;
        DataTable dadosTabela = new DataTable();

        //Método Pronto.
        public void Salvar(string nome, int Situacao,
            string nomeCongregacao, int idSetor, string cpf, string rg, string naturalidade, DateTime dataNascimento,
            string nacionalidade, int profissao, int sexo, int estadoCivil, int grauInstrucao, string Pai, string Mae, string Endereco,
            string numero, string complemento, string Bairro, string Cidade, int Estado,
            string CEP, string TelefoneFixo, string TelefoneCelular, string email, DateTime dataConversao,
            string BatismoAguas, DateTime DataBatismo, string BatismoEspiritoSanto,
            DateTime DataBatismoEspiritoSanto, bool dizimista, string Observacoes)
        {
            novoCadastro = new AcessoDados2.CadastrosAcessoDados();
            novoCadastro.Salvar(nome, Situacao, nomeCongregacao, idSetor, cpf, rg, naturalidade, dataNascimento,
            nacionalidade, profissao, sexo, estadoCivil, grauInstrucao, Pai, Mae, Endereco, numero, complemento, Bairro, Cidade, Estado,
            CEP, TelefoneFixo, TelefoneCelular, email, dataConversao, BatismoAguas, DataBatismo, BatismoEspiritoSanto,
            DataBatismoEspiritoSanto, true, Observacoes);
        }

        public void Alterar(int idCadastro, string nome, int Situacao,
            string nomeCongregacao,int idSetor, string cpf, string rg, string naturalidade, DateTime dataNascimento,
            string nacionalidade, int profissao, int sexo, int estadoCivil, int grauInstrucao, string Pai, string Mae, string Endereco,
            string numero, string complemento, string Bairro, string Cidade, int Estado,
            string CEP, string TelefoneFixo, string TelefoneCelular, string email, DateTime dataConversao,
            string BatismoAguas, DateTime DataBatismo, string BatismoEspiritoSanto,
            DateTime DataBatismoEspiritoSanto, bool dizimista, string Observacoes)
        {
            if (cpf == "")
            {
                MessageBox.Show("O campo CPF não pode ficar vazio", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool CPF = ValidaCpf(cpf);

                if (Convert.ToBoolean(CPF) == false)
                {
                    MessageBox.Show("O CPF é inválido", "CPF INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToBoolean(CPF) == true)
                    {
                        AcessoDados2.CadastrosAcessoDados novoCadastro;
                        novoCadastro = new AcessoDados2.CadastrosAcessoDados();
                        DataTable dadosTabela = new DataTable();

                        /*           dadosTabela = novoCadastro.PesquisarCpf(CPF); */
                        /* Fazer a Verificação se o cpf ja for cadastrado. Se já for cadastrado não haverá alteração
                         se não , será salvo */
                        if (dadosTabela.Rows.Count > 0)
                        {
                            for (int i = 0; i < dadosTabela.Rows.Count; i++)
                            {
                                if (idCadastro == Convert.ToInt32(dadosTabela.Rows[i]["ID_CADASTRO"].ToString()))
                                {
                                    novoCadastro.Alterar(idCadastro, nome, Situacao, nomeCongregacao, idSetor, cpf, rg, naturalidade, dataNascimento,
                                    nacionalidade, profissao, sexo, estadoCivil, grauInstrucao, Pai, Mae, Endereco, numero, complemento, Bairro, Cidade, Estado,
                                    CEP, TelefoneFixo, TelefoneCelular, email, dataConversao, BatismoAguas, DataBatismo, BatismoEspiritoSanto,
                                    DataBatismoEspiritoSanto, true, Observacoes);
                                }
                            }
                        }
                        else
                        {
                            novoCadastro.Alterar(idCadastro, nome, Situacao, nomeCongregacao, idSetor, cpf, rg, naturalidade, dataNascimento,
                                    nacionalidade, profissao, sexo, estadoCivil, grauInstrucao, Pai, Mae, Endereco, numero, complemento, Bairro, Cidade, Estado,
                                    CEP, TelefoneFixo, TelefoneCelular, email, dataConversao, BatismoAguas, DataBatismo, BatismoEspiritoSanto,
                                    DataBatismoEspiritoSanto, dizimista, Observacoes);
                        }
                    }
                }
            }
        }

        public void Excluir(int idCadastro)
        {
            try
            {
                novoCadastro = new AcessoDados2.CadastrosAcessoDados();
                novoCadastro.Excluir(idCadastro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método Pronto
        public DataTable Listar()
        {
            try
            {
                novoCadastro = new AcessoDados2.CadastrosAcessoDados();
                DataTable dadosTabela = new DataTable();
                
                dadosTabela = novoCadastro.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

                return dadosTabela;
        }

        //Método Pronto
        public DataTable ListarCongregacaoCadastro(string nomeCongregacao)
        {
            try
            {
                novoCadastro = new AcessoDados2.CadastrosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCadastro.ListarCongregacaoCadastro(nomeCongregacao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dadosTabela;
        }
        
        //Método Pronto.
        public DataTable ListarSetorCadastro(int NumeroSetor)
        {
            try
            {
                novoCadastro = new AcessoDados2.CadastrosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCadastro.ListarSetorCadastro(NumeroSetor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dadosTabela;
        }
        
        //Método Pronto.
        public DataTable ListarSituacaoCadastro(string situacao)
        {
            try
            {
                novoCadastro = new AcessoDados2.CadastrosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoCadastro.ListarSituacaoCadastro(situacao);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dadosTabela;
        
        }
        
        //Método Pronto.
        public DataTable PesquisarNomeCadastro(string nomeCadastro)
            {
                try
                {
                    novoCadastro = new AcessoDados2.CadastrosAcessoDados();
                    DataTable dadosTabela = new DataTable();

                    dadosTabela = novoCadastro.PesquisarNomeCadastro(nomeCadastro);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
 
                    return dadosTabela;
            }

        //Método Pronto.
            public void Validar(string idCadastro, string nome, int Situacao, int Congregacao, string CPF, string Rg,
                                string Naturalidade, DateTime DataNascimento, string Nacionalidade, int Profissao,
                                int Sexo, int EstadoCivil, int GrauInstrucao, string Mae, string Endereco, string Bairro,
                                string Cidade, int UF, string CEP)
        {
            try
            {

                if (idCadastro.Trim().Length == 0)
                {
                    MessageBox.Show("Antes de Salvar, clique no botão Novo Cadastro para Incluir um Cadastro!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (nome.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Situacao == 0)
                {
                    MessageBox.Show("É necessário selecionar uma Situação!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Situacao == -1)
                {
                    MessageBox.Show("É necessário selecionar uma Situação!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Congregacao == -1)
                {
                    MessageBox.Show("É necessário selecionar uma Congregação!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Congregacao == 0)
                {
                    MessageBox.Show("É necessário selecionar uma Congregação!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (CPF == "")
                {
                    MessageBox.Show("É necessário preencher o CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Rg.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher o RG!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Naturalidade.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher a Naturalidade!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (DataNascimento.Date == DateTime.Today)
                {
                    MessageBox.Show("Selecione a Data de Nascimento!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Nacionalidade.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher o RG!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Profissao == 0)
                {
                    MessageBox.Show("É necessário preencher a Profissão", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Profissao == -1)
                {
                    MessageBox.Show("É necessário preencher a Profissão", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Sexo == 0)
                {
                    MessageBox.Show("É necessário preencher o campo Sexo!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Sexo == -1)
                {
                    MessageBox.Show("É necessário preencher o campo Sexo!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (EstadoCivil == -1)
                {
                    MessageBox.Show("É necessário preencher o Estado Civil!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (EstadoCivil == 0)
                {
                    MessageBox.Show("É necessário preencher o Estado Civil!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (GrauInstrucao == -1)
                {
                    MessageBox.Show("É necessário preencher o Grau de Instrução", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (GrauInstrucao == -1)
                {
                    MessageBox.Show("É necessário preencher o Grau de Instrução!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Mae.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher o nome da Mãe!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Endereco.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher o Endereço!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Bairro.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher o Bairro!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Cidade.Trim().Length == 0)
                {
                    MessageBox.Show("É necessário preencher a Cidade!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (UF == -1)
                {
                    MessageBox.Show("É necessário preencher o Estado!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (UF == 0)
                {
                    MessageBox.Show("É necessário preencher o Estado!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (CEP.Trim().Length == 0)
                {
                    MessageBox.Show("É obrigatório preencher o CEP", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro");
            }

        }

        public bool ValidarPesquisaAvancada(int cboNome, int cboSituacao, int cboCongregacao, int cboSetor, string pesquisaAvancada)
        {
            try
            {
                if (pesquisaAvancada.Trim().Length == 0 && cboSetor == -1)
                {
                    MessageBox.Show("Digite algo no campo para inserção de texto ou escolha a Pesquisa por Setor, ou ainda"
                       + "aperte o botão Voltar a Secretaria!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if(cboNome == -1 && cboSituacao == -1 && cboCongregacao == -1 && cboSetor == -1)
                {
                    MessageBox.Show("Selecione uma opção de pesquisa ou aperte o botão Voltar a Secretaria para visualizar todos os cadastros",
                                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);

            }
        }

        public bool ValidaCpf(string CPf)
        {
            RegraNegocio2.ValidaDocumentos novoCpf = new RegraNegocio2.ValidaDocumentos();
            novoCpf.ValidaCpf(CPf);
            

            if (Convert.ToBoolean(CPf) == ValidaCpf(CPf))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
