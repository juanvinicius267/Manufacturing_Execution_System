﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scania.Br.KD.API.Maxload.Synchronization.Data;

namespace Scania.Br.KD.API.Maxload.Synchronization.Migrations
{
    [DbContext(typeof(MaxloadContext))]
    [Migration("20200427134019_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Scania.Br.KD.API.Maxload.Synchronization.Models.MaxloadModel", b =>
                {
                    b.Property<int>("MaxloadId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BatchId");

                    b.Property<string>("BoxeNumber");

                    b.Property<string>("Component");

                    b.Property<int>("ContainerNum");

                    b.Property<string>("MuCode");

                    b.Property<int>("PriorityNumber");

                    b.Property<int>("PriorityNumber2");

                    b.Property<DateTime>("SavedHour");

                    b.HasKey("MaxloadId");

                    b.ToTable("Tb_Maxload");
                });

            modelBuilder.Entity("Scania.Br.KD.API.Maxload.Synchronization.Models.RoundsRuleModel", b =>
                {
                    b.Property<int>("RoundsId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CabDock");

                    b.Property<bool>("CabLine");

                    b.Property<int>("CabRounds");

                    b.Property<string>("Component");

                    b.Property<bool>("EcuDock");

                    b.Property<bool>("EcuLine");

                    b.Property<int>("EcuRounds");

                    b.Property<string>("MuCode");

                    b.Property<DateTime>("SavedHour");

                    b.Property<bool>("SkdDock");

                    b.Property<bool>("SkdLine");

                    b.Property<int>("SkdRounds");

                    b.Property<bool>("SkidDock");

                    b.Property<bool>("SkidLine");

                    b.Property<int>("SkidRounds");

                    b.HasKey("RoundsId");

                    b.ToTable("Tb_RoundsRule");
                });
#pragma warning restore 612, 618
        }
    }
}