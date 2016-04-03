/**
* Filename:  Setting.xaml.cs
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
    public partial class Setting : Window
    {      
        public Setting()
        {
            InitializeComponent();
            var dc = (MainViewModel)this.DataContext;

            if(dc.CloseAction == null)
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

        private void LogoutSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            dc.SignOut();
        }

        private void Measurement_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SimpleIoc.Default.IsRegistered<MainViewModel>())
                SimpleIoc.Default.Unregister<MainViewModel>();

            NewMeasurement win = new NewMeasurement();
            win.Owner = this;
            win.ShowDialog();        
        }       

        private void setting_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UpdateSettings win = new UpdateSettings();
            win.Owner = this;
            win.ShowDialog();
        }

        private void OpenChangePasswordPopUp(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            dc.IsChangePasswordOpen = true;
        }

        private void deliver_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SimpleIoc.Default.IsRegistered<OrderViewModel>())
                SimpleIoc.Default.Unregister<OrderViewModel>();
            
            OpenOrderWindow("delivery");
        }

        private void TodayOrder_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SimpleIoc.Default.IsRegistered<OrderViewModel>())
                SimpleIoc.Default.Unregister<OrderViewModel>();
            
            OpenOrderWindow("today");
        }

        private void Invoice_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SimpleIoc.Default.IsRegistered<OrderViewModel>())
                SimpleIoc.Default.Unregister<OrderViewModel>();

            OpenOrderWindow("all");
        }

        private void OpenOrderWindow(string val)
        {
            Order win = new Order(val);
            win.Owner = this;
            win.ShowDialog();
        }

        private void report_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SimpleIoc.Default.IsRegistered<ReportViewModel>())
                SimpleIoc.Default.Unregister<ReportViewModel>();

            Reports win = new Reports();
            win.Owner = this;
            win.ShowDialog();
        }
    }
}
