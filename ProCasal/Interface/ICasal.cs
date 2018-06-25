using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICasal
    {
        // Cadastrar Casal

        int CadastrarCasal(int pessoaA, int pessoaB);

        // Excluir Casal

        void ExcluirPessoaCasal(int IdPessoa);

        //Editar Casal

        void EditarPessoaCasal(int IdPessoa, int comando);

        //Listar Casal

        List<string> ListarPessoaCasal(int IdCasal);


    }
}
