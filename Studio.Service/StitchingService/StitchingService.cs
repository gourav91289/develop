using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using com.boutique.Entity;

namespace com.boutique.Service
{
    public class StitchingService : IStitchingService
    {
        private readonly IUnitOfWork _unitofWork;
       
        public StitchingService(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
            
        }

        public void Dispose()
        {
            _unitofWork.Dispose();
        }

        public StitchingItem AddUpdateStitchingItem(StitchingItem stitchingItem)
        {
            if (stitchingItem.Id > 0)
            {
                _unitofWork.Repository<StitchingItem>().Update(stitchingItem);
            }
            else
            {               
                _unitofWork.Repository<StitchingItem>().Insert(stitchingItem);

            }
            _unitofWork.Save();
            return stitchingItem;
        }
       
        public List<StitchingItem> GetAllstitchingItems(int BoutiqueId)
        {
            return _unitofWork.Repository<StitchingItem>().Query().Get().Where(x => x.BoutiqueId == BoutiqueId).ToList();
        }

        public StitchingItem GetStitchingItem(int BoutiqueId, int Id)
        {
            return _unitofWork.Repository<StitchingItem>().Query().Get().
                FirstOrDefault(x => x.BoutiqueId == BoutiqueId && x.Id == Id);
        }

        public List<StitchingItem> GetAllUndeletedstitchingItems(int BoutiqueId)
        {
            return _unitofWork.Repository<StitchingItem>().Query().Include(x => x.ParameterTypes).Get().
                Where(x => !x.IsDeleted && x.BoutiqueId == BoutiqueId).ToList();
        }

        public ParameterType AddUpdateStitchingParameterItem(ParameterType parameterItem)
        {
            if (parameterItem.Id > 0)
            {
                _unitofWork.Repository<ParameterType>().Update(parameterItem);
            }
            else
            {
                _unitofWork.Repository<ParameterType>().Insert(parameterItem);

            }
            _unitofWork.Save();
            return parameterItem;
        }

        public List<ParameterType> GetAllParameterTypes(int BoutiqueId, int Id)
        {
            return _unitofWork.Repository<StitchingItem>().Query().Include(x => x.ParameterTypes).Get().
                FirstOrDefault(x => x.BoutiqueId == BoutiqueId && x.Id == Id).ParameterTypes.ToList();
        }


    }
}
