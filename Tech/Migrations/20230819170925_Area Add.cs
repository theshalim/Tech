using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tech.Migrations
{
    public partial class AreaAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_manufracturingAddresses_ManufracturingAddressId",
                table: "products");

            migrationBuilder.DropTable(
                name: "manufracturingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_products_ManufracturingAddressId",
                table: "products");

            migrationBuilder.CreateTable(
                name: "HrDistricts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnName = table.Column<string>(maxLength: 50, nullable: false),
                    BnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrDistricts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "HrDivisions",
                columns: table => new
                {
                    DivisionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnName = table.Column<string>(maxLength: 50, nullable: false),
                    BnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrDivisions", x => x.DivisionId);
                });

            migrationBuilder.CreateTable(
                name: "HrThanas",
                columns: table => new
                {
                    ThanaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnName = table.Column<string>(maxLength: 50, nullable: false),
                    BnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrThanas", x => x.ThanaId);
                });

            migrationBuilder.CreateTable(
                name: "EmpInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpCode = table.Column<int>(nullable: false),
                    EmpEnName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 15, nullable: false),
                    DivisionId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    ThanaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpInfos_HrDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "HrDistricts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpInfos_HrDivisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "HrDivisions",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpInfos_HrThanas_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "HrThanas",
                        principalColumn: "ThanaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfos_DistrictId",
                table: "EmpInfos",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfos_DivisionId",
                table: "EmpInfos",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfos_ThanaId",
                table: "EmpInfos",
                column: "ThanaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpInfos");

            migrationBuilder.DropTable(
                name: "HrDistricts");

            migrationBuilder.DropTable(
                name: "HrDivisions");

            migrationBuilder.DropTable(
                name: "HrThanas");

            migrationBuilder.CreateTable(
                name: "manufracturingAddresses",
                columns: table => new
                {
                    ManufracturingAddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bnName = table.Column<string>(nullable: true),
                    enName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufracturingAddresses", x => x.ManufracturingAddressId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_ManufracturingAddressId",
                table: "products",
                column: "ManufracturingAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_manufracturingAddresses_ManufracturingAddressId",
                table: "products",
                column: "ManufracturingAddressId",
                principalTable: "manufracturingAddresses",
                principalColumn: "ManufracturingAddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
