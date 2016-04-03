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


using System.ComponentModel;
using GalaSoft.MvvmLight.Command;
using com.boutique.Service;
using com.boutique.Views;
using com.boutique.Entity;
using System.Collections.Generic;

namespace com.boutique.ViewModel
{
    public partial class MainViewModel : BaseViewModel 
    {
        public MainViewModel(IUserService userService
            , IBoutiqueService boutiqueService
            , IStitchingService stitchingService
            , ICustomerDetailService customerDetailService)
            : base(userService, boutiqueService, stitchingService, customerDetailService)
        {
            this.StitchingItem = stitchingService.GetAllUndeletedstitchingItems(userSettings.boutique.BoutiqueId);            
            this.BillNumber = (1000 + customerDetailService.GetTotalCount(userSettings.boutique.BoutiqueId) + 1).ToString();
        }

        #region for Internal Properties

        #endregion

        #region for Command
        private RelayCommand _OnSignOut;
        public RelayCommand OnSignOut
        {
            get { return _OnSignOut ?? (_OnSignOut = new RelayCommand(SignOut)); }
        }
        #endregion

        #region for Action
        #endregion

        #region for properties


        #endregion

        #region Methods

        public void SignOut()
        {
            if (worker != null && worker.IsBusy == true)
                return;
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                ViewModel.ViewModelLocator.Cleanup(); //we need to dispose view models on logout as they still exist in application scope.
                Login w = new Login();
                CloseAction();
                w.Show();
            };

            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
            };
            worker.RunWorkerAsync();
            worker.Dispose();
        }

        #endregion

    }
}