/**
* Filename:  Reports.xaml.cs
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
using com.boutique.Model;

namespace com.boutique.Views
{
    public partial class Reports : Window
    {
        public Reports()
        {
            InitializeComponent();

            var dc = (ReportViewModel)this.DataContext;
            dc.SetReportTypes();

            if (dc.CloseAction == null)
                dc.CloseAction = new Action(() => this.Close());

            txtFileName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "FileName");
            txtFileName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "FileName");

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
                case "FileName":
                    if (tb.Text.ToLower().Trim() == "enter file name")
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
                case "FileName":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter File Name";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
            }
        }

        private void genrate_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PopGenrateReportItems.IsOpen = true;
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calendar.SelectedDate.HasValue)
            {
                if (popupDateSelector.PlacementTarget is TextBox)
                {
                    var dc = (ReportViewModel)this.DataContext;
                    TextBox target = popupDateSelector.PlacementTarget as TextBox;
                    
                    if(target.Name == "txtDateTo")
                    {
                        if (string.IsNullOrEmpty(dc.FromDate))
                        {
                            dc.ShowMessage("Please select From date first");
                            return;
                        }


                        string[] date = dc.FromDate.Contains("-") ? dc.FromDate.Split('-') : dc.FromDate.Split('/');
                        var newDate = new DateTime(Convert.ToInt16(date[2]), Convert.ToInt16(date[1]), Convert.ToInt16(date[0]));

                        if( newDate > calendar.SelectedDate.Value)
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
            ListView listview = (ListView)sender;

            if(listview.SelectedItem != null)
            {
                var dc = (ReportViewModel)this.DataContext;
                dc.SelectedReport = (ReportModel)listview.SelectedItem;
                PopGenrateReportItems.IsOpen = false;

                if(dc.SelectedReport.value > 0)
                {
                    dc.FromDate = string.Empty;
                    dc.ToDate = string.Empty;
                }
            }
        }       

        private void txtFolder_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            using (System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog())
            {
                dlg.Description = "Select Folder";
                dlg.RootFolder = System.Environment.SpecialFolder.MyComputer; 
                dlg.ShowNewFolderButton = true;
                System.Windows.Forms.DialogResult result = dlg.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    var dc = (ReportViewModel)this.DataContext;
                    dc.SaveFolderLocation = dlg.SelectedPath;
                    txtFolder.Foreground = Brushes.White;
                }
            }
        }

        private void btnGenrateReport_Click(object sender, RoutedEventArgs e)
        {
            var dc = (ReportViewModel)this.DataContext;
            if (dc.SelectedReport.value == 0 && string.IsNullOrEmpty(dc.FromDate))
                dc.ShowMessage("Please select atleast one type");
            else if (string.IsNullOrEmpty(dc.SaveFolderLocation.Replace("Select Folder", "")))
                dc.ShowMessage("Please select folder");
            else if (string.IsNullOrEmpty(dc.SaveFileName.Replace("Enter File Name", "")))
                dc.ShowMessage("Please enter save file name");
            else
            {
                MessageBoxResult result = MessageBox.Show("We will inform you when file will be created.Do you want to continue?", "Create CSV", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
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

                        var orders = dc.customerDetailService.GetReports(startDate, endDate, dc.userSettings.boutique.BoutiqueId);
                        if (orders != null && orders.Count > 0)
                            dc.CreateCsvFile(orders);
                        else
                            dc.ShowMessage("No records found.");
                        break;
                    case MessageBoxResult.No:
                        dc.ShowMessage("File creation aborted!");
                        break;                    
                }
            }
        }
    }
}

