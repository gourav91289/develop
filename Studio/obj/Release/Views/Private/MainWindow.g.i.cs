﻿#pragma checksum "..\..\..\..\Views\Private\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F144334E821C5CE2E211CE75A7BD742C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using com.levelsbeyond.Common.UserInterfaceHelper;
using com.levelsbeyond.Converters;
using com.levelsbeyond.Views.UserControls;


namespace com.levelsbeyond.Views.Private {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal com.levelsbeyond.Views.Private.MainWindow MainPanel;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabAssets;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabIngest;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabStatus;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup SettingPopUp;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup AlertBox;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup ChangePasswordBox;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup AboutAccessEngine;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Views\Private\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UCWFDynamicProp;
        
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
            System.Uri resourceLocater = new System.Uri("/com.levelsbeyond;component/views/private/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Private\MainWindow.xaml"
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
            this.MainPanel = ((com.levelsbeyond.Views.Private.MainWindow)(target));
            
            #line 7 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.MainPanel.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.MainPanel_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.MainPanel.SizeChanged += new System.Windows.SizeChangedEventHandler(this.MainPanel_SizeChanged);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.MainPanel.Closed += new System.EventHandler(this.MainPanel_Closed);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.MainPanel.Closing += new System.ComponentModel.CancelEventHandler(this.MainPanel_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 74 "..\..\..\..\Views\Private\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MainWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 76 "..\..\..\..\Views\Private\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenCloseSetting);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tabAssets = ((System.Windows.Controls.TabItem)(target));
            
            #line 90 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.tabAssets.Drop += new System.Windows.DragEventHandler(this.DropBox_Drop);
            
            #line default
            #line hidden
            
            #line 90 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.tabAssets.DragOver += new System.Windows.DragEventHandler(this.DropBox_DragOver);
            
            #line default
            #line hidden
            
            #line 91 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.tabAssets.DragLeave += new System.Windows.DragEventHandler(this.DropBox_DragLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tabIngest = ((System.Windows.Controls.TabItem)(target));
            return;
            case 6:
            this.tabStatus = ((System.Windows.Controls.TabItem)(target));
            
            #line 104 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.tabStatus.Drop += new System.Windows.DragEventHandler(this.DropBox_Drop);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.tabStatus.DragOver += new System.Windows.DragEventHandler(this.DropBox_DragOver);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\Views\Private\MainWindow.xaml"
            this.tabStatus.DragLeave += new System.Windows.DragEventHandler(this.DropBox_DragLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SettingPopUp = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 8:
            this.AlertBox = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 9:
            this.ChangePasswordBox = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 10:
            this.AboutAccessEngine = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 11:
            this.UCWFDynamicProp = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

