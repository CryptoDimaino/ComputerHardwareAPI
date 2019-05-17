using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardware.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Socket> Sockets {get;set;}
        public DbSet<CPU> CPUs {get;set;}
        public DbSet<Manufacturer> Manufacturers {get;set;}
        public DbSet<Chipset> Chipsets {get;set;}
        public DbSet<CPUDetail> CPUDetails {get;set;}

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);

            ModelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer() {ManufacturerId = 1, Name = "Intel Corporation", URL = "https://www.intel.com/content/www/us/en/homepage.html"},
                new Manufacturer() {ManufacturerId = 2, Name = "Advanced Micro Devices, Inc", URL = "https://www.amd.com/en"}
            );

            ModelBuilder.Entity<Socket>().HasData(
                new Socket() {SocketId = 1, Name = "LGA-1151"},
                new Socket() {SocketId = 2, Name = "LGA-1150"},
                new Socket() {SocketId = 3, Name = "TR4"},
                new Socket() {SocketId = 4, Name = "SP3"},
                new Socket() {SocketId = 5, Name = "AM4"},
                new Socket() {SocketId = 6, Name = "LGA-2066"},
                new Socket() {SocketId = 7, Name = "LGA-3647"},
                new Socket() {SocketId = 8, Name = "AM1"},
                new Socket() {SocketId = 9, Name = "FM2+"},
                new Socket() {SocketId = 10, Name = "FM2"},
                new Socket() {SocketId = 11, Name = "LGA-1356"},
                new Socket() {SocketId = 12, Name = "AM3+"},
                new Socket() {SocketId = 13, Name = "FS1"},
                new Socket() {SocketId = 14, Name = "FM1"},
                new Socket() {SocketId = 15, Name = "2011"}
            );

            ModelBuilder.Entity<Chipset>().HasData(
                new Chipset() 
                {
                    ChipsetId = 1, 
                    Name = "Z390",
                    LaunchDate = "Q4'18",
                    BusSpeed = "8",
                    TDP = "6",
                    Overclock = true,
                    DIMMsPerChannel = "2",
                    DisplaysSupported = "3",
                    PCIExpressRevision = "3.0",
                    MaxPCIExpressLanes = "24",
                    NumberOfUSBPorts = 14,
                    USBRevision = "3.1",
                    MaxSata3Ports = 6,
                    IntelOptaneMemorySupported = true,
                    IntelvProPlatformEligibility = false,
                    IntelMEFirmwareVersion = "12",
                    IntelHDAudioTechnology = true,
                    IntelRapidStorageTechnology = true,
                    IntelRapidStorageTechnologyForPCIStorage = true,
                    IntelSmartSoundTechnology = true,
                    IntelPlatformTTTrustTechnology = true,
                    IntelBootGuard = true
                }
            );

            ModelBuilder.Entity<CPUDetail>().HasData(
                new CPUDetail() 
                {
                    CPUDetailId = 1, 
                    TJunction = "LGA-1151",
                    MaxCPUs = 1,
                    PackageSizeX = "37.5",
                    PackageSizeY = "37.5",
                    IntelOptaneMemorySupported = true,
                    IntelTurboBoostTechnology2 = true,
                    IntelTurboBoostTechnology1 = null,
                    IntelvProPlatformEligibility = true,
                    IntelHyperThreadingTechnology = true,
                    IntelVirtualizationTechnologyforDirectIO = true,
                    VTxWithExtendedPageTables = true,
                    IntelTSXNI = true,
                    Intel64 = true,
                    InstructionSet = "64-bit",
                    IdleStates = true,
                    EnhancedIntelSpeedStepTechnology = true,
                    ThermalMonitoringTechnologies = true,
                    IntelIdentityProtectionTechnology = true,
                    StableImagePlatformProgram = true,
                    IntelAESNewInstructions = true,
                    SecureKey = true,
                    IntelSoftwareGuardExtentions = true,
                    IntelMemoryProtectionExtensions = true,
                    IntelOSGuard = true,
                    IntelTrustedExecutionTechnology = true,
                    ExecuteDisableBit = true,
                    IntelBootGuard = true
                }
            );


            ModelBuilder.Entity<CPU>().HasData(
                new CPU() 
                {
                    CPUId = 1,
                    Name = "9900K",
                    CoreCount = 8,
                    ThreadCount = 16,
                    BaseFrequency = 3.60,
                    MaxFrequency = 5.00,
                    L3Cache = 16,
                    TDP = 95,
                    Series = "Intel Core i9",
                    Family = "Coffee Lake",
                    Type = "Desktop",
                    ECC = false,
                    SMT = true,
                    Lithography = "14",
                    MaxMemory = "128",
                    MaxMemoryChannel = "2",
                    IntegratedGraphics = "",
                    MaxGPUClockRate = "",
                    MSRPPrice = 500.00,
                    PCIExpressLanes = 16,
                    ReleaseDate = "Q4'18",
                    SocketId = 1,
                    ManufacturerId = 1,
                    ChipsetId = 1
                }
            );

        }
    }
}