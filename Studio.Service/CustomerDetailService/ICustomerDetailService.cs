using com.boutique.Entity;
using System;
using System.Collections.Generic;

namespace com.boutique.Service
{
    public interface ICustomerDetailService : IDisposable
    {
        CustomerDetail AddUpdateCustomerDetail(CustomerDetail customerDetail); 
        CustomerDetail GetCustomerDetailsById(int Id);
        IEnumerable<CustomerDetail> GetAllCustomerDetails(int BoutiqueId);
        Int32 GetTotalCount(int BoutiqueId);
        Int32 GetTotalCount(DateTime startDate, DateTime endDate, int BoutiqueId);
        List<CustomerDetail> GetTodayDeliverOrders(int BoutiqueId);
        List<CustomerDetail> GetTodayOrders(int BoutiqueId);
        IList<CustomerDetail> GetReports(DateTime startDate, DateTime endDate, int BoutiqueId);
        IList<CustomerDetail> GetOrders(DateTime startDate, DateTime endDate, int Page, int Size, int BoutiqueId);
    }
}


