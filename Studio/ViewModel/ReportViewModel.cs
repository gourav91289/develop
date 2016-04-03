


using com.boutique.Common.UserInterfaceHelper;
/**
* Filename: ReportViewModel.cs
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
using com.boutique.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace com.boutique.ViewModel
{
    public class ReportViewModel : BaseViewModel
    {
        public ReportViewModel(IUserService userService
            , IBoutiqueService boutiqueService
            , IStitchingService stitchingService
            , ICustomerDetailService customerDetailService)
            : base(userService, boutiqueService, stitchingService, customerDetailService)        
        
        {

        }

        #region for Properties      

        private string _FromDate = string.Empty; //new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("dd/MM/yyyy");
        public string FromDate
        {
            get { return _FromDate; }
            set
            {
                _FromDate = value;
                RaisePropertyChanged(() => FromDate);
            }
        }

        private string _ToDate = string.Empty; //new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1).ToString("dd/MM/yyyy");
        public string ToDate
        {
            get { return _ToDate; }
            set
            {
                _ToDate = value;
                RaisePropertyChanged(() => ToDate);
            }
        }

        private string _SaveFolderLocation = "Select Folder";
        public string SaveFolderLocation
        {
            get { return _SaveFolderLocation; }
            set
            {
                _SaveFolderLocation = value;
                RaisePropertyChanged(() => SaveFolderLocation);
            }
        }

        private string _SaveFileName = "Enter File Name";
        public string SaveFileName
        {
            get { return _SaveFileName; }
            set
            {
                _SaveFileName = value;
                RaisePropertyChanged(() => SaveFileName);
            }
        }

        #endregion

        #region for Action      

        #endregion

        #region for Methods            

        public void CreateCsvFile(IList<CustomerDetail> result)
        {
            if (worker != null && worker.IsBusy == true)
                return;
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                ShowMessage("CsvFile Created successfully");
                return;
            };

            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                string savedLoc = string.Format("{0}{1}", Path.Combine(SaveFolderLocation, SaveFileName.Replace(".", "").Replace("csv", "")), ".csv");
                result.ToCSV(exclude: "Id,DeliveryDate,ExtraLine,StitchingDetails,EmbroideryDetails,CreateOn,LastUpdatedOn,IsDeleted,ObjectState,_StitchingDetails,_EmbroideryDetails,BoutiqueId",
                    path: savedLoc);
            };
            worker.RunWorkerAsync();
            worker.Dispose();
        }

        #endregion

    }
}

