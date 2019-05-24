using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerHardware.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chipsets",
                columns: table => new
                {
                    ChipsetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    LaunchDate = table.Column<string>(nullable: false),
                    BusSpeed = table.Column<string>(nullable: false),
                    TDP = table.Column<string>(nullable: false),
                    Overclock = table.Column<bool>(nullable: false),
                    DIMMsPerChannel = table.Column<string>(nullable: false),
                    DisplaysSupported = table.Column<string>(nullable: false),
                    PCIExpressRevision = table.Column<string>(nullable: false),
                    MaxPCIExpressLanes = table.Column<string>(nullable: false),
                    NumberOfUSBPorts = table.Column<int>(nullable: false),
                    USBRevision = table.Column<string>(nullable: false),
                    MaxSata3Ports = table.Column<int>(nullable: false),
                    IntelOptaneMemorySupported = table.Column<bool>(nullable: true),
                    IntelvProPlatformEligibility = table.Column<bool>(nullable: true),
                    IntelMEFirmwareVersion = table.Column<string>(nullable: true),
                    IntelHDAudioTechnology = table.Column<bool>(nullable: true),
                    IntelRapidStorageTechnology = table.Column<bool>(nullable: true),
                    IntelRapidStorageTechnologyForPCIStorage = table.Column<bool>(nullable: true),
                    IntelSmartSoundTechnology = table.Column<bool>(nullable: true),
                    IntelPlatformTTTrustTechnology = table.Column<bool>(nullable: true),
                    IntelBootGuard = table.Column<bool>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
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
                    Name = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
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
                    Name = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
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
                    Name = table.Column<string>(nullable: false),
                    CoreCount = table.Column<int>(nullable: false),
                    ThreadCount = table.Column<int>(nullable: false),
                    BaseFrequency = table.Column<double>(nullable: false),
                    MaxFrequency = table.Column<double>(nullable: false),
                    L3Cache = table.Column<double>(nullable: false),
                    TDP = table.Column<int>(nullable: false),
                    Series = table.Column<string>(nullable: false),
                    Family = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    ECC = table.Column<bool>(nullable: false),
                    SMT = table.Column<bool>(nullable: false),
                    Lithography = table.Column<string>(nullable: false),
                    MaxMemory = table.Column<string>(nullable: false),
                    MaxMemoryChannel = table.Column<string>(nullable: false),
                    IntegratedGraphics = table.Column<string>(nullable: true),
                    MaxGPUClockRate = table.Column<string>(nullable: true),
                    MSRPPrice = table.Column<double>(nullable: false),
                    PCIExpressLanes = table.Column<double>(nullable: false),
                    ReleaseDate = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
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
                    TJunction = table.Column<string>(nullable: false),
                    MaxCPUs = table.Column<int>(nullable: false),
                    PackageSizeX = table.Column<string>(nullable: false),
                    PackageSizeY = table.Column<string>(nullable: false),
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
                    IntelBootGuard = table.Column<bool>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
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
                columns: new[] { "ChipsetId", "BusSpeed", "CreatedAt", "DIMMsPerChannel", "DisplaysSupported", "IntelBootGuard", "IntelHDAudioTechnology", "IntelMEFirmwareVersion", "IntelOptaneMemorySupported", "IntelPlatformTTTrustTechnology", "IntelRapidStorageTechnology", "IntelRapidStorageTechnologyForPCIStorage", "IntelSmartSoundTechnology", "IntelvProPlatformEligibility", "LaunchDate", "MaxPCIExpressLanes", "MaxSata3Ports", "Name", "NumberOfUSBPorts", "Overclock", "PCIExpressRevision", "TDP", "USBRevision", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "8", new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5106), "2", "3", true, true, "12", true, true, true, true, true, false, "Q4'18", "24", 6, "Z390", 14, true, "3.0", "6", "3.1", new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5552) },
                    { 2, "TBD", new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5923), "4", "0", null, null, null, null, null, null, null, null, null, "Q2'17", "8", 12, "X399", 14, true, "3.0", "TBD", "3.1", new DateTime(2019, 5, 24, 10, 21, 18, 18, DateTimeKind.Local).AddTicks(5933) }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "CreatedAt", "Name", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5133), "Intel Corporation", "https://www.intel.com/content/www/us/en/homepage.html", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5470) },
                    { 2, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5758), "Advanced Micro Devices, Inc", "https://www.amd.com/en", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(5768) }
                });

            migrationBuilder.InsertData(
                table: "Sockets",
                columns: new[] { "SocketId", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 14, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9473), "FM1", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9475) },
                    { 13, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9468), "FS1", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9470) },
                    { 12, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9463), "AM3+", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9465) },
                    { 11, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9457), "LGA-1356", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9460) },
                    { 10, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9452), "FM2", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9455) },
                    { 9, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9447), "FM2+", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9450) },
                    { 8, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9442), "AM1", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9445) },
                    { 6, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9432), "LGA-2066", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9434) },
                    { 15, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9478), "2011", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9480) },
                    { 5, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9427), "AM4", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9429) },
                    { 4, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9422), "SP3", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9424) },
                    { 3, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9416), "TR4", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9419) },
                    { 2, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9401), "LGA-1150", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9410) },
                    { 1, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(8825), "LGA-1151", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9126) },
                    { 7, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9437), "LGA-3647", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9439) },
                    { 16, new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9483), "TR4", new DateTime(2019, 5, 24, 10, 21, 18, 17, DateTimeKind.Local).AddTicks(9485) }
                });

            migrationBuilder.InsertData(
                table: "CPUs",
                columns: new[] { "CPUId", "BaseFrequency", "ChipsetId", "CoreCount", "CreatedAt", "ECC", "Family", "IntegratedGraphics", "L3Cache", "Lithography", "MSRPPrice", "ManufacturerId", "MaxFrequency", "MaxGPUClockRate", "MaxMemory", "MaxMemoryChannel", "Name", "PCIExpressLanes", "ReleaseDate", "SMT", "Series", "SocketId", "TDP", "ThreadCount", "Type", "UpdatedAt" },
                values: new object[] { 1, 3.6000000000000001, 1, 8, new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(568), false, "Coffee Lake", "", 16.0, "14", 500.0, 1, 5.0, "", "128", "2", "9900K", 16.0, "Q4'18", true, "Intel Core i9", 1, 95, 16, "Desktop", new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.InsertData(
                table: "CPUs",
                columns: new[] { "CPUId", "BaseFrequency", "ChipsetId", "CoreCount", "CreatedAt", "ECC", "Family", "IntegratedGraphics", "L3Cache", "Lithography", "MSRPPrice", "ManufacturerId", "MaxFrequency", "MaxGPUClockRate", "MaxMemory", "MaxMemoryChannel", "Name", "PCIExpressLanes", "ReleaseDate", "SMT", "Series", "SocketId", "TDP", "ThreadCount", "Type", "UpdatedAt" },
                values: new object[] { 2, 3.3999999999999999, 2, 16, new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(1162), true, "Zen", null, 32.0, "14", 999.0, 2, 4.0, null, "128", "4", "1950X", 16.0, "Q2'17", true, "AMD Ryzen Threadripper", 16, 180, 32, "Desktop", new DateTime(2019, 5, 24, 10, 21, 18, 20, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.InsertData(
                table: "CPUDetails",
                columns: new[] { "CPUDetailId", "CreatedAt", "EnhancedIntelSpeedStepTechnology", "ExecuteDisableBit", "IdleStates", "InstructionSet", "Intel64", "IntelAESNewInstructions", "IntelBootGuard", "IntelHyperThreadingTechnology", "IntelIdentityProtectionTechnology", "IntelMemoryProtectionExtensions", "IntelOSGuard", "IntelOptaneMemorySupported", "IntelSoftwareGuardExtentions", "IntelTSXNI", "IntelTrustedExecutionTechnology", "IntelTurboBoostTechnology1", "IntelTurboBoostTechnology2", "IntelVirtualizationTechnologyforDirectIO", "IntelvProPlatformEligibility", "MaxCPUs", "PackageSizeX", "PackageSizeY", "SecureKey", "StableImagePlatformProgram", "TJunction", "ThermalMonitoringTechnologies", "UpdatedAt", "VTxWithExtendedPageTables" },
                values: new object[] { 1, new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3365), true, true, true, "64-bit", true, true, true, true, true, true, true, true, true, true, true, null, true, true, true, 1, "37.5", "37.5", true, true, "LGA-1151", true, new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3619), true });

            migrationBuilder.InsertData(
                table: "CPUDetails",
                columns: new[] { "CPUDetailId", "CreatedAt", "EnhancedIntelSpeedStepTechnology", "ExecuteDisableBit", "IdleStates", "InstructionSet", "Intel64", "IntelAESNewInstructions", "IntelBootGuard", "IntelHyperThreadingTechnology", "IntelIdentityProtectionTechnology", "IntelMemoryProtectionExtensions", "IntelOSGuard", "IntelOptaneMemorySupported", "IntelSoftwareGuardExtentions", "IntelTSXNI", "IntelTrustedExecutionTechnology", "IntelTurboBoostTechnology1", "IntelTurboBoostTechnology2", "IntelVirtualizationTechnologyforDirectIO", "IntelvProPlatformEligibility", "MaxCPUs", "PackageSizeX", "PackageSizeY", "SecureKey", "StableImagePlatformProgram", "TJunction", "ThermalMonitoringTechnologies", "UpdatedAt", "VTxWithExtendedPageTables" },
                values: new object[] { 2, new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3946), null, null, null, "64-bit", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, "58.5", "75.4", null, null, "TR4", null, new DateTime(2019, 5, 24, 10, 21, 18, 19, DateTimeKind.Local).AddTicks(3955), null });

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
