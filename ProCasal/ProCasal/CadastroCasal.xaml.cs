using Controller;
using Model;
using System;
using System.Windows;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for ValidacaoLogin.xaml
    /// </summary>
    public partial class CadastroCasal : Window
    {
        PessoaController pessoaController = new PessoaController();

        #region CadastroCasal

        public CadastroCasal()
        {
            InitializeComponent();

        }

        #endregion

        #region SetParmCadastro
        public void SetParmCadastro()
        {
            var usuario = Application.Current.Properties["_user"] as Pessoa;
            IdPessoaA.Text = Convert.ToString(usuario.IdPessoa);
            txbPessoaA.Text = usuario.Nome;
        }
        #endregion

        #region VoltarLogin

        private void VoltarLogin(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            Close();
        }

        #endregion

        #region VoltarCadastroPessoa

        private void VoltarCadastroPessoa(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
            Close();
        }

        #endregion



    }
}
