﻿using System;
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
        }

        private void CadastroCasal(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                CadastroMes cadastroMes = new CadastroMes();
                cadastroMes.Show();

            }
        }
    }
}
