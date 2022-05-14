using Sistma_de_Ctrl.de_Igr._SC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistma_de_Ctrl.de_Igr.Evang.Ass.de_Deus_SICAD
{
    public partial class FrmPrincipal : Form
    {
        RegraNegocio2.UsuariosRegraNegocio novoUsuario;
        string nomeUsuario;
        string nivelUsuario;
        public int idUsuario;

        public FrmPrincipal(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de Controle de Igrejas - SCI. Dia: " + DateTime.Today.Date.ToShortDateString() + " Horário: " + DateTime.Now.ToShortTimeString();
           
            CarregaDadosUsuario();
            
            nivelUsuario = lblNivelUsuario.Text;
            VerificaNivelUsuario(nivelUsuario);
            
            RegraNegocio2.SetoresRegraNegocio novoSetor = new RegraNegocio2.SetoresRegraNegocio();
            novoSetor.RetornarConexao();
       //fazer a MessageBox de Boas Vindas com o nome do Usuário MessageBox.Show("Usuário: " + "Bem Vindo ao Sistema de Controle para Igrejas!");
        }    

        private void btnSecretarias_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel<frmSecretaria>();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel<frmConfiguracoes>();
        }

        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pnlPrincipal.Controls.OfType<Forms>().FirstOrDefault();

            try
            {
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnlPrincipal.Controls.Add(formulario);
                    pnlPrincipal.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                        formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            formulario.Show();
            formulario.BringToFront();
        }
        /*    private void VerificaFormulario(Form novoForm)
            {
                foreach (Form formularios in this.MdiChildren)
                {
                    if (formularios.Name == novoForm.Name)
                    {
                        formularios.Focus();
                        return;
                    }
                }
                this.LayoutMdi(MdiLayout.Cascade);
                novoForm.MdiParent = this;
                novoForm.Show();
            } */

        private void btnTesouraria_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmTesouraria>();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmConfiguracoes>();
        }

        private void btnSecretaria_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmSecretaria>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmCadastroUsuarios>();
        }

        public void CarregaDadosUsuario()
        {
            try
            {
                novoUsuario = new RegraNegocio2.UsuariosRegraNegocio();
                DataTable dadosTabela = new DataTable();
                /* dadosTabela = novoUsuario.RetonarUsuário(idUsuario); */

                nomeUsuario = dadosTabela.Rows[0]["NOME_USUARIO"].ToString();
                nivelUsuario = dadosTabela.Rows[0]["NOME_NIVEL"].ToString();


                lblUsuario.Text = "Usuário" + nomeUsuario;
                lblNivelUsuario.Text = "Nível" + nivelUsuario;
                lblData.Text = DateTime.Today.ToShortDateString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Deseja sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin formularioLogin = new FrmLogin();
                formularioLogin.ShowDialog();

                if (formularioLogin.DialogResult == DialogResult.Yes)
                {
                    idUsuario = formularioLogin.idUsuario;
                    this.OnLoad(e);
                }
            }
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToLongTimeString();

        }

        private void VerificaNivelUsuario(string nivelUsuario)
        {
            switch (nivelUsuario)
            {
                case "Administrador":
                    btnSecretaria.Enabled = true;
                    btnTesouraria.Enabled = true;
                    btnPatrimonial.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnConfiguracao.Enabled = true;
               break;
              
               case "Pastor Presidente":
                    btnSecretaria.Enabled = true;
                    btnTesouraria.Enabled = true;
                    btnPatrimonial.Enabled = true;
                    btnUsuarios.Enabled = false;
                    btnConfiguracao.Enabled = false;
                    break;

                case "Vice-Presidente":
                    btnSecretaria.Enabled = true;
                    btnTesouraria.Enabled = false;
                    btnPatrimonial.Enabled = true;
                    btnUsuarios.Enabled = false;
                    btnConfiguracao.Enabled = false;
                    break;

                case "Pastor":
                    btnSecretaria.Enabled = true;
                    btnTesouraria.Enabled = false;
                    btnPatrimonial.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnConfiguracao.Enabled = false;
                    break;

                case "Tesoureiro":
                    btnSecretaria.Enabled = false;
                    btnTesouraria.Enabled = true;
                    btnPatrimonial.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnConfiguracao.Enabled = false;
                    break;

                case "Secretário":
                    btnSecretaria.Enabled = true;
                    btnTesouraria.Enabled = false;
                    btnPatrimonial.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnConfiguracao.Enabled = false;
                    break;

                case "Usuário":
                    btnSecretaria.Enabled = false;
                    btnTesouraria.Enabled = false;
                    btnPatrimonial.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnConfiguracao.Enabled = false;
                    break;
                  
                    


            }
        }
    }
}
