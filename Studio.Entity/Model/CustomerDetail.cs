using com.boutique.Helper.Helpers;
using com.boutique.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.boutique.Entity
{
    public class CustomerDetail : Audit
    {
        public int Id { get; set; }
        public string BillNo { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string _DeliveryDate
        {
            get { return DeliveryDate.ToString("dd/MM/yyyy"); }
            set
            {
                _DeliveryDate = value;
            }
        }        
       
        [NotMapped]
        public string ExtraLine { get; set; }
       
        public string StitchingDetails { get; set; }

        [NotMapped]
        public List<StitchingMeasurementModel> _StitchingDetails
        {
            get { return SerializeHelper.Deserialize<List<StitchingMeasurementModel>>(StitchingDetails); }
            set
            {
                _StitchingDetails = value;
            }
        }

        public string EmbroideryDetails { get; set; }

        [NotMapped]
        public List<StitchingEmbroidaryModel> _EmbroideryDetails
        {
            get { return SerializeHelper.Deserialize<List<StitchingEmbroidaryModel>>(EmbroideryDetails); }
            set
            {
                _EmbroideryDetails = value;
            }
        }
        public int BoutiqueId { get; set; }
    }
}
