/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:com.boutique"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/
/**
* Filename:  ViewModelLocator.cs
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
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Repository;
using Repository.Providers.EntityFramework;
using com.boutique.Data;
using com.boutique.Service;

namespace com.boutique.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IUserService, UserService>();
            SimpleIoc.Default.Register<IBoutiqueService, BoutiqueService>();
            SimpleIoc.Default.Register<IStitchingService, StitchingService>();
            SimpleIoc.Default.Register<ICustomerDetailService, CustomerDetailService>();
            SimpleIoc.Default.Register<IUnitOfWork, UnitOfWork>();
            SimpleIoc.Default.Register<IDbContext, MyDatabaseContext>();
            SimpleIoc.Default.Register<IUnitOfWorkForService, IUnitOfWork>();
            SimpleIoc.Default.Register<SetupViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();           
        }

        public SetupViewModel Setup
        {
            get
            {
                return SimpleIoc.Default.IsRegistered<SetupViewModel>() ? ServiceLocator.Current.GetInstance<SetupViewModel>() :
                    new System.Func<SetupViewModel>(() =>
                    {
                        SimpleIoc.Default.Register<SetupViewModel>();
                        return ServiceLocator.Current.GetInstance<SetupViewModel>();
                    })();

            }
        }

        public LoginViewModel Login
        {
            get
            {
                return SimpleIoc.Default.IsRegistered<LoginViewModel>() ? ServiceLocator.Current.GetInstance<LoginViewModel>() :
                    new System.Func<LoginViewModel>(() =>
                    {
                        SimpleIoc.Default.Register<LoginViewModel>();
                        return ServiceLocator.Current.GetInstance<LoginViewModel>();
                    })();

            }
        }      

        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.IsRegistered<MainViewModel>() ?
                    ServiceLocator.Current.GetInstance<MainViewModel>() :
                    new System.Func<MainViewModel>(() =>
                    {
                        SimpleIoc.Default.Register<MainViewModel>();
                        return ServiceLocator.Current.GetInstance<MainViewModel>();
                    })();

            }
        }

        public OrderViewModel Order
        {
            get
            {
                return SimpleIoc.Default.IsRegistered<OrderViewModel>() ?
                    ServiceLocator.Current.GetInstance<OrderViewModel>() :
                    new System.Func<OrderViewModel>(() =>
                    {
                        SimpleIoc.Default.Register<OrderViewModel>();
                        return ServiceLocator.Current.GetInstance<OrderViewModel>();
                    })();

            }
        }

        public ReportViewModel Report
        {
            get
            {
                return SimpleIoc.Default.IsRegistered<ReportViewModel>() ?
                    ServiceLocator.Current.GetInstance<ReportViewModel>() :
                    new System.Func<ReportViewModel>(() =>
                    {
                        SimpleIoc.Default.Register<ReportViewModel>();
                        return ServiceLocator.Current.GetInstance<ReportViewModel>();
                    })();

            }
        }

        public static void Cleanup()
        {
            if (SimpleIoc.Default.IsRegistered<SetupViewModel>())
                SimpleIoc.Default.Unregister<SetupViewModel>();
            if (SimpleIoc.Default.IsRegistered<LoginViewModel>())
                SimpleIoc.Default.Unregister<LoginViewModel>();           
            if (SimpleIoc.Default.IsRegistered<MainViewModel>())
                SimpleIoc.Default.Unregister<MainViewModel>();
            if (SimpleIoc.Default.IsRegistered<OrderViewModel>())
                SimpleIoc.Default.Unregister<OrderViewModel>();
            if (SimpleIoc.Default.IsRegistered<ReportViewModel>())
                SimpleIoc.Default.Unregister<ReportViewModel>();
            // TODO Clear the ViewModels
        }
    }
}