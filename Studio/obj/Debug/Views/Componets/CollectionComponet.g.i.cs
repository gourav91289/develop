﻿#pragma checksum "..\..\..\..\Views\Componets\CollectionComponet.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E012F150EF216F6632E6A9EA30EBC992"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdornedControl;
using Microsoft.Windows.Themes;
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
using WpfControls;
using WpfControls.Editors;
using com.boutique.Common.UserInterfaceHelper;
using com.boutique.Converters;
using com.boutique.ViewModel;


namespace com.boutique.Views.Componets {
    
    
    /// <summary>
    /// CollectionComponet
    /// </summary>
    public partial class CollectionComponet : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 1 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal com.boutique.Views.Componets.CollectionComponet CollectionUserControl;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanelCollection;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listSelectedCollection;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AutoCompleteTextbox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup PopUpQueryBuilderFilter;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCollectionMessage;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView QueryBuilderItemsCollection;
        
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
            System.Uri resourceLocater = new System.Uri("/com.boutique;component/views/componets/collectioncomponet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
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
            this.CollectionUserControl = ((com.boutique.Views.Componets.CollectionComponet)(target));
            return;
            case 2:
            this.stackPanelCollection = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.border = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.listSelectedCollection = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.AutoCompleteTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 92 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
            this.AutoCompleteTextbox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AutoCompleteTextbox_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 93 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
            this.AutoCompleteTextbox.KeyUp += new System.Windows.Input.KeyEventHandler(this.AutoCompleteTextbox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PopUpQueryBuilderFilter = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 110 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
            this.PopUpQueryBuilderFilter.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.PopUpQueryBuilderFilter_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblCollectionMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.QueryBuilderItemsCollection = ((System.Windows.Controls.ListView)(target));
            
            #line 120 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
            this.QueryBuilderItemsCollection.KeyDown += new System.Windows.Input.KeyEventHandler(this.QueryBuilderItems_KeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 77 "..\..\..\..\Views\Componets\CollectionComponet.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ImageRmoveCollection_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

