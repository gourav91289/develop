


using com.boutique.Entity;
using com.boutique.Model;
/**
* Filename:  MainViewModel.cs
*
* Copyright 2015 - 2016 Oman Infotech Incorporated
* All Rights Reserved.
*
* NOTICE:  All information contained herein is, and remains
* the property of Oman Infotech Incorporated and its suppliers,
* if any. The intellectual and technical concepts contained
* herein are proprietary to Oman Infotech Incorporated
* and its suppliers and may be covered by India, U.S. and Foreign Patents,
* patents in process, and are protected by trade secret or copyright law.
* Dissemination of this information or reproduction of this material
* is unlawful and strictly forbidden unless prior written permission is obtained
* from Oman Infotech.
*
*/
using com.boutique.Service;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace com.boutique.ViewModel
{
    public partial class MainViewModel 
    {
        #region for Action
        public Action<string> SetDataContextOfPopUp;
        public Action UpdateDataContext;
        public Action UpdateStitchingItem;
        #endregion

        #region for properties

        private bool _IsStitchingItem = false;
        public bool IsStitchingItem
        {
            get { return _IsStitchingItem; }
            set
            {
                _IsStitchingItem = value;
                RaisePropertyChanged(() => IsStitchingItem);
            }
        }

        private bool _IsDropDownOpen = false;
        public bool IsDropDownOpen
        {
            get { return _IsDropDownOpen; }
            set
            {
                _IsDropDownOpen = value;
                RaisePropertyChanged(() => IsDropDownOpen);
            }
        }

        private bool _IsEditable = false;
        public bool IsEditable
        {
            get { return _IsEditable; }
            set
            {
                _IsEditable = value;
                RaisePropertyChanged(() => IsEditable);
            }
        }

        private MeasurementModel _measurement = new MeasurementModel();
        public MeasurementModel measurement
        {
            get { return _measurement; }
            set
            {
                _measurement = value;
                RaisePropertyChanged(() => measurement);
            }
        }

        private List<StitchingItem> _StitchingItem = new List<StitchingItem>();
        public List<StitchingItem> StitchingItem
        {
            get { return _StitchingItem; }
            set
            {
                _StitchingItem = value;
                RaisePropertyChanged(() => StitchingItem);
            }
        }

        private List<ParameterType> _Parameters = new List<ParameterType>();
        public List<ParameterType> Parameters
        {
            get { return _Parameters; }
            set
            {
                _Parameters = value;
                RaisePropertyChanged(() => Parameters);
            }
        }

        private List<ParameterType> _StitchingItemParameters = new List<ParameterType>();
        public List<ParameterType> StitchingItemParameters
        {
            get { return _StitchingItemParameters; }
            set
            {
                _StitchingItemParameters = value;
                RaisePropertyChanged(() => StitchingItemParameters);
            }
        }

        private StitchingItem _GridSeletedStitchingItem = new StitchingItem();
        public StitchingItem GridSeletedStitchingItem
        {
            get { return _GridSeletedStitchingItem; }
            set
            {
                _GridSeletedStitchingItem = value;
                RaisePropertyChanged(() => GridSeletedStitchingItem);
            }
        }

        private CustomerDetail _EditableCustomerDetail = new CustomerDetail();
        public CustomerDetail EditableCustomerDetail
        {
            get { return _EditableCustomerDetail; }
            set
            {
                _EditableCustomerDetail = value;
                RaisePropertyChanged(() => EditableCustomerDetail);
            }
        }

        private string _BillNumber = string.Empty;
        public string BillNumber
        {
            get { return _BillNumber; }
            set
            {
                _BillNumber = value;
                RaisePropertyChanged(() => BillNumber);
            }
        }

        #endregion

        #region Commands    

        private RelayCommand<string> _ShowStitchingItemPopUp;
        public RelayCommand<string> ShowStitchingItemPopUp
        {
            get { return _ShowStitchingItemPopUp ?? (_ShowStitchingItemPopUp = new RelayCommand<string>(ShowStitchingItem)); }
        }

        private RelayCommand<StitchingItem> _AssetGridRowSelectedCommand;
        public RelayCommand<StitchingItem> AssetGridRowSelectedCommand
        {
            get { return _AssetGridRowSelectedCommand ?? (_AssetGridRowSelectedCommand = 
                    new RelayCommand<StitchingItem>(AssetGridRowSelected)); }
        }

        #endregion

        #region for Method

        public void ShowStitchingItem(string item)
        {
            SetDataContextOfPopUp(item);
            IsStitchingItem = true;
        }

        public void AssetGridRowSelected(StitchingItem item)
        {
            GridSeletedStitchingItem = item;
            UpdateStitchingItem();
        }

        public void SetEditableOrder(CustomerDetail customerDetail)
        {
            IsEditable = true;
            EditableCustomerDetail = customerDetail;
            measurement = new MeasurementModel()
            {
                BillNo = measurement.BillNo.Replace("i.e", "").Trim(),
                Date = customerDetail.CreateOn.ToString("dd/MM/yyyy"),
                DeliveryDate = customerDetail.DeliveryDate.ToString("dd/MM/yyyy"),               
                Address = customerDetail.Address,
                ContactNumber = customerDetail.ContactNumber,
                CustomerName = customerDetail.CustomerName,
            };
            this.StitchingItem = stitchingService.GetAllUndeletedstitchingItems(userSettings.boutique.BoutiqueId);
            //this.Parameters = stitchingService.GetAllParameterTypes(userSettings.boutique.BoutiqueId);
        }

        #endregion

    }
}