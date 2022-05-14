using Sistma_de_Ctrl.de_Igr.Evang.Ass.de_Deus_SICAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistma_de_Ctrl.de_Igr._SC
{
    public partial class frmPesquisaAvancada : Form
    {
        frmSecretaria FormSecretaria;
        public DataGridView dtgCadastro;
        RegraNegocio2.CadastrosRegraNegocio novoCadastro;
        public frmPesquisaAvancada()
        {
            InitializeComponent();
        }

        private void btnPesquisarPesquisaAvancada_Click(object sender, EventArgs e)
        {
            try
            {
                /*Instanciamos e criamos um objeto do DataGridView Cadastro, do Formulário Secretaria, para então mostrar ele com o resultado da 
                  pesquisa Avançada */

                //Fazer o Validar
                novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
                bool resultadoValidacao = novoCadastro.ValidarPesquisaAvancada(Convert.ToInt32(cboNome.Text), Convert.ToInt32(cboSituacao.Text),
                                                              Convert.ToInt32(cboCongregacao.Text), Convert.ToInt32(cboSetor.Text),
                                                              txtPesquisaAvancada.Text);
                if (resultadoValidacao == true)
                {
                    FormSecretaria = new frmSecretaria();
                    novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();

                    if (cboNome.SelectedIndex >= 0)
                    {
                        string nome = cboNome.Text;
                        FormSecretaria.dtgCadastro.DataSource = novoCadastro.PesquisarNomeCadastro(nome);

                        /*Faz fechar o frmPesquisaAvancada, fazendo aparecer o frmSecretaria */
                        this.Close();
                        FormSecretaria.BringToFront();
                    }

                    else if (cboSituacao.SelectedIndex >= 0)
                    {
                        string situacao = cboSituacao.Text;
                        FormSecretaria.dtgCadastro.DataSource = novoCadastro.ListarSituacaoCadastro(situacao);

                        /*Faz fechar o frmPesquisaAvancada, fazendo aparecer o frmSecretaria */
                        this.Close();
                        FormSecretaria.BringToFront();
                    }
                    else if (cboCongregacao.SelectedIndex >= 0)
                    {
                        string congregacao = cboCongregacao.Text;
                        FormSecretaria.dtgCadastro.DataSource = novoCadastro.PesquisarNomeCadastro(congregacao);

                        /*Faz fechar o frmPesquisaAvancada, fazendo aparecer o frmSecretaria */
                        this.Close();
                        FormSecretaria.BringToFront();
                    }
                    else if (cboSetor.SelectedIndex >= 0)
                    {
                        int setor = Convert.ToInt32(cboSetor.Text);
                        FormSecretaria.dtgCadastro.DataSource = novoCadastro.ListarSetorCadastro(setor);

                        /*Faz fechar o frmPesquisaAvancada, fazendo aparecer o frmSecretaria */
                        this.Close();
                        FormSecretaria.BringToFront();
                    } 
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro no aplicativo\nTente novamente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no botão Pesquisar da PesquisaAvancada!\nTente de novo mais tarde! \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSecretaria.BringToFront();
        }

        private void txtPesquisaAvancada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string pesquisaAvancada = txtPesquisaAvancada.Text;

                if (txtPesquisaAvancada.Text == "Digite aqui")
                {
                    txtPesquisaAvancada.Clear();
                }
                else if (pesquisaAvancada.Trim().Length == 0 && cboSetor.SelectedIndex == -1)
                {
                    txtPesquisaAvancada.BackColor = Color.Firebrick;

                    MessageBox.Show("Digite algo no campo para inserção de texto ou escolha a Pesquisa por Setor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtPesquisaAvancada.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro enquanto eu validava o campo de inserção de texto(txtPesquisaAvançada)\n"
                                + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisaAvancada_Leave(object sender, EventArgs e)
        {
            try
            {
                string pesquisaAvancada = txtPesquisaAvancada.Text;

                if (txtPesquisaAvancada.Text == "Digite aqui")
                {
                    txtPesquisaAvancada.Clear();
                }
                else if (pesquisaAvancada.Trim().Length == 0 && cboSetor.SelectedIndex == -1)
                {
                    txtPesquisaAvancada.BackColor = Color.Firebrick;

                    MessageBox.Show("Digite algo no campo para inserção de texto ou escolha a Pesquisa por Setor!",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtPesquisaAvancada.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro enquanto eu validava o campo de inserção de texto(txtPesquisaAvançada)\n"
                                + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
