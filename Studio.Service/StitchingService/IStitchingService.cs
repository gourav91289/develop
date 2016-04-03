using com.boutique.Entity;
using System;
using System.Collections.Generic;

namespace com.boutique.Service
{
    public interface IStitchingService : IDisposable
    {
        StitchingItem AddUpdateStitchingItem(StitchingItem stitchingItem);       
        List<StitchingItem> GetAllstitchingItems(int BoutiqueId);
        StitchingItem GetStitchingItem(int BoutiqueId, int Id);
        List<StitchingItem> GetAllUndeletedstitchingItems(int BoutiqueId);
        List<ParameterType> GetAllParameterTypes(int BoutiqueId, int Id);
        ParameterType AddUpdateStitchingParameterItem(ParameterType parameterItem);           
    }
}


