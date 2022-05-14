using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistma_de_Ctrl.de_Igr.Evang.Ass.de_Deus_SICAD
{
    public partial class frmCadastro : Form
    {
        public frmSecretaria formularioSecretaria;
        /*bool dizimista;*/

        public frmCadastro()
        {
            InitializeComponent();
        }

        RegraNegocio2.CadastrosRegraNegocio novoCadastro;
        RegraNegocio2.CongregacoesRegraNegocio novaCongregacao;
        
        private void Limpar()
        {
            //Terminar o Método Limpar.
            txtCodigo.Text = "";
            txtNome.Clear();
            cboSituacao.SelectedIndex = 0;
            cboCongregacao.SelectedIndex = 0;
            cboSetor.SelectedIndex = -1;
            mktCPF.Text = "";
            mktRG.Text = "";
            txtNaturalidade.Text = "";
            dtpDataNascimento.Value = DateTime.Today.Date;
            txtNacionalidade.Clear();
            cboProfissao.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;
            cboGrauInstrucao.SelectedIndex = 0;
            txtPai.Clear();
            txtMae.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cboEstado.SelectedIndex = 0;
            mktCEP.Clear();
            mktTelefoneFixo.Clear();
            mktTelefoneCelular.Clear();
            txtEmail.Clear();

            //Guia Complemento.
            dtpDataConversao.Value = DateTime.Today.Date;
            txtBatismoAguas.Clear();
            dtpDataBatismo.Value = DateTime.Today.Date;
            txtBatismoEspiritoSanto.Clear();
            dtpBatismoEspiritoSanto.Value = DateTime.Today.Date;
            
            rbSim.Checked = false;
            rbNão.Checked = false;
            
            txtObservacoes.Clear();
            
            txtNome.Focus();
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                txtNome.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true; 
            }
            else
            {
                txtNome.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSituacao.SelectedIndex == -1)
            {
                cboSituacao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboSituacao.SelectedIndex == 0)
            {
                cboSituacao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboSituacao.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboCongregacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCongregacao.SelectedIndex == 0)
            {
                cboCongregacao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }

            if (cboCongregacao.SelectedIndex == -1)
            {
                cboCongregacao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboCongregacao.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;

                switch (cboCongregacao.Text)
                {
                    case "Sede":
                        cboSetor.SelectedIndex = 1;
                        break;

                    case "Monte Hermon":
                        cboSetor.SelectedIndex = 2;
                        break;

                    case "Canaã":
                        cboSetor.SelectedIndex = 2;
                        break;

                    case "Belém":
                        cboSetor.SelectedIndex = 2;
                        break;

                    case "Getsêmani":
                        cboSetor.SelectedIndex = 2;
                        break;

                    case "Betânia":
                        cboSetor.SelectedIndex = 2;
                        break;

                        //Setor 3.
                    case "Nova Jerusalém":
                        cboSetor.SelectedIndex = 3;
                        break;

                    case "Mananciais":
                        cboSetor.SelectedIndex = 3;
                        break;

                    case "Monte Sião":
                        cboSetor.SelectedIndex = 3;
                        break;

                    case "Shalom":
                        cboSetor.SelectedIndex = 3;
                        break;

                    default:
                        break;
                }
            }
        }

        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSetor.SelectedIndex == -1)
            {
                cboSetor.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboSetor.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            if (txtCidade.Text.Trim() == "")
            {
                txtCidade.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtCidade.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtNaturalidade_TextChanged(object sender, EventArgs e)
        {
            string naturalidade = txtNaturalidade.Text;

            if (naturalidade.Trim().Length == 0)
            {
                txtNaturalidade.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtNaturalidade.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtNacionalidade_TextChanged(object sender, EventArgs e)
        {
            string nacionalidade = txtNacionalidade.Text;

            if (nacionalidade.Trim().Length == 0)
            {
                txtNacionalidade.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtNacionalidade.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void mktCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                string CEP = mktCEP.Text;

                string novoCEP = CEP.Replace(".", "").Replace("-", "").Trim();

                if (novoCEP.Trim().Length == 0)
                {
                    mktCEP.BackColor = Color.Firebrick;
                    lblCampoObrigatorio.Visible = true;
                }
                else
                {
                    mktCEP.BackColor = Color.White;
                    lblCampoObrigatorio.Visible = false;
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSexo.SelectedIndex == -1)
            {
                cboSexo.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboSexo.SelectedIndex == 0)
            {
                cboSexo.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboSexo.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                txtNome.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtNome.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void mktCPF_Leave(object sender, EventArgs e)
        {
            string CPF = mktCPF.Text;
            string novoCPF = CPF.Replace(".", "").Replace("-", "");

            if (novoCPF == "")
            {
                mktCPF.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktCPF.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void mktRG_Leave(object sender, EventArgs e)
        {
            string RG = mktRG.Text;
            string novoRG = RG.Replace(".", "");

            if (novoRG.Trim().Length == 0)
            {
                mktRG.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktRG.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                /*  if (rbSim.Checked == true)
                   {
                       Convert.ToBoolean(dizimista);
                       dizimista = true;
                   }
                   else if(rbNão.Checked == true)
                   {
                       Convert.ToBoolean(dizimista);
                       dizimista = false;
                   }
                    */
                string RG = mktRG.Text;
                string nome = txtNome.Text;
                string CEP = mktCEP.Text;
                string CPF = mktCPF.Text;
                string novoCEP = CEP.Replace(".", "").Replace(" ", "");
                string novoCPF = CPF.Replace(".", "").Replace("-", "").Replace(" ", "");
                string novoRG = RG.Replace(".", "");

           /*   novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
                bool cpfValidado = novoCadastro.ValidaCpf(novoCPF); */

              /*novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
                novoCadastro.Validar(txtCodigo.Text, nome, Convert.ToInt32(cboSituacao.Text), Convert.ToInt32(cboCongregacao.Text),
                    novoCPF, novoRG, txtNaturalidade.Text, dtpDataNascimento.Value.Date, txtNacionalidade.Text, Convert.ToInt32(cboProfissao.Text),
                    Convert.ToInt32(cboSexo.Text), Convert.ToInt32(cboEstadoCivil.Text), Convert.ToInt32(cboGrauInstrucao.Text), txtMae.Text,
                    txtEndereco.Text, txtBairro.Text, txtCidade.Text, Convert.ToInt32(cboEstado.Text), novoCEP);
              */

                DataTable dadosTabela = new DataTable();
                //Terminar o método Abaixo.
                // dadosTabela = novoCadastro.RetornarCadastro(CPF);
                string idCadastro = txtCodigo.Text;

                if(idCadastro.Trim().Length == 0) 
                {
                    MessageBox.Show("Primeiro clique no botão Novo Cadastro para incluir um novo Cadastro", "Clique em Novo Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

              /*    if (cpfValidado == false)
                    {
                        MessageBox.Show("CPF Inválido. \nDigite um CPF válido para continuar com o cadastro.");
                    }
                    else
                    { */
                        if (idCadastro == "0")
                        {
                            if (dadosTabela.Rows.Count > 0)
                            {
                                MessageBox.Show("CPF já cadastrado!");
                            }
                            else
                            {
                                novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();

                                novoCadastro.Salvar(nome, Convert.ToInt32(cboSituacao.Text), cboCongregacao.Text, Convert.ToInt32(cboSetor.Text), novoCPF, mktRG.Text, 
                                txtNaturalidade.Text, Convert.ToDateTime(dtpDataNascimento.Value), txtNacionalidade.Text, Convert.ToInt32(cboProfissao.Text),
                                Convert.ToInt32(cboSexo.Text), Convert.ToInt32(cboEstadoCivil.Text), Convert.ToInt32(cboGrauInstrucao.Text), txtPai.Text, txtMae.Text,
                                txtEndereco.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, Convert.ToInt32(cboEstado.Text), novoCEP, 
                                mktTelefoneFixo.Text, mktTelefoneCelular.Text, txtEmail.Text, Convert.ToDateTime(dtpDataConversao.Value), txtBatismoAguas.Text, 
                                Convert.ToDateTime(dtpDataBatismo.Value), txtBatismoEspiritoSanto.Text, Convert.ToDateTime(dtpBatismoEspiritoSanto.Value),/* true,*/ 
                                txtObservacoes.Text);

                                MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Limpar();
                            }

                        }
                        else
                        {
                            novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();

                            novoCadastro.Alterar(Convert.ToInt32(txtCodigo.Text), nome, Convert.ToInt32(cboSituacao.Text), cboCongregacao.Text,
                                    Convert.ToInt32(cboSetor.Text), novoCPF, mktRG.Text, txtNaturalidade.Text,
                                    Convert.ToDateTime(dtpDataNascimento.Value), txtNacionalidade.Text, Convert.ToInt32(cboProfissao.Text), Convert.ToInt32(cboSexo.Text),
                                    Convert.ToInt32(cboEstadoCivil.Text), Convert.ToInt32(cboGrauInstrucao.Text), txtPai.Text, txtMae.Text, txtEndereco.Text, 
                                    txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, Convert.ToInt32(cboEstado.Text), novoCEP, mktTelefoneFixo.Text,
                                    mktTelefoneCelular.Text, txtEmail.Text, Convert.ToDateTime(dtpDataConversao.Value), txtBatismoAguas.Text,
                                    Convert.ToDateTime(dtpDataBatismo.Value), txtBatismoEspiritoSanto.Text, Convert.ToDateTime(dtpBatismoEspiritoSanto.Value), true,
                                    txtObservacoes.Text);

                            MessageBox.Show("Cadastro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Limpar();

                        }   } 
            /* } */
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            formularioSecretaria = new frmSecretaria();

            formularioSecretaria.ListarCadastros();
            formularioSecretaria.Estilo();            
        }

        private void mktTelefoneFixo_Leave(object sender, EventArgs e)
        {
            string Telefone = mktTelefoneFixo.Text;
            string novoTelefone = Telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                                                                
            if (novoTelefone.Trim().Length == 0)
            {
                mktTelefoneFixo.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktTelefoneFixo.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir esse cadastro?", "Deseja Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {

                    if (txtCodigo.Text.Trim().Length == 0 || txtCodigo.Text == "0")
                    {
                        MessageBox.Show("Primeiro selecione um cadastro para realizar a sua exclusão", "Sem Código de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        novoCadastro.Excluir(Convert.ToInt32(txtCodigo.Text));

                        MessageBox.Show("Cadastro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Limpar();

            formularioSecretaria.ListarCadastros();
            formularioSecretaria.Estilo();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            try
            {

                novaCongregacao = new RegraNegocio2.CongregacoesRegraNegocio();

             // cboCongregacao.DataSource = novaCongregacao.ListarCongregacao();
                //cboCongregacao.DisplayMember = "CONGREGACAO";
                //cboCongregacao.ValueMember = "ID_CONGREGACAO";

                novaCongregacao = new RegraNegocio2.CongregacoesRegraNegocio();

            //  cboSetor.DataSource = novaCongregacao.ListarCongregacao();
           //   cboSetor.DisplayMember = "ID_SETOR";
          //    cboSetor.ValueMember = "ID_SETOR";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Erro no frmCadastro_Load", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "0";
        }

        private void txtMae_TextChanged(object sender, EventArgs e)
        {
            if (txtMae.Text.Trim() == "")
            {
                txtMae.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
                txtMae.Focus();
            }
            else
            {
                txtMae.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboSituacao_Leave(object sender, EventArgs e)
        {
            if (cboSituacao.SelectedIndex == -1)
            {
                cboSituacao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboSituacao.SelectedIndex == 0)
            {
                cboSituacao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboSituacao.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboProfissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProfissao.SelectedIndex == -1)
            {
                cboProfissao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboProfissao.SelectedIndex == 0)
            {
                cboProfissao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboProfissao.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboProfissao_Leave(object sender, EventArgs e)
        {
            if (cboProfissao.SelectedIndex == -1)
            {
                cboProfissao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboProfissao.SelectedIndex == 0)
            {
                cboProfissao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboProfissao.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboSexo_Leave(object sender, EventArgs e)
        {
            if (cboSexo.SelectedIndex == -1)
            {
                cboSexo.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboSexo.SelectedIndex == 0)
            {
                cboSexo.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboSexo.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstadoCivil.SelectedIndex == -1)
            {
                cboEstadoCivil.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboEstadoCivil.SelectedIndex == 0)
            {
                cboEstadoCivil.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboEstadoCivil.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboEstadoCivil_Leave(object sender, EventArgs e)
        {
            if (cboEstadoCivil.SelectedIndex == -1)
            {
                cboEstadoCivil.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboEstadoCivil.SelectedIndex == 0)
            {
                cboEstadoCivil.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboEstadoCivil.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboGrauInstrucao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrauInstrucao.SelectedIndex == -1)
            {
                cboGrauInstrucao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboGrauInstrucao.SelectedIndex == 0)
            {
                cboGrauInstrucao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboGrauInstrucao.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboGrauInstrucao_Leave(object sender, EventArgs e)
        {
            if (cboGrauInstrucao.SelectedIndex == -1)
            {
                cboGrauInstrucao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboGrauInstrucao.SelectedIndex == 0)
            {
                cboGrauInstrucao.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboGrauInstrucao.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtPai_TextChanged(object sender, EventArgs e)
        {
            if (txtPai.Text.Trim() == "")
            {
                txtPai.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtPai.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtPai_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtNaturalidade_Leave(object sender, EventArgs e)
        {
            if (txtNaturalidade.Text.Trim() == "")
            {
                txtNaturalidade.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtNaturalidade.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtMae_Leave(object sender, EventArgs e)
        {
            if (txtMae.Text.Trim() == "")
            {
                txtMae.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtMae.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.Text.Trim() == "")
            {
                txtEndereco.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtEndereco.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            if (txtEndereco.Text.Trim() == "")
            {
                txtEndereco.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtEndereco.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() == "")
            {
                txtNumero.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtNumero.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() == "")
            {
                txtNumero.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtNumero.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            if (txtComplemento.Text.Trim() == "")
            {
                txtComplemento.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtComplemento.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            if (txtComplemento.Text.Trim() == "")
            {
                txtComplemento.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtComplemento.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            if (txtBairro.Text.Trim() == "")
            {
                txtBairro.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtBairro.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            if (txtBairro.Text.Trim() == "")
            {
                txtBairro.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtBairro.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (txtCidade.Text.Trim() == "")
            {
                txtCidade.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                txtCidade.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.SelectedIndex == -1)
            {
                cboEstado.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboEstado.SelectedIndex == 0)
            {
                cboEstado.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboEstado.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void cboEstado_Leave(object sender, EventArgs e)
        {
            if (cboEstado.SelectedIndex == -1)
            {
                cboEstado.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            if (cboEstado.SelectedIndex == 0)
            {
                cboEstado.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                cboEstado.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void mktCEP_Leave(object sender, EventArgs e)
        {
            string CEP = mktCEP.Text;

            string novoCEP = CEP.Replace(".", "").Replace("-", "").Trim();

            if (novoCEP.Trim().Length == 0)
            {
                mktCEP.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktCEP.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void mktTelefoneFixo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string Telefone = mktTelefoneFixo.Text;
            string novoTelefone = Telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (novoTelefone.Trim().Length == 0)
            {
                mktTelefoneFixo.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktTelefoneFixo.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void mktTelefoneCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string TelefoneCelular = mktTelefoneCelular.Text;
            string novoTelefoneCelular = TelefoneCelular.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (novoTelefoneCelular.Trim().Length == 0)
            {
                mktTelefoneCelular.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktTelefoneCelular.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void mktTelefoneCelular_Leave(object sender, EventArgs e)
        {
            string TelefoneCelular = mktTelefoneCelular.Text;
            string novoTelefoneCelular = TelefoneCelular.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (novoTelefoneCelular.Trim().Length == 0)
            {
                mktTelefoneCelular.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktTelefoneCelular.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
           
        }

        private void mktRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string RG = mktRG.Text;
            string novoRG = RG.Replace(".", "");

            if (novoRG.Trim().Length == 0)
            {
                mktRG.BackColor = Color.Firebrick;
                lblCampoObrigatorio.Visible = true;
            }
            else
            {
                mktRG.BackColor = Color.White;
                lblCampoObrigatorio.Visible = false;
            }
        }

        private void rbNão_Leave(object sender, EventArgs e)
        {
            if (rbNão.Checked == false && rbSim.Checked == false)
            {
                rbNão.BackColor = Color.Firebrick;
                rbSim.BackColor = Color.Firebrick;
                lblCampoObrigatorio2.Visible = true;
            }
            else
            {
                rbNão.BackColor = Color.White;
                rbSim.BackColor = Color.White;
                lblCampoObrigatorio2.Visible = false;
            }
        }
    }
}
