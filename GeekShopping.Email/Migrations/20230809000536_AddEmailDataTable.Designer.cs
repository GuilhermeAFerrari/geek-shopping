﻿// <auto-generated />
using System;
using GeekShopping.Email.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.Email.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20230809000536_AddEmailDataTable")]
    partial class AddEmailDataTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeekShopping.Email.Models.EmailLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Log")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("log");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("sent_date");

                    b.HasKey("Id");

                    b.ToTable("email_logs");
                });
#pragma warning restore 612, 618
        }
    }
}
