﻿#pragma checksum "..\..\..\..\Views\Setting\Setting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2AE1EC3CCBE14483DE074071425D4EB1"
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
using com.boutique.Views;


namespace com.boutique.Views {
    
    
    /// <summary>
    /// Setting
    /// </summary>
    public partial class Setting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\Views\Setting\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal com.boutique.Views.Setting SettingsWindow;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\Setting\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdTop;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\Setting\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MinimizeSettingWindow;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\Setting\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseSettingWindow;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\Setting\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LogoutSettingWindow;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Views\Setting\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Measurement;
        
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
            System.Uri resourceLocater = new System.Uri("/com.boutique;component/views/setting/setting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Setting\Setting.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.SettingsWindow = ((com.boutique.Views.Setting)(target));
            
            #line 14 "..\..\..\..\Views\Setting\Setting.xaml"
            this.SettingsWindow.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Settings_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.brdTop = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.MinimizeSettingWindow = ((System.Windows.Controls.Image)(target));
            
            #line 39 "..\..\..\..\Views\Setting\Setting.xaml"
            this.MinimizeSettingWindow.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeSettingWindow_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseSettingWindow = ((System.Windows.Controls.Image)(target));
            
            #line 44 "..\..\..\..\Views\Setting\Setting.xaml"
            this.CloseSettingWindow.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseSettingWindow_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LogoutSettingWindow = ((System.Windows.Controls.Image)(target));
            
            #line 49 "..\..\..\..\Views\Setting\Setting.xaml"
            this.LogoutSettingWindow.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.LogoutSettingWindow_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Measurement = ((System.Windows.Controls.Image)(target));
            
            #line 113 "..\..\..\..\Views\Setting\Setting.xaml"
            this.Measurement.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Measurement_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

