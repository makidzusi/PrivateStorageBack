using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrivateStorage.DataAccess.Entities
{
    public sealed class User
    {
    
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<UserFile> UserFiles { get; set; }

    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email).IsRequired(true);

            builder.Property(x =>x.Password).IsRequired(true);

            builder.Property(x => x.NickName).IsRequired(true).HasMaxLength(20);
        }
    }
}
