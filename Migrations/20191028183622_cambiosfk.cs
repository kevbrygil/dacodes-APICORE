using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dacodes_APICORE.Migrations
{
    public partial class cambiosfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Lessons_QuestionFK",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lesson_scores_Lesson_scoreFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Users_UserFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_scores_Enrollments_EnrollmentFK",
                table: "Lesson_scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_scores_Lessons_LessonFK",
                table: "Lesson_scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseFK",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Lessons_LessonFK",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Users_UserFK",
                table: "Tokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleFK",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleFK",
                table: "Users",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserFK",
                table: "Tokens",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LessonFK",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseFK",
                table: "Lessons",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LessonFK",
                table: "Lesson_scores",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EnrollmentFK",
                table: "Lesson_scores",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserFK",
                table: "Enrollments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Lesson_scoreFK",
                table: "Enrollments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseFK",
                table: "Enrollments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "QuestionFK",
                table: "Choices",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Lessons_QuestionFK",
                table: "Choices",
                column: "QuestionFK",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseFK",
                table: "Enrollments",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lesson_scores_Lesson_scoreFK",
                table: "Enrollments",
                column: "Lesson_scoreFK",
                principalTable: "Lesson_scores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Users_UserFK",
                table: "Enrollments",
                column: "UserFK",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_scores_Enrollments_EnrollmentFK",
                table: "Lesson_scores",
                column: "EnrollmentFK",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_scores_Lessons_LessonFK",
                table: "Lesson_scores",
                column: "LessonFK",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseFK",
                table: "Lessons",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Lessons_LessonFK",
                table: "Questions",
                column: "LessonFK",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Users_UserFK",
                table: "Tokens",
                column: "UserFK",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleFK",
                table: "Users",
                column: "RoleFK",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Lessons_QuestionFK",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lesson_scores_Lesson_scoreFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Users_UserFK",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_scores_Enrollments_EnrollmentFK",
                table: "Lesson_scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_scores_Lessons_LessonFK",
                table: "Lesson_scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseFK",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Lessons_LessonFK",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Users_UserFK",
                table: "Tokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleFK",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleFK",
                table: "Users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserFK",
                table: "Tokens",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "LessonFK",
                table: "Questions",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseFK",
                table: "Lessons",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "LessonFK",
                table: "Lesson_scores",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "EnrollmentFK",
                table: "Lesson_scores",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserFK",
                table: "Enrollments",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "Lesson_scoreFK",
                table: "Enrollments",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseFK",
                table: "Enrollments",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "QuestionFK",
                table: "Choices",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Lessons_QuestionFK",
                table: "Choices",
                column: "QuestionFK",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseFK",
                table: "Enrollments",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lesson_scores_Lesson_scoreFK",
                table: "Enrollments",
                column: "Lesson_scoreFK",
                principalTable: "Lesson_scores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Users_UserFK",
                table: "Enrollments",
                column: "UserFK",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_scores_Enrollments_EnrollmentFK",
                table: "Lesson_scores",
                column: "EnrollmentFK",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_scores_Lessons_LessonFK",
                table: "Lesson_scores",
                column: "LessonFK",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseFK",
                table: "Lessons",
                column: "CourseFK",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Lessons_LessonFK",
                table: "Questions",
                column: "LessonFK",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Users_UserFK",
                table: "Tokens",
                column: "UserFK",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleFK",
                table: "Users",
                column: "RoleFK",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
