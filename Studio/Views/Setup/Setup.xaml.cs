/**
* Filename:  Setup.xaml.cs
*
* Copyright 2015 - 2016 Oman Infotech Incorporated
* All Rights Reserved.
*
* NOTICE:  All information contained herein is, and remains
* the property of Oman Infotech Incorporated and its suppliers,
* if any. The intellectual and technical concepts contained
* herein are proprietary to Oman Infotech Incorporated
* and its suppliers and may be covered by India, U.S. and Foreign Patents,
* patents in process, and are protected by trade secret or copyright law.
* Dissemination of this information or reproduction of this material
* is unlawful and strictly forbidden unless prior written permission is obtained
* from Oman Infotech.
*
*/

using com.boutique.ViewModel;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace com.boutique.Views
{
    /// <summary>
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class Setup : Window
    {
        public Setup()
        {
            InitializeComponent();          
            Loaded += SetupWindow_Loaded;

            var vm = (SetupViewModel)this.DataContext;

            if (vm.CloseAction == null)
                vm.CloseAction = new Action(() => this.Close());

            if (vm.ReturnToUserName == null)
                vm.ReturnToUserName = new Action(() =>
                {
                    btnPreviousBoutiqueInformation_Click(null, null);
                    vm.ShowMessage("Username already exists.");
                });

            txtUserName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "UserName");
            txtUserName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "UserName");

            txtFirstName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "FirstName");
            txtFirstName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "FirstName");

            txtLastName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "LastName");
            txtLastName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "LastName");

            txtName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Name");
            txtName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Name");

            txtAddress.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Address");
            txtAddress.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Address");

            txtlandline.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "landline");
            txtlandline.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "landline");

            txtPhoneNumber.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Phone");
            txtPhoneNumber.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Phone");
        }

        private void SetupWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var dc = (SetupViewModel)this.DataContext;
            CheckIsAppInstalled(dc);
        }

        private void CheckIsAppInstalled(SetupViewModel dc)
        {
            if (dc.userSettings == null || string.IsNullOrEmpty(dc.userSettings.Key))
            {
                dc.Configuration = "Please wait while we setup app for first use";
                PopUpSetUp.IsOpen = true;
            }
            else
            {
                dc.Configuration = "Please wait";
                PopUpSetUp.IsOpen = false;
                dc.PrepareSetUp();
            }
        }

        private void SetUpWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnNextUserInformation_Click(object sender, RoutedEventArgs e)
        {
            var dc = (SetupViewModel)this.DataContext;

            if (string.IsNullOrEmpty(dc.FirstName) || dc.FirstName == "Enter FirstName")
            {  
                txtFirstName.Focus();
                FocusManager.SetFocusedElement(this, txtFirstName);
                Keyboard.Focus(txtFirstName);

                txtFirstName.Foreground = Brushes.White;
            }
            else if (string.IsNullOrEmpty(dc.UserName) || dc.UserName == "Enter Username")
            {
                txtUserName.Focus();
                FocusManager.SetFocusedElement(this, txtUserName);
                Keyboard.Focus(txtUserName);

                txtUserName.Foreground = Brushes.White;
            }
            else if (string.IsNullOrEmpty(dc.Password))
            {
                txtPassword.Focus();
                FocusManager.SetFocusedElement(this, txtPassword);
                Keyboard.Focus(txtPassword);

                txtPassword.Foreground = Brushes.White;
            }
            else
            {
                SendingAssetsreachEngine.Value = 50;
                grdUserdetails.Visibility = Visibility.Collapsed;
                grdBoutiquedetails.Visibility = Visibility.Visible;

                txtName.Focus();
                FocusManager.SetFocusedElement(this, txtName);
                Keyboard.Focus(txtName);

                txtName.Foreground = Brushes.White;
            }
            
        }

        private void btnCancelUserInformation_Click(object sender, RoutedEventArgs e)
        {
            PopUpSetUp.IsOpen = false;
            this.Close();
        }

        private void btnPreviousBoutiqueInformation_Click(object sender, RoutedEventArgs e)
        {
            grdUserdetails.Visibility = Visibility.Visible;
            grdBoutiquedetails.Visibility = Visibility.Collapsed;

            txtFirstName.Focus();
            FocusManager.SetFocusedElement(this, txtFirstName);
            Keyboard.Focus(txtFirstName);

            txtFirstName.Foreground = Brushes.White;
        }

        private void btnFinsihBoutiqueInformation_Click(object sender, RoutedEventArgs e)
        {
            var dc = (SetupViewModel)this.DataContext;

            if (string.IsNullOrEmpty(dc.Name) || dc.Name == "Enter boutique name")
            {
                txtName.Focus();
                FocusManager.SetFocusedElement(this, txtName);
                Keyboard.Focus(txtName);

                txtName.Foreground = Brushes.White;
            }
            else
            {
                SendingAssetsreachEngine.Value = 100;
                Thread.Sleep(1000);
                dc.boutiqueInformation.Name = dc.Name;
                dc.boutiqueInformation.BillStartNumber = 1000;
                dc.boutiqueInformation.CreateOn = DateTime.Now;
                dc.boutiqueInformation.LastUpdatedOn = DateTime.Now;
                dc.boutiqueInformation.IsDeleted = false;
                dc.boutiqueInformation.Address = (dc.boutiqueInformation.Address != "Enter Boutique Address" ? dc.boutiqueInformation.Address : string.Empty);
                dc.boutiqueInformation.PhoneNumber = (dc.boutiqueInformation.PhoneNumber != "Enter Phone Number" ? dc.boutiqueInformation.PhoneNumber : string.Empty);
                dc.boutiqueInformation.LandlineNumber = (dc.boutiqueInformation.LandlineNumber != "Enter Landline Number" ? dc.boutiqueInformation.LandlineNumber : string.Empty);

                PopUpSetUp.IsOpen = false;
                dc.PrepareSetUp();
            }
        }

        private void PopUpSetUp_Loaded(object sender, RoutedEventArgs e)
        {
            txtFirstName.Focus();
            FocusManager.SetFocusedElement(this, txtFirstName);
            Keyboard.Focus(txtFirstName);
            txtFirstName.Foreground = Brushes.White;
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
                case "FirstName":
                    if (tb.Text.ToLower().Trim() == "enter firstname")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }

                    break;
                case "LastName":
                    if (tb.Text.ToLower().Trim() == "enter lastname")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }

                    break;
                case "Name":
                    if (tb.Text.ToLower().Trim() == "enter boutique name")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }

                    break;
                case "Address":
                    if (tb.Text.ToLower().Trim() == "enter boutique address")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }

                    break;
                case "landline":
                    if (tb.Text.ToLower().Trim() == "enter landline number")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }

                    break;
                case "Phone":
                    if (tb.Text.ToLower().Trim() == "enter phone number")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }

                    break;
            }
        }

        private void TextLostFocus(object sender, EventArgs e, string key)
        {
            TextBox tb = (TextBox)sender;
            switch (key)
            {
                case "UserName":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter UserName";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "FirstName":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter FirstName";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }

                    break;
                case "LastName":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter LastName";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }

                    break;
                case "Name":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Boutique Name";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Address":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Boutique Address";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "landline":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Landline Number";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Phone":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Phone Number";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            var dc = (SetupViewModel)this.DataContext;
            dc.IsExired = false;
            dc.CloseAction();
        }
    }
}

