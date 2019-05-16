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

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);

            ModelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer() {ManufacturerId = 1, Name = "Intel Corporation", URL = "https://www.intel.com/content/www/us/en/homepage.html"},
                new Manufacturer() {ManufacturerId = 2, Name = "Advanced Micro Devices, Inc", URL = "https://www.amd.com/en"}
            );

            ModelBuilder.Entity<Socket>().HasData(
                new Socket() {SocketId = 1, Name = "LGA-1151"},
                new Socket() {SocketId = 2, Name = "LGA-1150"}
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
// public int CPUId {get;set;}
//         public string Name {get;set;}
//         public int CoreCount {get;set;}  

//         public double BaseFrequency {get;set;}
//         public double MaxFrequency {get;set;}
//         public double L3Cache {get;set;}
//         public int TDP {get;set;}
//         public string Series {get;set;}
//         public string Family {get;set;}
//         public bool ForServer {get;set;}
//         public bool ECC {get;set;}
//         public bool SMT {get;set;}
//         public string Lithography {get;set;}
//         public string MaxMemory {get;set;}
//         public string IntegratedGraphics {get;set;}
//         public string MaxGPUClockRate {get;set;}
//         public double Price {get;set;}
//         public DateTime ReleaseDate {get;set;}

//         public Socket Socket {get;set;}
//         public Manufacturer Manufacturer {get;set;}