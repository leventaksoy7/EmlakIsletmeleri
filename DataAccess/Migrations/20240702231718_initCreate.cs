using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workplaces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizedPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workplaces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkplaceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Workplaces_WorkplaceID",
                        column: x => x.WorkplaceID,
                        principalTable: "Workplaces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaSquareMeters = table.Column<double>(type: "float", nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    BuildingFloors = table.Column<int>(type: "int", nullable: false),
                    HeatingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsForSale = table.Column<byte>(type: "tinyint", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaleSoldDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsForRent = table.Column<byte>(type: "tinyint", nullable: false),
                    RentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RentEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ListedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    TenantCustomerId = table.Column<int>(type: "int", nullable: true),
                    WorkplaceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Customers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Customers_TenantCustomerId",
                        column: x => x.TenantCustomerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Workplaces_WorkplaceID",
                        column: x => x.WorkplaceID,
                        principalTable: "Workplaces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertySales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    SellerCustomerId = table.Column<int>(type: "int", nullable: false),
                    BuyerCustomerId = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealEstateAgentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PropertySales_Customers_BuyerCustomerId",
                        column: x => x.BuyerCustomerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertySales_Customers_SellerCustomerId",
                        column: x => x.SellerCustomerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertySales_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertySales_Workplaces_RealEstateAgentId",
                        column: x => x.RealEstateAgentId,
                        principalTable: "Workplaces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RealEstateAgentSales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealEstateAgentId = table.Column<int>(type: "int", nullable: false),
                    PropertySaleId = table.Column<int>(type: "int", nullable: false),
                    SaleAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstateAgentSales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RealEstateAgentSales_PropertySales_PropertySaleId",
                        column: x => x.PropertySaleId,
                        principalTable: "PropertySales",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RealEstateAgentSales_Workplaces_RealEstateAgentId",
                        column: x => x.RealEstateAgentId,
                        principalTable: "Workplaces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_WorkplaceID",
                table: "Customers",
                column: "WorkplaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerId",
                table: "Properties",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TenantCustomerId",
                table: "Properties",
                column: "TenantCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_WorkplaceID",
                table: "Properties",
                column: "WorkplaceID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySales_BuyerCustomerId",
                table: "PropertySales",
                column: "BuyerCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySales_PropertyId",
                table: "PropertySales",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySales_RealEstateAgentId",
                table: "PropertySales",
                column: "RealEstateAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySales_SellerCustomerId",
                table: "PropertySales",
                column: "SellerCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstateAgentSales_PropertySaleId",
                table: "RealEstateAgentSales",
                column: "PropertySaleId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstateAgentSales_RealEstateAgentId",
                table: "RealEstateAgentSales",
                column: "RealEstateAgentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RealEstateAgentSales");

            migrationBuilder.DropTable(
                name: "PropertySales");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Workplaces");
        }
    }
}
