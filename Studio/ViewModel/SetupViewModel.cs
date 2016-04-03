/**
 * Filename:  SetupViewModel.cs
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

using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Net;
using com.boutique.ViewModel;
using com.boutique.Model.Remote.Login;
using com.boutique.Entity.Model;
using com.boutique.Entity;
using System.Configuration;
using System.ComponentModel;
using System.Threading;
using com.boutique.Service;
using System.Windows;
using com.boutique.Views;
using System.Linq;
using WhatsAppApi;
using com.boutique.Common.UserInterfaceHelper;

namespace com.boutique.ViewModel
{
    public class SetupViewModel : BaseViewModel
    {
        public SetupViewModel(IUserService userService
            , IBoutiqueService boutiqueService
            , IStitchingService stitchingService
            , ICustomerDetailService customerDetailService)
            : base(userService, boutiqueService, stitchingService, customerDetailService)
        {                  
        }

        #region for Properties

        private string _Configuration;
        public string Configuration
        {
            get
            {
                return _Configuration;
            }
            set
            {
                _Configuration = value;
                RaisePropertyChanged("Configuration");
            }
        }

        private bool _FirstTime = false;
        public bool FirstTime
        {
            get
            {
                return _FirstTime;
            }
            set
            {
                _FirstTime = value;
                RaisePropertyChanged("FirstTime");
            }
        }
        
        private bool _IsExired = false;
        public bool IsExired
        {
            get
            {
                return _IsExired;
            }
            set
            {
                _IsExired = value;
                RaisePropertyChanged("IsExired");
            }
        }

        #endregion

        #region for Action
        public Action ReturnToUserName { get; set; }
        #endregion

        #region for Methods

        public void PrepareSetUp()
        {
            if (worker != null && worker.IsBusy == true)
                return;
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
           
            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                //if (FirstTime)
                //    OpenSettingWindow();
                //else
                if (IsExired)
                {
                    return;
                }
                //else if (UIHelper.IsNetworkAvailable())
                    OpenLoginWindow();
                //else
                //    CloseAction();
            };

            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                //if (UIHelper.IsNetworkAvailable())
                //{
                    if (userSettings == null || string.IsNullOrEmpty(userSettings.Key))
                    {
                        AddUser(false);
                    }
                    else
                    {
                        User user = userService.GetUserByGUID(Base64ToGuid(userSettings.Key));
                        if (user != null)
                        {
                            if (TodayDate > user.ExpireDate)
                                IsExired = true;
                            else
                                IsExired = false;
                        }
                        else
                        {
                            AddUser(true);
                        }
                    }                   
                //}
                //else
                //{
                //    MessageBox.Show("You must connect to internet to proceed further");
                //    Thread.Sleep(1000);
                //}

            };
            worker.RunWorkerAsync();
            worker.Dispose();
        }

        public void AddUser(bool isSettings)
        {           
            Guid guid = Guid.NewGuid();

            if (isSettings)
            {
                boutiqueInformation = userSettings.boutique;
                boutiqueInformation.BoutiqueId = 0;
                var name = userSettings.Name.Split(' ');

                if (name.Length == 1)
                    FirstName = name[0];
                else if (name.Length == 2)
                {
                    FirstName = name[0];
                    LastName = name[1];
                }
                else
                {
                    LastName = string.Join(" ", name.Skip(name.Length - 2));
                    FirstName = userSettings.Name.Replace(LastName, "").Trim();
                }

                guid = Base64ToGuid(userSettings.Key);
                UserName = userSettings.Username;
                Password = !string.IsNullOrEmpty(userSettings.Password) ? Decrypt(userSettings.Password.ToString()) : "test";
            }

            if (!IsUserExists(UserName, null))
            {
                var boutique = boutiqueService.AddUpdateBoutique(boutiqueInformation);

                User user = new User()
                {
                    IsDeleted = false,
                    CreateOn = DateTime.Now,
                    LastUpdatedOn = DateTime.Now,
                    ExpireDate = DateTime.Now.AddYears(1),
                    IsActive = true,
                    FirstName = FirstName,
                    LastName = (LastName.Trim().ToLower() == "enter lastname" && string.IsNullOrEmpty(LastName) ? string.Empty : LastName),
                    UserName = UserName,
                    Password = Encrypt(Password.ToString()),
                    guid = guid,
                    boutique = boutique
                };

                user = userService.AddUpdateUser(user);

                //WhatsApp wa = new WhatsApp("919885149767", "S2pRzjFSWnVcHCwGFkjJuFI2oCM=", "Gourav Boutique APP", false, false);
                //wa.OnConnectSuccess += () =>
                //{
                //    wa.OnLoginSuccess += (phoneNumber, data) =>
                //    {
                //        wa.SendMessage("919855926390", "New User had registred " + boutique.Name +  " with us.");
                //    };
                //};

                if (user != null)
                {
                    Settings settings = new Settings()
                    {
                        Key = GuidToBase64(user.guid),
                        LoggedUserId = Encrypt(user.UserId.ToString()),
                        Name = user.FirstName + " " + user.LastName,
                        Username = user.UserName,
                        boutique = boutique,
                        Password = Encrypt(user.Password.ToString()),
                    };
                    SaveSettings(settings);
                    userSettings = RetriveSettings();
                    FirstTime = true;
                    Thread.Sleep(1000);
                }
                else
                {
                    ShowMessage("User is not registred with us, Please contact administrator");
                }
            }
        }

        #endregion

    }
}

