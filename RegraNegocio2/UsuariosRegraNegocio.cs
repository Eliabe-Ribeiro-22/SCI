using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegraNegocio2
{
    public class UsuariosRegraNegocio
    {
        AcessoDados2.UsuariosAcessoDados novoUsuario;
        DataTable dadosTabela = new DataTable();
        Criptografia criptografia;
        
        //Método Pronto.
        public void Salvar(int idUsuario, string nome, string usuario, int nivelUsuario, string senha1, /* string senha2,*/  int status, DateTime dataCadastro)
        {
         Criptografia criptografia = new Criptografia();

            string senhaCripto = criptografia.Criptografar(senha1);
            
            novoUsuario = new AcessoDados2.UsuariosAcessoDados();
            dadosTabela = novoUsuario.RetornarUsuario(idUsuario);

            if (dadosTabela.Rows.Count == 0)
            {
                novoUsuario = new AcessoDados2.UsuariosAcessoDados();
                novoUsuario.Salvar(idUsuario, nome, usuario, nivelUsuario, senhaCripto,/*senha2,*/ status, dataCadastro); 
            }
            else
            {
                MessageBox.Show("Usuário já cadastrado \nUsuário: " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString(), "Usuário já existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //Método Validar()
        public void Validar(int idUsuario, string nome, string usuario, int nivelUsuario, string senha1, string senha2, int status, DateTime dataCadastro)
        {
            try
            {
                if (nome == "")
                {
                    throw new Exception("Digite o nome do Usuário!");
                }
                if (nome.Trim().Length == 0)
                {
                    throw new Exception("Digite o nome do Usuário!");
                }
                if (usuario.Trim().Length == 0)
                {
                    throw new Exception("Digite o usuário do Login!");
                }
                if (senha1.Trim().Length == 0)
                {
                    throw new Exception("Digite a Senha!");
                }
                if (senha2.Trim().Length == 0)
                {
                    throw new Exception("Confirme a Senha!");
                }
                if (senha1.Length > 4)
                {
                    throw new Exception("A senha deve conter 4 dígitos!");
                }
                if (senha1.Length < 4)
                {
                    throw new Exception("A senha deve conter 4 dígitos!");
                }
                if (senha1 != senha2)
                {
                    throw new Exception("Os campos Senha e Confirme a Senha devem ser iguais");
                }


                if (idUsuario == -1)
                {
                    throw new Exception("O campo Código do Usuário não pode ficar vazio");
                }

                if (nivelUsuario == -1)
                {
                    throw new Exception("O campo Nível do Usuário não pode ficar vazio");
                }
                if (status == -1)
                {
                    throw new Exception("O campo Status não pode ficar vazio");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "\nOcorreu um erro no método Validar");
            }
        }

        public DataTable Login(string usuario, string senha)
        {
            //Pesquisa no banco de Dados pelos parâmetros nome e senha.
            novoUsuario = new AcessoDados2.UsuariosAcessoDados();
            novoUsuario.PesquisarUsuario(usuario, senha);
            return dadosTabela;
        }
        public void Excluir(int idUsuario)
        {
            novoUsuario = new AcessoDados2.UsuariosAcessoDados();
            novoUsuario.Excluir(idUsuario);
        }
        public void Alterar(int idUsuario, string nome, string usuario, int nivelUsuario, string senha, /* string senha2,*/  int status, DateTime dataCadastro)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                novoUsuario = new AcessoDados2.UsuariosAcessoDados();
                //Acho que não preciso da linha de código abaixo;
                // dadosTabela = novoUsuario.RetornarUsuario(idUsuario);

                //FAZER O MÉTODO RetornarLogin() na AcessoDados2.UsuariosAcessoDados().
                dadosTabela = novoUsuario.RetornarLogin(usuario);

                if (dadosTabela.Rows.Count > 0)
                {
                    novoUsuario = new AcessoDados2.UsuariosAcessoDados();

                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_USUARIO"]) == idUsuario)
                        {
                            if (senha == dadosTabela.Rows[i]["SENHA_USUARIO"].ToString().Substring(0, 4))
                            {
                                novoUsuario.Alterar(idUsuario, nome, usuario, nivelUsuario, dadosTabela.Rows[i]["SENHA_USUARIO"].ToString(), status, dataCadastro);
                            }
                            else
                            {
                                criptografia = new Criptografia();
                                string senhaCripto = criptografia.Criptografar(senha);

                                novoUsuario.Alterar(idUsuario, nome, usuario, nivelUsuario, senhaCripto, /*senha2*/ status, dataCadastro);
                            }                  
                        }
                        else
                        {
                            throw new Exception("Este login já foi utilizado, cadastre outro! \nUsuário: " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString());
                        }
                    }
                }
                else // Senão constar no dadosTabela.
                {
                    novoUsuario = new AcessoDados2.UsuariosAcessoDados();
                    dadosTabela = novoUsuario.RetornarUsuario(idUsuario);


                    if (senha == dadosTabela.Rows[0]["SENHA_USUARIO"].ToString().Substring(0, 4))
                    {
                        novoUsuario.Alterar(idUsuario, nome, usuario, nivelUsuario, dadosTabela.Rows[0]["SENHA_USUARIO"].ToString(), status, dataCadastro);
                    }
                    else
                    {
                        criptografia = new Criptografia();
                        string senhaCripto = criptografia.Criptografar(senha);

                        novoUsuario.Alterar(idUsuario, nome, usuario, nivelUsuario, senhaCripto, status, dataCadastro);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Ocorreu um erro no Alterar da Camada Regra de Negócios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RetornarUsuario(int idUsuario)
        {
            novoUsuario = new AcessoDados2.UsuariosAcessoDados();
         /*   novoUsuario.RetornarUsuarios(idUsuario); //Falta fazer o referido método na Camada AcessoDados, que fará a Pesquisa pelo IdUsuario. */
        }
    }
 
}
