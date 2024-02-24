﻿// <auto-generated />
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240127073549_FeatureError")]
    partial class FeatureError
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Security System"
                        },
                        new
                        {
                            Id = 2,
                            Name = "High-Speed Internet Connectivity"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Energy-Efficient Lighting"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Flexible Workspace"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Smart HVAC Systems"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Customizable Interior Layouts"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Green Spaces"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Meeting Rooms with Tech Infrastructure"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Accessibility Features"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Waste Management Systems"
                        });
                });

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Warsaw",
                            Country = "Poland"
                        },
                        new
                        {
                            Id = 2,
                            City = "Gdansk",
                            Country = "Poland"
                        });
                });

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.Premise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RoomsCount")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Premises");
                });

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.PremiseFeature", b =>
                {
                    b.Property<int>("PremiseId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.HasKey("PremiseId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("PremiseFeatures");
                });

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.Premise", b =>
                {
                    b.HasOne("BlazorApp.SharedLibrary.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.PremiseFeature", b =>
                {
                    b.HasOne("BlazorApp.SharedLibrary.Models.Feature", "Feature")
                        .WithMany("PremiseFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp.SharedLibrary.Models.Premise", "Premise")
                        .WithMany("PremiseFeatures")
                        .HasForeignKey("PremiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Premise");
                });

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.Feature", b =>
                {
                    b.Navigation("PremiseFeatures");
                });

            modelBuilder.Entity("BlazorApp.SharedLibrary.Models.Premise", b =>
                {
                    b.Navigation("PremiseFeatures");
                });
#pragma warning restore 612, 618
        }
    }
}
