﻿#pragma checksum "..\..\..\..\Views\Reports\Reports.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D74E065C8AD41A8CEB2CCF8EE71B60E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfAnimatedGif;
using com.boutique.Common.UserInterfaceHelper;
using com.boutique.Converters;
using com.boutique.Views;
using com.boutique.Views.UserControls;


namespace com.boutique.Views {
    
    
    /// <summary>
    /// Reports
    /// </summary>
    public partial class Reports : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal com.boutique.Views.Reports ReportsWindow;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtToday;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MinimizeSettingWindow;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseSettingWindow;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGenrateReport;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDateFrom;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDateTo;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFolder;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFileName;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popupDateSelector;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calendar;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup PopGenrateReportItems;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListreportItem;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\..\Views\Reports\Reports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup AlertBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/com.boutique;component/views/reports/reports.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Reports\Reports.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ReportsWindow = ((com.boutique.Views.Reports)(target));
            return;
            case 2:
            this.txtToday = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.MinimizeSettingWindow = ((System.Windows.Controls.Image)(target));
            
            #line 57 "..\..\..\..\Views\Reports\Reports.xaml"
            this.MinimizeSettingWindow.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeSettingWindow_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseSettingWindow = ((System.Windows.Controls.Image)(target));
            
            #line 62 "..\..\..\..\Views\Reports\Reports.xaml"
            this.CloseSettingWindow.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseSettingWindow_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtGenrateReport = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\..\..\Views\Reports\Reports.xaml"
            this.txtGenrateReport.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.genrate_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtDateFrom = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\..\..\Views\Reports\Reports.xaml"
            this.txtDateFrom.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.txtDate_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtDateTo = ((System.Windows.Controls.TextBox)(target));
            
            #line 113 "..\..\..\..\Views\Reports\Reports.xaml"
            this.txtDateTo.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.txtDate_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtFolder = ((System.Windows.Controls.TextBox)(target));
            
            #line 125 "..\..\..\..\Views\Reports\Reports.xaml"
            this.txtFolder.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.txtFolder_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtFileName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\..\Views\Reports\Reports.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnGenrateReport_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.popupDateSelector = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 12:
            this.calendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 160 "..\..\..\..\Views\Reports\Reports.xaml"
            this.calendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.calendar_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.PopGenrateReportItems = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 14:
            this.ListreportItem = ((System.Windows.Controls.ListView)(target));
            
            #line 177 "..\..\..\..\Views\Reports\Reports.xaml"
            this.ListreportItem.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListreportItem_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 15:
            this.AlertBox = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

