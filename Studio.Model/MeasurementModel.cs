using com.boutique.Entity;
/**
* Filename:  LoginData.cs
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace com.boutique.Model
{
    public class MeasurementModel : BaseModel, INotifyPropertyChanged
    {
        private string _BillNo = "i.e";
        public string BillNo
        {
            get { return _BillNo; }
            set
            {
                _BillNo = value;
                OnPropertyChanged("BillNo");
            }
        }

        private string _Date = DateTime.Today.ToString("dd/MM/yyyy");
        public string Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                OnPropertyChanged("Date");
            }
        }

        private string _DeliveryDate = DateTime.Today.ToString("dd/MM/yyyy");
        public string DeliveryDate
        {
            get { return _DeliveryDate; }
            set
            {
                _DeliveryDate = value;
                OnPropertyChanged("DeliveryDate");
            }
        }

        private string _CustomerName = "Enter Customer Name";
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                _CustomerName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        private string _ContactNumber = "Enter Contact Number";
        public string ContactNumber
        {
            get { return _ContactNumber; }
            set
            {
                _ContactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }

        private string _Address = "Enter Address";
        public string Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
                OnPropertyChanged("Address");
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

    }

    public class StitchingMeasurementModel : INotifyPropertyChanged
    {
        private string _SerialNumber = "1";
        public string SerialNumber
        {
            get { return _SerialNumber; }
            set
            {
                _SerialNumber = value;
                OnPropertyChanged("SerialNumber");
            }
        }

        private string _ItemCount = "No Of Items";
        public string ItemCount
        {
            get
            {
                return _ItemCount;
            }
            set
            {
                _ItemCount = value;
                OnPropertyChanged("ItemCount");
            }
        }

        private string _Price = "Rate Per Unit";
        public string Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                OnPropertyChanged("Price");
            }
        }

        private string _Color = "Select Color";
        public string Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                OnPropertyChanged("Color");
            }
        }

        private string _StitchingItemName = "Select Item";
        public string StitchingItemName
        {
            get { return _StitchingItemName; }
            set
            {
                _StitchingItemName = value;
                OnPropertyChanged("StitchingItemName");
            }
        }

        private List<Parameter> _Parameter;
        public List<Parameter> Parameter
        {
            get { return _Parameter; }
            set
            {
                _Parameter = value;
                OnPropertyChanged("Parameter");
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
    }

    public class StitchingEmbroidaryModel : INotifyPropertyChanged
    {
        private string _SerialNumber = "1";
        public string SerialNumber
        {
            get { return _SerialNumber; }
            set
            {
                _SerialNumber = value;
                OnPropertyChanged("SerialNumber");
            }
        }

        private string _ItemCount = "No Of Items";
        public string ItemCount
        {
            get
            {
                return _ItemCount;
            }
            set
            {
                _ItemCount = value;
                OnPropertyChanged("ItemCount");
            }
        }

        private string _Code = "Design Code";
        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
                OnPropertyChanged("Code");
            }
        }

        private string _Price = "Rate Per Unit";
        public string Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                OnPropertyChanged("Price");
            }
        }

        private string _Color = "Select Color";
        public string Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                OnPropertyChanged("Color");
            }
        }

        private string _StitchingItemName = "Select Item";
        public string StitchingItemName
        {
            get { return _StitchingItemName; }
            set
            {
                _StitchingItemName = value;
                OnPropertyChanged("StitchingItemName");
            }
        }

        private string _ExtraNote = "Extra Notes";
        public string ExtraNote
        {
            get { return _ExtraNote; }
            set
            {
                _ExtraNote = value;
                OnPropertyChanged("ExtraNote");
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
    }

    public class Parameter
    {
        public string name { get; set; }
        public string value { get; set; }
    }

}
