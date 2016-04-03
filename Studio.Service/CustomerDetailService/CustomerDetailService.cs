using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using com.boutique.Entity;

namespace com.boutique.Service
{
    public class CustomerDetailService : ICustomerDetailService
    {
        private readonly IUnitOfWork _unitofWork;
       
        public CustomerDetailService(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
            
        }

        public void Dispose()
        {
            _unitofWork.Dispose();
        }

        public CustomerDetail AddUpdateCustomerDetail(CustomerDetail customerDetail)
        {
            if (customerDetail.Id > 0)
            {
                _unitofWork.Repository<CustomerDetail>().Update(customerDetail);
            }
            else
            {               
                _unitofWork.Repository<CustomerDetail>().Insert(customerDetail);

            }
            _unitofWork.Save();
            return customerDetail;
        }

        public CustomerDetail GetCustomerDetailsById(int Id)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<CustomerDetail> GetAllCustomerDetails(int BoutiqueId)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().Where(x => x.BoutiqueId == BoutiqueId);
        }

        public Int32 GetTotalCount(int BoutiqueId)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().Where(x => x.BoutiqueId == BoutiqueId).Count();
        }

        public Int32 GetTotalCount(DateTime startDate, DateTime endDate, int BoutiqueId)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().
                Where(x => x.CreateOn >= startDate && x.CreateOn <= endDate && x.BoutiqueId == BoutiqueId).Count();
        }

        public List<CustomerDetail> GetTodayDeliverOrders(int BoutiqueId)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().
                Where(o => o.DeliveryDate == DateTime.Today && o.BoutiqueId == BoutiqueId).OrderBy(x => x.BillNo).ToList();
        }

        public List<CustomerDetail> GetTodayOrders(int BoutiqueId)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().
                Where(o => o.CreateOn == DateTime.Today && o.BoutiqueId == BoutiqueId).OrderBy(x => x.BillNo).ToList();
        }

        public IList<CustomerDetail> GetReports(DateTime startDate, DateTime endDate, int BoutiqueId)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().
                Where(o => o.CreateOn >= startDate && o.CreateOn <= endDate && o.BoutiqueId == BoutiqueId).OrderBy(x => x.BillNo).ToList();
        }

        public IList<CustomerDetail> GetOrders(DateTime startDate, DateTime endDate, int Page, int Size, int BoutiqueId)
        {
            return _unitofWork.Repository<CustomerDetail>().Query().Get().
                Where(o =>
                o.CreateOn >= startDate &&
                o.CreateOn <= endDate
                && o.BoutiqueId == BoutiqueId).
                OrderBy(x => x.BillNo).
                Skip((Page -1) * Size).Take(Size).
                ToList();
        }
    }
}
