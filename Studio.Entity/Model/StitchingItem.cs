using System.Collections.Generic;

namespace com.boutique.Entity
{
    public class StitchingItem : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoutiqueId { get; set; }
        public virtual List<ParameterType> ParameterTypes { get; set; }

    }
}
