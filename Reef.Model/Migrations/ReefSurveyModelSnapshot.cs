﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reef.Model;

namespace Reef.Model.Migrations
{
    [DbContext(typeof(ReefSurvey))]
    partial class ReefSurveyModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reef.Model.Fish", b =>
                {
                    b.Property<int>("FishId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommonName");

                    b.Property<string>("FamilyName");

                    b.Property<string>("ScientificName");

                    b.Property<int>("SurveyId");

                    b.Property<string>("Trophic");

                    b.HasKey("FishId");

                    b.HasIndex("SurveyId");

                    b.ToTable("Fish");
                });

            modelBuilder.Entity("Reef.Model.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Management");

                    b.Property<string>("RegionName");

                    b.Property<string>("StudyArea");

                    b.Property<string>("SubRegionName");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Reef.Model.Schools", b =>
                {
                    b.Property<int>("SchoolsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FishCount");

                    b.Property<int>("FishId");

                    b.Property<double>("FishLength");

                    b.HasKey("SchoolsId");

                    b.HasIndex("FishId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Reef.Model.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchCode");

                    b.Property<int>("LocationId");

                    b.Property<string>("SurveyDate");

                    b.Property<int>("SurveyIndex");

                    b.Property<string>("SurveyYear");

                    b.HasKey("SurveyId");

                    b.HasIndex("LocationId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Reef.Model.Fish", b =>
                {
                    b.HasOne("Reef.Model.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reef.Model.Schools", b =>
                {
                    b.HasOne("Reef.Model.Fish", "Fish")
                        .WithMany()
                        .HasForeignKey("FishId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reef.Model.Survey", b =>
                {
                    b.HasOne("Reef.Model.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
