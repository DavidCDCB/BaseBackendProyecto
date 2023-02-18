using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProtoNet.Migrations
{
    public partial class DatosFake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, "Melvin.Schaden@hotmail.com", "Melvin Schaden", 1852L },
                    { 2, "Taylor_Hansen@hotmail.com", "Taylor Hansen", 2534L },
                    { 3, "Sylvia.Boyer31@hotmail.com", "Sylvia Boyer", 7622L },
                    { 4, "Leah.Hagenes@gmail.com", "Leah Hagenes", 7955L },
                    { 5, "Pablo.Mayert53@hotmail.com", "Pablo Mayert", 906L },
                    { 6, "Ronnie.Ward@gmail.com", "Ronnie Ward", 8791L },
                    { 7, "Erin_Ortiz15@hotmail.com", "Erin Ortiz", 3342L },
                    { 8, "Eula_Kessler41@gmail.com", "Eula Kessler", 197L },
                    { 9, "Edwin.Cummerata14@hotmail.com", "Edwin Cummerata", 5177L },
                    { 10, "Ramon.Keeling@gmail.com", "Ramon Keeling", 7522L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
