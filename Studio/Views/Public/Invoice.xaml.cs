/**
* Filename:  Invoice.xaml.cs
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
using com.boutique.Converters;
using System.Windows.Documents;
using VisualPrint;

namespace com.boutique.Views
{
    public partial class Invoice : Window
    {    
        public Invoice()
        {
            InitializeComponent();
            InvoiceWindow.Loaded += InvoiceWindow_Loaded;
        }

        private void InvoiceWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;

            List<StitchingMeasurementModel> stitchingSizeDetails = 
                UIHelper.Deserialize<List<StitchingMeasurementModel>>(dc.InvoiceCustomerDetail.StitchingDetails);
            stckPanelMain.DataContext = stitchingSizeDetails;

            decimal stitchingSizeTotal =
                stitchingSizeDetails.Where(x => x.Price != "").Select(x => (Convert.ToInt16(x.ItemCount) * Convert.ToDecimal(x.Price))).Sum();

            List<StitchingEmbroidaryModel> embroidrayDetails =
                UIHelper.Deserialize<List<StitchingEmbroidaryModel>>(dc.InvoiceCustomerDetail.EmbroideryDetails);
            stckEmbrodiaryPanelMain.DataContext = embroidrayDetails;

            lstInvoiceStitchingItems.ItemsSource = stitchingSizeDetails;

            if (embroidrayDetails.Count > 0)
            {
                lstInvoiceEmbroideryItems.Visibility = Visibility.Visible;
                brdrEmbrdoidertext.Visibility = Visibility.Visible;
                lstInvoiceEmbroideryItems.ItemsSource = embroidrayDetails;

                stitchingSizeTotal +=
                embroidrayDetails.Where(x => x.Price != "").Select(x => (Convert.ToInt16(x.ItemCount) * Convert.ToDecimal(x.Price))).Sum();
            }
            else
            {
                lstInvoiceEmbroideryItems.Visibility = Visibility.Collapsed;
                brdrEmbrdoidertext.Visibility = Visibility.Collapsed;
            }

            ShowStitchingSize(stitchingSizeDetails);
            ShowStitchingEmbroidary(embroidrayDetails);

            dc.InvoiceTotal = stitchingSizeTotal.ToString() + "/-";
        }

        private void CloseSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeSettingWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void AddStitchingSizes(StitchingMeasurementModel model)
        {
            Style styleWrapPanel = stckPanelMain.FindResource("wrapPanel") as Style;
            Style styleDropdown = InvoiceWindow.FindResource("CustomDropDown") as Style;
            Style styleTextbox = InvoiceWindow.FindResource("StitchingCustomTextBox") as Style;
            Style styleButton = InvoiceWindow.FindResource("SubmitButton") as Style;
            Style styleTextButton = InvoiceWindow.FindResource("TextButtonStyle") as Style;

            StitchingMeasurementModel measurement = new StitchingMeasurementModel();
            if (model != null)
            {
                measurement.Images = model.Images;
                measurement.ItemCount = model.ItemCount;
                measurement.Parameter = model.Parameter;
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
            txtSerialNo.FontWeight = FontWeights.SemiBold;
            txtSerialNo.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#595959"));
            txtSerialNo.SetBinding(TextBox.TextProperty, new Binding("SerialNumber")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            //txtSerialNo.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "SrNo");
            //txtSerialNo.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "SrNo");
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
            //txtStitchItem.TextChanged += txtStitchingItem_TextChanged;
            //txtStitchItem.PreviewMouseLeftButtonUp += (object s, MouseButtonEventArgs arg) =>
            //    showstitchingitem_PreviewMouseLeftButtonUp(s, arg, "txtstitchingItem" + measurement.SerialNumber);
            wrpPanel.Children.Add(txtStitchItem);

            #endregion

            #region for Textbox Item Count

            TextBox txtItemCount = new TextBox();
            txtItemCount.Style = styleTextbox;
            txtItemCount.Width = 130;
            txtItemCount.Name = "txtItemCount" + measurement.SerialNumber;
            txtItemCount.SetBinding(TextBox.TextProperty, new Binding("ItemCount")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            //txtItemCount.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "ItemCount");
            //txtItemCount.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "ItemCount");
            //txtItemCount.PreviewTextInput += (object sender, TextCompositionEventArgs e) => TextInput(sender, e, "number");
            wrpPanel.Children.Add(txtItemCount);

            #endregion

            #region for Textbox Item Price

            TextBox txtPrice = new TextBox();
            txtPrice.Style = styleTextbox;
            txtPrice.Width = 120;
            txtPrice.Margin = new Thickness(0, 0, 0, 0);
            txtPrice.Name = "txtItemPrice" + measurement.SerialNumber;
            txtPrice.SetBinding(TextBox.TextProperty, new Binding("Price")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                NotifyOnTargetUpdated = true,
                NotifyOnSourceUpdated = true
            });
            //txtPrice.GotFocus += (object sender, RoutedEventArgs e) => TextGotFocus(sender, e, "Price");
            //txtPrice.LostFocus += (object sender, RoutedEventArgs e) => TextLostFocus(sender, e, "Price");
           // txtPrice.PreviewTextInput += (object sender, TextCompositionEventArgs e) => TextInput(sender, e, "double");
            wrpPanel.Children.Add(txtPrice);

            #endregion

            #region for Dropdown ColorPicker

            CustomColorPicker customCP = new CustomColorPicker();
            customCP.Margin = new Thickness(5, 10, 0, 0);
            customCP.Width = 120;
            customCP.Name = "customCP" + measurement.SerialNumber;
           // customCP.SelectedColorChanged += new Action<Color,
                                           // CustomColorPicker>((obj, s) => customCP_SelectedColorChanged(obj, s));
            wrpPanel.Children.Add(customCP);

            #endregion                        

            #region for Parameters 

            ListBox lisBox = new ListBox();
            lisBox.Name = "listBoxParameter" + measurement.SerialNumber;
            lisBox.BorderThickness = new Thickness(0, 0, 0, 0);
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

            string xaml = @"<ItemsPanelTemplate  xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                                <WrapPanel Orientation='Horizontal' />
                          </ItemsPanelTemplate>";
            lisBox.ItemsPanel = XamlReader.Parse(xaml) as ItemsPanelTemplate;

            xaml = @"<DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                        <Border BorderThickness='2' Margin='0,10,0,0'
                                Padding='3,5,3,5' BorderBrush='#696969'
                                CornerRadius='2' Background='White' VerticalAlignment='Center'>
                            <TextBlock TextAlignment='Left' Padding='10,0,10,0' FontSize='13'
                                FontFamily='Open Sans' Foreground='#595959' FontWeight='SemiBold'
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
            btnMeasurment.Tag = measurement.SerialNumber;
            btnMeasurment.Style = styleTextButton;
            btnMeasurment.Margin = new Thickness(5, 10, 0, 0);
            btnMeasurment.Content = "Add Measurement Detail";
            btnMeasurment.ToolTip = "Add Measurement Detail";
            //btnMeasurment.Click += btnAddMeasurement_PreviewMouseLeftButtonUp;
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
               // btn.Click += removeItem_Click;
                wrpPanel.Children.Add(btn);

                #endregion
            }

            stckPanelMain.Children.Add(wrpPanel);
        }

        private void ShowStitchingSize(List<StitchingMeasurementModel> stitchingSizeDetails)
        {
            Style styleWrapPanel = stckPanelMain.FindResource("wrapPanel") as Style;
            Style styleHeader = InvoiceWindow.FindResource("Boutiuqefonttext") as Style;
            Style styleListBox = InvoiceWindow.FindResource("ListBoxtemStyleNoHighlighting") as Style;            

            double width = (stckPanelMain.ActualWidth / 3);

            double imagewidth = (stckPanelMain.ActualWidth / 8);

            foreach (var item in stitchingSizeDetails)
            {               
                WrapPanel wrpPanel = new WrapPanel();
                wrpPanel.Style = styleWrapPanel;
                wrpPanel.DataContext = item;

                #region for Text Header Stitching Item

                Label txtHeader = new Label();
                txtHeader.FontWeight = FontWeights.SemiBold;
                txtHeader.FontSize = 17;
                txtHeader.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#db0a06"));
                MultiBinding mb = new MultiBinding();
                MultBindingConverter imageConvert = new MultBindingConverter();
                mb.Converter = imageConvert;
                mb.Bindings.Add(new Binding("StitchingItemName"));
                mb.Bindings.Add(new Binding("ItemCount"));
                mb.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                mb.NotifyOnSourceUpdated = true;//this is important. 
                mb.NotifyOnTargetUpdated = true;
                mb.Mode = BindingMode.TwoWay;
                txtHeader.SetBinding(Label.ContentProperty, mb);

                wrpPanel.Children.Add(txtHeader);

                #endregion

                #region for Stitching Images

                ListBox lisBoxImages = new ListBox();
                lisBoxImages.ItemContainerStyle = styleListBox;
                lisBoxImages.BorderThickness = new Thickness(0, 0, 0, 0);
                lisBoxImages.BorderBrush = Brushes.Transparent;
                lisBoxImages.Background = Brushes.Transparent;
                lisBoxImages.Margin = new Thickness(0, 0, 0, 15);
                lisBoxImages.SetValue(ScrollViewer.HorizontalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
                lisBoxImages.SetBinding(ListBox.ItemsSourceProperty, new Binding("Images")
                {
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    NotifyOnTargetUpdated = true,
                    NotifyOnSourceUpdated = true
                });

                string xaml1 = @"<ItemsPanelTemplate  xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                                <UniformGrid Columns='15'/>
                          </ItemsPanelTemplate>";
                lisBoxImages.ItemsPanel = XamlReader.Parse(xaml1) as ItemsPanelTemplate;

                DataTemplate template = new DataTemplate();

                //FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
                //border.SetValue(Border.BorderThicknessProperty, new Thickness(1));
                //border.SetValue(Border.CornerRadiusProperty, new CornerRadius(3));
                //border.SetValue(Border.PaddingProperty, new Thickness(5, 2, 2, 2));
                //border.SetValue(Border.MarginProperty, new Thickness(0, 0, 10, 5));
                //border.SetValue(Border.WidthProperty, 30d);
                //border.SetValue(Border.BorderBrushProperty, (SolidColorBrush)(new BrushConverter().ConvertFrom("#434346")));
                //border.SetValue(Border.BackgroundProperty, (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D30")));

                FrameworkElementFactory image = new FrameworkElementFactory(typeof(Image));
                image.SetValue(Image.TagProperty, new Binding() { Path = new PropertyPath("Key") });
                image.SetValue(Image.HeightProperty, 30d);
                image.SetValue(Image.WidthProperty, 30d);
                Binding sorceConverter = new Binding();
                sorceConverter.Path = new PropertyPath("Value");
                sorceConverter.Converter = new BytesArrayConverter();
                image.SetBinding(Image.SourceProperty, sorceConverter);

                //border.AppendChild(image);

                template.VisualTree = image;
                lisBoxImages.ItemTemplate = template;
                wrpPanel.Children.Add(lisBoxImages);

                #endregion                  

                #region for Parameters 

                ListBox lisBox = new ListBox();
                lisBox.ItemContainerStyle = styleListBox;
                lisBox.BorderThickness = new Thickness(0, 0, 0, 0);
                lisBox.BorderBrush = Brushes.Transparent;
                lisBox.Margin = new Thickness(0, 0, 0, 15);
                lisBox.SetValue(ScrollViewer.HorizontalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
                lisBox.SetBinding(ListBox.ItemsSourceProperty, new Binding("Parameter")
                {
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    NotifyOnTargetUpdated = true,
                    NotifyOnSourceUpdated = true
                });

                string xaml = @"<ItemsPanelTemplate  xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                                <UniformGrid Columns='3'/>
                          </ItemsPanelTemplate>";
                lisBox.ItemsPanel = XamlReader.Parse(xaml) as ItemsPanelTemplate;


                xaml = @"<DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                            <Border BorderThickness='0,0,0,1' Margin='0,0,0,0'
                                    Padding='0,5,10,5' BorderBrush='#696969' Width='" + width + @"'
                                    CornerRadius ='0' Background='White' VerticalAlignment='Center'>                            
                                <TextBlock TextAlignment='Left' TextWrapping='Wrap' Padding='0,0,0,0' FontSize='14'
                                    FontFamily='Open Sans' Foreground='#1e1e1e' FontWeight='Normal'
                                    VerticalAlignment='Center'>
                                    <Run Text='{Binding name}' />
                                    <Run Text=' = ' />
                                    <Run Text='{Binding value}' />
                                </TextBlock>
                            </Border>
                         </DataTemplate>";
                lisBox.ItemTemplate = XamlReader.Parse(xaml) as DataTemplate;
                wrpPanel.Children.Add(lisBox);

                #endregion

                stckPanelMain.Children.Add(wrpPanel);
            }  
        }

        private void ShowStitchingEmbroidary(List<StitchingEmbroidaryModel> embroidrayDetails)
        {
            Style styleWrapPanel = stckPanelMain.FindResource("wrapPanel") as Style;
            Style styleHeader = InvoiceWindow.FindResource("Boutiuqefonttext") as Style;
            Style styleListBox = InvoiceWindow.FindResource("ListBoxtemStyleNoHighlighting") as Style;            

            foreach (var item in embroidrayDetails)
            {
                WrapPanel wrpPanel = new WrapPanel();
                wrpPanel.Orientation = Orientation.Vertical;
                wrpPanel.Style = styleWrapPanel;
                wrpPanel.DataContext = item;

                #region for Text Header Stitching Item

                Label txtHeader = new Label();
                txtHeader.Margin = new Thickness(0, 0, 0, 0);
                txtHeader.FontWeight = FontWeights.SemiBold;
                txtHeader.FontSize = 17;
                txtHeader.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#db0a06"));
                MultiBinding mb = new MultiBinding();
                MultBindingConverter imageConvert = new MultBindingConverter();
                mb.Converter = imageConvert;
                mb.Bindings.Add(new Binding("StitchingItemName"));
                mb.Bindings.Add(new Binding("ItemCount"));
                mb.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                mb.NotifyOnSourceUpdated = true;//this is important. 
                mb.NotifyOnTargetUpdated = true;
                mb.Mode = BindingMode.TwoWay;
                txtHeader.SetBinding(Label.ContentProperty, mb);

                wrpPanel.Children.Add(txtHeader);

                #endregion

                #region for Stitching Images

                ListBox lisBoxImages = new ListBox();
                lisBoxImages.ItemContainerStyle = styleListBox;
                lisBoxImages.BorderThickness = new Thickness(0, 0, 0, 0);
                lisBoxImages.BorderBrush = Brushes.Transparent;
                lisBoxImages.Background = Brushes.Transparent;
                lisBoxImages.Margin = new Thickness(0, 0, 0, 15);
                lisBoxImages.SetValue(ScrollViewer.HorizontalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
                lisBoxImages.SetBinding(ListBox.ItemsSourceProperty, new Binding("Images")
                {
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    NotifyOnTargetUpdated = true,
                    NotifyOnSourceUpdated = true
                });

                string xaml1 = @"<ItemsPanelTemplate  xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                                <UniformGrid Columns='15'/>
                          </ItemsPanelTemplate>";
                lisBoxImages.ItemsPanel = XamlReader.Parse(xaml1) as ItemsPanelTemplate;

                DataTemplate template = new DataTemplate();

                //FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
                //border.SetValue(Border.BorderThicknessProperty, new Thickness(1));
                //border.SetValue(Border.CornerRadiusProperty, new CornerRadius(3));
                //border.SetValue(Border.PaddingProperty, new Thickness(5, 2, 2, 2));
                //border.SetValue(Border.MarginProperty, new Thickness(0, 0, 10, 5));
                //border.SetValue(Border.WidthProperty, 30d);
                //border.SetValue(Border.BorderBrushProperty, (SolidColorBrush)(new BrushConverter().ConvertFrom("#434346")));
                //border.SetValue(Border.BackgroundProperty, (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D30")));

                FrameworkElementFactory image = new FrameworkElementFactory(typeof(Image));
                image.SetValue(Image.TagProperty, new Binding() { Path = new PropertyPath("Key") });
                image.SetValue(Image.HeightProperty, 30d);
                image.SetValue(Image.WidthProperty, 30d);
                Binding sorceConverter = new Binding();
                sorceConverter.Path = new PropertyPath("Value");
                sorceConverter.Converter = new BytesArrayConverter();
                image.SetBinding(Image.SourceProperty, sorceConverter);

                //border.AppendChild(image);

                template.VisualTree = image;
                lisBoxImages.ItemTemplate = template;
                wrpPanel.Children.Add(lisBoxImages);

                #endregion                  

                #region for Embroidary Deatil

                Grid grd = new Grid();
                grd.Margin = new Thickness(0, 10, 0, 0);
                RowDefinition rd = new RowDefinition();
                grd.RowDefinitions.Add(rd);
                rd = new RowDefinition();
                grd.RowDefinitions.Add(rd);

                #region for Item Code and color

                StackPanel sp = new StackPanel();
                sp.Orientation = Orientation.Horizontal;
                sp.SetValue(Grid.RowProperty, 0);               

                TextBlock txtDesignCode = new TextBlock();
                txtDesignCode.FontWeight = FontWeights.SemiBold;
                txtDesignCode.FontSize = 14;
                txtDesignCode.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#1e1e1e"));
                txtDesignCode.Text = "Design Code - ";
                sp.Children.Add(txtDesignCode);

                TextBlock itemCode = new TextBlock();
                itemCode.FontWeight = FontWeights.SemiBold;
                itemCode.FontSize = 14;
                itemCode.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#1e1e1e"));
                itemCode.SetBinding(TextBlock.TextProperty, new Binding()
                {
                    Path = new PropertyPath("Code"),
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    NotifyOnSourceUpdated = true,
                    NotifyOnTargetUpdated = true,
                });
                sp.Children.Add(itemCode);              
               

                TextBlock txtItemColor = new TextBlock();
                txtItemColor.Margin = new Thickness(25, 0, 0, 0);
                txtItemColor.FontWeight = FontWeights.SemiBold;
                txtItemColor.FontSize = 14;
                txtItemColor.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#1e1e1e"));
                txtItemColor.Text = "Item Color";                
                sp.Children.Add(txtItemColor);

                CovertToSoildBrush brushConverter = new CovertToSoildBrush();
                Binding b = new Binding()
                {
                    Path = new PropertyPath("Color"),
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    NotifyOnSourceUpdated = true,
                    NotifyOnTargetUpdated = true,
                    Converter = brushConverter
                };

                Border brdrItemColor = new Border()
                {
                    Width = 12,
                    Height = 12,
                    Margin = new Thickness(5, 5, 0, 0),
                    BorderThickness = new Thickness(1, 1, 1, 1)                   
                };

                brdrItemColor.SetBinding(Border.BackgroundProperty, b);
                brdrItemColor.SetBinding(Border.BorderBrushProperty, b);

                sp.Children.Add(brdrItemColor);

                grd.Children.Add(sp);

                #endregion

                #region for Extra Note
                TextBlock txtNote = new TextBlock();
                txtNote.SetValue(Grid.RowProperty, 1);
                txtNote.Margin = new Thickness(0, 10, 0, 0);
                txtItemColor.FontWeight = FontWeights.SemiBold;
                txtItemColor.FontSize = 14;
                txtNote.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#1e1e1e"));
                txtNote.SetBinding(TextBlock.TextProperty, new Binding()
                {
                    Path = new PropertyPath("ExtraNote"),
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    NotifyOnSourceUpdated = true,
                    NotifyOnTargetUpdated = true
                });
                grd.Children.Add(txtNote);
                #endregion

                wrpPanel.Children.Add(grd);
                #endregion               

                stckEmbrodiaryPanelMain.Children.Add(wrpPanel);
            }
        }      

        private void printInvoice_Click(object sender, RoutedEventArgs e)
        {
            var dc = (MainViewModel)this.DataContext;
            _print(dc.InvoiceCustomerDetail.CustomerName.Replace(" ", "_"));
        }

        private void _print(string invoiceName)
        {
            PrintDialog prtDlg = new PrintDialog();
            if (prtDlg.ShowDialog() == true)
            {

                var pages = Convert.ToInt16(scrollGrid.ScrollableHeight / 842);

                Size pageSize = new Size(prtDlg.PrintableAreaWidth - 60, prtDlg.PrintableAreaHeight - 60);
                grdInvoice.Measure(pageSize);
                grdInvoice.Arrange(new Rect(15, 15, pageSize.Width, pageSize.Height));
                prtDlg.PrintVisual(grdInvoice, "Invoice " + invoiceName);

            }
        }

        //private void _print(string invoiceName)
        //{
        //    VisualPrintDialog printDlg = new VisualPrintDialog(grdInvoice);
        //    printDlg.ShowDialog();

        //    PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
        //    //printDlg.ShowDialog();
        //    //get selected printer capabilities
        //    System.Printing.PrintCapabilities capabilities = printDlg.PrintQueue.GetPrintCapabilities(printDlg.PrintTicket);

        //    //get scale of the print wrt to screen of WPF visual
        //    double scale = Math.Min(capabilities.PageImageableArea.ExtentWidth / this.ActualWidth, capabilities.PageImageableArea.ExtentHeight /
        //                   this.ActualHeight);

        //    //Transform the Visual to scale
        //    this.LayoutTransform = new ScaleTransform(scale, scale);

        //    //get the size of the printer page
        //    Size sz = new Size(this.ActualWidth, this.ActualHeight);

        //    //update the layout of the visual to the printer page size.
        //    grdInvoice.Measure(sz);
        //    grdInvoice.Arrange(new Rect(new Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), sz));

        //    //now print the visual to printer to fit on the one page.
        //    printDlg.PrintVisual(grdInvoice, "Invoice " + invoiceName);
        //}

        //private void PrintVisual_Sized(UIElement toPrint)
        //{
        //    PrintDialog dlg = new PrintDialog();
        //    System.Printing.PrintQueue queue = dlg.PrintQueue;

        //    // Get C5 page size if possible from printer
        //    var availPageSizes = queue.GetPrintCapabilities().PageMediaSizeCapability;
        //    System.Printing.PageMediaSize pageSize = System.Data.Entity.Utilities.GetPageSize(availPageSizes, System.Printing.PageMediaSizeName.ISOC5Envelope);

        //    if (pageSize != null)
        //    {
        //        System.Printing.PrintTicket ticket = new System.Printing.PrintTicket
        //        {
        //            PageMediaSize = pageSize,
        //            InputBin = System.Printing.InputBin.AutoSelect,
        //            CopyCount = 1
        //        };

        //        dlg.UserPageRangeEnabled = false;

        //        var result = dlg.PrintQueue.MergeAndValidatePrintTicket(dlg.PrintTicket, ticket);
        //        System.Diagnostics.Debug.Print(result.ConflictStatus.ToString());

        //        // Try to get the page size honoured by someone!!!
        //        dlg.PrintQueue.DefaultPrintTicket = result.ValidatedPrintTicket;
        //        dlg.PrintQueue.UserPrintTicket = result.ValidatedPrintTicket;
        //        dlg.PrintTicket = result.ValidatedPrintTicket;

        //        // Height still seems to be A4 sized!?
        //        System.Diagnostics.Debug.Print("Height: " + dlg.PrintableAreaHeight);
        //    }

        //    // Ask user which printer they want...
        //    if (dlg.ShowDialog().GetValueOrDefault(false))
        //    {
        //        Size printSize = new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight);
        //        toPrint.Measure(printSize);
        //        toPrint.Arrange(new Rect(new Point(), printSize));
        //        toPrint.UpdateLayout();

        //        dlg.PrintVisual(toPrint, "My Print Job");
        //    }
        //}
    }
}

