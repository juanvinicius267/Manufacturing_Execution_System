﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scania.Br.KD.Api.Container.Schedule.Data;

namespace Scania.Br.KD.Api.Container.Schedule.Migrations
{
    [DbContext(typeof(ContainerContext))]
    [Migration("20200331193623_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Scania.Br.Container.Scheduling.Models.DockModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dock_Description");

                    b.Property<int>("Dock_Number");

                    b.HasKey("Id");

                    b.ToTable("Tb_Dock");
                });

            modelBuilder.Entity("Scania.Br.Container.Scheduling.Models.LineModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Line_Description");

                    b.Property<int>("Line_Number");

                    b.HasKey("Id");

                    b.ToTable("Tb_Line");
                });

            modelBuilder.Entity("Scania.Br.Container.Scheduling.Models.ScheduleContainerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BatchId");

                    b.Property<string>("Container_Number");

                    b.Property<string>("Container_Type");

                    b.Property<DateTime>("Create_Date");

                    b.Property<int>("Dock");

                    b.Property<DateTime?>("Edit_Date");

                    b.Property<DateTime>("End_Date");

                    b.Property<string>("License_Plate");

                    b.Property<string>("Line");

                    b.Property<string>("Shipping_Company");

                    b.Property<DateTime>("Star_Date");

                    b.Property<string>("User_Create");

                    b.Property<string>("User_Edit");

                    b.HasKey("Id");

                    b.ToTable("TB_Schedule_Container");
                });

            modelBuilder.Entity("Scania.Br.KD.Api.Container.Schedule.Models.ContainerTypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlturaExterna");

                    b.Property<string>("AlturaInterna");

                    b.Property<string>("CapacidadeM3");

                    b.Property<string>("ComprimentoExterno");

                    b.Property<string>("ComprimentoInterno");

                    b.Property<DateTime>("DataDeGravacao");

                    b.Property<string>("LarguraExterna");

                    b.Property<string>("LarguraInterna");

                    b.Property<string>("PesoMaximo");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Tb_ContainerType");
                });
#pragma warning restore 612, 618
        }
    }
}
