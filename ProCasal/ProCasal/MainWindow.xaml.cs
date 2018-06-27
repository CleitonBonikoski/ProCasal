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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            usuarioLogin.MaxLength = 40;
            senhaLogin.MaxLength = 14;
        }

        private void CadastrarPessoa(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
            Close();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            
            if (!usuarioLogin.Text.Equals("") && senhaLogin.Password != "")
            {
                
                // Realizar validacao para login
                CadastroCasal cadastroCasal = new CadastroCasal();
                cadastroCasal.Show();
                Close();
            }

            
            
        }
    }
}
