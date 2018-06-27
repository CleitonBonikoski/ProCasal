using Model;
using System.Windows;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for ValidacaoLogin.xaml
    /// </summary>
    public partial class CadastroCasal : Window
    {
        public CadastroCasal()
        {
            InitializeComponent();

            Pessoa pessoa = new Pessoa();

            txbPessoaA.Text = pessoa.Nome = " Joao";

                 //txbPessoaB.Text = pessoa.Nome = " Maria";
                //pessoa.DataNasc = "20/09/1995";
                //pessoa.Sexo = "Masculino";

        }
    }
}
