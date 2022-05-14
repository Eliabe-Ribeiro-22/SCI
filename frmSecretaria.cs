using Sistma_de_Ctrl.de_Igr._SC;
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
    public partial class frmSecretaria : Form
    {
        RegraNegocio2.CadastrosRegraNegocio novoCadastro;
        public frmSecretaria()
        {
            InitializeComponent();
        }

       
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro formularioCadastro = new frmCadastro();
            formularioCadastro.Show();
        }

        private void frmSecretaria_Load(object sender, EventArgs e)
        {
            ListarCadastros();
            Estilo();
        }

        public void ListarCadastros()
        {
            novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
            dtgCadastro.DataSource = novoCadastro.Listar();
        }

        public void Estilo()
        {
            for (int i = 0; i < dtgCadastro.Rows.Count; i += 2)
            {
                dtgCadastro.Rows[i].DefaultCellStyle.BackColor = Color.PeachPuff;
            }
            for (int i = 1; i < dtgCadastro.Rows.Count; i += 2)
            {
                dtgCadastro.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
            }
        }

        private void btnPesquisaAvancada_Click(object sender, EventArgs e)
        {
            frmPesquisaAvancada formularioPesquisaAvancada = new frmPesquisaAvancada();
            formularioPesquisaAvancada.Show();
        }

        private void txtPesquisaRápida_TextChanged(object sender, EventArgs e)
        {
            //Pesquisa Rápida
            //Faltou a pesquisa por Setor - Só por número.
            try
            {
                string pesquisa = txtPesquisaRápida.Text;

                novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
                novoCadastro.PesquisarNomeCadastro(txtPesquisaRápida.Text);
                
                if (dtgCadastro.Rows.Count < 0)
                {
                    novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
                    novoCadastro.ListarCongregacaoCadastro(txtPesquisaRápida.Text);
                    
                    if (dtgCadastro.Rows.Count < 0)
                    {
                        novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
                        novoCadastro.ListarSituacaoCadastro(txtPesquisaRápida.Text);
                    }
                }
                else if (Convert.ToString(pesquisa).Trim().Length == 0)
                {
                    novoCadastro = new RegraNegocio2.CadastrosRegraNegocio();
                    novoCadastro.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro enquanto fazia a pesquisa rápida no referido campo\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }
    }
}
