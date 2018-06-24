using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Casal
    {
        public DateTime DataInicio { get; set; }

        public string PrimeiroEncontro { get; set; }

        public DateTime MesAtual { get; set; }

        Pessoa pessoaA = new Pessoa();

        Pessoa pessoaB = new Pessoa();

        public string Resumo { get; set; }

    }
}
