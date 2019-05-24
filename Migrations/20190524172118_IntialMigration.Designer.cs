﻿// <auto-generated />
using System;
using ComputerHardware.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComputerHardware.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190524172118_IntialMigration")]
    partial class IntialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComputerHardware.Models.CPU", b =>
                {
                    b.Property<int>("CPUId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseFrequency");

                    b.Property<int>("ChipsetId");

                    b.Property<int>("CoreCount");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("ECC");

                    b.Property<string>("Family")
                        .IsRequired();

                    b.Property<string>("IntegratedGraphics");

                    b.Property<double>("L3Cache");

                    b.Property<string>("Lithography")
                        .IsRequired();

                    b.Property<double>("MSRPPrice");

                    b.Property<int>("ManufacturerId");

                    b.Property<double>("MaxFrequency");

                    b.Property<string>("MaxGPUClockRate");

                    b.Property<string>("MaxMemory")
                        .IsRequired();

                    b.Property<string>("MaxMemoryChannel")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("PCIExpressLanes");

                    b.Property<string>("ReleaseDate")
                        .IsRequired();

                    b.Property<bool>("SMT");

                    b.Property<string>("Series")
                        .IsRequired();

                    b.Property<int>("SocketId");

                    b.Property<int>("TDP");

                    b.Property<int>("ThreadCount");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("CPUId");

                    b.HasIndex("ChipsetId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("SocketId");

                    b.ToTable("CPUs");

                    b.HasData(
                        new
                        {
                            CPUId = 1,
                            BaseFrequency = 3.6000000000000001,
                            ChipsetId = 1,
                            CoreCount = 8,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(568),
                            ECC = false,
                            Family = "Coffee Lake",
                            IntegratedGraphics = "",
                            L3Cache = 16.0,
                            Lithography = "14",
                            MSRPPrice = 500.0,
                            ManufacturerId = 1,
                            MaxFrequency = 5.0,
                            MaxGPUClockRate = "",
                            MaxMemory = "128",
                            MaxMemoryChannel = "2",
                            Name = "9900K",
                            PCIExpressLanes = 16.0,
                            ReleaseDate = "Q4'18",
                            SMT = true,
                            Series = "Intel Core i9",
                            SocketId = 1,
                            TDP = 95,
                            ThreadCount = 16,
                            Type = "Desktop",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(841)
                        },
                        new
                        {
                            CPUId = 2,
                            BaseFrequency = 3.3999999999999999,
                            ChipsetId = 2,
                            CoreCount = 16,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(1162),
                            ECC = true,
                            Family = "Zen",
                            L3Cache = 32.0,
                            Lithography = "14",
                            MSRPPrice = 999.0,
                            ManufacturerId = 2,
                            MaxFrequency = 4.0,
                            MaxMemory = "128",
                            MaxMemoryChannel = "4",
                            Name = "1950X",
                            PCIExpressLanes = 16.0,
                            ReleaseDate = "Q2'17",
                            SMT = true,
                            Series = "AMD Ryzen Threadripper",
                            SocketId = 16,
                            TDP = 180,
                            ThreadCount = 32,
                            Type = "Desktop",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(1172)
                        });
                });

            modelBuilder.Entity("ComputerHardware.Models.CPUDetail", b =>
                {
                    b.Property<int>("CPUDetailId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool?>("EnhancedIntelSpeedStepTechnology");

                    b.Property<bool?>("ExecuteDisableBit");

                    b.Property<bool?>("IdleStates");

                    b.Property<string>("InstructionSet");

                    b.Property<bool?>("Intel64");

                    b.Property<bool?>("IntelAESNewInstructions");

                    b.Property<bool?>("IntelBootGuard");

                    b.Property<bool?>("IntelHyperThreadingTechnology");

                    b.Property<bool?>("IntelIdentityProtectionTechnology");

                    b.Property<bool?>("IntelMemoryProtectionExtensions");

                    b.Property<bool?>("IntelOSGuard");

                    b.Property<bool?>("IntelOptaneMemorySupported");

                    b.Property<bool?>("IntelSoftwareGuardExtentions");

                    b.Property<bool?>("IntelTSXNI");

                    b.Property<bool?>("IntelTrustedExecutionTechnology");

                    b.Property<bool?>("IntelTurboBoostTechnology1");

                    b.Property<bool?>("IntelTurboBoostTechnology2");

                    b.Property<bool?>("IntelVirtualizationTechnologyforDirectIO");

                    b.Property<bool?>("IntelvProPlatformEligibility");

                    b.Property<int>("MaxCPUs");

                    b.Property<string>("PackageSizeX")
                        .IsRequired();

                    b.Property<string>("PackageSizeY")
                        .IsRequired();

                    b.Property<bool?>("SecureKey");

                    b.Property<bool?>("StableImagePlatformProgram");

                    b.Property<string>("TJunction")
                        .IsRequired();

                    b.Property<bool?>("ThermalMonitoringTechnologies");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<bool?>("VTxWithExtendedPageTables");

                    b.HasKey("CPUDetailId");

                    b.ToTable("CPUDetails");

                    b.HasData(
                        new
                        {
                            CPUDetailId = 1,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3365),
                            EnhancedIntelSpeedStepTechnology = true,
                            ExecuteDisableBit = true,
                            IdleStates = true,
                            InstructionSet = "64-bit",
                            Intel64 = true,
                            IntelAESNewInstructions = true,
                            IntelBootGuard = true,
                            IntelHyperThreadingTechnology = true,
                            IntelIdentityProtectionTechnology = true,
                            IntelMemoryProtectionExtensions = true,
                            IntelOSGuard = true,
                            IntelOptaneMemorySupported = true,
                            IntelSoftwareGuardExtentions = true,
                            IntelTSXNI = true,
                            IntelTrustedExecutionTechnology = true,
                            IntelTurboBoostTechnology2 = true,
                            IntelVirtualizationTechnologyforDirectIO = true,
                            IntelvProPlatformEligibility = true,
                            MaxCPUs = 1,
                            PackageSizeX = "37.5",
                            PackageSizeY = "37.5",
                            SecureKey = true,
                            StableImagePlatformProgram = true,
                            TJunction = "LGA-1151",
                            ThermalMonitoringTechnologies = true,
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3619),
                            VTxWithExtendedPageTables = true
                        },
                        new
                        {
                            CPUDetailId = 2,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3946),
                            InstructionSet = "64-bit",
                            MaxCPUs = 1,
                            PackageSizeX = "58.5",
                            PackageSizeY = "75.4",
                            TJunction = "TR4",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3955)
                        });
                });

            modelBuilder.Entity("ComputerHardware.Models.Chipset", b =>
                {
                    b.Property<int>("ChipsetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusSpeed")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("DIMMsPerChannel")
                        .IsRequired();

                    b.Property<string>("DisplaysSupported")
                        .IsRequired();

                    b.Property<bool?>("IntelBootGuard");

                    b.Property<bool?>("IntelHDAudioTechnology");

                    b.Property<string>("IntelMEFirmwareVersion");

                    b.Property<bool?>("IntelOptaneMemorySupported");

                    b.Property<bool?>("IntelPlatformTTTrustTechnology");

                    b.Property<bool?>("IntelRapidStorageTechnology");

                    b.Property<bool?>("IntelRapidStorageTechnologyForPCIStorage");

                    b.Property<bool?>("IntelSmartSoundTechnology");

                    b.Property<bool?>("IntelvProPlatformEligibility");

                    b.Property<string>("LaunchDate")
                        .IsRequired();

                    b.Property<string>("MaxPCIExpressLanes")
                        .IsRequired();

                    b.Property<int>("MaxSata3Ports");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NumberOfUSBPorts");

                    b.Property<bool>("Overclock");

                    b.Property<string>("PCIExpressRevision")
                        .IsRequired();

                    b.Property<string>("TDP")
                        .IsRequired();

                    b.Property<string>("USBRevision")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ChipsetId");

                    b.ToTable("Chipsets");

                    b.HasData(
                        new
                        {
                            ChipsetId = 1,
                            BusSpeed = "8",
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5106),
                            DIMMsPerChannel = "2",
                            DisplaysSupported = "3",
                            IntelBootGuard = true,
                            IntelHDAudioTechnology = true,
                            IntelMEFirmwareVersion = "12",
                            IntelOptaneMemorySupported = true,
                            IntelPlatformTTTrustTechnology = true,
                            IntelRapidStorageTechnology = true,
                            IntelRapidStorageTechnologyForPCIStorage = true,
                            IntelSmartSoundTechnology = true,
                            IntelvProPlatformEligibility = false,
                            LaunchDate = "Q4'18",
                            MaxPCIExpressLanes = "24",
                            MaxSata3Ports = 6,
                            Name = "Z390",
                            NumberOfUSBPorts = 14,
                            Overclock = true,
                            PCIExpressRevision = "3.0",
                            TDP = "6",
                            USBRevision = "3.1",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5552)
                        },
                        new
                        {
                            ChipsetId = 2,
                            BusSpeed = "TBD",
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5923),
                            DIMMsPerChannel = "4",
                            DisplaysSupported = "0",
                            LaunchDate = "Q2'17",
                            MaxPCIExpressLanes = "8",
                            MaxSata3Ports = 12,
                            Name = "X399",
                            NumberOfUSBPorts = 14,
                            Overclock = true,
                            PCIExpressRevision = "3.0",
                            TDP = "TBD",
                            USBRevision = "3.1",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5933)
                        });
                });

            modelBuilder.Entity("ComputerHardware.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("URL")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5133),
                            Name = "Intel Corporation",
                            URL = "https://www.intel.com/content/www/us/en/homepage.html",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5470)
                        },
                        new
                        {
                            ManufacturerId = 2,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5758),
                            Name = "Advanced Micro Devices, Inc",
                            URL = "https://www.amd.com/en",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5768)
                        });
                });

            modelBuilder.Entity("ComputerHardware.Models.Socket", b =>
                {
                    b.Property<int>("SocketId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("SocketId");

                    b.ToTable("Sockets");

                    b.HasData(
                        new
                        {
                            SocketId = 1,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(8825),
                            Name = "LGA-1151",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9126)
                        },
                        new
                        {
                            SocketId = 2,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9401),
                            Name = "LGA-1150",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9410)
                        },
                        new
                        {
                            SocketId = 3,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9416),
                            Name = "TR4",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9419)
                        },
                        new
                        {
                            SocketId = 4,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9422),
                            Name = "SP3",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9424)
                        },
                        new
                        {
                            SocketId = 5,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9427),
                            Name = "AM4",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9429)
                        },
                        new
                        {
                            SocketId = 6,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9432),
                            Name = "LGA-2066",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9434)
                        },
                        new
                        {
                            SocketId = 7,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9437),
                            Name = "LGA-3647",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9439)
                        },
                        new
                        {
                            SocketId = 8,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9442),
                            Name = "AM1",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9445)
                        },
                        new
                        {
                            SocketId = 9,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9447),
                            Name = "FM2+",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9450)
                        },
                        new
                        {
                            SocketId = 10,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9452),
                            Name = "FM2",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9455)
                        },
                        new
                        {
                            SocketId = 11,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9457),
                            Name = "LGA-1356",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9460)
                        },
                        new
                        {
                            SocketId = 12,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9463),
                            Name = "AM3+",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9465)
                        },
                        new
                        {
                            SocketId = 13,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9468),
                            Name = "FS1",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9470)
                        },
                        new
                        {
                            SocketId = 14,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9473),
                            Name = "FM1",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9475)
                        },
                        new
                        {
                            SocketId = 15,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9478),
                            Name = "2011",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9480)
                        },
                        new
                        {
                            SocketId = 16,
                            CreatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9483),
                            Name = "TR4",
                            UpdatedAt = new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9485)
                        });
                });

            modelBuilder.Entity("ComputerHardware.Models.CPU", b =>
                {
                    b.HasOne("ComputerHardware.Models.Chipset", "Chipset")
                        .WithMany("CPUs")
                        .HasForeignKey("ChipsetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComputerHardware.Models.Manufacturer", "Manufacturer")
                        .WithMany("CPUs")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComputerHardware.Models.Socket", "Socket")
                        .WithMany("CPUs")
                        .HasForeignKey("SocketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComputerHardware.Models.CPUDetail", b =>
                {
                    b.HasOne("ComputerHardware.Models.CPU", "CPU")
                        .WithOne("CPUDetail")
                        .HasForeignKey("ComputerHardware.Models.CPUDetail", "CPUDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}