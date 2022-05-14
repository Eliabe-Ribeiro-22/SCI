using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados2
{
    public class Conexao
    {
        private static string conexao = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = SCI; Integrated Security = True";
            //Antiga String de Conexão.
         //   @"Data Source=NOTEBOOKVOLNI\SQLEXPRESS; Initial Catalog=SCI; Persist Security Info=true; Pooling = false";
      
        public static string stringConexao
        {
            get { return conexao; }
        }
        //Falta Adicionar Segurança ao Método RetornarConexao.
       public string RetornarConexao()
        {
            string stringConexao1 = stringConexao;
            return stringConexao1;
        }
      }
}
