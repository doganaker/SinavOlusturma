﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SinavOlusturma.Models.ORM.Context;

namespace SinavOlusturma.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20210211123005_ExamTableUpdate")]
    partial class ExamTableUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SinavOlusturma.Models.ORM.Entities.Exam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArticleContent")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTitle")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionFourID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionOneID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionThreeID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionTwoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("QuestionFourID");

                    b.HasIndex("QuestionOneID");

                    b.HasIndex("QuestionThreeID");

                    b.HasIndex("QuestionTwoID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("SinavOlusturma.Models.ORM.Entities.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChoiceA")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChoiceB")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChoiceC")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChoiceD")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QBody")
                        .HasColumnType("TEXT");

                    b.Property<string>("RightAnswer")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("SinavOlusturma.Models.ORM.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SinavOlusturma.Models.ORM.Entities.Exam", b =>
                {
                    b.HasOne("SinavOlusturma.Models.ORM.Entities.Question", "QuestionFour")
                        .WithMany()
                        .HasForeignKey("QuestionFourID");

                    b.HasOne("SinavOlusturma.Models.ORM.Entities.Question", "QuestionOne")
                        .WithMany()
                        .HasForeignKey("QuestionOneID");

                    b.HasOne("SinavOlusturma.Models.ORM.Entities.Question", "QuestionThree")
                        .WithMany()
                        .HasForeignKey("QuestionThreeID");

                    b.HasOne("SinavOlusturma.Models.ORM.Entities.Question", "QuestiontWO")
                        .WithMany()
                        .HasForeignKey("QuestionTwoID");

                    b.Navigation("QuestionFour");

                    b.Navigation("QuestionOne");

                    b.Navigation("QuestionThree");

                    b.Navigation("QuestiontWO");
                });
#pragma warning restore 612, 618
        }
    }
}