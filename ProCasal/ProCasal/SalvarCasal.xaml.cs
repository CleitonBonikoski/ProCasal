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

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            DataInicio.Text = "";
            PrimeiroEncontro.Text = "";
            Resumo.Text = "";
        }
    }
}
