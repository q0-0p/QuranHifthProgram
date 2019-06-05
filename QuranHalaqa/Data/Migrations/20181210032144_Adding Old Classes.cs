using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuranHalaqa.Data.Migrations
{
    public partial class AddingOldClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quranjuz",
                columns: table => new
                {
                    QuranJuzId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JuzName = table.Column<string>(nullable: true),
                    JuzNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quranjuz", x => x.QuranJuzId);
                });

            migrationBuilder.CreateTable(
                name: "Sheikh",
                columns: table => new
                {
                    SheikhId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SheikhFirstName = table.Column<string>(nullable: true),
                    SheikhLastName = table.Column<string>(nullable: true),
                    SheikhCellNumber = table.Column<string>(nullable: true),
                    SheikhHomeAddress = table.Column<string>(nullable: true),
                    SheikhEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sheikh", x => x.SheikhId);
                });

            migrationBuilder.CreateTable(
                name: "QuranSura",
                columns: table => new
                {
                    QuranSuraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SuraName = table.Column<string>(nullable: true),
                    SuraNumber = table.Column<string>(nullable: true),
                    NumberOfAyas = table.Column<int>(nullable: false),
                    QuranJuzId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuranSura", x => x.QuranSuraId);
                    table.ForeignKey(
                        name: "FK_QuranSura_Quranjuz_QuranJuzId",
                        column: x => x.QuranJuzId,
                        principalTable: "Quranjuz",
                        principalColumn: "QuranJuzId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Halaqa",
                columns: table => new
                {
                    HalaqaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SheikhId = table.Column<int>(nullable: false),
                    HalaqaName = table.Column<string>(nullable: true),
                    HalaqaStartDate = table.Column<DateTime>(nullable: false),
                    HalaqaEndDate = table.Column<DateTime>(nullable: true),
                    HalaqaStartTime = table.Column<string>(nullable: true),
                    HalaqaEndTime = table.Column<string>(nullable: true),
                    DaySaturday = table.Column<bool>(nullable: false),
                    DaySunday = table.Column<bool>(nullable: false),
                    DayMonday = table.Column<bool>(nullable: false),
                    DayTuesday = table.Column<bool>(nullable: false),
                    DayWednesday = table.Column<bool>(nullable: false),
                    DayThursday = table.Column<bool>(nullable: false),
                    DayFriday = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halaqa", x => x.HalaqaId);
                    table.ForeignKey(
                        name: "FK_Halaqa_Sheikh_SheikhId",
                        column: x => x.SheikhId,
                        principalTable: "Sheikh",
                        principalColumn: "SheikhId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HalaqaSession",
                columns: table => new
                {
                    HalaqaSessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HalaqaId = table.Column<int>(nullable: false),
                    HalaqaSessionDate = table.Column<DateTime>(nullable: false),
                    IsCanceled = table.Column<bool>(nullable: false),
                    ReasonCanceled = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HalaqaSession", x => x.HalaqaSessionId);
                    table.ForeignKey(
                        name: "FK_HalaqaSession_Halaqa_HalaqaId",
                        column: x => x.HalaqaId,
                        principalTable: "Halaqa",
                        principalColumn: "HalaqaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentNumber = table.Column<string>(nullable: true),
                    StudentFirstName = table.Column<string>(nullable: true),
                    StudentLastName = table.Column<string>(nullable: true),
                    ParentName = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    StudentStatus = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    HalaqaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Halaqa_HalaqaId",
                        column: x => x.HalaqaId,
                        principalTable: "Halaqa",
                        principalColumn: "HalaqaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    ContactFirstName = table.Column<string>(nullable: true),
                    ContactLastName = table.Column<string>(nullable: true),
                    RelationshipToStudents = table.Column<string>(nullable: true),
                    ContactPhone = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true),
                    ContactAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactsId);
                    table.ForeignKey(
                        name: "FK_Contacts_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ExamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    OverAllMistakes = table.Column<string>(nullable: true),
                    OverAllSelfies = table.Column<string>(nullable: true),
                    OverAllResult = table.Column<string>(nullable: true),
                    ExamLimitMistakes = table.Column<string>(nullable: true),
                    ExamLimitSelfies = table.Column<string>(nullable: true),
                    ExamOverAllComments = table.Column<string>(nullable: true),
                    QuranJuzId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exam_Quranjuz_QuranJuzId",
                        column: x => x.QuranJuzId,
                        principalTable: "Quranjuz",
                        principalColumn: "QuranJuzId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentWork",
                columns: table => new
                {
                    StudentWorkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HalaqaSessionId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    WorkDueDate = table.Column<string>(nullable: true),
                    AssignedWorkStatus = table.Column<string>(nullable: true),
                    AssignedWork = table.Column<string>(nullable: true),
                    NewWork = table.Column<string>(nullable: true),
                    RevisionStatus = table.Column<string>(nullable: true),
                    Revision = table.Column<string>(nullable: true),
                    NewRevision = table.Column<string>(nullable: true),
                    RevisionSelfies = table.Column<int>(nullable: false),
                    RevisionMistakes = table.Column<int>(nullable: false),
                    AssignedWorkSelfies = table.Column<int>(nullable: false),
                    AssignedWorkMistakes = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    IsPresent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentWork", x => x.StudentWorkId);
                    table.ForeignKey(
                        name: "FK_StudentWork_HalaqaSession_HalaqaSessionId",
                        column: x => x.HalaqaSessionId,
                        principalTable: "HalaqaSession",
                        principalColumn: "HalaqaSessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentWork_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamEntry",
                columns: table => new
                {
                    ExamEntryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamId = table.Column<int>(nullable: false),
                    SuraMistakes = table.Column<string>(nullable: true),
                    SuraSelfies = table.Column<string>(nullable: true),
                    SuraResult = table.Column<string>(nullable: true),
                    SuraComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamEntry", x => x.ExamEntryId);
                    table.ForeignKey(
                        name: "FK_ExamEntry_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_StudentId",
                table: "Contacts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_QuranJuzId",
                table: "Exam",
                column: "QuranJuzId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_StudentId",
                table: "Exam",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamEntry_ExamId",
                table: "ExamEntry",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Halaqa_SheikhId",
                table: "Halaqa",
                column: "SheikhId");

            migrationBuilder.CreateIndex(
                name: "IX_HalaqaSession_HalaqaId",
                table: "HalaqaSession",
                column: "HalaqaId");

            migrationBuilder.CreateIndex(
                name: "IX_QuranSura_QuranJuzId",
                table: "QuranSura",
                column: "QuranJuzId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_HalaqaId",
                table: "Student",
                column: "HalaqaId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentWork_HalaqaSessionId",
                table: "StudentWork",
                column: "HalaqaSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentWork_StudentId_HalaqaSessionId",
                table: "StudentWork",
                columns: new[] { "StudentId", "HalaqaSessionId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ExamEntry");

            migrationBuilder.DropTable(
                name: "QuranSura");

            migrationBuilder.DropTable(
                name: "StudentWork");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "HalaqaSession");

            migrationBuilder.DropTable(
                name: "Quranjuz");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Halaqa");

            migrationBuilder.DropTable(
                name: "Sheikh");
        }
    }
}
