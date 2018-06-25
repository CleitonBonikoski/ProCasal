﻿using System.Collections.Generic;

namespace Interface
{
    interface IPessoa
    {
        // Cadastrar

        int CadastrarPessoa();

       // Excluir

        void ExcluirPessoa(int IdPessoa);

        //Editar

        void EditarPessoa(int IdPessoa);

        //Listar

        List<string> ListarPessoa(int IdPessoa);

    }
}
