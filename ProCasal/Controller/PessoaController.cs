﻿using Model;
using System.Collections.Generic;

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
            pessoa.Nome = "Joao";
            pessoa.SobreNome = "Silva";
            pessoa.DataNasc = "20/08/1992";
            pessoa.Sexo = "Masculino";

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

            lstPessoas.Add(pessoaAtual);

        }

        #endregion

        #region ValidacaoLogin

        public bool ValidacaoLogin(string nome, string sobreNome)
        {            
            foreach (var item in lstPessoas)
            {
                if(item.Nome.Equals(nome) && item.SobreNome.Equals(sobreNome))
                {
                    return true;
                }                
            }
            return false;            
        }

        #endregion
        
    }
}
