using com.boutique.Entity;
using System;
using System.Collections.Generic;

namespace com.boutique.Service
{
    public interface IBoutiqueService : IDisposable
    {
        Boutique AddUpdateBoutique(Boutique boutique);       
        IEnumerable<Boutique> GetAllBoutiques();
        Boutique GetBoutiqueById(int BoutiqueId);
    }
}


