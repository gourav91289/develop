/**
* Filename:  UserDetail.xaml.cs
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

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using com.boutique.ViewModel;
using com.boutique.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace com.boutique.Views.UserControls
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class UserDetail : UserControl
    {
        public UserDetail()
        {
            InitializeComponent();

            txtUserName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "UserName");
            txtUserName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "UserName");

            txtFirstName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "FirstName");
            txtFirstName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "FirstName");

            txtLastName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "LastName");
            txtLastName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "LastName");

        }

        private void btnCancelUpdateUserInformation_Click(object sender, RoutedEventArgs e)
        {
            var win = Window.GetWindow(this) as UpdateSettings;
            win.Close();
        }

        private async void btnUpdateUpdateUserInformation_Click(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            dc.LoadinDataContentPopup = true;           

            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);

                    if (string.IsNullOrEmpty(dc.FirstName) || dc.FirstName == "Enter FirstName")
                    {
                        txtFirstName.Focus();
                        FocusManager.SetFocusedElement(this, txtFirstName);
                        Keyboard.Focus(txtFirstName);

                        txtFirstName.Foreground = Brushes.Black;
                    }
                    else if (string.IsNullOrEmpty(dc.UserName) || dc.UserName == "Enter UserName")
                    {
                        txtUserName.Focus();
                        FocusManager.SetFocusedElement(this, txtUserName);
                        Keyboard.Focus(txtUserName);

                        txtUserName.Foreground = Brushes.Black;
                    }
                    else
                    {
                        User user = dc.userService.GetUserByGUID(dc.Base64ToGuid(dc.userSettings.Key));
                        if (user != null)
                        {
                            user.FirstName = dc.FirstName;
                            user.LastName = dc.LastName;
                            user.UserName = dc.UserName;
                            user.LastUpdatedOn = DateTime.Now;
                            dc.userService.AddUpdateUser(user);

                            dc.userSettings.Name = user.FirstName + " " + user.LastName;
                            dc.userSettings.Username = user.UserName;

                            dc.SaveSettings(dc.userSettings);
                            dc.userSettings = dc.RetriveSettings();
                        }
                    }

                    dc.LoadinDataContentPopup = false;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
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
                        tb.Text = "Enter Lastname";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }

                    break;               
            }
        }
    }
}
