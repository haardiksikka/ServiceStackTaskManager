using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace TaskManager.DAL.Configuration
{
    using TaskManager.DAL.Model;

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
             this.Property(u => u.FirstName)
             .IsRequired()
             .HasMaxLength(50);

            this.HasKey(u => u.UserId);

            this.Property(u => u.UserId)
           .IsRequired();


            this.Property(u => u.Email)
               .IsRequired();

            this.Property(u => u.Password)
               .IsRequired();

        }
    }
}
