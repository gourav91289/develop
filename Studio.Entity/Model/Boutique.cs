using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.boutique.Entity
{
    public class Boutique : Audit
    {
        public int BoutiqueId { get; set; }
        public int BillStartNumber { get; set; }
              
        public string Name { get; set; }

        [NotMapped]
        private string _Address = "Enter Boutique Address";
        public string Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
            }
        }

        [NotMapped]
        private string _PhoneNumber = "Enter Phone Number";
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                _PhoneNumber = value;
            }
        }

        [NotMapped]
        private string _LandlineNumber = "Enter Landline Number";
        public string LandlineNumber
        {
            get { return _LandlineNumber; }
            set
            {
                _LandlineNumber = value;
            }
        }       

    }
}
