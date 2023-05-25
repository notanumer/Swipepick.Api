﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Swipepick.Angular.DataAccess;

#nullable disable

namespace Swipepick.Angular.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("QuestionStudent", b =>
                {
                    b.Property<int>("QuestionsId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentsId")
                        .HasColumnType("integer");

                    b.HasKey("QuestionsId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("QuestionStudent");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CorrectAnswer")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId")
                        .IsUnique();

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.AnswerVariant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnswerId")
                        .HasColumnType("integer");

                    b.Property<string>("Variant")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.ToTable("AnswerVariant");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TestId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TestId")
                        .HasColumnType("integer");

                    b.Property<int>("TestResult")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.StudentAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentAnswers");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.StudentAnswerVariant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentAnswerId")
                        .HasColumnType("integer");

                    b.Property<int>("Variant")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StudentAnswerId");

                    b.ToTable("StudentAnswerVariant");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("RemovedAt")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UniqueCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("UpdatedAt")
                        .HasColumnType("date");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UniqueCode")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuestionStudent", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Swipepick.Angular.Domain.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Answer", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.Question", "Question")
                        .WithOne("Answer")
                        .HasForeignKey("Swipepick.Angular.Domain.Answer", "QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.AnswerVariant", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.Answer", "Answer")
                        .WithMany("AnswerVariants")
                        .HasForeignKey("AnswerId");

                    b.Navigation("Answer");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Question", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Student", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.Test", "Test")
                        .WithMany("Students")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Swipepick.Angular.Domain.User", "User")
                        .WithMany("Students")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.StudentAnswer", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.Student", "Student")
                        .WithOne("StudentAnswer")
                        .HasForeignKey("Swipepick.Angular.Domain.StudentAnswer", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.StudentAnswerVariant", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.StudentAnswer", "Answer")
                        .WithMany("Answers")
                        .HasForeignKey("StudentAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Test", b =>
                {
                    b.HasOne("Swipepick.Angular.Domain.User", "User")
                        .WithMany("Tests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Answer", b =>
                {
                    b.Navigation("AnswerVariants");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Question", b =>
                {
                    b.Navigation("Answer");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Student", b =>
                {
                    b.Navigation("StudentAnswer");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.StudentAnswer", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.Test", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Swipepick.Angular.Domain.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
