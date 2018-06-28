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
            usuarioLogin.MaxLength = 40;
            senhaLogin.MaxLength = 14;
            pes.CadastrarPessoa();
        }

        private void CadastrarPessoa(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
            Close();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            
            if (!usuarioLogin.Text.Equals("") && senhaLogin.Password != "")
            {
                
                // Realizar validacao para login
                CadastroCasal cadastroCasal = new CadastroCasal();
                cadastroCasal.Show();
                Close();
            }

        }
    }
}
