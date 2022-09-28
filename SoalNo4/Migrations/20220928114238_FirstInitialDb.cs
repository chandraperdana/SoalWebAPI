using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoalNo4.Migrations
{
    public partial class FirstInitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { new Guid("172862ec-f69c-4be2-8e5f-e60bed9ff1ae"), "agus@gmail.com", "Agus", 12366678L, 3000000L },
                    { new Guid("48ec61b4-e38c-4442-bb5c-1eaddcff6bc4"), "rino@gmail.com", "Rino", 14444678L, 3200000L },
                    { new Guid("4b7843dd-4372-4b64-b487-5e33b0305862"), "Dodi@gmail.com", "Dodi", 12245678L, 4000000L },
                    { new Guid("51903878-fc9c-4412-8ec5-6247f0d2fe3b"), "ryan@gmail.com", "Ryan", 1111345678L, 7100000L },
                    { new Guid("5e63d57d-b744-4628-8c7c-c918b1e21e4f"), "chandra@gmail.com", "Chandra", 12345678L, 2000000L },
                    { new Guid("9749a740-c5d3-4e80-b2d4-accedd084124"), "aji@gmail.com", "Aji", 66665678L, 9000000L },
                    { new Guid("d3d7ac4c-fa2c-448c-8030-beee0ba297d8"), "taufik@gmail.com", "Taufik", 12345888L, 6000000L },
                    { new Guid("da509fee-a85c-4e3a-85a5-1a4cdce90d99"), "tyas@gmail.com", "Tyas", 15555678L, 2400000L },
                    { new Guid("f4e554a0-14a8-4013-9cd8-577f1430a70a"), "ani@gmail.com", "Ani", 18885678L, 3500000L },
                    { new Guid("feab6128-b8ce-478e-bd28-b0e7e3713547"), "retno@gmail.com", "Retno", 123433333L, 5000000L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
