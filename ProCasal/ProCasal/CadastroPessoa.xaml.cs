using System.Data.Entity.Migrations.Model;
using System;
using System.Windows;
using Controller;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CadastroPessoa : Window
    {
        PessoaController pessoaController = new PessoaController();

        public CadastroPessoa()
        {
            InitializeComponent();
            dataNascimentoCadastroPessoa.SelectedDate = new DateTime(1985,01,01);
        }

        private void CadastroDePessoa(object sender, RoutedEventArgs e)
        {
            pessoaController.CadastrarPessoa(nomeCadastroPessoa.Text,sobreNomeCadastroPessoa.Text,dataNascimentoCadastroPessoa.Text,sexoCadastroPessoa.Text);

        }

        private void LimparCampos(object sender, RoutedEventArgs e)
        {
            LimparCamposCadastroPessoa();
        }

        public void LimparCamposCadastroPessoa()
        {
            nomeCadastroPessoa.Text = "";
            sobreNomeCadastroPessoa.Text = "";
            dataNascimentoCadastroPessoa.Text = "";
            sexoCadastroPessoa.Text = "";
        }
    }
}
