using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Linq;
using System.Collections;
using System.Windows.Media.Imaging;
using System.IO;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace CapturedImages
{
    public partial class CustomStitchingImage : UserControl, INotifyPropertyChanged
    {
        #region DropDownChange event to get value
        public event Action<List<SelectedMultiPelItems>, CustomStitchingImage> SelectedData;
        #endregion

        #region For Setting Properties 
        public double ListWidth
        {
            get { return (double)GetValue(listWidth); }
            set
            {
                SetValue(listWidth, value);
            }
        }

        internal static readonly DependencyProperty listWidth =
            DependencyProperty.Register("ListWidth", typeof(double), typeof(CustomStitchingImage));

        #endregion

        #region For Properties

        WebCam webcam;

        private int _imageCounter = 0;

        private bool _IsDropDownOpen = false;
        public bool IsDropDownOpen
        {
            get { return _IsDropDownOpen; }
            set
            {
                _IsDropDownOpen = value;
                OnPropertyChanged("IsDropDownOpen");
            }
        }        

        private ObservableCollection<SelectedMultiPelItems> _SelectedImages = new ObservableCollection<SelectedMultiPelItems>();
        public ObservableCollection<SelectedMultiPelItems> SelectedImages
        {
            get { return _SelectedImages; }
            set
            {
                _SelectedImages = value;
                OnPropertyChanged("SelectedImages");
            }
        }       

        #endregion      

        #region INotifyPropertyChanged Members     

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public CustomStitchingImage()
        {
            InitializeComponent();
            this.DataContext = this;
            SelectedImages.CollectionChanged += SelectedImages_CollectionChanged;
        }

        private void SelectedImages_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //if (SelectedImages.Count > 0)
            //    btnCaptureImages.Margin = new Thickness(0, 10, 0, 0);
            //else
            //    btnCaptureImages.Margin = new Thickness(0, 0, 0, 0);

            OnPropertyChanged("SelectedImages");
        }

        private void ImageRemoveItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var image = sender as Image;
            var stackPanel = image.Parent as WrapPanel;

            int childCount = 0;
            Image textName = null;

            foreach (var childeren in stackPanel.Children)
            {
                if (childCount == 0)
                {
                    textName = childeren as Image;
                    break;
                }

                childCount++;
            }

            if (textName != null)
            {
                var items = SelectedImages.ToList();
                items.RemoveAll(x => x.Key == Convert.ToInt16(textName.Tag));
                SelectedImages = new ObservableCollection<SelectedMultiPelItems>(items);
            }

            listSelectedItems.Items.Refresh();
           
            if (SelectedData != null)
            {
                SelectedData(SelectedImages.ToList(), this);
            }
        }      
       
        public void SelectedDropDownItem(BitmapSource value)
        {
            if (value != null)
            {
                if (SelectedImages == null)
                    SelectedImages = new ObservableCollection<SelectedMultiPelItems>();

                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)value));
                encoder.QualityLevel = 100;
                byte[] bit = new byte[0];
                using (MemoryStream stream = new MemoryStream())
                {
                    encoder.Frames.Add(BitmapFrame.Create((BitmapSource)value));
                    encoder.Save(stream);
                    bit = stream.ToArray();
                    stream.Close();
                }

                SelectedImages.Add(new SelectedMultiPelItems()
                {
                    Key = _imageCounter++,
                    Value = bit
                });

                if (SelectedData != null)
                    SelectedData(SelectedImages.ToList(), this);
            }
        }                           

        private void btnCaptureImages_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IsDropDownOpen = true;
            // TODO: Add event handler implementation here.
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }

        private void bntStart_Click(object sender, RoutedEventArgs e)
        {

            webcam.Start();
        }

        private void bntStop_Click(object sender, RoutedEventArgs e)
        {
            webcam.Stop();            
        }

        private void bntContinue_Click(object sender, RoutedEventArgs e)
        {
            webcam.Continue();
        }

        private void bntCapture_Click(object sender, RoutedEventArgs e)
        {
            imgCapture.Source = imgVideo.Source;
        }

        private void bntSaveImage_Click(object sender, RoutedEventArgs e)
        {
            //Helper.SaveImageCapture((BitmapSource)imgCapture.Source);
            SelectedDropDownItem((BitmapSource)imgCapture.Source);
        }

        private void bntResolution_Click(object sender, RoutedEventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntSetting_Click(object sender, RoutedEventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void MultiSelectUserControl_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (e.NewFocus is Button)
            {

            }
            else
            {
                IsDropDownOpen = false;

                if (SelectedData != null && (SelectedImages == null || SelectedImages.Count == 0))
                {
                    SelectedData(SelectedImages.ToList(), this);
                }
            }

            e.Handled = true;
        }

        private void PopUpImagecapture_Closed(object sender, EventArgs e)
        {
            webcam.Stop(); 
        }

        private void btnUploadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *gif; *.bmp)|*.jpg; *.jpeg; *gif; *.bmp";
            if(open.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(open.FileName));
                imgCapture.Source = image;
                SelectedDropDownItem((BitmapSource)imgCapture.Source);
            }
        }

    }

    public class SelectedMultiPelItems
    {
        public int Key { get; set; }
        public byte[] Value { get; set; }
    }
      
    public class BytesArrayConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var image = new BitmapImage();
            using (var ms = new System.IO.MemoryStream((byte[])value))
            {               
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad; // here
                image.StreamSource = ms;
                image.EndInit();
            }           

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
