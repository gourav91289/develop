using com.boutique.Entity;
using System.Data.Entity.ModelConfiguration;

namespace com.boutique.Data
{
    public class StitchingItemMap : EntityTypeConfiguration<StitchingItem>
    {
        public StitchingItemMap()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).HasMaxLength(255);
            Ignore(p => p._CreateOn);
            Ignore(p => p._LastUpdatedOn);
            ToTable("StitchingItem");
        }
    }
}
