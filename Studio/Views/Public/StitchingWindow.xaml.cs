/**
* Filename:  StitchingWindow.xaml.cs
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
using com.boutique.Common.UserInterfaceHelper;
using System.Text.RegularExpressions;
using System.Linq;
using com.boutique.Entity;
using com.boutique.Model;
using System.Collections.Generic;

namespace com.boutique.Views
{
    public partial class StitchingWindow : Window
    {
        internal int StitchingItemId { get; set; }

        public StitchingWindow()
        {
            InitializeComponent();

            var dc = (MainViewModel)this.DataContext;

            if (dc.CloseAction == null)
                dc.CloseAction = new Action(() => this.Close());

            if (dc.UpdateStitchingItem == null)
                dc.UpdateStitchingItem = new Action(() => UpdateStitchingItem());

            txtName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Name");
            txtName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Name");

            txtParameterName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "TypeName");
            txtParameterName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "TypeName");

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
                case "Name":
                    if (tb.Text.ToLower().Trim() == "enter name")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "TypeName":
                    if (tb.Text.ToLower().Trim() == "enter name")
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
            tb.FontWeight = FontWeights.SemiBold;
            switch (key)
            {
                case "Name":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Name";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "TypeName":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Name";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
            }
        }         

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtName.Text =="Enter Name" && string.IsNullOrEmpty(txtName.Name))
            {
                return;
            }
            else
            {
                var dc = (MainViewModel)this.DataContext;
                dc.stitchingService.AddUpdateStitchingItem(new Entity.StitchingItem() {
                    Name = txtName.Text,
                    CreateOn = DateTime.Now,
                    LastUpdatedOn = DateTime.Now,
                    IsDeleted = false,
                    BoutiqueId = dc.userSettings.boutique.BoutiqueId
            });
                //this.Close();
                dc.UpdateDataContext();
            }
        }

        private void Delete_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image s = (Image)sender;
            var dc = (MainViewModel)this.DataContext;
            var stitchingItem = dc.StitchingItem.Where(x => x.Id == Convert.ToInt32(s.Tag)).FirstOrDefault();
            stitchingItem.IsDeleted = true;
            dc.stitchingService.AddUpdateStitchingItem(stitchingItem);
            dc.StitchingItem = dc.stitchingService.GetAllstitchingItems(dc.userSettings.boutique.BoutiqueId);
        }

        private void Edit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image s = (Image)sender;
            var dc = (MainViewModel)this.DataContext;
            dc.GridSeletedStitchingItem = dc.StitchingItem.Where(x => x.Id == Convert.ToInt32(s.Tag)).FirstOrDefault();
            UpdateStitchingItem();
        }

        private void UpdateStitchingItem()
        {
            var dc = (MainViewModel)this.DataContext;

            txtName.Text = dc.GridSeletedStitchingItem.Name;
            txtName.Focus();
            FocusManager.SetFocusedElement(this, txtName);
            Keyboard.Focus(txtName);

            btnAddNew.Visibility = Visibility.Collapsed;
            stcUpdatePanel.Visibility = Visibility.Visible;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "Enter Name" && string.IsNullOrEmpty(txtName.Name))
            {
                txtName.Focus();
                return;
            }
            else
            {
                var dc = (MainViewModel)this.DataContext;
                var stitchingItem = dc.StitchingItem.Where(x => x.Id == dc.GridSeletedStitchingItem.Id).FirstOrDefault();
                stitchingItem.Name = txtName.Text;
                stitchingItem.LastUpdatedOn = DateTime.Now;
                stitchingItem.IsDeleted = false;
                dc.stitchingService.AddUpdateStitchingItem(stitchingItem);
                dc.StitchingItem = dc.stitchingService.GetAllstitchingItems(dc.userSettings.boutique.BoutiqueId);

                btnAddNew.Visibility = Visibility.Visible;
                stcUpdatePanel.Visibility = Visibility.Collapsed;
                dc.GridSeletedStitchingItem = new Entity.StitchingItem();

                txtName.Text = "Enter Name";
                txtName.FontWeight = FontWeights.Normal;
                txtName.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#c6c6c6"));
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            txtName.Text = "Enter Name";
            txtName.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
            btnAddNew.Visibility = Visibility.Visible;
            stcUpdatePanel.Visibility = Visibility.Collapsed;
            dc.GridSeletedStitchingItem = new Entity.StitchingItem();
        }

        private void ButtonAddMeasurement_Click(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;

            if (txtParameterName.Text == "Enter Name" || string.IsNullOrEmpty(txtParameterName.Text))
            {
                dc.ShowMessage("Please enter measurement name");
                return;
            }
            else
            {
                AddParameter(dc.stitchingService.AddUpdateStitchingParameterItem(new Entity.ParameterType()
                {
                    Name = txtParameterName.Text,
                    CreateOn = DateTime.Now,
                    LastUpdatedOn = DateTime.Now,
                    IsDeleted = false,
                    BoutiqueId = dc.userSettings.boutique.BoutiqueId
                }));                
                txtParameterName.Text = "Enter Name";
                txtParameterName.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#c6c6c6"));

                PopUpMeasurementItems.IsOpen = false;
                PopUpMeasurementItems.PlacementTarget = PopUpMeasurementItems.PlacementTarget;
                
            }
        }

        private void AddParameter(ParameterType type)
        {      
            if (StitchingItemId > 0)
            {
                var vm = (MainViewModel)this.DataContext;

                var stitchingItem = vm.stitchingService.GetStitchingItem(type.BoutiqueId, StitchingItemId);

                if (stitchingItem.ParameterTypes == null)
                    stitchingItem.ParameterTypes = new List<ParameterType>();

                stitchingItem.ParameterTypes.Add(type);

                vm.Parameters = vm.stitchingService.AddUpdateStitchingItem(stitchingItem).ParameterTypes;

                vm.StitchingItem = vm.stitchingService.GetAllUndeletedstitchingItems(vm.userSettings.boutique.BoutiqueId);
            }
        }

        private void AddParameter_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PopUpMeasurementItems.PlacementTarget = (TextBlock)sender;
            PopUpMeasurementItems.IsOpen = true;
            StitchingItemId = Convert.ToInt32(((TextBlock)sender).Tag);
            var dc = (MainViewModel)this.DataContext;
            dc.Parameters = dc.stitchingService.GetAllParameterTypes(dc.userSettings.boutique.BoutiqueId, StitchingItemId);
        }

        private void ClosePopUp_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PopUpMeasurementItems.IsOpen = false;
        }

        private void PopUpMeasurementItems_Closed(object sender, EventArgs e)
        {

        }
    }
}

