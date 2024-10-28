using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanGallardo_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JGmodel1",
                columns: table => new
                {
                    JGmodel1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JGmodel1", x => x.JGmodel1ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JGmodel1");
        }
    }
}
