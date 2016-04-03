#region File Info
// File       : PreviewWindow.xaml.cs
// Description: 
// Package    : VisualPrint
//
//
#endregion
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace VisualPrint
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PreviewWindow : Window
    {
        public PreviewWindow(FlowDocument fdoc)
        {
            InitializeComponent();
            Viewer.Document = fdoc;
            Viewer.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
        }

        #region RoutedEvents

        public static readonly RoutedEvent PrintEvent = EventManager.RegisterRoutedEvent(
            "Print", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PreviewWindow));

        public event RoutedEventHandler Print
        {
            add { AddHandler(PrintEvent, value); }
            remove { RemoveHandler(PrintEvent, value); }
        }

        public FlowDocument Document { get { return Viewer.Document; } }

        #endregion

        private void OnPrintClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(PrintEvent));
            Close();
        }

        private void OnClosed(object sender, EventArgs e)
        {
            Viewer.Document = null;
            //make sure the GC collects everything
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
