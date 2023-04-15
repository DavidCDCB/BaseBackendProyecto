using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestServer.Migrations
{
    public partial class Datos_falsos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, "Antonio.Aguilera93@gmail.com", "Antonio Aguilera", 7603L },
                    { 2, "Carmen.Kanaria@yahoo.com", "Carmen Kanaria", 2625L },
                    { 3, "Gregorio84@nearbpo.com", "Gregorio Aponte", 8483L },
                    { 4, "XimenaGuadalupe.Garay4@hotmail.com", "Ximena Guadalupe Garay", 5013L },
                    { 5, "Esteban.Altamirano@gmail.com", "Esteban Altamirano", 1826L },
                    { 6, "Santiago49@nearbpo.com", "Santiago Murillo", 9930L },
                    { 7, "Rosario_Cerda@hotmail.com", "Rosario Cerda", 4154L },
                    { 8, "Raquel45@hotmail.com", "Raquel Lugo", 3740L },
                    { 9, "Gonzalo.Vera8@corpfolder.com", "Gonzalo Vera", 4013L },
                    { 10, "DulceMaria39@gmail.com", "Dulce María Canales", 8561L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
