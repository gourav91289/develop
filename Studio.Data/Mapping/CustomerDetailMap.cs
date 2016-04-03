using com.boutique.Entity;
using System.Data.Entity.ModelConfiguration;

namespace com.boutique.Data
{
    public class CustomerDetailMap : EntityTypeConfiguration<CustomerDetail>
    {
        public CustomerDetailMap()
        {
            HasKey(c => c.Id);
            Property(c => c.CustomerName).HasMaxLength(255);
            Property(c => c.ContactNumber).HasMaxLength(255);
            Property(c => c.BillNo).HasMaxLength(100);
            Ignore(c => c._DeliveryDate);
            Ignore(p => p._CreateOn);
            Ignore(p => p._LastUpdatedOn);
            ToTable("CustomerDetail");
        }
    }
}
