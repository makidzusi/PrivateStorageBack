using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateStorage.DataAccess.Entities
{
    [Table("UserFiles")]
    public sealed class UserFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int Size { get; set; }
    }

    public class FileConfiguration : IEntityTypeConfiguration<UserFile>
    {
        public void Configure(EntityTypeBuilder<UserFile> builder)
        {
     
            builder.Property(x => x.FileName).IsRequired(true);

        }
    }
}
