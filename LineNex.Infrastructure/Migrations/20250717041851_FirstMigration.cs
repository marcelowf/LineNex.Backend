using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LineNex.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionPoint",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionPoint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Layout",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionLine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionLine_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistributionPointStock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistributionPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionPointStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistributionPointStock_DistributionPoint_DistributionPointId",
                        column: x => x.DistributionPointId,
                        principalTable: "DistributionPoint",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InventoryDistributionPoint",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistributionPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryDistributionPoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryDistributionPoint_DistributionPoint_DistributionPointId",
                        column: x => x.DistributionPointId,
                        principalTable: "DistributionPoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryDistributionPoint_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistributionPointMachine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistributionPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionPointMachine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistributionPointMachine_DistributionPoint_DistributionPointId",
                        column: x => x.DistributionPointId,
                        principalTable: "DistributionPoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistributionPointMachine_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineConnection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineConnection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineConnection_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineSensor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SensorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineSensor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineSensor_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineSensor_Sensor_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineTag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineTag_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionLineMachine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductionLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionLineMachine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionLineMachine_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionLineMachine_ProductionLine_ProductionLineId",
                        column: x => x.ProductionLineId,
                        principalTable: "ProductionLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCompany",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCompany_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCompany_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineSensorData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineSensorMachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineSensorSensorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineSensorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineSensorData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineSensorData_MachineSensor_MachineSensorId",
                        column: x => x.MachineSensorId,
                        principalTable: "MachineSensor",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedById", "IsDeleted", "ModifiedAt", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { new Guid("17ec40e3-9be7-4201-b2a6-13fb71d41e94"), "RDR", new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, "Reader" },
                    { new Guid("27ec40e3-9be7-4201-b2a6-13fb71d41e94"), "CRT", new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, "Create" },
                    { new Guid("37ec40e3-9be7-4201-b2a6-13fb71d41e94"), "UPD", new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, "Update" },
                    { new Guid("47ec40e3-9be7-4201-b2a6-13fb71d41e94"), "DEL", new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, "Delete" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedById", "IsDeleted", "ModifiedAt", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { new Guid("a7ec40e3-9be7-4201-b2a6-13fb71d41e94"), "USER", new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, "Standard User" },
                    { new Guid("b7ec40e3-9be7-4201-b2a6-13fb71d41e94"), "ADMIN", new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "IsDeleted", "ModifiedAt", "ModifiedById", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, new Guid("17ec40e3-9be7-4201-b2a6-13fb71d41e94"), new Guid("b7ec40e3-9be7-4201-b2a6-13fb71d41e94") },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, new Guid("27ec40e3-9be7-4201-b2a6-13fb71d41e94"), new Guid("b7ec40e3-9be7-4201-b2a6-13fb71d41e94") },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, new Guid("37ec40e3-9be7-4201-b2a6-13fb71d41e94"), new Guid("b7ec40e3-9be7-4201-b2a6-13fb71d41e94") },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, new Guid("47ec40e3-9be7-4201-b2a6-13fb71d41e94"), new Guid("b7ec40e3-9be7-4201-b2a6-13fb71d41e94") },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), false, null, null, new Guid("17ec40e3-9be7-4201-b2a6-13fb71d41e94"), new Guid("a7ec40e3-9be7-4201-b2a6-13fb71d41e94") }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Email", "EmailConfirmed", "IsDeleted", "ModifiedAt", "ModifiedById", "Name", "Password", "RoleId" },
                values: new object[] { new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), new DateTime(2025, 1, 1, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("d17e004b-2335-4850-8a8a-4597cf73f862"), "marcelo.projects.dev@gmail.com", true, false, null, null, "Marcelo Wzorek Filho", "AQAAAAIAAYagAAAAENPeLyJ3XylxuM/AudsOGYLQyT4xYx2JLHr0aJM6G3upSFc2GuspPSfuBVe+bJw0wQ==", new Guid("b7ec40e3-9be7-4201-b2a6-13fb71d41e94") });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationToken_Token",
                table: "ApplicationToken",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationToken_UserId",
                table: "ApplicationToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributionPointMachine_DistributionPointId",
                table: "DistributionPointMachine",
                column: "DistributionPointId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributionPointMachine_MachineId",
                table: "DistributionPointMachine",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributionPointStock_DistributionPointId",
                table: "DistributionPointStock",
                column: "DistributionPointId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryDistributionPoint_DistributionPointId",
                table: "InventoryDistributionPoint",
                column: "DistributionPointId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryDistributionPoint_InventoryId",
                table: "InventoryDistributionPoint",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineConnection_MachineId",
                table: "MachineConnection",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineSensor_MachineId",
                table: "MachineSensor",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineSensor_SensorId",
                table: "MachineSensor",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineSensorData_MachineSensorId",
                table: "MachineSensorData",
                column: "MachineSensorId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineTag_MachineId",
                table: "MachineTag",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineTag_TagId",
                table: "MachineTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLine_CompanyId",
                table: "ProductionLine",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLineMachine_MachineId",
                table: "ProductionLineMachine",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLineMachine_ProductionLineId",
                table: "ProductionLineMachine",
                column: "ProductionLineId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_PermissionId",
                table: "RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_RoleId",
                table: "RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompany_CompanyId",
                table: "UserCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompany_UserId",
                table: "UserCompany",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationToken");

            migrationBuilder.DropTable(
                name: "DistributionPointMachine");

            migrationBuilder.DropTable(
                name: "DistributionPointStock");

            migrationBuilder.DropTable(
                name: "InventoryDistributionPoint");

            migrationBuilder.DropTable(
                name: "Layout");

            migrationBuilder.DropTable(
                name: "MachineConnection");

            migrationBuilder.DropTable(
                name: "MachineSensorData");

            migrationBuilder.DropTable(
                name: "MachineTag");

            migrationBuilder.DropTable(
                name: "ProductionLineMachine");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "UserCompany");

            migrationBuilder.DropTable(
                name: "DistributionPoint");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "MachineSensor");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "ProductionLine");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
