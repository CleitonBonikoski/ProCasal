﻿using Controller;
using Model;
using System;
using System.Windows;
using System.Windows.Media;

namespace ProCasal
{
    /// <summary>
    /// Interaction logic for ValidacaoLogin.xaml
    /// </summary>
    public partial class CadastroCasal : Window
    {
        PessoaController pessoaController = new PessoaController();

        #region CadastroCasal

        public CadastroCasal()
        {
            InitializeComponent();
        }

        #endregion

        #region SetParmCadastro

        private void SetParmCadastro(object sender, RoutedEventArgs e)
        {
            var usuario = Application.Current.Properties["_user"] as Pessoa;
            var usuarioB = Application.Current.Properties["_userB"] as Pessoa;

            #region Mostrar campos PessoaA
            if (usuario.IdPessoa>0)
            {
                #region Mostrar Campos de Identificacao

                lbId.Visibility = Visibility;
                lbnome.Visibility = Visibility;
                lbsobreNome.Visibility = Visibility;
                lbdataNasc.Visibility = Visibility;
                lbsexo.Visibility = Visibility;

                #endregion
                
                IdPessoaA.Visibility = Visibility;
                IdPessoaA.Text = Convert.ToString(usuario.IdPessoa);

                nomePessoaA.Visibility = Visibility;
                nomePessoaA.Text = usuario.Nome;

                sobreNomePessoaA.Visibility = Visibility;
                sobreNomePessoaA.Text = usuario.SobreNome;

                dataNascimentoPessoaA.Visibility = Visibility;
                dataNascimentoPessoaA.Text = usuario.DataNasc;

                sexoPessoaA.Visibility = Visibility;
                sexoPessoaA.Text = usuario.Sexo;

                ValidaSexo();

                btnMostrarCampos.Visibility = Visibility.Hidden;
            }
            #endregion

            #region Mostrar campos PessoaB
            if (usuarioB.IdPessoa > 0)
            {
                IdPessoaB.Visibility = Visibility;
                IdPessoaB.Text = Convert.ToString(usuario.IdPessoa);

                nomePessoaB.Visibility = Visibility;
                nomePessoaB.Text = usuario.Nome;

                sobreNomePessoaB.Visibility = Visibility;
                sobreNomePessoaB.Text = usuario.SobreNome;

                dataNascimentoPessoaB.Visibility = Visibility;
                dataNascimentoPessoaB.Text = usuario.DataNasc;

                sexoPessoaB.Visibility = Visibility;
                sexoPessoaB.Text = usuario.Sexo;

                ValidaSexo();

            }
            else
            {
                btnCadastrarPessoa.Visibility = Visibility;
            }
            #endregion

        }

        #endregion

        #region ValidaSexo
        public void ValidaSexo()
        {
            if (sexoPessoaA.Text.ToLower().Contains("mul"))
            {
                IdPessoaA.Foreground = Brushes.Pink;

                nomePessoaA.Foreground = Brushes.Pink;

                sobreNomePessoaA.Foreground = Brushes.Pink;

                dataNascimentoPessoaA.Foreground = Brushes.Pink;

                sexoPessoaA.Foreground = Brushes.Pink;

            }

            if (sexoPessoaB.Text.ToLower().Contains("mul"))
            {
                IdPessoaB.Foreground = Brushes.Pink;

                nomePessoaB.Foreground = Brushes.Pink;

                sobreNomePessoaB.Foreground = Brushes.Pink;

                dataNascimentoPessoaB.Foreground = Brushes.Pink;

                sexoPessoaB.Foreground = Brushes.Pink;
            }
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

        #region VoltarCadastroPessoa

        private void VoltarCadastroPessoa(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
            Close();
        }



        #endregion


    }
}
