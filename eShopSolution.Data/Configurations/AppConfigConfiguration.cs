using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs"); // Tên bảng
            builder.HasKey(x => x.Key); // Cấu hình khóa chính
            builder.Property(x => x.Value).IsRequired(true); // Cấu hình bắt buộc
        }
    }
}
