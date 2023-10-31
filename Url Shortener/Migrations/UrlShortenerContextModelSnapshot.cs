﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Url_Shortener.Data;

#nullable disable

namespace Url_Shortener.Migrations
{
    [DbContext(typeof(UrlShortenerContext))]
    partial class UrlShortenerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Url_Shortener.Models.UrlForCreationDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Categoria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContadorVisitas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShortUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserUrl");
                });
#pragma warning restore 612, 618
        }
    }
}
