﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RDF.Arcana.API.Data;

#nullable disable

namespace RDF.Arcana.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230726033609_AdjustUomEntity")]
    partial class AdjustUomEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RDF.Arcana.API.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CompanyName")
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_companies");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Fullname")
                        .HasColumnType("longtext")
                        .HasColumnName("fullname");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("longtext")
                        .HasColumnName("department_name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_departments");

                    b.ToTable("departments", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("ItemCode")
                        .HasColumnType("longtext")
                        .HasColumnName("item_code");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("longtext")
                        .HasColumnName("item_description");

                    b.Property<int>("MeatTypeId")
                        .HasColumnType("int")
                        .HasColumnName("meat_type_id");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("product_category_id");

                    b.Property<int>("UomId")
                        .HasColumnType("int")
                        .HasColumnName("uom_id");

                    b.HasKey("Id")
                        .HasName("pk_items");

                    b.HasIndex("MeatTypeId")
                        .HasDatabaseName("ix_items_meat_type_id");

                    b.HasIndex("ProductCategoryId")
                        .HasDatabaseName("ix_items_product_category_id");

                    b.HasIndex("UomId")
                        .HasDatabaseName("ix_items_uom_id");

                    b.ToTable("items", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("LocationName")
                        .HasColumnType("longtext")
                        .HasColumnName("location_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_locations");

                    b.ToTable("locations", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.MeatType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("MeatTypeName")
                        .HasColumnType("longtext")
                        .HasColumnName("meat_type_name");

                    b.Property<DateTime?>("Type")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_meat_types");

                    b.ToTable("meat_types", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("AddedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("added_by");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("ProductCategoryName")
                        .HasColumnType("longtext")
                        .HasColumnName("product_category_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_product_categories");

                    b.ToTable("product_categories", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.ProductSubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("modified_by");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("product_category_id");

                    b.Property<string>("ProductSubCategoryName")
                        .HasColumnType("longtext")
                        .HasColumnName("product_sub_category_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_product_sub_categories");

                    b.HasIndex("ProductCategoryId")
                        .HasDatabaseName("ix_product_sub_categories_product_category_id");

                    b.ToTable("product_sub_categories", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Uom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("AdddedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("addded_by");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("modified_by");

                    b.Property<string>("UomCode")
                        .HasColumnType("longtext")
                        .HasColumnName("uom_code");

                    b.Property<string>("UomDescription")
                        .HasColumnType("longtext")
                        .HasColumnName("uom_description");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_uoms");

                    b.ToTable("uoms", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("department_id");

                    b.Property<string>("Fullname")
                        .HasColumnType("longtext")
                        .HasColumnName("fullname");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<int>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("location_id");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UserRoleId")
                        .HasColumnType("int")
                        .HasColumnName("user_role_id");

                    b.Property<string>("Username")
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_users_company_id");

                    b.HasIndex("DepartmentId")
                        .HasDatabaseName("ix_users_department_id");

                    b.HasIndex("LocationId")
                        .HasDatabaseName("ix_users_location_id");

                    b.HasIndex("UserRoleId")
                        .IsUnique()
                        .HasDatabaseName("ix_users_user_role_id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("Permissions")
                        .HasColumnType("longtext")
                        .HasColumnName("permissions");

                    b.Property<string>("RoleName")
                        .HasColumnType("longtext")
                        .HasColumnName("role_name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_user_roles");

                    b.ToTable("user_roles", (string)null);
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Items", b =>
                {
                    b.HasOne("RDF.Arcana.API.Domain.MeatType", "MeatType")
                        .WithMany()
                        .HasForeignKey("MeatTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_items_meat_types_meat_type_id");

                    b.HasOne("RDF.Arcana.API.Domain.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_items_product_categories_product_category_id");

                    b.HasOne("RDF.Arcana.API.Domain.Uom", "Uom")
                        .WithMany("Items")
                        .HasForeignKey("UomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_items_uoms_uom_id");

                    b.Navigation("MeatType");

                    b.Navigation("ProductCategory");

                    b.Navigation("Uom");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.ProductSubCategory", b =>
                {
                    b.HasOne("RDF.Arcana.API.Domain.ProductCategory", "ProductCategory")
                        .WithMany("ProductSubCategory")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_sub_categories_product_categories_product_category_id");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.User", b =>
                {
                    b.HasOne("RDF.Arcana.API.Domain.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_users_companies_company_id");

                    b.HasOne("RDF.Arcana.API.Domain.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_users_departments_department_id");

                    b.HasOne("RDF.Arcana.API.Domain.Location", "Location")
                        .WithMany("Users")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_users_locations_location_id");

                    b.HasOne("RDF.Arcana.API.Domain.UserRoles", "UserRoles")
                        .WithOne("User")
                        .HasForeignKey("RDF.Arcana.API.Domain.User", "UserRoleId")
                        .HasConstraintName("fk_users_user_roles_user_role_id");

                    b.Navigation("Company");

                    b.Navigation("Department");

                    b.Navigation("Location");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Department", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Location", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.ProductCategory", b =>
                {
                    b.Navigation("ProductSubCategory");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.Uom", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RDF.Arcana.API.Domain.UserRoles", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
