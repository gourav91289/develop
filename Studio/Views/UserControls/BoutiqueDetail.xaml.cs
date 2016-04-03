/**
* Filename:  BoutiqueDetail.xaml.cs
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

using com.boutique.Entity;
using com.boutique.ViewModel;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace com.boutique.Views.UserControls
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class BoutiqueDetail : UserControl
    {
        public BoutiqueDetail()
        {
            InitializeComponent();

            txtName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Name");
            txtName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Name");

            txtAddress.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Address");
            txtAddress.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Address");

            txtlandline.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "landline");
            txtlandline.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "landline");

            txtPhoneNumber.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Phone");
            txtPhoneNumber.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Phone");
        }

        private async void btnUpdateBoutiqueInformation_Click(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            dc.LoadinDataContentPopup = true;            
            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    if (string.IsNullOrEmpty(dc.Name) || dc.Name == "Enter boutique name")
                    {
                        txtName.Focus();
                        FocusManager.SetFocusedElement(this, txtName);
                        Keyboard.Focus(txtName);

                        txtName.Foreground = Brushes.Black;
                    }
                    else
                    {
                        var boutique = dc.boutiqueService.GetBoutiqueById(dc.userSettings.boutique.BoutiqueId);

                        boutique.Name = dc.Name;
                        boutique.LastUpdatedOn = DateTime.Now;
                        boutique.Address = (dc.boutiqueInformation.Address != "Enter Boutique Address" ? dc.boutiqueInformation.Address : string.Empty);
                        boutique.PhoneNumber = (dc.boutiqueInformation.PhoneNumber != "Enter Phone Number" ? dc.boutiqueInformation.PhoneNumber : string.Empty);
                        boutique.LandlineNumber = (dc.boutiqueInformation.LandlineNumber != "Enter Landline Number" ? dc.boutiqueInformation.LandlineNumber : string.Empty);

                        boutique = dc.boutiqueService.AddUpdateBoutique(boutique);
                        dc.userSettings.boutique = boutique;

                        dc.SaveSettings(dc.userSettings);
                        dc.userSettings = dc.RetriveSettings();
                    }

                    dc.LoadinDataContentPopup = false;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnCancelBoutiqueInformation_Click(object sender, RoutedEventArgs e)
        {
            var win = Window.GetWindow(this) as UpdateSettings;
            win.Close();
        }

        private void TextGotFocus(object sender, EventArgs e, string key)
        {
            TextBox tb = (TextBox)sender;
            switch (key)
            {               
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
    }
}
