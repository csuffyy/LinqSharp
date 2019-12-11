﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLinq.Test;

namespace NLinq.Test.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191207131658_201912072116")]
    partial class _201912072116
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NLinq.Test.AppRegistry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Item");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("Item", "Key")
                        .IsUnique();

                    b.ToTable("AppRegistries");
                });

            modelBuilder.Entity("NLinq.Test.CPKeyModel", b =>
                {
                    b.Property<Guid>("Id1");

                    b.Property<Guid>("Id2");

                    b.HasKey("Id1", "Id2");

                    b.ToTable("CompositeKeyModels");
                });

            modelBuilder.Entity("NLinq.Test.EntityMonitorModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.ToTable("EntityMonitorModels");
                });

            modelBuilder.Entity("NLinq.Test.EntityTrackModel1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TotalQuantity")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.ToTable("EntityTrackModel1s");
                });

            modelBuilder.Entity("NLinq.Test.EntityTrackModel2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupQuantity")
                        .IsConcurrencyToken();

                    b.Property<Guid>("Super");

                    b.HasKey("Id");

                    b.HasIndex("Super");

                    b.ToTable("EntityTrackModel2s");
                });

            modelBuilder.Entity("NLinq.Test.EntityTrackModel3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Quantity")
                        .IsConcurrencyToken();

                    b.Property<Guid>("Super");

                    b.HasKey("Id");

                    b.HasIndex("Super");

                    b.ToTable("EntityTrackModel3s");
                });

            modelBuilder.Entity("NLinq.Test.FreeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FreeModels");
                });

            modelBuilder.Entity("NLinq.Test.SimpleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("NickName");

                    b.Property<string>("RealName");

                    b.HasKey("Id");

                    b.ToTable("SimpleModels");
                });

            modelBuilder.Entity("NLinq.Test.TrackModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Automatic");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("ForCondensed");

                    b.Property<string>("ForLower");

                    b.Property<string>("ForTrim");

                    b.Property<string>("ForUpper");

                    b.Property<DateTime>("LastWriteTime");

                    b.HasKey("Id");

                    b.ToTable("TrackModels");
                });

            modelBuilder.Entity("NLinq.Test.EntityTrackModel2", b =>
                {
                    b.HasOne("NLinq.Test.EntityTrackModel1", "SuperLink")
                        .WithMany("EntityTrackModel2s")
                        .HasForeignKey("Super")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NLinq.Test.EntityTrackModel3", b =>
                {
                    b.HasOne("NLinq.Test.EntityTrackModel2", "SuperLink")
                        .WithMany("EntityTrackModel3s")
                        .HasForeignKey("Super")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}