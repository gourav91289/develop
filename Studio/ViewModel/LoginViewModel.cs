/**
* Filename: LoginViewModel.cs
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

using com.boutique.Model.Remote.Login;
using com.boutique.Service;
using System;
using System.ComponentModel;
using System.Net;
using System.Threading;

namespace com.boutique.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(IUserService userService
            , IBoutiqueService boutiqueService
            , IStitchingService stitchingService
            , ICustomerDetailService customerDetailService)
            : base(userService, boutiqueService, stitchingService, customerDetailService)        
        
        {
            this.LoginData = new LoginData();
        }
        
        private LoginData _LoginData;
        public LoginData LoginData
        {
            get { return _LoginData; }
            set
            {
                _LoginData = value; RaisePropertyChanged(() => LoginData);
            }
        }

        private bool _isLogin;
        public bool isLogin
        {
            get { return _isLogin; }
            set
            {
                _isLogin = value;
                RaisePropertyChanged(() => isLogin);
            }
        }

        #region for Action
        public Action UserNotValid { get; set; }

        #endregion

        public void LoginToApplication()
        {
            if (worker != null && worker.IsBusy == true)
                return;
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                if (isLogin)
                    OpenSettingWindow();
                else
                    UserNotValid();
            };

            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                var user = userService.GetUserByGUID(Base64ToGuid(userSettings.Key));

                if (user != null && user.UserName == UserName && Decrypt(user.Password) == Password)
                {
                    LoggedUserFullName = user.FirstName + " " + user.LastName;
                    BoutiqueDetails = user.boutique != null ? user.boutique : new Entity.Boutique(); 
                    Thread.Sleep(1000);
                    isLogin = true;
                }
                else
                {
                    ShowMessage("User is not valid");
                    isLogin = false;
                }


            };
            worker.RunWorkerAsync();
            worker.Dispose();
        }
      
    }
}

