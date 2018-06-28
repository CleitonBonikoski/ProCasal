using Model;

namespace Controller
{
    public class PessoaController 
    {
        private Context context = new Context();

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
        

    }
}
