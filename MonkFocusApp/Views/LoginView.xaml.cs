﻿using MonkFocusApp.ViewModels;
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

namespace MonkFocusApp.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e) //TODO REMOVE
        {
            //TextBox textBox = (TextBox)sender;
            //if (textBox.Text == textBox.Tag?.ToString())
            //{
            //    textBox.Text = string.Empty;
            //}
        }

        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e) //TODO REMOVE
        {
            //TextBox textBox = (TextBox)sender;
            //if (string.IsNullOrWhiteSpace(textBox.Text))
            //{
            //    textBox.Text = textBox.Tag?.ToString();
            //}
        }

        //private void MyTextBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;

        //    textBox.Text = "username";
        //}

        private void Username_focus(object sender, MouseButtonEventArgs e)
        {
            Username.Focus();
        }

        private void Password_focus(object sender, MouseButtonEventArgs e)
        {
            Password.Focus();
        }

        #region ButtonCosmetics

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Border border = (Border)sender;
            border.Background = new SolidColorBrush(Color.FromArgb(255,33,84,95)); // Change to your desired hover color
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            Border border = (Border)sender;
            border.Background = new SolidColorBrush(Color.FromArgb(255,60,155,176)); // Change to your original color
        }

        #endregion


    }
}
