using Model;
using System;
using System.Linq;

namespace Controller
{
    public class CasalController
    {
        private Context context = new Context();

        #region CadastrarCasal

        public void CadastrarCasal(string dataInicio, string primeiroEncontro,int idPessoaA, int idPessoaB, string resumo)
        {
            Casal casal = new Casal();

            casal.DataInicio = dataInicio;
            casal.PrimeiroEncontro = primeiroEncontro;
            casal.MesAtual = Convert.ToString(DateTime.Today);
            casal.idPessoaA = idPessoaA;
            casal.idPessoaB = idPessoaB;
            casal.Resumo = resumo;

            context.dBcasal.Add(casal);
            context.SaveChanges();
        }

        #endregion

        #region BuscarCasal

        public Casal BuscarCasal(int idPessoaA)
        {
            return context.dBcasal.Where(a => a.idPessoaA  == idPessoaA ).FirstOrDefault();
        }

        #endregion

        #region Remover Casal

        public void ExcluirCasal(int idPessoa)
        {
            PessoaController pessoaController = new PessoaController();
            CasalController casalController = new CasalController();
            Casal casal = new Casal();
            casal = casalController.BuscarCasal(idPessoa);

            if (casal != null)
            {
                context.dBcasal.Remove(casal);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
