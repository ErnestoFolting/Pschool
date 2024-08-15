using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PschoolBackend_DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "parentCouples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent1Id = table.Column<int>(type: "int", nullable: true),
                    Parent2Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parentCouples", x => x.Id);
                    table.CheckConstraint("CK_NotEqual_ParentIds", "[Parent1Id] <> [Parent2Id]");
                    table.ForeignKey(
                        name: "FK_parentCouples_parents_Parent1Id",
                        column: x => x.Parent1Id,
                        principalTable: "parents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_parentCouples_parents_Parent2Id",
                        column: x => x.Parent2Id,
                        principalTable: "parents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ParentCoupleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_parentCouples_ParentCoupleId",
                        column: x => x.ParentCoupleId,
                        principalTable: "parentCouples",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_parentCouples_Parent1Id",
                table: "parentCouples",
                column: "Parent1Id",
                unique: true,
                filter: "[Parent1Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_parentCouples_Parent2Id",
                table: "parentCouples",
                column: "Parent2Id",
                unique: true,
                filter: "[Parent2Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_students_ParentCoupleId",
                table: "students",
                column: "ParentCoupleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "parentCouples");

            migrationBuilder.DropTable(
                name: "parents");
        }
    }
}
