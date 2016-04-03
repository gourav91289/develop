/**
* Filename:  NewMeasurement.xaml.cs
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
using System.Windows.Data;
using com.boutique.Model;
using DropDownCustomColorPicker;
using com.boutique.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using CapturedImages;
using System.Collections.ObjectModel;

namespace com.boutique.Views
{
    public partial class NewMeasurement : Window
    {
        private Button AddMeasurementSender { get; set; }

        private List<ParameterType> AllParameterstypes { get; set; }

        public NewMeasurement()
        {
            InitializeComponent();

            var dc = (MainViewModel)this.DataContext;
            //var vm = new ViewModel.ViewModelLocator().Login;
           
            dc.boutiqueInformation = dc.userSettings.boutique;

            NewMeasurementWindow.Loaded += NewMeasurementWindow_Loaded;

            if (dc.CloseAction == null)
                dc.CloseAction = new Action(() => this.Close());

            if (dc.SetDataContextOfPopUp == null)
                dc.SetDataContextOfPopUp = new Action<string>((obj) => SetDataContext(obj));

            if (dc.UpdateDataContext == null)
                dc.UpdateDataContext = new Action(() => UpdatePopContent());

            txtCustomerName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "CustomerName");
            txtCustomerName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "CustomerName");

            txtContactNo.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "ContactNo");
            txtContactNo.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "ContactNo");

            txtAddress.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Address");
            txtAddress.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Address");

            FilterCombobox.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Serach");
            FilterCombobox.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Serach");

            txtName.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Name");
            txtName.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Name");
        }

        private void NewMeasurementWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;

            if (dc.EditableCustomerDetail.StitchingDetails != null && 
                dc.EditableCustomerDetail.StitchingDetails.Count() > 0)
                stckPanelMain.DataContext = UIHelper.Deserialize<List<StitchingMeasurementModel>>(dc.EditableCustomerDetail.StitchingDetails);
            else
                stckPanelMain.DataContext = new List<StitchingMeasurementModel>();

            if (dc.EditableCustomerDetail.EmbroideryDetails != null &&
                dc.EditableCustomerDetail.EmbroideryDetails.Count() > 0)
                stckEmbrodiaryPanelMain.DataContext = UIHelper.Deserialize<List<StitchingEmbroidaryModel>>(dc.EditableCustomerDetail.EmbroideryDetails);
            else
                stckEmbrodiaryPanelMain.DataContext = new List<StitchingEmbroidaryModel>();

            if (dc.EditableCustomerDetail.StitchingDetails != null &&
                dc.EditableCustomerDetail.StitchingDetails.Count() > 0)
            {
                foreach (var model in (List<StitchingMeasurementModel>)stckPanelMain.DataContext)
                {
                    AddStitchingSizes(model);
                }
            }
            else
                AddStitchingSizes(null);


            if (dc.EditableCustomerDetail.EmbroideryDetails != null &&
                dc.EditableCustomerDetail.EmbroideryDetails.Count() > 0)
                stckEmbrodiaryPanelMain.DataContext = UIHelper.Deserialize<List<StitchingEmbroidaryModel>>(dc.EditableCustomerDetail.EmbroideryDetails);
            {
                foreach (var model in (List<StitchingEmbroidaryModel>)stckEmbrodiaryPanelMain.DataContext)
                {
                    AddStitchingEmbroidary(model);
                }
            }

            //AddStitchingEmbroidary(null);
            dc.measurement.BillNo = "i.e";

            if (dc.EditableCustomerDetail.StitchingDetails != null)
                dc.measurement.BillNo += " " + dc.EditableCustomerDetail.BillNo;
            else
                dc.measurement.BillNo += " " + dc.BillNumber;

            txtBill.Text = dc.measurement.BillNo;
            AllParameterstypes = dc.Parameters;

            if (dc.EditableCustomerDetail != null)
            {
                if (dc.measurement.CustomerName.ToLower().Trim() != "enter customer name")
                    txtCustomerName.Foreground = Brushes.White;

                if (dc.measurement.ContactNumber.ToLower().Trim() != "enter contact number")
                    txtContactNo.Foreground = Brushes.White;

                if (dc.measurement.Address.ToLower().Trim() != "enter address")
                    txtAddress.Foreground = Brushes.White;
            }
        }

        private void CloseSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        
        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calendar.SelectedDate.HasValue)
            {
                if (popupDateSelector.PlacementTarget is TextBox)
                {
                    TextBox target = popupDateSelector.PlacementTarget as TextBox;
                    target.Text = calendar.SelectedDate.Value.ToString("dd/MM/yyyy");
                    target.Foreground = Brushes.White;
                    popupDateSelector.IsOpen = false;
                }      
            }
        }

        private void SetDataContext(string obj)
        {
            TextBox foundTextBox = UIHelper.FindChild<TextBox>(this, obj);
            PopUpStitchingItems.PlacementTarget = foundTextBox;            
        }

        private void CollectionUserControl_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            if (e.NewFocus is ListViewItem || e.NewFocus is ListView || e.NewFocus is Button)
            {
                dc.IsStitchingItem = true;
            }
            else
            {               
                dc.IsStitchingItem = false;
            }

            e.Handled = true;
        }

        private void TextGotFocus(object sender, EventArgs e, string key)
        {
            TextBox tb = (TextBox)sender;            
            switch (key)
            {
                case "CustomerName":
                    if (tb.Text.ToLower().Trim() == "enter customer name")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "ContactNo":
                    if (tb.Text.ToLower().Trim() == "enter contact number")
                    {
                        tb.Text = "";                        
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "Address":
                    if (tb.Text.ToLower().Trim() == "enter address")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "SrNo":
                    if (tb.Text.ToLower().Trim() == "sr no")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "ItemCount":
                    if (tb.Text.ToLower().Trim() == "no of items")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "Price":
                    if (tb.Text.ToLower().Trim() == "rate per unit")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "Serach":
                    if (tb.Text.ToLower().Trim() == "serach")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "Name":
                    if (tb.Text.ToLower().Trim() == "enter name")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "Code":
                    if (tb.Text.ToLower().Trim() == "design code")
                    {
                        tb.Text = "";
                        tb.Foreground = Brushes.White;
                    }
                    break;
                case "Note":
                    if (tb.Text.ToLower().Trim() == "extra notes")
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
                case "CustomerName":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Customer Name";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "ContactNo":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Contact Number";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Address":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Address";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "SrNo":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Sr No";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "ItemCount":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "No Of Items";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Price":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Rate Per Unit";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Serach":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Serach";
                        tb.FontWeight = FontWeights.Normal;
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Name":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Enter Name";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
                case "Code":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Design Code";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break; 
                case "Note":
                    if (tb.Text.ToLower().Trim() == "")
                    {
                        tb.Text = "Extra Notes";
                        tb.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#818183"));
                    }
                    break;
            }
        }

        private void TextInput(object sender, TextCompositionEventArgs e, string type)
        {
            Regex regex = null;

            switch (type)
            {
                case "number":
                    regex = new Regex("^[0-9]*$");
                    e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
                    break;
                case "double":
                    regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
                    e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
                    break;
                default:
                    break;
            }
        }

        private void txtDate_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            string[] date = txtBox.Text.Contains("-") ? txtBox.Text.Split('-') : txtBox.Text.Split('/');
            popupDateSelector.PlacementTarget = txtBox;
            calendar.SelectedDate = new DateTime(Convert.ToInt16(date[2]), Convert.ToInt16(date[1]), Convert.ToInt16(date[0]));
            calendar.DisplayDate = calendar.SelectedDate.Value;
            popupDateSelector.IsOpen = true;

        }

        void customCP_SelectedColorChanged(Color obj, CustomColorPicker sender)
        {
            WrapPanel wp = (WrapPanel)sender.Parent;
            StitchingEmbroidaryModel SMM = (StitchingEmbroidaryModel)wp.DataContext;
            SMM.Color = obj.ToString().Length > 2 ? "#" + obj.ToString().Substring(2) : obj.ToString();
        }

        void customWC_SelectedColorChanged(List<SelectedMultiPelItems> obj, CustomStitchingImage sender)
        {
            if (obj != null)
            {
                WrapPanel wp = (WrapPanel)sender.Parent;
                if (wp.DataContext is StitchingMeasurementModel)
                {
                    StitchingMeasurementModel SMM = (StitchingMeasurementModel)wp.DataContext;
                    SMM.Images = obj;
                }
                else if (wp.DataContext is StitchingEmbroidaryModel)
                {
                    StitchingEmbroidaryModel SMM = (StitchingEmbroidaryModel)wp.DataContext;
                    SMM.Images = obj;
                }
            }
        }

        private void Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            dc.StitchingItem = dc.stitchingService.GetAllstitchingItems(dc.userSettings.boutique.BoutiqueId);
            StitchingWindow win = new StitchingWindow();
            win.Owner = this;
            win.Unloaded += (object s, RoutedEventArgs arg) =>
            {
                dc.GridSeletedStitchingItem = new Entity.StitchingItem();
                UpdatePopContent();
            };
            win.ShowDialog();
        }     

        private void UpdatePopContent()
        {
            var dc = (MainViewModel)this.DataContext;
            dc.StitchingItem = dc.stitchingService.GetAllUndeletedstitchingItems(dc.userSettings.boutique.BoutiqueId);
            dc.IsStitchingItem = true;
        }

        private void addMore_Click(object sender, RoutedEventArgs e)
        {
            AddStitchingSizes(null);
        }

        private void addSameSizeStitching_Click(object sender, RoutedEventArgs e)
        {
            int noofChilddrens = stckPanelMain.Children.OfType<WrapPanel>().Count();
            AddStitchingSizes((StitchingMeasurementModel)stckPanelMain.Children.OfType<WrapPanel>().ElementAt(noofChilddrens - 1).DataContext);
        }

        private void addMoreEmobroidary_Click(object sender, RoutedEventArgs e)
        {
            AddStitchingEmbroidary(null);
        }

        private void addSameSizeEmbordiray_Click(object sender, RoutedEventArgs e)
        {
            int noofChilddrens = stckEmbrodiaryPanelMain.Children.OfType<WrapPanel>().Count();
            if (noofChilddrens > 0)
                AddStitchingEmbroidary((StitchingEmbroidaryModel)stckEmbrodiaryPanelMain.Children.OfType<WrapPanel>().ElementAt(noofChilddrens - 1).DataContext);
            else
                AddStitchingEmbroidary(null);
        }

        private void AddStitchingSizes(StitchingMeasurementModel model)
        {
            Style styleWrapPanel = stckPanelMain.FindResource("wrapPanel") as Style;
            Style styleDropdown = NewMeasurementWindow.FindResource("CustomDropDown") as Style;
            Style styleTextbox = NewMeasurementWindow.FindResource("StitchingCustomTextBox") as Style;
            Style styleButton = NewMeasurementWindow.FindResource("SubmitButton") as Style;
            Style styleTextButton = NewMeasurementWindow.FindResource("TextButtonStyle") as Style;

            StitchingMeasurementModel measurement = new StitchingMeasurementModel();
            if(model != null)
            {
                measurement.Images = model.Images;
                measurement.ItemCount = model.ItemCount;
                measurement.Parameter = new List<Parameter>();
                measurement.StitchingItemId = model.StitchingItemId;
                if (model.Parameter != null)
                {
                    foreach (var parameter in model.Parameter)
                    {
                        measurement.Parameter.Add(new Parameter() { name = parameter.name, value = parameter.value });
                    }
                }

                measurement.Price = model.Price;
                measurement.StitchingItemName = model.StitchingItemName;                
            }
            measurement.SerialNumber = stckPanelMain.Children.Count.ToString();

            WrapPanel wrpPanel = new WrapPanel();
            wrpPanel.Style = styleWrapPanel;
            wrpPanel.DataContext = measurement;           

            #region for Textbox serial number

            TextBox txtSerialNo = new TextBox();
            txtSerialNo.Style = styleDropdown;
            txtSerialNo.Margin = new Thickness(5, 10, 0, 0);
            txtSerialNo.Width = 70;
            txtSerialNo.Name = "txtSrNo" + measurement.SerialNumber;
            txtSerialNo.FontWeight = FontWeights.Normal;
            txtSerialNo.Foreground = Brushes.White;
            txtSerialNo.SetBinding(TextBox.TextProperty, new Binding("SerialNumber")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            wrpPanel.Children.Add(txtSerialNo);

            #endregion

            #region for Textbox Stitching Item Dropdown

            TextBox txtStitchItem = new TextBox();
            txtStitchItem.Style = styleDropdown;
            txtStitchItem.Margin = new Thickness(5, 10, 0, 0);
            txtStitchItem.Width = 130;
            txtStitchItem.Name = "txtstitchingItem" + measurement.SerialNumber;
            txtStitchItem.SetBinding(TextBox.TextProperty, new Binding("StitchingItemName")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtStitchItem.TextChanged += txtStitchingItem_TextChanged;
            txtStitchItem.PreviewMouseLeftButtonUp += (object s, MouseButtonEventArgs arg) =>
                showstitchingitem_PreviewMouseLeftButtonUp(s, arg, "txtstitchingItem" + measurement.SerialNumber);
            wrpPanel.Children.Add(txtStitchItem);

            #endregion

            #region for Textbox Item Count

            TextBox txtItemCount = new TextBox();
            txtItemCount.Style = styleTextbox;
            txtItemCount.Width = 130;
            if (model != null)
                txtItemCount.Foreground = Brushes.White;
            txtItemCount.SetBinding(TextBox.TextProperty, new Binding("ItemCount")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtItemCount.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "ItemCount");
            txtItemCount.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "ItemCount");
            txtItemCount.PreviewTextInput += (object sender, TextCompositionEventArgs e) => TextInput(sender, e, "number");
            wrpPanel.Children.Add(txtItemCount);

            #endregion

            #region for Textbox Item Price

            TextBox txtPrice = new TextBox();
            txtPrice.Style = styleTextbox;
            txtPrice.Width = 120;
            txtPrice.Margin = new Thickness(0, 0, 0, 0);
            if (model != null)
                txtPrice.Foreground = Brushes.White;
            txtPrice.Name = "txtItemPrice" + measurement.SerialNumber;
            txtPrice.SetBinding(TextBox.TextProperty, new Binding("Price")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtPrice.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Price");
            txtPrice.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Price");
            txtPrice.PreviewTextInput += (object sender, TextCompositionEventArgs e) => TextInput(sender, e, "double");
            wrpPanel.Children.Add(txtPrice);

            #endregion

            #region for Images Selecter

            CustomStitchingImage customWC = new CustomStitchingImage();
            customWC.Margin = new Thickness(5, 10, 0, 0);
            customWC.ListWidth = 460;
            customWC.Name = "customCP" + measurement.SerialNumber;
            customWC.SelectedData += new Action<List<SelectedMultiPelItems>, CustomStitchingImage>((obj, s) =>
                    customWC_SelectedColorChanged(obj, s));
            if (model != null)
            {
                customWC.SelectedImages = new ObservableCollection<SelectedMultiPelItems>(model.Images);
            }
            wrpPanel.Children.Add(customWC);


            #endregion

            #region for Parameters 

            ListBox lisBox = new ListBox();
            lisBox.Name = "listBoxParameter" + measurement.SerialNumber;
            lisBox.BorderThickness = new Thickness(0, 0, 0, 0);
            lisBox.Background = Brushes.Transparent;
            lisBox.BorderBrush = Brushes.Transparent;
            lisBox.Margin = new Thickness(0, 0, 0, 0);
            lisBox.SetValue(ScrollViewer.HorizontalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
            lisBox.SetBinding(ListBox.ItemsSourceProperty, new Binding("Parameter")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });

            var xaml = @"<ItemsPanelTemplate  xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                                <WrapPanel Orientation='Horizontal' />
                          </ItemsPanelTemplate>";
            lisBox.ItemsPanel = XamlReader.Parse(xaml) as ItemsPanelTemplate;

            xaml = @"<DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                        <Border BorderThickness='1' Margin='0,10,0,0'
                                Padding='3,5,3,5' BorderBrush='#434346'
                                CornerRadius='2' Background='#2D2D30' VerticalAlignment='Center'>
                            <TextBlock TextAlignment='Left' Padding='10,0,10,0' FontSize='13'
                                FontFamily='Open Sans' Foreground='White' FontWeight='Normal'
                                VerticalAlignment='Center'>
                                <Run Text='{Binding name}' />
                                <Run Text=' (' />
                                <Run Text='{Binding value}' />
                                <Run Text =') '/>
                            </TextBlock>
                        </Border>
                     </DataTemplate>";
            lisBox.ItemTemplate = XamlReader.Parse(xaml) as DataTemplate;
            wrpPanel.Children.Add(lisBox);

            #endregion

            #region for Button For Add Measurement Parameters

            Button btnMeasurment = new Button();
            btnMeasurment.Name = "btnMeasurment" + measurement.SerialNumber;
            btnMeasurment.Tag = measurement.SerialNumber;
            btnMeasurment.Style = styleTextButton;
            btnMeasurment.Margin = new Thickness(5, 10, 0, 0);
            btnMeasurment.Content = "Add Measurement Detail";
            btnMeasurment.ToolTip = "Add Measurement Detail";
            btnMeasurment.Click += btnAddMeasurement_PreviewMouseLeftButtonUp;
            wrpPanel.Children.Add(btnMeasurment);

            #endregion

            if (stckPanelMain.Children.Count > 1)
            {
                #region for Button Remove Item From Model

                Button btn = new Button();
                btn.Style = styleButton;
                btn.Width = 30;
                btn.Height = 30;
                btn.Margin = new Thickness(5, 10, 0, 0);
                btn.Content = "-";
                btn.ToolTip = "Remove Item";
                btn.Click += removeItem_Click;
                wrpPanel.Children.Add(btn);

                #endregion
            }            

            stckPanelMain.Children.Add(wrpPanel);            
        }

        private void txtStitchingItem_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txtSender = (TextBox)sender;
            if (txtSender.Text.ToLower().Trim() != "select item")
            {
                txtSender.Foreground = Brushes.White;
            }
        }

        private void AddStitchingEmbroidary(StitchingEmbroidaryModel model)
        {
            Style styleWrapPanel = stckPanelMain.FindResource("wrapPanel") as Style;
            Style styleDropdown = NewMeasurementWindow.FindResource("CustomDropDown") as Style;
            Style styleTextbox = NewMeasurementWindow.FindResource("StitchingCustomTextBox") as Style;
            Style styleButton = NewMeasurementWindow.FindResource("SubmitButton") as Style;
            Style styleTextButton = NewMeasurementWindow.FindResource("TextButtonStyle") as Style;
            Style styleCustomTextArea = NewMeasurementWindow.FindResource("CustomTextArea") as Style;

            StitchingEmbroidaryModel embroidary = new StitchingEmbroidaryModel();

            if (model != null)
            {
                embroidary.Color = model.Color;
                embroidary.Images = model.Images;
                embroidary.ItemCount = model.ItemCount;
                embroidary.ExtraNote = model.ExtraNote;
                embroidary.Price = model.Price;
                embroidary.StitchingItemName = model.StitchingItemName;
                embroidary.Code = model.Code;
                embroidary.StitchingItemId = model.StitchingItemId;
            }

            embroidary.SerialNumber = stckEmbrodiaryPanelMain.Children.Count.ToString();

            WrapPanel wrpPanel = new WrapPanel();
            wrpPanel.Style = styleWrapPanel;
            wrpPanel.DataContext = embroidary;

            #region for Textbox serial number

            TextBox txtSerialNo = new TextBox();
            txtSerialNo.Style = styleDropdown;
            txtSerialNo.Margin = new Thickness(5, 10, 0, 0);
            txtSerialNo.Width = 70;
            txtSerialNo.Name = "txtSrNoEmbroidary" + embroidary.SerialNumber;
            txtSerialNo.FontWeight = FontWeights.Normal;
            txtSerialNo.Foreground = Brushes.White;
            txtSerialNo.SetBinding(TextBox.TextProperty, new Binding("SerialNumber")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            wrpPanel.Children.Add(txtSerialNo);

            #endregion

            #region for Textbox Stitching Item Dropdown

            TextBox txtStitchItem = new TextBox();
            txtStitchItem.Style = styleDropdown;
            txtStitchItem.Margin = new Thickness(5, 10, 0, 0);
            txtStitchItem.Width = 130;
            txtStitchItem.Name = "txtstitchingItemEmbroidary" + embroidary.SerialNumber;
            txtStitchItem.SetBinding(TextBox.TextProperty, new Binding("StitchingItemName")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtStitchItem.TextChanged += txtStitchingItem_TextChanged;
            txtStitchItem.PreviewMouseLeftButtonUp += (object s, MouseButtonEventArgs arg) =>
                showstitchingitem_PreviewMouseLeftButtonUp(s, arg, "txtstitchingItemEmbroidary" + embroidary.SerialNumber);
            wrpPanel.Children.Add(txtStitchItem);

            #endregion

            #region for Textbox Item Count

            TextBox txtItemCount = new TextBox();
            txtItemCount.Style = styleTextbox;
            txtItemCount.Width = 130;
            if (model != null)
                txtItemCount.Foreground = Brushes.White;
            txtItemCount.Name = "txtItemCountEmbroidary" + embroidary.SerialNumber;
            txtItemCount.SetBinding(TextBox.TextProperty, new Binding("ItemCount")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtItemCount.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "ItemCount");
            txtItemCount.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "ItemCount");
            txtItemCount.PreviewTextInput += (object sender, TextCompositionEventArgs e) => TextInput(sender, e, "number");
            wrpPanel.Children.Add(txtItemCount);

            #endregion

            #region for Textbox Item Design Code

            TextBox txtItemDesignCode = new TextBox();
            txtItemDesignCode.Style = styleTextbox;
            txtItemDesignCode.Width = 120;
            if (model != null)
                txtItemDesignCode.Foreground = Brushes.White;
            txtItemDesignCode.Name = "txtItemDesignEmbroidary" + embroidary.SerialNumber;
            txtItemDesignCode.SetBinding(TextBox.TextProperty, new Binding("Code")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtItemDesignCode.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Code");
            txtItemDesignCode.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Code");           
            wrpPanel.Children.Add(txtItemDesignCode);

            #endregion

            #region for Textbox Item Price

            TextBox txtPrice = new TextBox();
            txtPrice.Style = styleTextbox;
            txtPrice.Width = 120;
            if (model != null)
                txtPrice.Foreground = Brushes.White;
            txtPrice.Margin = new Thickness(0, 0, 0, 0);
            txtPrice.Name = "txtItemPriceEmbroidary" + embroidary.SerialNumber;
            txtPrice.SetBinding(TextBox.TextProperty, new Binding("Price")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtPrice.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Price");
            txtPrice.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Price");
            txtPrice.PreviewTextInput += (object sender, TextCompositionEventArgs e) => TextInput(sender, e, "double");
            wrpPanel.Children.Add(txtPrice);

            #endregion

            #region for Images Selecter

            CustomStitchingImage customWC = new CustomStitchingImage();
            customWC.Margin = new Thickness(5, 10, 0, 0);
            customWC.ListWidth = 460;
            customWC.Name = "customEmbroidaryCP" + embroidary.SerialNumber;
            customWC.SelectedData += new Action<List<SelectedMultiPelItems>, CustomStitchingImage>((obj, s) =>
                    customWC_SelectedColorChanged(obj, s));
            if (model != null)
            {
                customWC.SelectedImages = new ObservableCollection<SelectedMultiPelItems>(model.Images);
            }
            wrpPanel.Children.Add(customWC);


            #endregion

            #region for Dropdown ColorPicker

            CustomColorPicker customCP = new CustomColorPicker();
            customCP.Margin = new Thickness(5, 10, 0, 0);
            customCP.Width = 120;
            customCP.Name = "customCPEmbroidary" + embroidary.SerialNumber;
            if (model != null)
                customCP.ColorText = model.Color;
            customCP.SelectedColorChanged += new Action<Color,
                                            CustomColorPicker>((obj, s) => customCP_SelectedColorChanged(obj, s));
            wrpPanel.Children.Add(customCP);

            #endregion

            #region for Button Remove Item From Model

            Button btn = new Button();
            btn.Style = styleButton;
            btn.Width = 30;
            btn.Height = 30;
            btn.Margin = new Thickness(5, 10, 0, 0);
            btn.Content = "-";
            btn.ToolTip = "Remove Item";
            btn.Click += removeItem_Click;
            wrpPanel.Children.Add(btn);

            #endregion            

            #region for Textbox Item Extra Notes

            TextBox txtItemNote = new TextBox();
            txtItemNote.Style = styleCustomTextArea;
            txtItemNote.Width = 455;
            if (model != null)
                txtItemNote.Foreground = Brushes.White;
            txtItemNote.Margin = new Thickness(5, 10, 0, 0);
            txtItemNote.Name = "txtItemNote" + embroidary.SerialNumber;
            txtItemNote.SetBinding(TextBox.TextProperty, new Binding("ExtraNote")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            txtItemNote.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Note");
            txtItemNote.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Note");
            wrpPanel.Children.Add(txtItemNote);

            #endregion

            stckEmbrodiaryPanelMain.Children.Add(wrpPanel);
        }

        private void showstitchingitem_PreviewMouseLeftButtonUp(object s, MouseButtonEventArgs arg, string name)
        {
            var dc = (MainViewModel)this.DataContext;
            dc.ShowStitchingItem(name);
        }

        private void removeItem_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            WrapPanel parent = (WrapPanel)btn.Parent;
            if (parent.DataContext is StitchingMeasurementModel)
                stckPanelMain.Children.Remove(parent);
            else
                stckEmbrodiaryPanelMain.Children.Remove(parent);
        }

        private void ListStitchingItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var list = (ListBox)sender;
            if(list.SelectedItem != null)
            {
                var txtBoxPlacement = (TextBox)PopUpStitchingItems.PlacementTarget;
                var wrpPanleParent = (WrapPanel)txtBoxPlacement.Parent;                

                if (wrpPanleParent.DataContext is StitchingMeasurementModel)
                {
                    var model = (StitchingMeasurementModel)wrpPanleParent.DataContext;
                    model.StitchingItemName = ((StitchingItem)list.SelectedItem).Name;
                    model.StitchingItemId = ((StitchingItem)list.SelectedItem).Id;
                    wrpPanleParent.DataContext = model;                   
                }
                else
                {
                    var model = (StitchingEmbroidaryModel)wrpPanleParent.DataContext;
                    model.StitchingItemName = ((StitchingItem)list.SelectedItem).Name;
                    model.StitchingItemId = ((StitchingItem)list.SelectedItem).Id;
                    wrpPanleParent.DataContext = model;                   
                }

                var dc = (MainViewModel)this.DataContext;
                dc.IsStitchingItem = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;

            if (txtName.Text == "Enter Name" || string.IsNullOrEmpty(txtName.Text))
            {
                dc.ShowMessage("Please enter name");
                return;
            }
            else
            {
                AddParameter(dc.stitchingService.AddUpdateStitchingParameterItem(new Entity.ParameterType()
                {
                    Name = txtName.Text,
                    CreateOn = DateTime.Now,
                    LastUpdatedOn = DateTime.Now,
                    IsDeleted = false,
                    BoutiqueId = dc.userSettings.boutique.BoutiqueId
                }));               

                //dc.Parameters = dc.stitchingService.GetAllParameterTypes(dc.userSettings.boutique.BoutiqueId);
                txtName.Text = "Enter Name";
                txtName.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#c6c6c6"));
            }
        }

        private void btnAddMeasurement_PreviewMouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            var btnSender = (Button)sender;
            AddMeasurementSender = btnSender;
            SetDataContextMeasurement();           
        }

        private void SetDataContextMeasurement()
        {
            var vm = (MainViewModel)this.DataContext;

            var dc = (StitchingMeasurementModel)AddMeasurementSender.DataContext;
            if (dc.StitchingItemId > 0)
            {
                vm.Parameters = vm.stitchingService.GetAllParameterTypes(vm.userSettings.boutique.BoutiqueId, dc.StitchingItemId);

                if (dc.Parameter == null)
                {
                    dc.Parameter = new List<Parameter>();
                    if (vm.Parameters != null)
                    {
                        List<StitchingItem> parametersTypes = vm.StitchingItem.Where(x => x.Id == dc.StitchingItemId).ToList();
                        foreach (var item in parametersTypes)
                        {
                            foreach (var parameter in item.ParameterTypes)
                            {
                                dc.Parameter.Add(new Parameter() { name = parameter.Name, value = string.Empty });
                            }
                        }
                    }
                }

                lstDropDownItem.DataContext = dc;

                lstDropDownItem.SetBinding(ListView.ItemsSourceProperty, new Binding("Parameter")
                {
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    NotifyOnTargetUpdated = true,
                    NotifyOnSourceUpdated = true
                });
                PopUpMeasurementItems.IsOpen = true;
            }
            else
            {
                vm.ShowMessage("Please select item.");
                return;
            }
        }

        private void AddParameter(ParameterType type)
        {
            var dc = (StitchingMeasurementModel)lstDropDownItem.DataContext;

            if(dc.StitchingItemId > 0)
            {
                var vm = (MainViewModel)this.DataContext;
                var stitchingItem = vm.stitchingService.GetStitchingItem(type.BoutiqueId, dc.StitchingItemId);

                if (stitchingItem.ParameterTypes == null)
                    stitchingItem.ParameterTypes = new List<ParameterType>();

                stitchingItem.ParameterTypes.Add(type);

                vm.Parameters = vm.stitchingService.AddUpdateStitchingItem(stitchingItem).ParameterTypes;

                vm.StitchingItem = vm.stitchingService.GetAllUndeletedstitchingItems(vm.userSettings.boutique.BoutiqueId);                                
            }

            //if (dc.Parameter == null )
            //    dc.Parameter = new List<Parameter>();

            dc.Parameter.Add(new Parameter() { name = type.Name, value = string.Empty });
            lstDropDownItem.ItemsSource = dc.Parameter;
            lstDropDownItem.Items.Refresh();
            AddMeasurementSender.DataContext = dc;
        }

        private void SelectItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {          
            SearchMeasurementParameter(sender);
        }

        private void SelectItem_KeyUp(object sender, KeyEventArgs e)
        {
            SearchMeasurementParameter(sender);
        }

        private void TextSerach_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SearchMeasurementParameter(sender);
        }

        private void SearchMeasurementParameter(object sender)
        {
            var dc = (MainViewModel)this.DataContext;
            dc.Parameters.All(x => { x.IsExists = false; return true; });

            TextBox text = FilterCombobox as TextBox;

            var btdc = (StitchingMeasurementModel)lstDropDownItem.DataContext;

            dc.Parameters.Where(i => btdc.Parameter.Select(p => p.name).ToList().Contains(i.Name)
            && i.Name.ToLower().Contains(text.Text.ToLower())).
            All(x => { x.IsExists = true; return true; });


            dc.IsDropDownOpen = true;
        }

        private void lstDropDownItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var lstView = (ListView)sender;
            if(lstView.SelectedItem != null)
            {
                var item = (ParameterType)lstView.SelectedItem;
                var dc = (MainViewModel)this.DataContext;
                if (!item.IsExists)                   
                    AddParameter(item);

                dc.IsDropDownOpen = false;
            }
        }

        private void lstDropDownItem_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                var lstView = (ListView)sender;
                if (lstView.SelectedItem != null)
                {
                    var dc = (MainViewModel)this.DataContext;
                    AddParameter((ParameterType)lstView.SelectedItem);
                    dc.IsDropDownOpen = false;
                }
            }
        }

        private void RemoveMeasurement_Click(object sender, RoutedEventArgs e)
        {
            Grid grid = (Grid)((Button)sender).Parent;
            var gridDataContext = (Parameter)grid.DataContext;

            var dc = (StitchingMeasurementModel)lstDropDownItem.DataContext;
            dc.Parameter.Remove(gridDataContext);

            lstDropDownItem.ItemsSource = dc.Parameter;
            lstDropDownItem.Items.Refresh();

            AddMeasurementSender.DataContext = dc;
        }

        private void stackSearch_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (e.NewFocus is ListViewItem || e.NewFocus is ListView)
            {

            }
            else
            {
                var dc = (MainViewModel)this.DataContext;
                dc.IsDropDownOpen = false;               
            }

            e.Handled = true;
        }

        private void ClosePopUp_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PopUpMeasurementItems.IsOpen = false;
        }

        private void ShowMeasurementParameter_Click(object sender, RoutedEventArgs e)
        {            
            PopUpMeasurementItems.IsOpen = false;           
        }

        private void PopUpMeasurementItems_Closed(object sender, EventArgs e)
        {
            string listBoxName = "listBoxParameter" + AddMeasurementSender.Tag;
            var listBox = UIHelper.FindChild<ListBox>(this, listBoxName);
            listBox.Items.Refresh();
        }

        private void submitMeasurement_Click(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;

            if(string.IsNullOrEmpty(txtCustomerName.Text) || txtCustomerName.Text.ToLower() == "enter customer name")
            {
                dc.ShowMessage("Please enter customer name");
                return;
            }
            else if (string.IsNullOrEmpty(txtContactNo.Text) || txtContactNo.Text.ToLower() == "enter contact number")
            {
                dc.ShowMessage("Please enter contact number");
                return;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) || txtAddress.Text.ToLower() == "enter address")
            {
                dc.ShowMessage("Please enter address");
                return;
            }

            List<StitchingMeasurementModel> stitchingContext = new List<StitchingMeasurementModel>();
            for(int i = 1; i< stckPanelMain.Children.Count; i++)
            {
                var data = (StitchingMeasurementModel)(((WrapPanel)stckPanelMain.Children[i]).DataContext);

                StitchingMeasurementModel model = new StitchingMeasurementModel()
                {
                    SerialNumber = data.SerialNumber,
                    Images = data.Images,
                    ItemCount = (data.ItemCount.ToLower() == "no of items" ? "" : data.ItemCount),
                    Price = (data.Price.ToLower() == "rate per unit" ? "" : data.Price),
                    StitchingItemName = (data.StitchingItemName.ToLower() == "select item" ? "" : data.StitchingItemName),
                    Parameter = data.Parameter
                };

                stitchingContext.Add(model);
            }
            string stitchingSizeDetails = UIHelper.Serialize<List<StitchingMeasurementModel>>(stitchingContext);


            List<StitchingEmbroidaryModel> embroidaryContext = new List<StitchingEmbroidaryModel>();
            for (int i = 1; i < stckEmbrodiaryPanelMain.Children.Count; i++)
            {
                var data = (StitchingEmbroidaryModel)(((WrapPanel)stckEmbrodiaryPanelMain.Children[i]).DataContext);

                StitchingEmbroidaryModel model = new StitchingEmbroidaryModel()
                {
                    SerialNumber = data.SerialNumber,
                    Images = data.Images,
                    Color = (data.Color.ToLower() == "select color" ? "#ffffff" : data.Color),
                    ItemCount = (data.ItemCount.ToLower() == "no of items" ? "" : data.ItemCount),
                    Price = (data.Price.ToLower() == "rate per unit" ? "" : data.Price),
                    StitchingItemName = (data.StitchingItemName.ToLower() == "select item" ? "" : data.StitchingItemName),
                    Code = (data.Code.ToLower() == "design code" ? "" : data.Code),
                    ExtraNote = (data.ExtraNote.ToLower() == "extra notes" ? "" : data.ExtraNote)
                };

                embroidaryContext.Add(model);              
            }
            string embroidrayDetails = UIHelper.Serialize<List<StitchingEmbroidaryModel>>(embroidaryContext);

            CustomerDetail customerDetail = null;

            if (dc.IsEditable)
                customerDetail = dc.customerDetailService.GetCustomerDetailsById(dc.EditableCustomerDetail.Id);
            else
                customerDetail = new CustomerDetail();

            customerDetail.BillNo = dc.measurement.BillNo.Replace("i.e", "").Trim();
            customerDetail.CreateOn = DateTime.ParseExact(dc.measurement.Date, "dd/M/yyyy", null);
            customerDetail.DeliveryDate = DateTime.ParseExact(dc.measurement.DeliveryDate, "dd/M/yyyy", null);
            customerDetail.LastUpdatedOn = DateTime.Today;
            customerDetail.Address = (dc.measurement.Address.ToLower() == "enter address" ? "" : dc.measurement.Address);
            customerDetail.ContactNumber = (dc.measurement.ContactNumber.ToLower() == "enter contact number" ? "" : dc.measurement.ContactNumber);
            customerDetail.CustomerName = (dc.measurement.CustomerName.ToLower() == "enter customer name" ? "" : dc.measurement.CustomerName);
            customerDetail.IsDeleted = false;
            customerDetail.StitchingDetails = stitchingSizeDetails;
            customerDetail.EmbroideryDetails = embroidrayDetails;
            customerDetail.BoutiqueId = dc.userSettings.boutique.BoutiqueId;           

            dc.InvoiceCustomerDetail = dc.customerDetailService.AddUpdateCustomerDetail(customerDetail);

            Invoice win = new Invoice();
            win.Show();
            this.Close();
        }        

    }
}

