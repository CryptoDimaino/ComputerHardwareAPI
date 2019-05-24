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
                new Manufacturer() 
                {
                    ManufacturerId = 1, 
                    Name = "Intel Corporation", 
                    URL = "https://www.intel.com/content/www/us/en/homepage.html", 
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
                },
                new Manufacturer() 
                {
                    ManufacturerId = 2, 
                    Name = "Advanced Micro Devices, Inc", 
                    URL = "https://www.amd.com/en",
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
                }
            );

            ModelBuilder.Entity<Socket>().HasData(
                new Socket() {SocketId = 1, Name = "LGA-1151", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 2, Name = "LGA-1150", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 3, Name = "TR4", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 4, Name = "SP3", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 5, Name = "AM4", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 6, Name = "LGA-2066", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 7, Name = "LGA-3647", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 8, Name = "AM1", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 9, Name = "FM2+", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 10, Name = "FM2", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 11, Name = "LGA-1356", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 12, Name = "AM3+", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 13, Name = "FS1", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 14, Name = "FM1", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 15, Name = "2011", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Socket() {SocketId = 16, Name = "TR4", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now}
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
                    IntelBootGuard = true,
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
                },
                new Chipset()
                {
                    ChipsetId = 2,
                    Name = "X399",
                    LaunchDate = "Q2'17",
                    BusSpeed = "TBD",
                    TDP = "TBD",
                    Overclock = true,
                    DIMMsPerChannel = "4",
                    DisplaysSupported = "0",
                    PCIExpressRevision = "3.0",
                    MaxPCIExpressLanes = "8",
                    NumberOfUSBPorts = 14,
                    USBRevision = "3.1",
                    MaxSata3Ports = 12,
                    IntelOptaneMemorySupported = null,
                    IntelvProPlatformEligibility = null,
                    IntelMEFirmwareVersion = null,
                    IntelHDAudioTechnology = null,
                    IntelRapidStorageTechnology = null,
                    IntelRapidStorageTechnologyForPCIStorage = null,
                    IntelSmartSoundTechnology = null,
                    IntelPlatformTTTrustTechnology = null,
                    IntelBootGuard = null,
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
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
                    IntelBootGuard = true,
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
                },
                new CPUDetail()
                {
                    CPUDetailId = 2, 
                    TJunction = "TR4",
                    MaxCPUs = 1,
                    PackageSizeX = "58.5",
                    PackageSizeY = "75.4",
                    IntelOptaneMemorySupported = null,
                    IntelTurboBoostTechnology2 = null,
                    IntelTurboBoostTechnology1 = null,
                    IntelvProPlatformEligibility = null,
                    IntelHyperThreadingTechnology = null,
                    IntelVirtualizationTechnologyforDirectIO = null,
                    VTxWithExtendedPageTables = null,
                    IntelTSXNI = null,
                    Intel64 = null,
                    InstructionSet = "64-bit",
                    IdleStates = null,
                    EnhancedIntelSpeedStepTechnology = null,
                    ThermalMonitoringTechnologies = null,
                    IntelIdentityProtectionTechnology = null,
                    StableImagePlatformProgram = null,
                    IntelAESNewInstructions = null,
                    SecureKey = null,
                    IntelSoftwareGuardExtentions = null,
                    IntelMemoryProtectionExtensions = null,
                    IntelOSGuard = null,
                    IntelTrustedExecutionTechnology = null,
                    ExecuteDisableBit = null,
                    IntelBootGuard = null,
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
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
                    ChipsetId = 1,
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
                },
                new CPU()
                {
                    CPUId = 2,
                    Name = "1950X",
                    CoreCount = 16,
                    ThreadCount = 32,
                    BaseFrequency = 3.40,
                    MaxFrequency = 4.00,
                    L3Cache = 32,
                    TDP = 180,
                    Series = "AMD Ryzen Threadripper",
                    Family = "Zen",
                    Type = "Desktop",
                    ECC = true,
                    SMT = true,
                    Lithography = "14",
                    MaxMemory = "128",
                    MaxMemoryChannel = "4",
                    IntegratedGraphics = null,
                    MaxGPUClockRate = null,
                    MSRPPrice = 999.00,
                    PCIExpressLanes = 16,
                    ReleaseDate = "Q2'17",
                    SocketId = 16,
                    ManufacturerId = 2,
                    ChipsetId = 2,
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
                }
            );

        }
    }
}