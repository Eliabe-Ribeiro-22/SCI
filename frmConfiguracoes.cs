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
    public partial class frmConfiguracoes : Form
    {
        RegraNegocio2.SetoresRegraNegocio novoSetor;
        RegraNegocio2.CongregacoesRegraNegocio novaCongregacao;
        DataGridView novodtg = new DataGridView();


        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void btnSalvarSetor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdSetor.Text == "")
                {
                    MessageBox.Show("Clique no botão Novo para incluir um novo Setor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Se o Código do Setor for igual a 0, ele irá Salvar o Setor.
                    if (Convert.ToInt32(txtIdSetor.Text) == 0)
                    {
                        novoSetor = new RegraNegocio2.SetoresRegraNegocio();
                        novoSetor.SalvarSetor(txtSetor.Text, txtSupervisor.Text, Convert.ToInt32(txtIdSetor.Text));
                        MessageBox.Show("Setor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarDetalhesSetores();
                    }
                    //Se não, ele irá alterar o Setor.
                    else
                    {
                        novoSetor = new RegraNegocio2.SetoresRegraNegocio();
                        novoSetor.AlterarSetor(Convert.ToInt32(txtIdSetor.Text), txtSetor.Text, txtSupervisor.Text);
                        MessageBox.Show("Setor Alterado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarDetalhesSetores();
                    } 
                }
                
               

            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally
            {
                Limpar();
            }

        }

        private void btnExcluirSetor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este setor?", "Deseja excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoSetor = new RegraNegocio2.SetoresRegraNegocio();
                    novoSetor.ExcluirSetor(Convert.ToInt32(txtIdSetor.Text));
                    MessageBox.Show("Setor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    ListarDetalhesSetores();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            try
            {
                Limpar();

                novoSetor = new RegraNegocio2.SetoresRegraNegocio();
                
                cboSetor.DataSource = novoSetor.ListarSetores();
                cboSetor.DisplayMember = "NOME_SETOR";
                cboSetor.ValueMember = "ID_SETOR";

                ListarDetalhesSetores();

                ListarDetalhesCongregacao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Limpar()
        {
            txtIdSetor.Text = "";
            txtSetor.Text = "";
            txtSupervisor.Text = "";

            //Limpa na tab Congregação.
            txtIdCongregacao.Text = "";
            txtNomeCongregacao.Text = "";
            cboSetor.SelectedIndex = -1;
            txtDirigente1.Text = "";
            txtDirigente2.Text = "";
        }
        public void Estilo(DataGridView DataGridView)
        {
            this.novodtg = DataGridView;

            if (novodtg == dtgSetor)
            {
                for (int i = 0; i < dtgSetor.Rows.Count; i += 2)
                {
                    dtgSetor.Rows[i].DefaultCellStyle.BackColor = Color.PeachPuff;
                }
                for (int i = 1; i < dtgSetor.Rows.Count; i += 2)
                {
                    dtgSetor.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                } 
            }
            else if (novodtg == dtgCongregacoes)
            {
                for (int i = 0; i < dtgCongregacoes.Rows.Count; i += 2)
                {
                    dtgCongregacoes.Rows[i].DefaultCellStyle.BackColor = Color.PeachPuff;
                }
                for (int i = 1; i < dtgCongregacoes.Rows.Count; i += 2)
                {
                    dtgCongregacoes.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
            }
            
        }
        private void dtgSetor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // txtIdSetor.Text = dtgSetor.
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtIdCongregacao.Text = "0";
            txtIdSetor.Text = "0";
        }

        private void btnExcluirCongregacao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir essa congregação?", "Deseja excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtIdCongregacao.Text == "")
                {
                    MessageBox.Show("Clique no botão Novo para incluir uma nova Congregação", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtIdCongregacao.Text == "0")
                {
                    novaCongregacao = new RegraNegocio2.CongregacoesRegraNegocio();
                    novaCongregacao.ExcluirCongregacao(Convert.ToInt32(txtIdCongregacao.Text));
                    MessageBox.Show("Setor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    ListarDetalhesCongregacao(); 
                }
            }
        }

        private void btnSalvarCongregacao_Click(object sender, EventArgs e)
        {
            try
            {

                novaCongregacao = new RegraNegocio2.CongregacoesRegraNegocio();
                //     Validar();

                if (txtIdCongregacao.Text == "")
                {
                    MessageBox.Show("Clique no botão Novo para incluir um novo Setor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToInt32(txtIdCongregacao.Text) == 0)
                    {
                        novaCongregacao.SalvarCongregacao(Convert.ToInt32(txtIdCongregacao.Text), txtNomeCongregacao.Text, Convert.ToInt32(cboSetor.SelectedValue)/*verificar como faz o salvamento do idSetor do cboSetor */, cboSetor.Text, txtDirigente1.Text, txtDirigente2.Text);
                        MessageBox.Show("Congregação Salva com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarDetalhesCongregacao();
                        Limpar();
                    }
                    else
                    {
                        novaCongregacao.AlterarCongregacao(Convert.ToInt32(txtIdCongregacao.Text), txtNomeCongregacao.Text, Convert.ToInt32(cboSetor.SelectedValue)/*verificar como faz o salvamento do idSetor do cboSetor */, cboSetor.Text, txtDirigente1.Text, txtDirigente2.Text);
                        MessageBox.Show("Congregação Alterada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarDetalhesCongregacao();
                        Limpar();
                    }
                }
            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListarDetalhesCongregacao()
        {
            novaCongregacao = new RegraNegocio2.CongregacoesRegraNegocio();

            dtgCongregacoes.DataSource = novaCongregacao.ListarCongregacao();

            Estilo(dtgCongregacoes);
        }
        public void ListarDetalhesSetores()
        {
           
            novoSetor = new RegraNegocio2.SetoresRegraNegocio();
           
            dtgSetor.DataSource = novoSetor.ListarSetores();

            Estilo(dtgSetor);
        }

        private void txtNomeCongregacao_Leave(object sender, EventArgs e)
        {
            if (txtNomeCongregacao.Text.Trim().Length == 0)
            {
                txtNomeCongregacao.BackColor = Color.Firebrick;
            }
            else
            {
                txtNomeCongregacao.BackColor = Color.White;
            }
        }

        private void txtDirigente1_TextChanged(object sender, EventArgs e)
        {
            if (txtDirigente1.Text.Trim().Length == 0)
            {
                txtDirigente1.BackColor = Color.Firebrick;
            }
            else
            {
                txtDirigente1.BackColor = Color.White;
            }
        }

        private void txtDirigente2_TextChanged(object sender, EventArgs e)
        {
            if (txtDirigente2.Text.Trim().Length == 0)
            {
                txtDirigente2.BackColor = Color.Firebrick;
            }
            else
            {
                txtDirigente2.BackColor = Color.White;
            }
        }
    }
}
