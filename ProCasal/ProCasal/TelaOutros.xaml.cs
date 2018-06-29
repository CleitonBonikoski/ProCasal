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

        }
        #endregion

    }
}
