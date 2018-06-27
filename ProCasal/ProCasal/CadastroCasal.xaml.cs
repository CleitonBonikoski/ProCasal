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
    /// Interaction logic for ValidacaoLogin.xaml
    /// </summary>
    public partial class CadastroCasal : Window
    {
        public CadastroCasal()
        {
            InitializeComponent();

            Pessoa pessoa = new Pessoa();

            txbPessoaA.Text = pessoa.Nome = " Joao";

                 //txbPessoaB.Text = pessoa.Nome = " Maria";
                //pessoa.DataNasc = "20/09/1995";
                //pessoa.Sexo = "Masculino";

        }
    }
}
