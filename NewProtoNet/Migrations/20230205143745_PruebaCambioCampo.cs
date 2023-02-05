using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProtoNet.Migrations
{
    /// <inheritdoc />
    public partial class PruebaCambioCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "name");
        }
    }
}
