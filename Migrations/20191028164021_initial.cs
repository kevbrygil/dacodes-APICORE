using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace dacodes_APICORE.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Mandatory_courses = table.Column<Guid[]>(nullable: true),
                    Mandatory_courses_code = table.Column<string[]>(nullable: true),
                    Credits = table.Column<int>(nullable: false),
                    Created_by = table.Column<Guid>(nullable: false),
                    Updated_by = table.Column<Guid>(nullable: false),
                    Approval_score = table.Column<float>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Question_details = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hours = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    CourseFK = table.Column<Guid>(nullable: true),
                    Created_by = table.Column<Guid>(nullable: false),
                    Updated_by = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Aproval_score = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Courses_CourseFK",
                        column: x => x.CourseFK,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    Cellphone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    RoleFK = table.Column<Guid>(nullable: true),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true),
                    CourseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleFK",
                        column: x => x.RoleFK,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    LessonFK = table.Column<Guid>(nullable: true),
                    Type_question = table.Column<string>(nullable: true),
                    Created_by = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Answers = table.Column<string[]>(nullable: true),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Lessons_LessonFK",
                        column: x => x.LessonFK,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserFK = table.Column<Guid>(nullable: true),
                    Access_token = table.Column<string>(nullable: true),
                    Refresh_token = table.Column<string>(nullable: true),
                    Access_token_expires_at = table.Column<long>(nullable: false),
                    Issued_at = table.Column<long>(nullable: false),
                    Refresh_token_expires_in = table.Column<long>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_Users_UserFK",
                        column: x => x.UserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Choices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    QuestionFK = table.Column<Guid>(nullable: true),
                    Is_correct = table.Column<bool>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true),
                    QuestionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Choices_Lessons_QuestionFK",
                        column: x => x.QuestionFK,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Choices_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserFK = table.Column<Guid>(nullable: true),
                    CourseFK = table.Column<Guid>(nullable: true),
                    Lesson_scoreFK = table.Column<Guid>(nullable: true),
                    Date_of_enrollment = table.Column<DateTime>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    Date_of_completation = table.Column<DateTime>(nullable: false),
                    Total_score = table.Column<float>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseFK",
                        column: x => x.CourseFK,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_Users_UserFK",
                        column: x => x.UserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lesson_scores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EnrollmentFK = table.Column<Guid>(nullable: true),
                    LessonFK = table.Column<Guid>(nullable: true),
                    Lesson_result = table.Column<float>(nullable: false),
                    Successful_answers = table.Column<int>(nullable: false),
                    Unsuccessful_answers = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson_scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_scores_Enrollments_EnrollmentFK",
                        column: x => x.EnrollmentFK,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_scores_Lessons_LessonFK",
                        column: x => x.LessonFK,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Choices_QuestionFK",
                table: "Choices",
                column: "QuestionFK");

            migrationBuilder.CreateIndex(
                name: "IX_Choices_QuestionId",
                table: "Choices",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Code",
                table: "Courses",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name",
                table: "Courses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseFK",
                table: "Enrollments",
                column: "CourseFK");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_Lesson_scoreFK",
                table: "Enrollments",
                column: "Lesson_scoreFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_UserFK",
                table: "Enrollments",
                column: "UserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_scores_EnrollmentFK",
                table: "Lesson_scores",
                column: "EnrollmentFK");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_scores_LessonFK",
                table: "Lesson_scores",
                column: "LessonFK");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseFK",
                table: "Lessons",
                column: "CourseFK");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_LessonFK",
                table: "Questions",
                column: "LessonFK");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserFK",
                table: "Tokens",
                column: "UserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseId",
                table: "Users",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleFK",
                table: "Users",
                column: "RoleFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lesson_scores_Lesson_scoreFK",
                table: "Enrollments",
                column: "Lesson_scoreFK",
                principalTable: "Lesson_scores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_scores_Lessons_LessonFK",
                table: "Lesson_scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_CourseId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lesson_scores_Lesson_scoreFK",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Lesson_scores");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
