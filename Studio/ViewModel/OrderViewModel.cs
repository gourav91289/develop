/**
* Filename: OrderViewModel.cs
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
using com.boutique.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace com.boutique.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel(IUserService userService
            , IBoutiqueService boutiqueService
            , IStitchingService stitchingService
            , ICustomerDetailService customerDetailService)
            : base(userService, boutiqueService, stitchingService, customerDetailService)        
        
        {

        }

        #region for Properties 

        private int _TotalOrder = 0;
        public int TotalOrder
        {
            get { return _TotalOrder; }
            set
            {
                _TotalOrder = value;
                RaisePropertyChanged(() => TotalOrder);
            }
        }

        private List<CustomerDetail> _OrderItems = new List<CustomerDetail>();
        public List<CustomerDetail> OrderItems
        {
            get { return _OrderItems; }
            set
            {
                _OrderItems = value;
                RaisePropertyChanged(() => OrderItems);
            }
        }

        private string _IsTodayOrders = string.Empty;
        public string IsTodayOrders

        {
            get { return _IsTodayOrders; }
            set
            {
                _IsTodayOrders = value;
                RaisePropertyChanged(() => IsTodayOrders);
            }
        }

        private string _FromDate = string.Empty; 
        public string FromDate
        {
            get { return _FromDate; }
            set
            {
                _FromDate = value;
                RaisePropertyChanged(() => FromDate);
            }
        }

        private string _ToDate = string.Empty; 
        public string ToDate
        {
            get { return _ToDate; }
            set
            {
                _ToDate = value;
                RaisePropertyChanged(() => ToDate);
            }
        }

        public bool IsPagingFired = true;

        public bool IsGetOrderCount = false;

        private bool _IsBackgroundInProgress = false;
        public bool IsBackgroundInProgress

        {
            get { return _IsBackgroundInProgress; }
            set
            {
                _IsBackgroundInProgress = value;
                RaisePropertyChanged(() => IsBackgroundInProgress);
            }
        }

        private bool _IsOnLoad = true;
        public bool IsOnLoad

        {
            get { return _IsOnLoad; }
            set
            {
                _IsOnLoad = value;
                RaisePropertyChanged(() => IsOnLoad);
            }
        }

        private DateTime _StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public DateTime StartDate
        {
            get { return _StartDate; }
            set
            {
                _StartDate = value;
                RaisePropertyChanged(() => StartDate);
            }
        }

        private DateTime _EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        public DateTime EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                RaisePropertyChanged(() => EndDate);
            }
        }

        #endregion

        #region for Action      

        #endregion

        #region for Methods      

        public void GetTodayDeliveryOrders()
        {
            OrderItems = customerDetailService.GetTodayDeliverOrders(userSettings.boutique.BoutiqueId);
        }

        public void GetTodayOrders()
        {
            OrderItems = customerDetailService.GetTodayOrders(userSettings.boutique.BoutiqueId);
        }

        public void GetOrders(DateTime startDate, DateTime endDate, int Page, int Size )
        {
            IsBackgroundInProgress = true;

            if (worker != null && worker.IsBusy == true)
                return;
            worker = new BackgroundWorker();

            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                IsPagingFired = true;
                IsBackgroundInProgress = false;
            };

            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                if(!IsGetOrderCount)
                {
                    TotalOrder = customerDetailService.GetTotalCount(startDate, endDate, userSettings.boutique.BoutiqueId);
                    IsGetOrderCount = true;
                }

                IsPagingFired = false;
                #region Bind Asset Grid

                var result = customerDetailService.GetOrders(startDate, endDate, Page, Size
                    , userSettings.boutique.BoutiqueId).ToList();

                if (Page == 1)
                    OrderItems = result;
                else
                    OrderItems.Concat(result);

                #endregion
            };

            worker.RunWorkerAsync();
            worker.Dispose();
           
        }       

        #endregion

    }
}

