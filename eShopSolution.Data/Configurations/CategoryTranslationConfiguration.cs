﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.SeoAlias).HasMaxLength(200).IsRequired();
            builder.Property(x => x.SeoDescription).HasMaxLength(500);
            builder.Property(x => x.SeoTitle).HasMaxLength(200);
            builder.Property(x => x.LaguageId).IsRequired().HasMaxLength(5).IsUnicode(false);
            builder.HasOne(x => x.Language).WithMany(x => x.CategoryTranslations).HasForeignKey(x => x.LaguageId);
            builder.HasOne(x => x.Category).WithMany(x => x.CategoryTranslations).HasForeignKey(x => x.CategoryId);
        }
    }
}
