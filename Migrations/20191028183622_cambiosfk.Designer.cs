﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dacodes_APICORE.Models;

namespace dacodes_APICORE.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20191028183622_cambiosfk")]
    partial class cambiosfk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("dacodes_APICORE.Models.Choice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Is_correct")
                        .HasColumnType("boolean");

                    b.Property<Guid>("QuestionFK")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("QuestionId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("QuestionFK");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<float>("Approval_score")
                        .HasColumnType("real");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Created_by")
                        .HasColumnType("uuid");

                    b.Property<int>("Credits")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid[]>("Mandatory_courses")
                        .HasColumnType("uuid[]");

                    b.Property<string[]>("Mandatory_courses_code")
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Updated_by")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid>("CourseFK")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Date_of_completation")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Date_of_enrollment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("Lesson_scoreFK")
                        .HasColumnType("uuid");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<float>("Total_score")
                        .HasColumnType("real");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("UserFK")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CourseFK");

                    b.HasIndex("Lesson_scoreFK")
                        .IsUnique();

                    b.HasIndex("UserFK");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("Aproval_score")
                        .HasColumnType("integer");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<Guid>("CourseFK")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Created_by")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Hours")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Question_details")
                        .HasColumnType("text");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Updated_by")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CourseFK");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Lesson_score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("EnrollmentFK")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LessonFK")
                        .HasColumnType("uuid");

                    b.Property<float>("Lesson_result")
                        .HasColumnType("real");

                    b.Property<int>("Successful_answers")
                        .HasColumnType("integer");

                    b.Property<int>("Unsuccessful_answers")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentFK");

                    b.HasIndex("LessonFK");

                    b.ToTable("Lesson_scores");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string[]>("Answers")
                        .HasColumnType("text[]");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Created_by")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid>("LessonFK")
                        .HasColumnType("uuid");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<string>("Type_question")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("LessonFK");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Token", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Access_token")
                        .HasColumnType("text");

                    b.Property<long>("Access_token_expires_at")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("Issued_at")
                        .HasColumnType("bigint");

                    b.Property<string>("Refresh_token")
                        .HasColumnType("text");

                    b.Property<long>("Refresh_token_expires_in")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UserFK")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserFK");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Cellphone")
                        .HasColumnType("text");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RoleFK")
                        .HasColumnType("uuid");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleFK");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Choice", b =>
                {
                    b.HasOne("dacodes_APICORE.Models.Lesson", "Questions")
                        .WithMany()
                        .HasForeignKey("QuestionFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dacodes_APICORE.Models.Question", null)
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Enrollment", b =>
                {
                    b.HasOne("dacodes_APICORE.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dacodes_APICORE.Models.Lesson_score", "Lesson_Score")
                        .WithOne()
                        .HasForeignKey("dacodes_APICORE.Models.Enrollment", "Lesson_scoreFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dacodes_APICORE.Models.User", "User")
                        .WithMany("Enrollments")
                        .HasForeignKey("UserFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Lesson", b =>
                {
                    b.HasOne("dacodes_APICORE.Models.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Lesson_score", b =>
                {
                    b.HasOne("dacodes_APICORE.Models.Enrollment", "Enrollment")
                        .WithMany()
                        .HasForeignKey("EnrollmentFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dacodes_APICORE.Models.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Question", b =>
                {
                    b.HasOne("dacodes_APICORE.Models.Lesson", "Lessons")
                        .WithMany("Questions")
                        .HasForeignKey("LessonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dacodes_APICORE.Models.Token", b =>
                {
                    b.HasOne("dacodes_APICORE.Models.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dacodes_APICORE.Models.User", b =>
                {
                    b.HasOne("dacodes_APICORE.Models.Course", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseId");

                    b.HasOne("dacodes_APICORE.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}