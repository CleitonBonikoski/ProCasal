using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for SalvarCasal.xaml
    /// </summary>
    public partial class SalvarCasal : Window
    {
        #region SalvarCasal

        public SalvarCasal()
        {
            InitializeComponent();

            var usuario = Application.Current.Properties["_user"] as Pessoa;
            var usuarioB = Application.Current.Properties["_userB"] as Pessoa;

            txbPessoaA.Text = usuario.Nome;
            txbPessoaB.Text = usuarioB.Nome;

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

        #region btnLimpar_Click
        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            DataInicio.Text = "";
            PrimeiroEncontro.Text = "";
            Resumo.Text = "";
        }


        #endregion

        #region SalvarCasalnoBanco

        public void SalvarCasalnoBanco(object sender, RoutedEventArgs e)
        {
            CasalController casalController = new CasalController();

            var usuario = Application.Current.Properties["_user"] as Pessoa;
            var usuarioB = Application.Current.Properties["_userB"] as Pessoa;

            casalController.CadastrarCasal(DataInicio.Text, PrimeiroEncontro.Text, usuario.IdPessoa, usuarioB.IdPessoa, Resumo.Text);

            CadastroCasal cadastroCasal = new CadastroCasal();

            cadastroCasal.Show();

            Close();

        }

        #endregion

    }
}
