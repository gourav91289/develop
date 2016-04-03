using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using com.boutique.Entity;

namespace com.boutique.Service
{
    public class BoutiqueService : IBoutiqueService
    {
        private readonly IUnitOfWork _unitofWork;
       
        public BoutiqueService(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
            
        }

        public void Dispose()
        {
            _unitofWork.Dispose();
        }

        public Boutique AddUpdateBoutique(Boutique boutique)
        {
            if (boutique.BoutiqueId > 0)
            {
                _unitofWork.Repository<Boutique>().Update(boutique);
            }
            else
            {               
                _unitofWork.Repository<Boutique>().Insert(boutique);

            }
            _unitofWork.Save();
            return boutique;
        }
       
        public IEnumerable<Boutique> GetAllBoutiques()
        {
            return _unitofWork.Repository<Boutique>().Query().Get();
        }

        public Boutique GetBoutiqueById(int BoutiqueId)
        {
            return _unitofWork.Repository<Boutique>().Query().Get().Where(x => x.BoutiqueId == BoutiqueId).FirstOrDefault();
        }

    }
}
