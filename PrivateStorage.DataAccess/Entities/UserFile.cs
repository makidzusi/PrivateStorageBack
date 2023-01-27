﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateStorage.DataAccess.Entities
{
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
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FileName).IsRequired(true);

        }
    }
}
