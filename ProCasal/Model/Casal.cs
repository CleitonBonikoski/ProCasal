using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Casal
    {
        [Key]
        public int IdCasal { get; set; }

        public string DataInicio { get; set; }

        public string PrimeiroEncontro { get; set; }

        public string MesAtual { get; set; }

        public int idPessoaA { get; set; }

        public int idPessoaB  { get; set; }

        public string Resumo { get; set; }

    }
}
