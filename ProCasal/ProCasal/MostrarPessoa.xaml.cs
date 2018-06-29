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
    /// Interaction logic for MostrarPessoa.xaml
    /// </summary>
    public partial class MostrarPessoa : Window
    {
        #region MostrarPessoa
        public MostrarPessoa()
        {
            InitializeComponent();

            var usuario = Application.Current.Properties["_user"] as Pessoa;

            lblID.Content = usuario.IdPessoa;
            lblNome.Content = usuario.Nome;
            lblSobreNome.Content = usuario.SobreNome;
            lblDataNascimento.Content = usuario.DataNasc;
            lblSexo.Content = usuario.Sexo;

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

        #region Voltar TelaOutros
        private void VoltarTelaOutros(object sender, RoutedEventArgs e)
        {
            TelaOutros telaOutros = new TelaOutros();
            telaOutros.Show();
            Close();
        }

        #endregion


    }
}
