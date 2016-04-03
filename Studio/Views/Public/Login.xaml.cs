/**
* Filename:  Login.xaml.cs
*
* Levels Beyond CONFIDENTIAL
*
* Copyright 2003 - 2015 Levels Beyond Incorporated
* All Rights Reserved.
*
* NOTICE:  All information contained herein is, and remains
* the property of Levels Beyond Incorporated and its suppliers,
* if any.  The intellectual and technical concepts contained
* herein are proprietary to Levels Beyond Incorporated
* and its suppliers and may be covered by U.S. and Foreign Patents,
* patents in process, and are protected by trade secret or copyright law.
* Dissemination of this information or reproduction of this material
* is unlawful and strictly forbidden unless prior written permission is obtained
* from Levels Beyond Incorporated.
*
*/

using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using com.boutique.ViewModel;
using System.Windows.Controls;
using System;

namespace com.boutique.Views
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            Loaded += LoginWindow_Loaded;

            txtUserName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "UserName");
            txtUserName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "UserName");

            txtFocusBorder.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Password");
            txtPasswordBorder.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Password");

            var dc = (LoginViewModel)this.DataContext;

            if (dc.CloseAction == null)
                dc.CloseAction = new Action(() => this.Close());

            if (dc.UserNotValid == null)
                dc.UserNotValid = new Action(() => UserNotValid());
        }

        private void LoginWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtUserName.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#cccccc")); 
            txtUserName.Focus();
            FocusManager.SetFocusedElement(this, txtUserName);
            Keyboard.Focus(txtUserName);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ValidateLoginClick();
        }

        private void CloseSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TextGotFocus(object sender, EventArgs e, string key)
        {
            TextBox tb = (TextBox)sender;
            switch (key)
            {
                case "UserName":
                    if (tb.Text.ToLower().Trim() == "enter username")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "Password":
                    if (tb.Text.ToLower().Trim() == "enter password")
                    {
                        brdrFocusBorder.Visibility = Visibility.Collapsed;
                        brderPasswordBorder.Visibility = Visibility.Visible;
                        txtPasswordBorder.Focus();
                        FocusManager.SetFocusedElement(this, txtPasswordBorder);
                        Keyboard.Focus(txtPasswordBorder);

                    }
                    break;
            }
        }

        private void TextLostFocus(object sender, EventArgs e, string key)
        {

            TextBox tb = new TextBox();

            if (sender is TextBox)
                tb = (TextBox)sender;

            switch (key)
            {
                case "UserName":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter UserName";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Password":
                    var dc = (LoginViewModel)this.DataContext;
                    if (dc.Password.ToLower().Trim() == "")
                    {
                        brdrFocusBorder.Visibility = Visibility.Visible;
                        brderPasswordBorder.Visibility = Visibility.Collapsed;
                    }
                    break;
            }
        }

        private void UserNotValid()
        {
            imgLoginProcessing.Visibility = Visibility.Collapsed;
            btnLogin.Visibility = Visibility.Visible;

            txtUserName.Focus();
            FocusManager.SetFocusedElement(this, txtUserName);
            Keyboard.Focus(txtUserName);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ValidateLoginClick();
            }
        }

        private void ValidateLoginClick()
        {
            var dc = (LoginViewModel)this.DataContext;
            if (string.IsNullOrEmpty(dc.UserName) || dc.UserName == "Enter UserName")
            {
                txtUserName.Focus();
                FocusManager.SetFocusedElement(this, txtUserName);
                Keyboard.Focus(txtUserName);
                dc.ShowMessage("Please enter username");
            }
            else if (string.IsNullOrEmpty(dc.Password))
            {
                txtFocusBorder.Focus();
                FocusManager.SetFocusedElement(this, txtFocusBorder);
                Keyboard.Focus(txtFocusBorder);
                dc.ShowMessage("Please enter password");
            }
            else
            {
                imgLoginProcessing.Visibility = Visibility.Visible;
                btnLogin.Visibility = Visibility.Collapsed;
                dc.LoginToApplication();
            }
        }
    }
}

