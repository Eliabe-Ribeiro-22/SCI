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
    public partial class FrmCadastroUsuarios : Form
    {
        
        RegraNegocio2.UsuariosRegraNegocio novoCadastro;

        public FrmCadastroUsuarios()
        {
            InitializeComponent();
        }

         
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {/*
                novoCadastro = new RegraNegocio2.UsuariosRegraNegocio();
                novoCadastro.Validar(Convert.ToInt32(txtIdUsuario.Text), txtNome.Text, txtUsuario.Text, Convert.ToInt32(cboNivelUsuario.Text), txtSenha1.Text, txtSenha2.Text, Convert.ToInt32(cboStatus.Text), Convert.ToDateTime(dtpDataCadatro.Value));        
              */
                DateTime dataCadastro = Convert.ToDateTime(dtpDataCadatro.Value.ToString());
                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);
                string nome = txtNome.Text;
                string usuario = txtUsuario.Text;
                string senha1 = txtSenha1.Text;
                string senha2 = txtSenha2.Text;
                try
                {
                    if (senha1.Trim().Length == 0)
                    {
                        MessageBox.Show("O campo senha não pode ser vazio", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao verificar se a senha1 está vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    if (senha2.Trim().Length == 0)
                    {
                        MessageBox.Show("O campo Confirme a senha não pode ser vazio", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao verificar se a senha1 está vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Erro
                int nivelUsuario = 1;
                //   Convert.ToInt32(cboNivelUsuario.Text);
                int status = 1;
               //   Convert.ToInt32(cboStatus.Text);

                if (idUsuario == 0)
                {
                    novoCadastro = new RegraNegocio2.UsuariosRegraNegocio();
                    

                    novoCadastro.Salvar(idUsuario, nome, usuario, nivelUsuario, senha1, /*senha2*/ status, dataCadastro);
                }
                else
                {
                    novoCadastro = new RegraNegocio2.UsuariosRegraNegocio();

                    DataTable dadosTabela = new DataTable();
                    //   dadosTabela = novoCadastro.Retornar
                   
                    novoCadastro.Alterar(idUsuario, nome, usuario, nivelUsuario, senha1, /*senha2*/ status, dataCadastro);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Limpar();
                ListarUsuario();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                novoCadastro = new RegraNegocio2.UsuariosRegraNegocio();
                if (MessageBox.Show("Deseja realmente excluir este Usuário?", "Deseja Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtIdUsuario.Text == "")
                    {
                        MessageBox.Show("Não há um Usuário para ser excluído", "Impossível Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Convert.ToInt32(txtIdUsuario.Text) == 0)
                        {
                            novoCadastro.Validar(Convert.ToInt32(txtIdUsuario.Text), txtNome.Text, txtUsuario.Text, Convert.ToInt32(cboNivelUsuario.Text), txtSenha1.Text, txtSenha2.Text, Convert.ToInt32(cboStatus.Text), Convert.ToDateTime(dtpDataCadatro.Value));

                            novoCadastro = new RegraNegocio2.UsuariosRegraNegocio();
                            novoCadastro.Excluir(Convert.ToInt32(txtIdUsuario.Text));

                        }

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

        private void cboStatus_Leave(object sender, EventArgs e)
        {
            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("O campo Status não pode ficar vazio");
            }
        }
        //Método Pronto.
        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
                {


                    // Antigo Método Descriptografar - Abaixo.
                    // Criptografia = new RegraNegocio2.Criptografia();
                    // string senhaDescripto = Criptografia.Descriptografar(dtgUsuarios.Rows[e.RowIndex].Cells["SENHA"].Value.ToString());
                    txtIdUsuario.Text = dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value.ToString();
                    txtNome.Text = dtgUsuarios.Rows[e.RowIndex].Cells["NOME"].Value.ToString();

                    if (dtgUsuarios.Rows[e.RowIndex].Cells["SENHA"].Value.ToString().Trim().Length == 32)
                    {
                        string novaSenha = dtgUsuarios.Rows[e.RowIndex].Cells["SENHA"].Value.ToString().Substring(0, 4);

                        txtSenha1.Text = novaSenha;
                        txtSenha2.Text = novaSenha;
                    }
                    cboNivelUsuario.SelectedValue = dtgUsuarios.Rows[e.RowIndex].Cells["NIVEL_USUARIO"].Value.ToString();
                    cboStatus.Text = dtgUsuarios.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();
                    dtpDataCadatro.Value = Convert.ToDateTime(dtgUsuarios.Rows[e.RowIndex].Cells["DATA_CADASTRO"].Value); 
                }

                else
                {
                    if (dtgUsuarios.Columns[e.ColumnIndex].Name == "buttonExcluir")
                    {
                        if (MessageBox.Show("Deseja realmente excluir esse Usuário?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                novoCadastro.Excluir(Convert.ToInt32(txtIdUsuario.Text));
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
        }
              
        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDataCadatro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboNivelUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = "0";
        }

        private void ListarUsuario()
        {
          // Falta Fazer os Métodos Listar RegraNegocio/Acesso Dados.
         //   dtgUsuarios.DataSource = novoCadastro.Listar();
        }

        public void Limpar()
        {
            txtIdUsuario.Text = "";
            txtNome.Text = "";
            txtUsuario.Text = "";
            cboNivelUsuario.SelectedIndex = -1;
            txtSenha1.Text = "";
            txtSenha2.Text = "";
            cboStatus.SelectedIndex = -1;
            dtpDataCadatro.Value = DateTime.Today.Date;
        }
    }
}
