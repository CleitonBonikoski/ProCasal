using Model;
using System;

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
    }
}
