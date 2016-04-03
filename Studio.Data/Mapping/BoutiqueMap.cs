using com.boutique.Entity;
using System.Data.Entity.ModelConfiguration;

namespace com.boutique.Data
{
    class BoutiqueMap : EntityTypeConfiguration<Boutique>
    {
        public BoutiqueMap()
        {
            HasKey(b => b.BoutiqueId);
            Property(c => c.Name).HasMaxLength(255);
            Property(c => c.PhoneNumber).HasMaxLength(500);
            Property(c => c.LandlineNumber).HasMaxLength(500);
            Ignore(p => p._CreateOn);
            Ignore(p => p._LastUpdatedOn);
            ToTable("Boutique");
        }
    }
}
