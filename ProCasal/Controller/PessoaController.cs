using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class PessoaController 
    {
        List<Pessoa> lstPessoas = new List<Pessoa>();
        private Context context = new Context();

        #region cadastrar Pessoa

        public void CadastrarPessoa()
        {
            Pessoa pessoa = new Pessoa();

            pessoa.IdPessoa = 1;
            pessoa.Nome = "Teste";
            pessoa.SobreNome = "Teste";
            string dataAtual = Convert.ToString(DateTime.Today);
            pessoa.DataNasc = dataAtual;
            pessoa.Sexo = " M - F ";

            context.dBpessoa.Add(pessoa);
            context.SaveChanges();
            
        }
        #endregion

        #region CadastrarPessoa Com Parametros

        public void CadastrarPessoa(string nome, string sobreNome, string dataNasc, string sexo)
        {
            Pessoa pessoaAtual = new Pessoa();

            pessoaAtual.Nome = nome;
            pessoaAtual.SobreNome = sobreNome;
            pessoaAtual.DataNasc = dataNasc;
            pessoaAtual.Sexo = sexo;

            context.dBpessoa.Add(pessoaAtual);
            context.SaveChanges();

            lstPessoas.Add(pessoaAtual);

        }

        #endregion

        #region ValidacaoLogin

        public Pessoa ValidacaoLogin(string ID, string nome)
        {
            try
            {
                int IDPesquisa = Convert.ToInt32(ID);
                return context.dBpessoa.Where(a => a.IdPessoa == IDPesquisa && a.Nome == nome).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;                
            }
        }

        #endregion

    }
}
