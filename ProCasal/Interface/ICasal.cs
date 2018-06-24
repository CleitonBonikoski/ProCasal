using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICasal : IMes
    {
        // Cadastrar

        void CadastrarPessoaA();
        void CadastrarPessoaB();

        // Excluir
        void ExcluirPessoaA(int IdPessoaA);
        void ExcluirPessoaB(int IdPessoaB);

        //Editar
        void EditarPessoaA(int IdPessoaA);
        void EditarPessoaB(int IdPessoaB);

        //Listar
        List<string> ListarPessoaA(int IdPessoaA);
        List<string> ListarPessoaB(int IdPessoaB);


    }
}
