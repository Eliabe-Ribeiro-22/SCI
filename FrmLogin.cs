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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public int idUsuario;
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        RegraNegocio2.UsuariosRegraNegocio novoUsuario;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                novoUsuario = new RegraNegocio2.UsuariosRegraNegocio();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.Login(txtUsuario.Text, txtSenha.Text);//Pesquisa os usuário do Sistema e os retorna.

                if (dadosTabela.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou senha inválidos", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dadosTabela.Rows[0]["STATUS_USUARIO"].ToString() == "Inativo")
                    {
                        MessageBox.Show("Conta de usuário inativa.\nContate o administrador do sistema", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Olá, " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString() + ".\nBem-Vindo ao sistema", "Entrada permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["ID_USUARIO"]);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

      
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
                
        }

        
    }
}
