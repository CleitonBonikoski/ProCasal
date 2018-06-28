using System.ComponentModel.DataAnnotations;

namespace Model
{   
    
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string DataNasc { get; set; }

        public string Sexo { get; set; }

    }

}
