﻿// <auto-generated />
using CartApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CartApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20200515042913_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CartApi.Models.Feedback", b =>
                {
                    b.Property<string>("FId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("CartApi.Models.Product", b =>
                {
                    b.Property<string>("PId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CartApi.Models.Register", b =>
                {
                    b.Property<string>("RId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("secondname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RId");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
