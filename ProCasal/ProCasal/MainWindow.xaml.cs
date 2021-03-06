﻿using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PessoaController pessoaController = new PessoaController();

        #region Start Tela
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Ir Tela Cadastrar Pessoa
        private void CadastrarPessoa(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
            Close();
        }
        #endregion

        #region Validar Login

        private void Login(object sender, RoutedEventArgs e)
        {
            
            if (!iDLogin.Text.Equals("") && !nomeLogin.Text.Equals(""))
            {

                Application.Current.Properties["_user"] = pessoaController.pessoaSession(Convert.ToString(iDLogin.Text));

                Pessoa pessoa = pessoaController.ValidacaoLogin(iDLogin.Text, nomeLogin.Text);
                try
                {
                    if (pessoa.IdPessoa > 0)
                    {
                        CadastroCasal cadastroCasal = new CadastroCasal();
                        cadastroCasal.Show();
                        Close();
                    }
                    else
                    {
                        iDLogin.Text = "";
                        nomeLogin.Text = "";
                    }
                }
                catch (System.Exception)
                {
                    iDLogin.Text = "";
                    nomeLogin.Text = "";
                }
                             
                
            }
        }

        #endregion

    }
}
