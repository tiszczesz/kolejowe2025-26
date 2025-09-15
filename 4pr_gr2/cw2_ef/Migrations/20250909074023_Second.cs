using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cw2_ef.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Editors",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "ul. Wookkk, Kraków 31-161", "Appress" },
                    { 2, "ul. Wookkk, Kraków 31-161", "Trrrrr" },
                    { 3, "ul. Wookkk, Kraków 31-161", "Rainbow" },
                    { 4, "ul. Zygmunta, Kraków 31-161", "Feryk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Editors");
        }
    }
}
