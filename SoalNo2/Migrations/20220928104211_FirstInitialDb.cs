using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoalNo2.Migrations
{
    public partial class FirstInitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    Salary = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name", "Phone", "Salary" },
                values: new object[,]
                {
                    { 1, "chandra@gmail.com", "Chandra", 12345678L, 2000000L },
                    { 2, "Dodi@gmail.com", "Dodi", 12245678L, 4000000L },
                    { 3, "agus@gmail.com", "Agus", 12366678L, 3000000L },
                    { 4, "taufik@gmail.com", "Taufik", 12345888L, 6000000L },
                    { 5, "retno@gmail.com", "Retno", 123433333L, 5000000L },
                    { 6, "tyas@gmail.com", "Tyas", 15555678L, 2400000L },
                    { 7, "ryan@gmail.com", "Ryan", 1111345678L, 7100000L },
                    { 8, "rino@gmail.com", "Rino", 14444678L, 3200000L },
                    { 9, "aji@gmail.com", "Aji", 66665678L, 9000000L },
                    { 10, "ani@gmail.com", "Ani", 18885678L, 3500000L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
