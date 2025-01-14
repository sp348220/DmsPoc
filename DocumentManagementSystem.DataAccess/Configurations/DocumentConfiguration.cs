﻿using DocumentManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.DataAccess.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(x=> x.Title).IsRequired();
            builder.Property(x=> x.Description).HasColumnType("ntext").IsRequired();
            builder.Property(x=> x.DocState).IsRequired();
            builder.Property(x=> x.SendDate).IsRequired();
            builder.Property(x=>x.ClassOfDoc).HasMaxLength(30).IsRequired();
            builder.Property(x=> x.TypeOfDoc).HasMaxLength(30).IsRequired();

            builder.HasOne(x => x.AppUser).WithMany(x => x.Documents).HasForeignKey(x => x.AppUserId);

        }
    }
}
