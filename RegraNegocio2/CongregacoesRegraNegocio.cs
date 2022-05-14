using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio2
{
    public class CongregacoesRegraNegocio
    {
        DataTable dadosTabela = new DataTable();
        public void SalvarCongregacao(int idCongregacao, string congregacao, int idSetor, string nomeSetor, string Dirigente1, string Dirigente2)
        {
            try
            {
                AcessoDados2.CongregacoesAcessoDados novaCongregacao = new AcessoDados2.CongregacoesAcessoDados();
                novaCongregacao.SalvarCongregacao(idCongregacao, congregacao, idSetor, nomeSetor, Dirigente1, Dirigente2);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "Ocorreu um erro no Método SalvarCongregacao do Regra Negocio");
            }
            //Falta Fazer o Validar
            // Validar();
           
            
        }
        public void ExcluirCongregacao(int idCongregacao)
        {
            AcessoDados2.CongregacoesAcessoDados novaCongregacao = new AcessoDados2.CongregacoesAcessoDados();
            novaCongregacao.ExcluirCongregacao(idCongregacao);
           
        }

    /*    public void Validar()
        {

        } */
        public void AlterarCongregacao(int idCongregacao, string congregacao, int idSetor, string nomeSetor, string Dirigente1, string Dirigente2)
        {
            // Validar();
            AcessoDados2.CongregacoesAcessoDados novaCongregacao = new AcessoDados2.CongregacoesAcessoDados();
            novaCongregacao.AlterarCongregacao(idCongregacao, congregacao, idSetor, nomeSetor, Dirigente1, Dirigente2);
        }

       public DataTable ListarCongregacao()
        {
            AcessoDados2.CongregacoesAcessoDados novaCongregacao = new AcessoDados2.CongregacoesAcessoDados();
            novaCongregacao.ListarCongregacao();
            return dadosTabela;
        }
   
    }
}
