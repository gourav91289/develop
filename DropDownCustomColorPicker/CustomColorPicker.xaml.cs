using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DropDownCustomColorPicker
{
    /// <summary>
    /// Interaction logic for CustomColorPicker.xaml
    /// </summary>
    public partial class CustomColorPicker : UserControl, INotifyPropertyChanged
    {
        public event Action<Color, CustomColorPicker> SelectedColorChanged;

        String _hexValue = string.Empty;

        public String HexValue
        {
            get { return _hexValue; }
            set { _hexValue = value; }
        }

        private Color selectedColor = Colors.Transparent;
        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                if (selectedColor != value)
                {
                    selectedColor = value;
                }
            }
        }

        public bool _isContexMenuOpened = false;

        private string _ColorText = "Select Color";
        public string ColorText
        {
            get { return _ColorText; }
            set
            {
                _ColorText = value;
                OnPropertyChanged("ColorText");
            }
        }

        #region INotifyPropertyChanged Members
     
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion 

        public CustomColorPicker()
        {
            InitializeComponent();
            this.DataContext = this;
            ColorPicker.Loaded += ColorPicker_Loaded;
            popupColorSelector.Opened += PopupColorSelector_Opened;
            popupColorSelector.Closed += PopupColorSelector_Closed;
            borderColor.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(b_PreviewMouseLeftButtonUp);
        }

        private void ColorPicker_Loaded(object sender, RoutedEventArgs e)
        {
            if(ColorText != "Select Color")
            {
                ColorText = "#" + (ColorText.Replace("#", "").Length > 6 ? ColorText.Replace("#", "").Substring(1) : ColorText);

                recContent.Stroke = (SolidColorBrush)(new BrushConverter().ConvertFrom(ColorText)); 
                recContent.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom(ColorText));
                HexValue = ColorText;
                ColorText = HexValue;
                colorName.Foreground = Brushes.White;

                recContent.Visibility = Visibility.Visible;
            }
        }

        private void PopupColorSelector_Opened(object sender, EventArgs e)
        {
            _isContexMenuOpened = true;
        }

        void PopupColorSelector_Closed(object sender, EventArgs e)
        {
            if (SelectedColorChanged != null)
            {
                SelectedColorChanged(cp.CustomColor, this);
            }
            recContent.Stroke = new SolidColorBrush(cp.CustomColor);
            recContent.Fill = new SolidColorBrush(cp.CustomColor);
            HexValue = string.Format("#{0}", cp.CustomColor.ToString().Substring(3));
            ColorText = HexValue;
            colorName.Foreground = Brushes.White;

            recContent.Visibility = Visibility.Visible;
        }

        void b_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupColorSelector.IsOpen = true;
        }

        private void popupColorSelector_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }
    }
}
