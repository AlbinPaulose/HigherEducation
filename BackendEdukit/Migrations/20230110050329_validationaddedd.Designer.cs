// <auto-generated />
using BackendEdukit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendEdukit.Migrations
{
    [DbContext(typeof(DataContextClass))]
    [Migration("20230110050329_validationaddedd")]
    partial class validationaddedd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackendEdukit.Models.College", b =>
                {
                    b.Property<int>("ColgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColgId"), 1L, 1);

                    b.Property<string>("CollegeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Courseid")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("futureCourseid")
                        .HasColumnType("int");

                    b.HasKey("ColgId");

                    b.ToTable("tblcollege");
                });

            modelBuilder.Entity("BackendEdukit.Models.CollegeNew", b =>
                {
                    b.Property<int>("CollegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CollegeId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatsAvailable")
                        .HasColumnType("int");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CollegeId");

                    b.ToTable("tblcollegenew");
                });

            modelBuilder.Entity("BackendEdukit.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("tblcourse");
                });

            modelBuilder.Entity("BackendEdukit.Models.FututeCourse", b =>
                {
                    b.Property<int>("futureCourseid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("futureCourseid"), 1L, 1);

                    b.Property<int>("Courseid")
                        .HasColumnType("int");

                    b.Property<string>("futureCoursename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("futureCoursetype")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("futureCourseid");

                    b.ToTable("tblfuturecourse");
                });
#pragma warning restore 612, 618
        }
    }
}
