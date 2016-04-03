/**
* Filename:  App.xaml.cs
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
using com.boutique.Views;
using com.boutique.Data;
using com.boutique.Service;
using Microsoft.Practices.Unity;
using Repository;
using Repository.Providers.EntityFramework;
using System.Windows;
using com.boutique.ViewModel;

namespace com.boutique
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    IUnityContainer container = new UnityContainer();

        //    container
        //        .RegisterType<BaseViewModel>()
        //        .RegisterType<SetupViewModel>()
        //        .RegisterType<LoginViewModel>()
        //        .RegisterType<IUserService, UserService>()
        //        .RegisterType<IBoutiqueService, BoutiqueService>()
        //        .RegisterType<IUnitOfWorkForService, IUnitOfWork>()                
        //        .RegisterType<IUnitOfWork, UnitOfWork>()
        //        .RegisterType<IDbContext, MyDatabaseContext>();

        //    //var window = container.Resolve<Setup>();
        //    //window.Show();
        //}

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(((Exception)(e.ExceptionObject)).GetBaseException().Message);
            App.Current.Shutdown();
        }

    }
}