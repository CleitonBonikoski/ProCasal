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

        #region Start Tela
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Ir Tela Cadastrar Pessoa
        private void CadastrarPessoa(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
            Close();
        }
        #endregion

        #region Validar Login

        private void Login(object sender, RoutedEventArgs e)
        {
            
            if (!nomeLogin.Text.Equals("") && !sobreNomeLogin.Text.Equals(""))
            {                
                if (pes.ValidacaoLogin(nomeLogin.Text, sobreNomeLogin.Text))
                {
                    CadastroCasal cadastroCasal = new CadastroCasal();
                    cadastroCasal.Show();
                    Close();
                }
                nomeLogin.Text = "";
                sobreNomeLogin.Text = "";
            }
        }

        #endregion

    }
}
