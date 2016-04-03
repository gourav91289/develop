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

using com.boutique.Entity;
using com.boutique.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;

namespace com.boutique.ViewModel
{
    public partial class MainViewModel 
    {
        #region for Action
       
        #endregion

        #region for properties

        private CustomerDetail _InvoiceCustomerDetail;
        public CustomerDetail InvoiceCustomerDetail
        {
            get { return _InvoiceCustomerDetail; }
            set
            {
                _InvoiceCustomerDetail = value;
                RaisePropertyChanged(() => InvoiceCustomerDetail);
            }
        }

        private string _InvoiceTotal;
        public string InvoiceTotal
        {
            get { return _InvoiceTotal; }
            set
            {
                _InvoiceTotal = value;
                RaisePropertyChanged(() => InvoiceTotal);
            }
        }

        private bool _InPritable = true;
        public bool InPritable
        {
            get { return _InPritable; }
            set
            {
                _InPritable = value;
                RaisePropertyChanged(() => InPritable);
            }
        }

        #endregion

        #region Commands    

        #endregion

        #region for Method


        #endregion

    }
}