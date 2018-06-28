using Controller;
using Model;
using System.Collections.Generic;
using System.Windows;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PessoaController pes = new PessoaController();
        List<Pessoa> lstPessoa = new List<Pessoa>();

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
            
            if (!iDLogin.Text.Equals("") && !nomeLogin.Text.Equals(""))
            {
                foreach (var item in pes.ValidacaoLogin(iDLogin.Text, nomeLogin.Text))
                {
                    lstPessoa.Add(item);
                }

                if (lstPessoa.Count>0)
                {
                    CadastroCasal cadastroCasal = new CadastroCasal();
                    cadastroCasal.Show();
                    Close();
                }
                else
                {
                    iDLogin.Text = "";
                    nomeLogin.Text = "";
                }               
                
            }
        }

        #endregion

    }
}
