﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SERVIEX.Contexts;

namespace SERVIEX.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201015160114_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SERVIEX.Entities.Gender", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("id");

                    b.ToTable("genders");
                });

            modelBuilder.Entity("SERVIEX.Entities.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("genderid")
                        .HasColumnType("int");

                    b.Property<int>("idGender")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("genderid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("SERVIEX.Entities.User", b =>
                {
                    b.HasOne("SERVIEX.Entities.Gender", "gender")
                        .WithMany("users")
                        .HasForeignKey("genderid");
                });
#pragma warning restore 612, 618
        }
    }
}
