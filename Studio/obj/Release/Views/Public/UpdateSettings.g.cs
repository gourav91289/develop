﻿#pragma checksum "..\..\..\..\Views\Public\UpdateSettings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C811F4F4E7640D1A02637E2F4C4A9364"
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
using com.boutique.Views.UserControls;


namespace com.boutique.Views {
    
    
    /// <summary>
    /// UpdateSettings
    /// </summary>
    public partial class UpdateSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\Views\Public\UpdateSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal com.boutique.Views.UpdateSettings UpdateSettingsWindow;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\Public\UpdateSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridDataContent;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\Public\UpdateSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdTop;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\Public\UpdateSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MinimizeSettingWindow;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\Public\UpdateSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseSettingWindow;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\Public\UpdateSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup LoadinDataContentPopup;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Views\Public\UpdateSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLoginProcessing;
        
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
            System.Uri resourceLocater = new System.Uri("/com.boutique;component/views/public/updatesettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Public\UpdateSettings.xaml"
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
            this.UpdateSettingsWindow = ((com.boutique.Views.UpdateSettings)(target));
            
            #line 15 "..\..\..\..\Views\Public\UpdateSettings.xaml"
            this.UpdateSettingsWindow.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Settings_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridDataContent = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.brdTop = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.MinimizeSettingWindow = ((System.Windows.Controls.Image)(target));
            
            #line 54 "..\..\..\..\Views\Public\UpdateSettings.xaml"
            this.MinimizeSettingWindow.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeSettingWindow_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CloseSettingWindow = ((System.Windows.Controls.Image)(target));
            
            #line 59 "..\..\..\..\Views\Public\UpdateSettings.xaml"
            this.CloseSettingWindow.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseSettingWindow_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LoadinDataContentPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 7:
            this.imgLoginProcessing = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

