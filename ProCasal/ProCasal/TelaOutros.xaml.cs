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
    /// Interaction logic for TelaOutros.xaml
    /// </summary>
    public partial class TelaOutros : Window
    {
        #region TelaOutros
        public TelaOutros()
        {
            InitializeComponent();
        }
        #endregion

        #region Editar
        private void EditarPessoaCadastrada(object sender, RoutedEventArgs e)
        {
            TelaEditarPessoa editarPessoa = new TelaEditarPessoa();
            editarPessoa.Show();

            Close();

        }
        #endregion

        #region Mostrar
        private void MostrarPessoaCadastrada(object sender, RoutedEventArgs e)
        {
            MostrarPessoa mostrarPessoa = new MostrarPessoa();
            mostrarPessoa.Show();
            Close();
        }
        #endregion

        #region Excluir
        private void ExcluirPessoaCadastrada(object sender, RoutedEventArgs e)
        {
            PessoaController pessoaController = new PessoaController();

            var usuario = Application.Current.Properties["_user"] as Pessoa;

            pessoaController.ExcluirPessoa(usuario.IdPessoa);

            MainWindow login = new MainWindow();
            login.Show();
            Close();

        }

        #endregion

        #region  MostrarCasal

        private void MostrarCasal(object sender, RoutedEventArgs e)
        {
            TelaApresentacaoCasal telaApresentacaoCasal = new TelaApresentacaoCasal();
            telaApresentacaoCasal.Show();
            Close();

        }



        #endregion

        #region ExcluirCasal
        private void ExcluirCasal(object sender, RoutedEventArgs e)
        {
            var usuario = Application.Current.Properties["_user"] as Pessoa;
            CasalController casalController = new CasalController();

            casalController.ExcluirCasal(usuario.IdPessoa);

            MainWindow main = new MainWindow();
            main.Show();
            Close();

        }
        #endregion  
    }
}
