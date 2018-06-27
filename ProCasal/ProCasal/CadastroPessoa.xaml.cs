using Model;
using System;
using System.Windows;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CadastroPessoa : Window
    {
        public CadastroPessoa()
        {
            InitializeComponent();
            dataNascimentoCadastroPessoa.SelectedDate = new DateTime(1985,01,01);
        }

        private void CadastroCasal(object sender, RoutedEventArgs e)
        {
            if (!nomeCadastroPessoa.Text.Equals("") && !sobreNomeCadastroPessoa.Text.Equals("") && !sexoCadastroPessoa.Text.Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = nomeCadastroPessoa.Text;
                pessoa.SobreNome = sobreNomeCadastroPessoa.Text;
                pessoa.DataNasc = dataNascimentoCadastroPessoa.Text;
                pessoa.Sexo = sexoCadastroPessoa.Text;

                CadastroCasal cadastroCasal = new CadastroCasal();
                cadastroCasal.Show();

                Close();

            }
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
