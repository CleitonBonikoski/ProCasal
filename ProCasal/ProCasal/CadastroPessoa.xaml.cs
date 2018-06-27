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
