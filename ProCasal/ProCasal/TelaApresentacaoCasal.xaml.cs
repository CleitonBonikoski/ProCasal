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
    /// Interaction logic for TelaApresentacaoCasal.xaml
    /// </summary>
    public partial class TelaApresentacaoCasal : Window
    {
        public TelaApresentacaoCasal()
        {
            InitializeComponent();
            var usuario = Application.Current.Properties["_user"] as Pessoa;

        }

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
