using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SinavOlusturma.Migrations
{
    public partial class QuestionAndExamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QBody = table.Column<string>(type: "TEXT", nullable: true),
                    RightAnswer = table.Column<string>(type: "TEXT", nullable: true),
                    ChoiceA = table.Column<string>(type: "TEXT", nullable: true),
                    ChoiceB = table.Column<string>(type: "TEXT", nullable: true),
                    ChoiceC = table.Column<string>(type: "TEXT", nullable: true),
                    ChoiceD = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticleTitle = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleContent = table.Column<string>(type: "TEXT", nullable: true),
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Exams_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_QuestionID",
                table: "Exams",
                column: "QuestionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
