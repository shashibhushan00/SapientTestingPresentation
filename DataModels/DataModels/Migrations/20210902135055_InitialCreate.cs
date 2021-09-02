using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModels.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiConfigurations",
                columns: table => new
                {
                    ApiConfigurationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiPublisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchedulingTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiConfigurations", x => x.ApiConfigurationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    EmailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserRole = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "ApiEndpoints",
                columns: table => new
                {
                    ApiEndpointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiEndpointUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MethodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApiPublisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdPartyApiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiEndpoints", x => x.ApiEndpointId);
                    table.ForeignKey(
                        name: "FK_ApiEndpoints_ApiConfigurations_ThirdPartyApiId",
                        column: x => x.ThirdPartyApiId,
                        principalTable: "ApiConfigurations",
                        principalColumn: "ApiConfigurationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Symbols",
                columns: table => new
                {
                    SymbolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SymbolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdPartyApiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symbols", x => x.SymbolId);
                    table.ForeignKey(
                        name: "FK_Symbols_ApiConfigurations_ThirdPartyApiId",
                        column: x => x.ThirdPartyApiId,
                        principalTable: "ApiConfigurations",
                        principalColumn: "ApiConfigurationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGridViews",
                columns: table => new
                {
                    EmailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GridViewEncoding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GridViewName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGridViews", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_UserGridViews_Users_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Users",
                        principalColumn: "EmailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarketQuotes",
                columns: table => new
                {
                    MarketQuoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfShares = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularMarketChange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegularMarketChangePercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegularMarketDayHigh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegularMarketDayLow = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegularMarketVolume = table.Column<long>(type: "bigint", nullable: false),
                    RegularMarketOpen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrailingPE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceToSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ForwardPE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tradable = table.Column<bool>(type: "bit", nullable: false),
                    SymbolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketQuotes", x => x.MarketQuoteId);
                    table.ForeignKey(
                        name: "FK_MarketQuotes_Symbols_SymbolId",
                        column: x => x.SymbolId,
                        principalTable: "Symbols",
                        principalColumn: "SymbolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiEndpoints_ThirdPartyApiId",
                table: "ApiEndpoints",
                column: "ThirdPartyApiId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketQuotes_SymbolId",
                table: "MarketQuotes",
                column: "SymbolId");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_ThirdPartyApiId",
                table: "Symbols",
                column: "ThirdPartyApiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiEndpoints");

            migrationBuilder.DropTable(
                name: "MarketQuotes");

            migrationBuilder.DropTable(
                name: "UserGridViews");

            migrationBuilder.DropTable(
                name: "Symbols");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ApiConfigurations");
        }
    }
}
