using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerHardware.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chipsets",
                columns: table => new
                {
                    ChipsetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LaunchDate = table.Column<string>(nullable: true),
                    BusSpeed = table.Column<string>(nullable: true),
                    TDP = table.Column<string>(nullable: true),
                    Overclock = table.Column<bool>(nullable: false),
                    DIMMsPerChannel = table.Column<string>(nullable: true),
                    DisplaysSupported = table.Column<string>(nullable: true),
                    PCIExpressRevision = table.Column<string>(nullable: true),
                    MaxPCIExpressLanes = table.Column<string>(nullable: true),
                    NumberOfUSBPorts = table.Column<int>(nullable: false),
                    USBRevision = table.Column<string>(nullable: true),
                    MaxSata3Ports = table.Column<int>(nullable: false),
                    IntelOptaneMemorySupported = table.Column<bool>(nullable: true),
                    IntelvProPlatformEligibility = table.Column<bool>(nullable: true),
                    IntelMEFirmwareVersion = table.Column<string>(nullable: true),
                    IntelHDAudioTechnology = table.Column<bool>(nullable: true),
                    IntelRapidStorageTechnology = table.Column<bool>(nullable: true),
                    IntelRapidStorageTechnologyForPCIStorage = table.Column<bool>(nullable: true),
                    IntelSmartSoundTechnology = table.Column<bool>(nullable: true),
                    IntelPlatformTTTrustTechnology = table.Column<bool>(nullable: true),
                    IntelBootGuard = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chipsets", x => x.ChipsetId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "Sockets",
                columns: table => new
                {
                    SocketId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sockets", x => x.SocketId);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    CPUId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CoreCount = table.Column<int>(nullable: false),
                    ThreadCount = table.Column<int>(nullable: false),
                    BaseFrequency = table.Column<double>(nullable: false),
                    MaxFrequency = table.Column<double>(nullable: false),
                    L3Cache = table.Column<double>(nullable: false),
                    TDP = table.Column<int>(nullable: false),
                    Series = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ECC = table.Column<bool>(nullable: false),
                    SMT = table.Column<bool>(nullable: false),
                    Lithography = table.Column<string>(nullable: true),
                    MaxMemory = table.Column<string>(nullable: true),
                    MaxMemoryChannel = table.Column<string>(nullable: true),
                    IntegratedGraphics = table.Column<string>(nullable: true),
                    MaxGPUClockRate = table.Column<string>(nullable: true),
                    MSRPPrice = table.Column<double>(nullable: false),
                    PCIExpressLanes = table.Column<double>(nullable: false),
                    ReleaseDate = table.Column<string>(nullable: true),
                    SocketId = table.Column<int>(nullable: false),
                    ManufacturerId = table.Column<int>(nullable: false),
                    ChipsetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.CPUId);
                    table.ForeignKey(
                        name: "FK_CPUs_Chipsets_ChipsetId",
                        column: x => x.ChipsetId,
                        principalTable: "Chipsets",
                        principalColumn: "ChipsetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_Sockets_SocketId",
                        column: x => x.SocketId,
                        principalTable: "Sockets",
                        principalColumn: "SocketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPUDetails",
                columns: table => new
                {
                    CPUDetailId = table.Column<int>(nullable: false),
                    TJunction = table.Column<string>(nullable: true),
                    MaxCPUs = table.Column<int>(nullable: false),
                    PackageSizeX = table.Column<string>(nullable: true),
                    PackageSizeY = table.Column<string>(nullable: true),
                    IntelOptaneMemorySupported = table.Column<bool>(nullable: true),
                    IntelTurboBoostTechnology2 = table.Column<bool>(nullable: true),
                    IntelTurboBoostTechnology1 = table.Column<bool>(nullable: true),
                    IntelvProPlatformEligibility = table.Column<bool>(nullable: true),
                    IntelHyperThreadingTechnology = table.Column<bool>(nullable: true),
                    IntelVirtualizationTechnologyforDirectIO = table.Column<bool>(nullable: true),
                    VTxWithExtendedPageTables = table.Column<bool>(nullable: true),
                    IntelTSXNI = table.Column<bool>(nullable: true),
                    Intel64 = table.Column<bool>(nullable: true),
                    InstructionSet = table.Column<string>(nullable: true),
                    IdleStates = table.Column<bool>(nullable: true),
                    EnhancedIntelSpeedStepTechnology = table.Column<bool>(nullable: true),
                    ThermalMonitoringTechnologies = table.Column<bool>(nullable: true),
                    IntelIdentityProtectionTechnology = table.Column<bool>(nullable: true),
                    StableImagePlatformProgram = table.Column<bool>(nullable: true),
                    IntelAESNewInstructions = table.Column<bool>(nullable: true),
                    SecureKey = table.Column<bool>(nullable: true),
                    IntelSoftwareGuardExtentions = table.Column<bool>(nullable: true),
                    IntelMemoryProtectionExtensions = table.Column<bool>(nullable: true),
                    IntelOSGuard = table.Column<bool>(nullable: true),
                    IntelTrustedExecutionTechnology = table.Column<bool>(nullable: true),
                    ExecuteDisableBit = table.Column<bool>(nullable: true),
                    IntelBootGuard = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUDetails", x => x.CPUDetailId);
                    table.ForeignKey(
                        name: "FK_CPUDetails_CPUs_CPUDetailId",
                        column: x => x.CPUDetailId,
                        principalTable: "CPUs",
                        principalColumn: "CPUId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Chipsets",
                columns: new[] { "ChipsetId", "BusSpeed", "DIMMsPerChannel", "DisplaysSupported", "IntelBootGuard", "IntelHDAudioTechnology", "IntelMEFirmwareVersion", "IntelOptaneMemorySupported", "IntelPlatformTTTrustTechnology", "IntelRapidStorageTechnology", "IntelRapidStorageTechnologyForPCIStorage", "IntelSmartSoundTechnology", "IntelvProPlatformEligibility", "LaunchDate", "MaxPCIExpressLanes", "MaxSata3Ports", "Name", "NumberOfUSBPorts", "Overclock", "PCIExpressRevision", "TDP", "USBRevision" },
                values: new object[] { 1, "8", "2", "3", true, true, "12", true, true, true, true, true, false, "Q4'18", "24", 6, "Z390", 14, true, "3.0", "6", "3.1" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "Intel Corporation", "https://www.intel.com/content/www/us/en/homepage.html" },
                    { 2, "Advanced Micro Devices, Inc", "https://www.amd.com/en" }
                });

            migrationBuilder.InsertData(
                table: "Sockets",
                columns: new[] { "SocketId", "Name" },
                values: new object[,]
                {
                    { 13, "FS1" },
                    { 12, "AM3+" },
                    { 11, "LGA-1356" },
                    { 10, "FM2" },
                    { 9, "FM2+" },
                    { 8, "AM1" },
                    { 6, "LGA-2066" },
                    { 14, "FM1" },
                    { 5, "AM4" },
                    { 4, "SP3" },
                    { 3, "TR4" },
                    { 2, "LGA-1150" },
                    { 1, "LGA-1151" },
                    { 7, "LGA-3647" },
                    { 15, "2011" }
                });

            migrationBuilder.InsertData(
                table: "CPUs",
                columns: new[] { "CPUId", "BaseFrequency", "ChipsetId", "CoreCount", "ECC", "Family", "IntegratedGraphics", "L3Cache", "Lithography", "MSRPPrice", "ManufacturerId", "MaxFrequency", "MaxGPUClockRate", "MaxMemory", "MaxMemoryChannel", "Name", "PCIExpressLanes", "ReleaseDate", "SMT", "Series", "SocketId", "TDP", "ThreadCount", "Type" },
                values: new object[] { 1, 3.6000000000000001, 1, 8, false, "Coffee Lake", "", 16.0, "14", 500.0, 1, 5.0, "", "128", "2", "9900K", 16.0, "Q4'18", true, "Intel Core i9", 1, 95, 16, "Desktop" });

            migrationBuilder.InsertData(
                table: "CPUDetails",
                columns: new[] { "CPUDetailId", "EnhancedIntelSpeedStepTechnology", "ExecuteDisableBit", "IdleStates", "InstructionSet", "Intel64", "IntelAESNewInstructions", "IntelBootGuard", "IntelHyperThreadingTechnology", "IntelIdentityProtectionTechnology", "IntelMemoryProtectionExtensions", "IntelOSGuard", "IntelOptaneMemorySupported", "IntelSoftwareGuardExtentions", "IntelTSXNI", "IntelTrustedExecutionTechnology", "IntelTurboBoostTechnology1", "IntelTurboBoostTechnology2", "IntelVirtualizationTechnologyforDirectIO", "IntelvProPlatformEligibility", "MaxCPUs", "PackageSizeX", "PackageSizeY", "SecureKey", "StableImagePlatformProgram", "TJunction", "ThermalMonitoringTechnologies", "VTxWithExtendedPageTables" },
                values: new object[] { 1, true, true, true, "64-bit", true, true, true, true, true, true, true, true, true, true, true, null, true, true, true, 1, "37.5", "37.5", true, true, "LGA-1151", true, true });

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_ChipsetId",
                table: "CPUs",
                column: "ChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_ManufacturerId",
                table: "CPUs",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_SocketId",
                table: "CPUs",
                column: "SocketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUDetails");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "Chipsets");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Sockets");
        }
    }
}
