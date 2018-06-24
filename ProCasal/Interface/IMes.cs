using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IMes
    {
        // Cadastrar

        void CadastrarMes();

        // Editar

        void EditarMes(DateTime IdMes);

        // Excluir

        void ExcluirMes(DateTime IdMes);

        // Listar

        List<string> ListarMes(DateTime IdMes);

    }
}
