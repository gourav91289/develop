using Repository;
using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.boutique.Entity
{
    public class Audit : EntityBase
    {
        public DateTime CreateOn { get; set; }

        [JsonIgnore]
        public string _CreateOn
        {
            get { return CreateOn.ToString("dd/MM/yyyy"); }
            set
            {
                _CreateOn = value;
            }
        }
        public DateTime LastUpdatedOn { get; set; }

        [JsonIgnore]
        public string _LastUpdatedOn
        {
            get { return LastUpdatedOn.ToString("dd/MM/yyyy"); }
            set
            {
                _LastUpdatedOn = value;
            }
        }
        public bool IsDeleted { get; set; }
    }
}
