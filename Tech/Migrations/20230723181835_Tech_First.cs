using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tech.Migrations
{
    public partial class Tech_First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enName = table.Column<string>(maxLength: 20, nullable: false),
                    bnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "manufracturingAddresses",
                columns: table => new
                {
                    ManufracturingAddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enName = table.Column<string>(maxLength: 20, nullable: false),
                    bnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufracturingAddresses", x => x.ManufracturingAddressId);
                });

            migrationBuilder.CreateTable(
                name: "priceRanges",
                columns: table => new
                {
                    PriceRangeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priceRanges", x => x.PriceRangeId);
                });

            migrationBuilder.CreateTable(
                name: "productionYears",
                columns: table => new
                {
                    ProductionYearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enName = table.Column<string>(maxLength: 20, nullable: false),
                    bnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productionYears", x => x.ProductionYearId);
                });

            migrationBuilder.CreateTable(
                name: "productUnits",
                columns: table => new
                {
                    UnitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enName = table.Column<string>(maxLength: 20, nullable: false),
                    bnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productUnits", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enName = table.Column<string>(nullable: false),
                    bnName = table.Column<string>(nullable: true),
                    UnitId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    ManufracturingAddressId = table.Column<int>(nullable: false),
                    PriceRangeId = table.Column<int>(nullable: true),
                    ProductionYearId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_manufracturingAddresses_ManufracturingAddressId",
                        column: x => x.ManufracturingAddressId,
                        principalTable: "manufracturingAddresses",
                        principalColumn: "ManufracturingAddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_priceRanges_PriceRangeId",
                        column: x => x.PriceRangeId,
                        principalTable: "priceRanges",
                        principalColumn: "PriceRangeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_productionYears_ProductionYearId",
                        column: x => x.ProductionYearId,
                        principalTable: "productionYears",
                        principalColumn: "ProductionYearId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_productUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "productUnits",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_ColorId",
                table: "products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ManufracturingAddressId",
                table: "products",
                column: "ManufracturingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_products_PriceRangeId",
                table: "products",
                column: "PriceRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductionYearId",
                table: "products",
                column: "ProductionYearId");

            migrationBuilder.CreateIndex(
                name: "IX_products_UnitId",
                table: "products",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "colors");

            migrationBuilder.DropTable(
                name: "manufracturingAddresses");

            migrationBuilder.DropTable(
                name: "priceRanges");

            migrationBuilder.DropTable(
                name: "productionYears");

            migrationBuilder.DropTable(
                name: "productUnits");
        }
    }
}
