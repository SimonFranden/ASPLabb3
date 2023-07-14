using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPLabb3_DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Description", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, "Naturfotografi är ett brett spektrum av fotografier som tagits utomhus med naturliga motiv.", 1, "Naturfotografi" },
                    { 2, "Basket eller basketboll (äldre benämning korgboll) är en lagidrott och bollsport.", 2, "Basket" }
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Kalle Anka");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Långben");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name", "TelephoneNumber" },
                values: new object[] { 3, "Musse Pigg", "070-1234567" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Person 1");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Person 2");
        }
    }
}
