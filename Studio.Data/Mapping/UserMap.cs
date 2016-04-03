using com.boutique.Entity;
using System.Data.Entity.ModelConfiguration;

namespace com.boutique.Data
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(u => u.UserId);
            Property(c => c.FirstName).HasMaxLength(255);
            Property(c => c.LastName).HasMaxLength(255);            
            Property(c => c.UserName).HasMaxLength(255);
            Ignore(p => p._CreateOn);
            Ignore(p => p._LastUpdatedOn);
            ToTable("User");
        }
    }
}
