using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.boutique.Entity
{
    public class User : Audit
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public DateTime ExpireDate { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid guid { get; set; }
        public virtual Boutique boutique { get; set; }
    }
}
