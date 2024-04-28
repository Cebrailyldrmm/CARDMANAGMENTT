using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CardFinder.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Customerİd = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CustomerSurname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CustomerPhone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CustomerTC = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Customerİd);
                });

            migrationBuilder.CreateTable(
                name: "cards",
                columns: table => new
                {
                    Cardid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Customerİd = table.Column<int>(type: "integer", nullable: false),
                    CardName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Bankname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Cardtybe = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    cardnumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CardMonth = table.Column<int>(type: "integer", nullable: false),
                    Cardyear = table.Column<int>(type: "integer", nullable: false),
                    CardCVV = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cards", x => x.Cardid);
                    table.ForeignKey(
                        name: "FK_cards_customers_Customerİd",
                        column: x => x.Customerİd,
                        principalTable: "customers",
                        principalColumn: "Customerİd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cards_Customerİd",
                table: "cards",
                column: "Customerİd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cards");

            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
