﻿#pragma checksum "..\..\..\..\Views\UserControls\WorkflowProperties.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2FAD7C204226FCAEEFB40CA6A79DD057"
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
using com.boutique.Common.UserInterfaceHelper;
using com.boutique.Converters;


namespace com.boutique.Views.UserControls {
    
    
    /// <summary>
    /// WorkflowProperties
    /// </summary>
    public partial class WorkflowProperties : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal com.boutique.Views.UserControls.WorkflowProperties WorkFlowProp;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridWorkFlowProperties;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popUpRootFile;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDirectoryRootPath;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRootDirectory;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView grdFileRoot;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView grdFileFolderDirectory;
        
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
            System.Uri resourceLocater = new System.Uri("/com.boutique;component/views/usercontrols/workflowproperties.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\UserControls\WorkflowProperties.xaml"
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
            this.WorkFlowProp = ((com.boutique.Views.UserControls.WorkflowProperties)(target));
            return;
            case 2:
            this.GridWorkFlowProperties = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.popUpRootFile = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 4:
            this.txtDirectoryRootPath = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.lblRootDirectory = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.grdFileRoot = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.grdFileFolderDirectory = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

