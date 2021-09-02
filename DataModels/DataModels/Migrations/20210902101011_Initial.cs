using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModels.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "api_configurations",
                columns: table => new
                {
                    api_configuration_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    api_publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scheduling_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_api_configurations", x => x.api_configuration_id);
                });

            migrationBuilder.CreateTable(
                name: "api_endpoints",
                columns: table => new
                {
                    api_endpoint_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apiEndpoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    method_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    api_publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    headers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    third_party_api_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_api_endpoints", x => x.api_endpoint_id);
                    table.ForeignKey(
                        name: "FK_api_endpoints_api_configurations_third_party_api_id",
                        column: x => x.third_party_api_id,
                        principalTable: "api_configurations",
                        principalColumn: "api_configuration_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_api_endpoints_third_party_api_id",
                table: "api_endpoints",
                column: "third_party_api_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "api_endpoints");

            migrationBuilder.DropTable(
                name: "api_configurations");
        }
    }
}
