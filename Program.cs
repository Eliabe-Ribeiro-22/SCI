using Sistma_de_Ctrl.de_Igr._SC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistma_de_Ctrl.de_Igr.Evang.Ass.de_Deus_SICAD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
        //    frmSplash TelaDeInicializacao = new frmSplash();
          //  TelaDeInicializacao.ShowDialog();
            
            FrmLogin formularioLogin = new FrmLogin();
            formularioLogin.ShowDialog();
           
                //Faz a verificação para a entrada de Usuários.
                /* if (formularioLogin.DialogResult == DialogResult.OK)
                 { */
                Application.Run(new FrmPrincipal(formularioLogin.idUsuario));
                /* }
                 else
                 {
                     Application.Exit();
                 } */
        }
    }
}
