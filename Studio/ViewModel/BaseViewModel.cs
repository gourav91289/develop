/**
* Filename:  BaseViewModel.cs
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

using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.Unity;
using com.boutique.Service;
using com.boutique.Entity.Model;
using System.Text;
using System.Security.Cryptography;
using com.boutique.Entity;
using com.boutique.Common.UserInterfaceHelper;
using com.boutique.Model;

namespace com.boutique.ViewModel
{

    public class BaseViewModel : ViewModelBase , IDataErrorInfo
    {  

        public BaseViewModel(IUserService userService
            , IBoutiqueService boutiqueService
            , IStitchingService stitchingService
            , ICustomerDetailService customerDetailService)
        {
            InitializeServices();

            if (this.userService == null)
                this.userService = userService;

            if (this.boutiqueService == null)
                this.boutiqueService = boutiqueService;

            if (this.stitchingService == null)
                this.stitchingService = stitchingService;

            if (this.customerDetailService == null)
                this.customerDetailService = customerDetailService;
        }

        #region for Internal Properties

        public BackgroundWorker worker;

        private static DateTime _TodayDate = (UIHelper.IsNetworkAvailable() ? UIHelper.GetNistTime() : DateTime.Today);
        public static DateTime TodayDate
        {
            get
            {
                return _TodayDate;
            }
            set
            {
                _TodayDate = value;
            }
        }

        #endregion

        void InitializeServices()
        {
            boutiqueInformation = new Boutique();            
            this.userSettings = new Settings();
            this.userSettings.boutique = new Boutique();
            userSettings = RetriveSettings();
        }

        #region for Action
        public Action CloseAction { get; set; }

        #endregion

        #region for command
        private RelayCommand _CloseAlert;
        public RelayCommand CloseAlert { get { return _CloseAlert ?? (_CloseAlert = new RelayCommand(CloseMessage)); } }
        #endregion

        #region for properties

        [Dependency]
        private IUserService _userService { get; set; }
        public IUserService userService
        {
            get
            {
                return _userService;
            }
            set
            {
                _userService = value;
            }
        }

        [Dependency]
        private IBoutiqueService _boutiqueService { get; set; }
        public IBoutiqueService boutiqueService
        {
            get
            {
                return _boutiqueService;
            }
            set
            {
                _boutiqueService = value;
            }
        }

        [Dependency]
        private IStitchingService _stitchingService { get; set; }
        public IStitchingService stitchingService
        {
            get
            {
                return _stitchingService;
            }
            set
            {
                _stitchingService = value;
            }
        }

        [Dependency]
        private ICustomerDetailService _customerDetailService { get; set; }
        public ICustomerDetailService customerDetailService
        {
            get
            {
                return _customerDetailService;
            }
            set
            {
                _customerDetailService = value;
            }
        }

        private string _FirstName = "Enter FirstName";
        [Required]
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        private string _LastName = "Enter LastName";
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        private string _UserName = "Enter UserName";
        [Required]
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                RaisePropertyChanged("UserName");
            }
        }

        private string _Password = string.Empty;
        [Required]
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                RaisePropertyChanged("Password");
            }
        }

        private string _Name = "Enter Boutique Name";
        [Required]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        string IDataErrorInfo.this[string propertyName] // Part of the IDataErrorInfo Interface
        {
            get { return GetMessage(propertyName); }
        }

        public static string LoggedUserFullName { get; set; }
        public static Boutique BoutiqueDetails { get; set; }

        private Settings _userSettings;
        public Settings userSettings
        {
            get
            {
                return _userSettings;
            }
            set
            {
                _userSettings = value;
                RaisePropertyChanged("userSettings");
            }
        }

        private Boutique _boutiqueInformation;
        public Boutique boutiqueInformation
        {
            get
            {
                return _boutiqueInformation;
            }
            set
            {
                _boutiqueInformation = value;
                RaisePropertyChanged("boutiqueInformation");
            }
        }

        private bool _IsAlertOpen = false;
        public bool IsAlertOpen
        {
            get { return _IsAlertOpen; }
            set
            {
                if (_IsAlertOpen == value) return;
                _IsAlertOpen = value;
                RaisePropertyChanged("IsAlertOpen");
            }
        }

        private string _AlertMessage;
        public string AlertMessage
        {
            get
            {
                return _AlertMessage;
            }
            set
            {
                _AlertMessage = value;
                RaisePropertyChanged("AlertMessage");
            }
        }

        private bool _IsParentWindowEnabled = true;
        public bool IsParentWindowEnabled
        {
            get { return _IsParentWindowEnabled; }
            set
            {
                if (_IsParentWindowEnabled == value) return;
                _IsParentWindowEnabled = value;
                RaisePropertyChanged("IsParentWindowEnabled");
            }
        }

        private ReportModel _SelectedReport = new ReportModel() { type = "Select", value = 0 };
        public ReportModel SelectedReport
        {
            get { return _SelectedReport; }
            set
            {
                _SelectedReport = value;
                RaisePropertyChanged(() => SelectedReport);
            }
        }

        private List<ReportModel> _ReportItems = new List<ReportModel>();
        public List<ReportModel> ReportItems
        {
            get { return _ReportItems; }
            set
            {
                _ReportItems = value;
                RaisePropertyChanged(() => ReportItems);
            }
        }

        #endregion

        #region Methods
        public void SetReportTypes()
        {
            List<ReportModel> model = new List<ReportModel>();
            model.Add(new ReportModel() { type = "Select", value = 0 });
            model.Add(new ReportModel() { type = "Current Month", value = 1 });
            model.Add(new ReportModel() { type = "Last Month", value = 2 });
            model.Add(new ReportModel() { type = "Last Two Months", value = 3 });
            model.Add(new ReportModel() { type = "Last Three Months", value = 4 });
            model.Add(new ReportModel() { type = "Last Six Months", value = 5 });

            ReportItems = model;
        }
        public string GetIsolatedStorageDirectoryPath()
        {
            string path = ConfigurationManager.AppSettings["DirName"] + "/" +
                ConfigurationManager.AppSettings["DirPath"] + "/" +
                ConfigurationManager.AppSettings["FileName"];
            return path;
        }      

        public Settings RetriveSettings()
        {
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null))
                {                   

                    string dirName = ConfigurationManager.AppSettings["DirName"];
                    if (isoStore.DirectoryExists(dirName) == false)
                        isoStore.CreateDirectory(dirName);
                    if (isoStore.DirectoryExists(dirName + "/config") == false)
                        isoStore.CreateDirectory(dirName + "/config");

                    if (isoStore.FileExists(GetIsolatedStorageDirectoryPath()))
                    {
                        //isoStore.DeleteFile(GetIsolatedStorageDirectoryPath());
                        //return new Settings();

                        using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(GetIsolatedStorageDirectoryPath(), FileMode.Open, isoStore))
                        {
                            using (StreamReader reader = new StreamReader(isoStream))
                            {
                                var stng = reader.ReadToEnd();
                                if (String.IsNullOrEmpty(stng) == false)
                                    return Helper.Helpers.SerializeHelper.JsonDeserialize<Settings>(stng);
                                return new Settings();
                            }
                        }
                    }
                    else
                    {
                        return new Settings();
                    }
                }
            }
            catch (System.Security.SecurityException sx)
            {
                throw;
            }
        }      

        public Result SaveSettings(Settings settings)
        {
            Result result = new Result();           
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null))
                {
                    string dirName = ConfigurationManager.AppSettings["DirName"];
                    if (isoStore.DirectoryExists(dirName) == false)
                        isoStore.CreateDirectory(dirName);
                    if (isoStore.DirectoryExists(dirName + "/config") == false)
                        isoStore.CreateDirectory(dirName + "/config");

                    if (isoStore.FileExists(GetIsolatedStorageDirectoryPath()))
                    {
                        using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(GetIsolatedStorageDirectoryPath(), FileMode.Truncate, isoStore))
                        {
                            using (StreamWriter writer = new StreamWriter(isoStream))
                            {
                                var stng = Helper.Helpers.SerializeHelper.JSONSerialize(settings);
                                writer.Write(stng);
                            }
                        }
                    }
                    else
                    {
                        using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(GetIsolatedStorageDirectoryPath(), FileMode.CreateNew, isoStore))
                        {
                            using (StreamWriter writer = new StreamWriter(isoStream))
                            {
                                var stng = Helper.Helpers.SerializeHelper.JSONSerialize(settings);
                                writer.Write(stng);
                            }
                        }
                    }
                }
            }
            catch (System.Security.SecurityException sx)
            {
                result.IsSuccess = false;
                result.Exception = sx.GetBaseException();
                result.ErrorMessage = sx.GetBaseException().Message;
                return result;
                throw;
            }

            result.IsSuccess = true;
            return result;
        }

        public void ShowMessage(string message)
        {
            AlertMessage = message;
            IsAlertOpen = true;
            IsParentWindowEnabled = false;
        }

        public string GuidToBase64(Guid guid)
        {
            return Convert.ToBase64String(guid.ToByteArray()).Replace("/", "-").Replace("+", "_").Replace("=", "");
        }

        public Guid Base64ToGuid(string base64)
        {
            Guid guid = default(Guid);
            base64 = base64.Replace("-", "/").Replace("_", "+") + "==";

            try
            {
                guid = new Guid(Convert.FromBase64String(base64));
            }
            catch (Exception ex)
            {
                throw new Exception("Bad Base64 conversion to GUID", ex);
            }

            return guid;
        }

        string GetMessage(string columnName)
        {

            if (string.IsNullOrEmpty(columnName))
                throw new ArgumentException("Invalid property name", columnName);

            string error = string.Empty;
            var value = this.GetType().GetProperty(columnName).GetValue(this, null);
            var results = new List<ValidationResult>(1);

            var context = new ValidationContext(this, null, null) { MemberName = columnName };

            var result = Validator.TryValidateProperty(value, context, results);

            if (!result)
            {
                var validationResult = results.First();
                error = validationResult.ErrorMessage;
            }
            return error;
        }

        public string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public void OpenSettingWindow()
        {
            try
            {
                com.boutique.Views.Setting settingWin = new com.boutique.Views.Setting();
                settingWin.Show();
                CloseAction();

            }
            catch (Exception)
            {

            }
        }

        public void OpenLoginWindow()
        {
            try
            {
                com.boutique.Views.Login loginWin = new com.boutique.Views.Login();
                loginWin.Show();
                CloseAction();
            }
            catch (Exception)
            {

            }
        }

        public void CloseMessage()
        {
            IsParentWindowEnabled = true;
            IsAlertOpen = false;
        }

        public bool IsUserExists(string username, int? id)
        {
            User user = userService.GetUserByUserName(username, id);
            return user != null ? true : false;

        }
        #endregion

    }
}