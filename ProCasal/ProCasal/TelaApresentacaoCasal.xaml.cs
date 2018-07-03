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
    /// Interaction logic for TelaApresentacaoCasal.xaml
    /// </summary>
    public partial class TelaApresentacaoCasal : Window
    {
        public TelaApresentacaoCasal()
        {
            InitializeComponent();
            var usuario = Application.Current.Properties["_user"] as Pessoa;
            CasalController casalController = new CasalController();
            Casal casal = new Casal();
            try
            {
                casal = casalController.BuscarCasal(usuario.IdPessoa);
                txtIdCasal.Text = Convert.ToString(casal.IdCasal);
                txtIdCasal.Visibility = Visibility.Visible;
                txtDataInicioCasal.Text = Convert.ToString(casal.DataInicio);
                txtDataInicioCasal.Visibility = Visibility.Visible;
                txtPrimeiroEncontroCasal.Text = Convert.ToString(casal.PrimeiroEncontro);
                txtPrimeiroEncontroCasal.Visibility = Visibility.Visible;
                txtIdPessoaACasal.Text = Convert.ToString(casal.idPessoaA);
                txtIdPessoaACasal.Visibility = Visibility.Visible;
                txtIdPessoaBCasal.Text = Convert.ToString(casal.idPessoaB);
                txtIdPessoaBCasal.Visibility = Visibility.Visible;
                txtResumoCasal.Text = Convert.ToString(casal.Resumo);
                txtResumoCasal.Visibility = Visibility.Visible;

            }
            catch (Exception)
            {

                casal.IdCasal = 0;
                casal.DataInicio = Convert.ToString(DateTime.Today);
                casal.PrimeiroEncontro = "";
                casal.MesAtual = Convert.ToString(DateTime.Today);
                casal.idPessoaA = 0;
                casal.idPessoaB = 0;
                casal.Resumo = "Casal Nao Encontrado!";


            }
            

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
