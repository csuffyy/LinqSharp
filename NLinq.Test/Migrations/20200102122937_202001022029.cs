﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NLinq.Test.Migrations
{
    public partial class _202001022029 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "FreeModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Northwnd.Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 15, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.CustomerDemographics",
                columns: table => new
                {
                    CustomerTypeID = table.Column<string>(maxLength: 10, nullable: false),
                    CustomerDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.CustomerDemographics", x => x.CustomerTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(maxLength: 5, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 40, nullable: false),
                    ContactName = table.Column<string>(maxLength: 30, nullable: true),
                    ContactTitle = table.Column<string>(maxLength: 30, nullable: true),
                    Address = table.Column<string>(maxLength: 60, nullable: true),
                    City = table.Column<string>(maxLength: 15, nullable: true),
                    Region = table.Column<string>(maxLength: 15, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 15, nullable: true),
                    Phone = table.Column<string>(maxLength: 24, nullable: true),
                    Fax = table.Column<string>(maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(maxLength: 10, nullable: false),
                    Title = table.Column<string>(maxLength: 30, nullable: true),
                    TitleOfCourtesy = table.Column<string>(maxLength: 25, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(maxLength: 60, nullable: true),
                    City = table.Column<string>(maxLength: 15, nullable: true),
                    Region = table.Column<string>(maxLength: 15, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 15, nullable: true),
                    HomePhone = table.Column<string>(maxLength: 24, nullable: true),
                    Extension = table.Column<string>(maxLength: 4, nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ReportsTo = table.Column<int>(nullable: true),
                    PhotoPath = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Northwnd.Employees_Northwnd.Employees_ReportsTo",
                        column: x => x.ReportsTo,
                        principalTable: "Northwnd.Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Regions",
                columns: table => new
                {
                    RegionID = table.Column<int>(nullable: false),
                    RegionDescription = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Regions", x => x.RegionID);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Shippers",
                columns: table => new
                {
                    ShipperID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 40, nullable: false),
                    Phone = table.Column<string>(maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Shippers", x => x.ShipperID);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 40, nullable: false),
                    ContactName = table.Column<string>(maxLength: 30, nullable: true),
                    ContactTitle = table.Column<string>(maxLength: 30, nullable: true),
                    Address = table.Column<string>(maxLength: 60, nullable: true),
                    City = table.Column<string>(maxLength: 15, nullable: true),
                    Region = table.Column<string>(maxLength: 15, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 15, nullable: true),
                    Phone = table.Column<string>(maxLength: 24, nullable: true),
                    Fax = table.Column<string>(maxLength: 24, nullable: true),
                    HomePage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCustomerDemos",
                columns: table => new
                {
                    CustomerID = table.Column<string>(maxLength: 5, nullable: false),
                    CustomerTypeID = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCustomerDemos", x => new { x.CustomerTypeID, x.CustomerID });
                    table.ForeignKey(
                        name: "FK_CustomerCustomerDemos_Northwnd.Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Northwnd.Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerCustomerDemos_Northwnd.CustomerDemographics_Customer~",
                        column: x => x.CustomerTypeID,
                        principalTable: "Northwnd.CustomerDemographics",
                        principalColumn: "CustomerTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Territories",
                columns: table => new
                {
                    TerritoryID = table.Column<string>(maxLength: 20, nullable: false),
                    TerritoryDescription = table.Column<string>(maxLength: 50, nullable: false),
                    RegionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Territories", x => x.TerritoryID);
                    table.ForeignKey(
                        name: "FK_Northwnd.Territories_Northwnd.Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Northwnd.Regions",
                        principalColumn: "RegionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<string>(maxLength: 5, nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: true),
                    RequiredDate = table.Column<DateTime>(nullable: true),
                    ShippedDate = table.Column<DateTime>(nullable: true),
                    ShipVia = table.Column<int>(nullable: true),
                    Freight = table.Column<double>(nullable: true),
                    ShipName = table.Column<string>(maxLength: 40, nullable: true),
                    ShipAddress = table.Column<string>(maxLength: 60, nullable: true),
                    ShipCity = table.Column<string>(maxLength: 15, nullable: true),
                    ShipRegion = table.Column<string>(maxLength: 15, nullable: true),
                    ShipPostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    ShipCountry = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Northwnd.Orders_Northwnd.Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Northwnd.Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Northwnd.Orders_Northwnd.Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Northwnd.Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Northwnd.Orders_Northwnd.Shippers_ShipVia",
                        column: x => x.ShipVia,
                        principalTable: "Northwnd.Shippers",
                        principalColumn: "ShipperID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(maxLength: 40, nullable: false),
                    SupplierID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: true),
                    QuantityPerUnit = table.Column<string>(maxLength: 20, nullable: true),
                    UnitPrice = table.Column<double>(nullable: true),
                    UnitsInStock = table.Column<short>(nullable: true),
                    UnitsOnOrder = table.Column<short>(nullable: true),
                    ReorderLevel = table.Column<short>(nullable: true),
                    Discontinued = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Northwnd.Products_Northwnd.Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Northwnd.Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Northwnd.Products_Northwnd.Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Northwnd.Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTerritories",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    TerritoryID = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTerritories", x => new { x.EmployeeID, x.TerritoryID });
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Northwnd.Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Northwnd.Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Northwnd.Territories_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "Northwnd.Territories",
                        principalColumn: "TerritoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Northwnd.OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false),
                    Quantity = table.Column<short>(nullable: false),
                    Discount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northwnd.OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_Northwnd.OrderDetails_Northwnd.Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Northwnd.Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Northwnd.OrderDetails_Northwnd.Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Northwnd.Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCustomerDemos_CustomerID",
                table: "CustomerCustomerDemos",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerritories_TerritoryID",
                table: "EmployeeTerritories",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.Employees_ReportsTo",
                table: "Northwnd.Employees",
                column: "ReportsTo");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.OrderDetails_ProductID",
                table: "Northwnd.OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.Orders_CustomerID",
                table: "Northwnd.Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.Orders_EmployeeID",
                table: "Northwnd.Orders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.Orders_ShipVia",
                table: "Northwnd.Orders",
                column: "ShipVia");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.Products_CategoryID",
                table: "Northwnd.Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.Products_SupplierID",
                table: "Northwnd.Products",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Northwnd.Territories_RegionID",
                table: "Northwnd.Territories",
                column: "RegionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCustomerDemos");

            migrationBuilder.DropTable(
                name: "EmployeeTerritories");

            migrationBuilder.DropTable(
                name: "Northwnd.OrderDetails");

            migrationBuilder.DropTable(
                name: "Northwnd.CustomerDemographics");

            migrationBuilder.DropTable(
                name: "Northwnd.Territories");

            migrationBuilder.DropTable(
                name: "Northwnd.Orders");

            migrationBuilder.DropTable(
                name: "Northwnd.Products");

            migrationBuilder.DropTable(
                name: "Northwnd.Regions");

            migrationBuilder.DropTable(
                name: "Northwnd.Customers");

            migrationBuilder.DropTable(
                name: "Northwnd.Employees");

            migrationBuilder.DropTable(
                name: "Northwnd.Shippers");

            migrationBuilder.DropTable(
                name: "Northwnd.Categories");

            migrationBuilder.DropTable(
                name: "Northwnd.Suppliers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "FreeModels");
        }
    }
}
