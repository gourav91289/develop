/**
* Filename:  UpdateSettings.xaml.cs
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
using com.boutique.Service;
using com.boutique.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.Unity;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace com.boutique.Views
{
    /// <summary>
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class UpdateSettings : Window
    {      
        public UpdateSettings()
        {
            InitializeComponent();

            var dc = (MainViewModel)this.DataContext;
            dc.SetUpdateSettingValues();
            if (dc.CloseAction == null)
                dc.CloseAction = new Action(() => this.Close());
        }
       
        private void Settings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void CloseSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }              
     
    }
}
