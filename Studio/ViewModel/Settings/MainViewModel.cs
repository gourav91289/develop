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

using com.boutique.Model;
using GalaSoft.MvvmLight.Command;
using System.Linq;

namespace com.boutique.ViewModel
{
    public partial class MainViewModel 
    {
        #region for Action

        #endregion

        #region for properties

        private bool _LoadinDataContentPopup = false;
        public bool LoadinDataContentPopup
        {
            get { return _LoadinDataContentPopup; }
            set
            {
                _LoadinDataContentPopup = value;
                RaisePropertyChanged(() => LoadinDataContentPopup);
            }
        }

        private ChangePassword _ChangePasswordData = new ChangePassword();
        public ChangePassword ChangePasswordData
        {
            get { return _ChangePasswordData; }
            set { _ChangePasswordData = value; RaisePropertyChanged(() => ChangePasswordData); }
        }     

        private bool _IsChangePasswordOpen;
        public bool IsChangePasswordOpen
        {
            get { return _IsChangePasswordOpen; }
            set
            {
                _IsChangePasswordOpen = value; RaisePropertyChanged(() => IsChangePasswordOpen);
            }
        }

        #endregion

        #region Commands  

        private RelayCommand _OnCancelChangePasswordClick;
        public RelayCommand OnCancelChangePasswordClick
        {
            get { return _OnCancelChangePasswordClick ?? (_OnCancelChangePasswordClick = new RelayCommand(OnCancelChangePassword)); }
        }

        private RelayCommand _OnSaveChangePasswordClick;
        public RelayCommand OnSaveChangePasswordClick
        {
            get { return _OnSaveChangePasswordClick ?? (_OnSaveChangePasswordClick = new RelayCommand(OnSaveChangePassword)); }
        }

        #endregion

        #region for Method

        public void SetUpdateSettingValues()
        {
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

            UserName = userSettings.Username;
            Name = userSettings.boutique.Name;
            boutiqueInformation = userSettings.boutique;
        }

        private void OnCancelChangePassword()
        {
            IsParentWindowEnabled = true;
            IsChangePasswordOpen = false;
        }

        private void OnSaveChangePassword()
        {           

            if (string.IsNullOrEmpty(ChangePasswordData.oldPassword) || 
                string.IsNullOrEmpty(ChangePasswordData.newPassword) || 
                string.IsNullOrEmpty(ChangePasswordData.confirmNewPassword) )
            {
                ShowMessage("Please enter correct password in Password field(s).");
                return;
            }
            if (ChangePasswordData.newPassword != ChangePasswordData.confirmNewPassword)
            {
                ShowMessage("New password and confirm password doesn't match.");
                return;
            }

            var user = userService.GetUserByGUID(Base64ToGuid(userSettings.Key));
            if(user.Password != Encrypt(ChangePasswordData.oldPassword))
            {
                ShowMessage("The password you supplied is invalid");
                return;
            }
            else
            {
                user.Password = Encrypt(ChangePasswordData.newPassword);
                user = userService.AddUpdateUser(user);
                if (user != null)
                {
                    userSettings.Password = Encrypt(user.Password.ToString());
                    SaveSettings(userSettings);
                }
            }           

            IsParentWindowEnabled = true;
            IsChangePasswordOpen = false;

            SignOut();
        }

        #endregion

    }
}