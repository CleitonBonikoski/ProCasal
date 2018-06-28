using Controller;
using System.Windows;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PessoaController pes = new PessoaController();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CadastrarPessoa(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
            Close();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            
            if (!nomeLogin.Text.Equals("") && !sobreNomeLogin.Text.Equals(""))
            {                
                // Realizar validacao para login
                CadastroCasal cadastroCasal = new CadastroCasal();
                cadastroCasal.Show();
                Close();
            }

        }
    }
}
