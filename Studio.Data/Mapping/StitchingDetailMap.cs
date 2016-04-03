using com.boutique.Entity;
using System.Data.Entity.ModelConfiguration;

namespace com.boutique.Data
{
    public class StitchingDetailMap : EntityTypeConfiguration<StitchingDetail>
    {
        public StitchingDetailMap()
        {
            HasKey(c => c.Id);
            Property(c => c.Color).HasMaxLength(10);
            ToTable("StitchingDetail");
        }
    }
}
