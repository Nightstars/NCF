﻿
// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using christ.Xncf.demo.Models.DatabaseModel;

namespace christ.Xncf.demo.Migrations.Migrations.SQLite
{
    [DbContext(typeof(demoSenparcEntities))]
    [Migration("20201220102450_AddSample")]
    partial class AddSample : Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("SenparcDemo.Xncf.NewApp.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdditionNote")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<int>("Blue")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Green")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Red")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("SenparcDemo_NewApp_Color");
                });
#pragma warning restore 612, 618
        }
    }
}