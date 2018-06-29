using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class PessoaController
    {
        private Context context = new Context();

        #region cadastrar Pessoa teste

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

        public int CadastrarPessoa(string nome, string sobreNome, string dataNasc, string sexo)
        {
            Pessoa pessoaAtual = new Pessoa();
            Pessoa pessoaSession = new Pessoa();
            
            pessoaAtual.Nome = nome;
            pessoaAtual.SobreNome = sobreNome;
            pessoaAtual.DataNasc = dataNasc;
            pessoaAtual.Sexo = sexo;

            context.dBpessoa.Add(pessoaAtual);
            context.SaveChanges();

            pessoaSession = BuscarPessoa(pessoaAtual.Nome, pessoaAtual.SobreNome, pessoaAtual.DataNasc, pessoaAtual.Sexo);
            
            return pessoaSession.IdPessoa;
        }


        #endregion

        #region BuscarPessoa por parametros

        private Pessoa BuscarPessoa(string nome, string sobreNome, string dataNasc, string sexo)
        {
            return context.dBpessoa.Where(a => a.Nome == nome && a.SobreNome == sobreNome && a.DataNasc == dataNasc && a.Sexo == sexo).FirstOrDefault();
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

        #region pessoaSession

        public Pessoa pessoaSession(string identificador)
        {
            try
            {
                int identificadorP = Convert.ToInt32(identificador);
                return context.dBpessoa.Where(p => p.IdPessoa == identificadorP).FirstOrDefault();

            }
            catch (Exception)
            {

                return null;
            }
        }

        #endregion

        #region Atualizar Pessoa

        public void AtualizarPessoa(Pessoa pessoa)
        {
            context.Entry(pessoa).State =
            System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }


        #endregion

        #region Remover Pessoa

        public void ExcluirPessoa(int idPessoa)
        {
            Pessoa pessoa = context.dBpessoa.Find(idPessoa);

            if (pessoa != null)
            {
                context.dBpessoa.Remove(pessoa);
                context.SaveChanges();
            }
        }

        #endregion

    }
}
