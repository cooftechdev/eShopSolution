using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                    new AppConfig() 
                    { 
                        Key="HomeTitle",
                        Value="Trang chủ - EShopSolution"
                    },
                    new AppConfig() 
                    { 
                        Key="HomeKeyword",
                        Value="Trang chủ - Từ khóa"
                    },
                    new AppConfig() 
                    { 
                        Key="HomeDescription",
                        Value="Trang chủ - Mô tả trang"
                    }
                );
            modelBuilder.Entity<Language>().HasData(
                    new Language()
                    {
                        Id="vi-VN",
                        Name="Tiếng Việt",
                        IsDefault=true
                    },
                    new Language()
                    {
                        Id="en-US",
                        Name="English",
                        IsDefault=false
                    }
                );
            modelBuilder.Entity<Category>().HasData(
                    new Category()
                    {
                        Id=1,
                        Name="Áo sơ mi",
                        IsShowOnHome=true,
                        ParentId=null,
                        SortOrder=1,
                        Status=Status.Active
                    },
                    new Category()
                    {
                        Id=2,
                        Name="Quần Âu",
                        IsShowOnHome=true,
                        ParentId=null,
                        SortOrder=2,
                        Status=Status.Active
                    }
                );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                    new CategoryTranslation()
                    {
                        Id=1,
                        CategoryId=1,
                        Name="Áo Nam",
                        LanguageId="vi-VN",
                        SeoAlias="ao-nam",
                        SeoDescription="Sản phẩm áo thời trang nam",
                        SeoTitle="Sản phẩm áo thời trang nam"
                    },
                    new CategoryTranslation()
                    {
                        Id = 2,
                        CategoryId = 1,
                        Name = "Men Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "men-shirt",
                        SeoDescription = "The shirt products for men",
                        SeoTitle = "The shirt products for men"
                    },
                    new CategoryTranslation()
                    {
                        Id = 3,
                        CategoryId = 2,
                        Name = "Áo nữ",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-nu",
                        SeoDescription = "Sản phẩm áo thời trang nữ",
                        SeoTitle = "Sản phẩm áo thời trang women"
                    },
                    new CategoryTranslation()
                    {
                        Id = 4,
                        CategoryId = 2,
                        Name = "Women Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "women-shirt",
                        SeoDescription = "The shirt products for women",
                        SeoTitle = "The shirt products for women"
                    }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product()
                    {
                        Id=1,
                        DateCreated=DateTime.Now,
                        OriginalPrice=100000,
                        Price=200000,
                        Stock=0,
                        ViewCount=0
                    }
                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                    new ProductTranslation()
                    {
                        Id = 1,
                        ProductId = 1,
                        Name = "Áo sơ mi nam trắng Việt Tiến",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                        SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                        SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                        Details = "Áo sơ mi nam trắng Việt Tiến",
                        Description = "Áo sơ mi nam trắng Việt Tiến"
                    },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory()
                    {
                        ProductId=1,CategoryId=1
                    }
                );
            var roleId = new Guid("056674A3-5FC3-48D2-9625-4CFB6EE83B8B");
            var adminId = new Guid("BA03C52C-B5FA-427F-8894-93E8C2E98598");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId ,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "baolocc21@gmail.com",
                NormalizedEmail = "baolocc21@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abc123@@"),
                SecurityStamp = string.Empty,
                FirstName = "Loc",
                LastName = "Bao",
                Dob = new DateTime(1988,02,29)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
