using Model;

namespace Controller
{
    public class PessoaController 
    {
        private Context context = new Context();

        public PessoaController()
        {
            
            Pessoa pes = new Pessoa();

            pes.IdPessoa = 1;
            pes.Nome = "Joao";
            pes.SobreNome = "Silva";
            pes.DataNasc = "20/08/1992";
            pes.Sexo = "Masculino";

            context.dBpessoa.Add(pes);
            context.SaveChanges();
            
        }
        

    }
}
