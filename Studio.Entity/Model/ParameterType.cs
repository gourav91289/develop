using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.boutique.Entity
{
    public class ParameterType : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoutiqueId { get; set; }
        [NotMapped]
        public bool IsExists { get; set; }
     

    }
}
