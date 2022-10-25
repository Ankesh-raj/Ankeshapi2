using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class api24a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "color_tbl",
                columns: table => new
                {
                    colourId = table.Column<Guid>(nullable: false),
                    colourName = table.Column<string>(nullable: true),
                    colourCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color_tbl", x => x.colourId);
                });

            migrationBuilder.CreateTable(
                name: "tb1_size",
                columns: table => new
                {
                    sizeId = table.Column<Guid>(nullable: false),
                    sizeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb1_size", x => x.sizeId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_createcredit",
                columns: table => new
                {
                    creditId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_createcredit", x => x.creditId);
                });

            migrationBuilder.CreateTable(
                name: "tb1_product",
                columns: table => new
                {
                    productId = table.Column<Guid>(nullable: false),
                    productName = table.Column<string>(nullable: true),
                    productYear = table.Column<int>(nullable: false),
                    channelId = table.Column<int>(nullable: false),
                    productCode = table.Column<string>(nullable: true),
                    sizeScaleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb1_product", x => x.productId);
                    table.ForeignKey(
                        name: "FK_tb1_product_tb1_size_sizeScaleId",
                        column: x => x.sizeScaleId,
                        principalTable: "tb1_size",
                        principalColumn: "sizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_article",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(nullable: false),
                    ArticleName = table.Column<string>(nullable: true),
                    colourId = table.Column<Guid>(nullable: false),
                    productId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_article", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_tbl_article_color_tbl_colourId",
                        column: x => x.colourId,
                        principalTable: "color_tbl",
                        principalColumn: "colourId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_article_tb1_product_productId",
                        column: x => x.productId,
                        principalTable: "tb1_product",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb1_product_sizeScaleId",
                table: "tb1_product",
                column: "sizeScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_article_colourId",
                table: "tbl_article",
                column: "colourId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_article_productId",
                table: "tbl_article",
                column: "productId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_article");

            migrationBuilder.DropTable(
                name: "tbl_createcredit");

            migrationBuilder.DropTable(
                name: "color_tbl");

            migrationBuilder.DropTable(
                name: "tb1_product");

            migrationBuilder.DropTable(
                name: "tb1_size");
        }
    }
}
