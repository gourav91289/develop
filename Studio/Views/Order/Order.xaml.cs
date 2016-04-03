/**
* Filename:  Order.xaml.cs
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
using System.Linq;
using com.boutique.Model;
using GalaSoft.MvvmLight.Ioc;

namespace com.boutique.Views
{
    public partial class Order : Window
    {
        #region for Internal Properties
        
        private static int _Page = 1;
        public static int Page
        {
            get { return _Page; }
            set { Page = value; }
        }

        private static int _Size = 30;
        public static int Size
        {
            get { return _Size; }
            set { Size = value; }
        }
        #endregion
        
        public Order()
        {
            InitializeComponent();           
        }
       
        public Order(string OrderView)
        {
            InitializeComponent();

            OrderWindow.Loaded += OrderWindow_Loaded;
            var dc = (OrderViewModel)this.DataContext;

            dc.IsTodayOrders = OrderView;

            if (dc.CloseAction == null)
                dc.CloseAction = new Action(() => this.Close());

            ListreportItem.SelectionChanged += ListreportItem_SelectionChanged;
        }       

        private void OrderWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var dc = (OrderViewModel)this.DataContext;
            switch (dc.IsTodayOrders)
            {
                case "all":
                    txtToday.Text = "View/Update Order";
                    grdSerachpanel.Visibility = Visibility.Visible;
                    OrderDataGrid.Columns[3].Visibility = Visibility.Visible;
                    OrderDataGrid.Columns[5].Visibility = Visibility.Visible;
                    break;
                case "delivery":
                    txtToday.Text = "Today Deliver Order";
                    grdSerachpanel.Visibility = Visibility.Collapsed;
                    OrderDataGrid.Columns[3].Visibility = Visibility.Collapsed;
                    OrderDataGrid.Columns[5].Visibility = Visibility.Collapsed;
                    dc.GetTodayDeliveryOrders();
                    break;
                case "today":
                    txtToday.Text = "Today Orders";
                    grdSerachpanel.Visibility = Visibility.Collapsed;
                    OrderDataGrid.Columns[3].Visibility = Visibility.Visible;
                    OrderDataGrid.Columns[5].Visibility = Visibility.Collapsed;
                    dc.GetTodayOrders();
                    break;
            }

            dc.SetReportTypes();

            ListreportItem.SelectedIndex = 1;

        }

        private void CloseSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Orderpreview_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image s = (Image)sender;
            var dc = (OrderViewModel)this.DataContext;

            var invoiceModel = new ViewModelLocator().Main;
            invoiceModel.InPritable = true;
            invoiceModel.InvoiceCustomerDetail = dc.OrderItems.Where(x => x.Id == Convert.ToInt32(s.Tag)).FirstOrDefault();

            Invoice win = new Invoice();
            win.Owner = this;
            win.ShowDialog();

        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calendar.SelectedDate.HasValue)
            {
                if (popupDateSelector.PlacementTarget is TextBox)
                {
                    var dc = (OrderViewModel)this.DataContext;
                    TextBox target = popupDateSelector.PlacementTarget as TextBox;

                    if (target.Name == "txtDateTo")
                    {
                        if (string.IsNullOrEmpty(dc.FromDate))
                        {
                            dc.ShowMessage("Please select From date first");
                            return;
                        }


                        string[] date = dc.FromDate.Contains("-") ? dc.FromDate.Split('-') : dc.FromDate.Split('/');
                        var newDate = new DateTime(Convert.ToInt16(date[2]), Convert.ToInt16(date[1]), Convert.ToInt16(date[0]));

                        if (newDate > calendar.SelectedDate.Value)
                        {
                            dc.ShowMessage("Date can not be less than From date");
                            dc.ToDate = string.Empty;
                            return;
                        }
                        else if (newDate < calendar.SelectedDate.Value.AddMonths(-6))
                        {
                            dc.ShowMessage("You can select date between 6 months");
                            dc.ToDate = string.Empty;
                            return;
                        }
                    }

                    target.Text = calendar.SelectedDate.Value.ToString("dd/MM/yyyy");
                    target.Foreground = Brushes.White;
                    popupDateSelector.IsOpen = false;
                    dc.SelectedReport = new ReportModel() { type = "Select", value = 0 };

                    if (target.Name == "txtDateTo")
                        dc.ToDate = calendar.SelectedDate.Value.ToString("dd/MM/yyyy");
                    else
                        dc.FromDate = calendar.SelectedDate.Value.ToString("dd/MM/yyyy");
                }
            }
        }

        private void genrate_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PopGenrateReportItems.IsOpen = true;
        }

        private void txtDate_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            popupDateSelector.PlacementTarget = txtBox;

            if (string.IsNullOrEmpty(txtBox.Text))
                calendar.SelectedDate = DateTime.Today;
            else
            {
                string[] date = txtBox.Text.Contains("-") ? txtBox.Text.Split('-') : txtBox.Text.Split('/');
                calendar.SelectedDate = new DateTime(Convert.ToInt16(date[2]), Convert.ToInt16(date[1]), Convert.ToInt16(date[0]));
            }

            calendar.DisplayDate = calendar.SelectedDate.Value;
            popupDateSelector.IsOpen = true;

        }

        private void ListreportItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ListSelectedItem(sender);
        }

        private void ListreportItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListSelectedItem(sender);
        }

        private void Order_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (e.OriginalSource.GetType() == typeof(ScrollViewer))
            {
                var os = ((System.Windows.RoutedEventArgs)(e)).OriginalSource as ScrollViewer;
                if (os.ScrollableHeight == 0 || os.ContentVerticalOffset == 0)
                    return;
                if (((OrderViewModel)this.DataContext).IsPagingFired && os.ScrollableHeight / 2 < os.ContentVerticalOffset)
                {
                    AppendDataToGrid();
                }
            }
            e.Handled = true;
        }

        public void AppendDataToGrid()
        {
            var dc = (OrderViewModel)this.DataContext;
            int total = 0;
            if (int.TryParse(dc.TotalOrder.ToString(), out total))
            {                
                if (total < ((Page+1)*Size))
                {
                    return;
                }
            }
            dc.GetOrders(dc.StartDate, dc.EndDate, Page, Size);
        }

        private void ListSelectedItem(object sender)
        {
            ListView listview = (ListView)sender;

            if (listview.SelectedItem != null)
            {
                var dc = (OrderViewModel)this.DataContext;
                dc.SelectedReport = (ReportModel)listview.SelectedItem;
                PopGenrateReportItems.IsOpen = false;

                if (dc.SelectedReport.value > 0)
                {
                    dc.FromDate = string.Empty;
                    dc.ToDate = string.Empty;
                }

                if(dc.IsOnLoad)
                {
                    dc.GetOrders(dc.StartDate, dc.EndDate, Page, Size);
                    dc.IsOnLoad = false;
                }
            }
        }

        private void btnSerach_Click(object sender, RoutedEventArgs e)
        {
            var dc = (OrderViewModel)this.DataContext;
            if (dc.SelectedReport.value == 0 && string.IsNullOrEmpty(dc.FromDate))
                dc.ShowMessage("Please select atleast one type");            
            else
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

                if (dc.SelectedReport.value > 0)
                {
                    switch (dc.SelectedReport.value)
                    {
                        case 2:
                            startDate = startDate.AddMonths(-1);
                            endDate = startDate.AddMonths(1).AddDays(-1);
                            break;
                        case 3:
                            startDate = startDate.AddMonths(-2);
                            endDate = startDate.AddMonths(2).AddDays(-1);
                            break;
                        case 4:
                            startDate = startDate.AddMonths(-3);
                            endDate = startDate.AddMonths(3).AddDays(-1);
                            break;
                        case 5:
                            startDate = startDate.AddMonths(-6);
                            endDate = startDate.AddMonths(6).AddDays(-1);
                            break;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(dc.FromDate))
                        startDate = DateTime.ParseExact(dc.FromDate, "dd/M/yyyy", null);
                    if (!string.IsNullOrEmpty(dc.ToDate))
                        endDate = DateTime.ParseExact(dc.ToDate, "dd/M/yyyy", null);
                }

                dc.StartDate = startDate;
                dc.EndDate = endDate;

                dc.GetOrders(startDate, endDate, Page, Size);
            }
        }

        private void Edit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SimpleIoc.Default.IsRegistered<MainViewModel>())
                SimpleIoc.Default.Unregister<MainViewModel>();

            Image s = (Image)sender;
            var dc = (OrderViewModel)this.DataContext;
            var InvoiceCustomerDetail = dc.OrderItems.Where(x => x.Id == Convert.ToInt32(s.Tag)).FirstOrDefault();

            var customerModel = new ViewModelLocator().Main;
            customerModel.SetEditableOrder(InvoiceCustomerDetail);

            NewMeasurement win = new NewMeasurement();
            this.Close();
            win.ShowDialog();
        }
    }
}

