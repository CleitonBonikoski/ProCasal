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
    /// Interaction logic for CadastroMes.xaml
    /// </summary>
    public partial class CadastroMes : Window
    {
        #region CadastroMes
        public CadastroMes()
        {
            InitializeComponent();
            diaEspecial.SelectedDate = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
        }
        #endregion

        #region Limpar Campos
        private void LimparCamposCadastroMes(object sender, RoutedEventArgs e)
        {
            diaEspecial.Text = "";
            txbLugarTop.Text = "";
            NivelFelicidade.Text = "";            
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


    }
}
