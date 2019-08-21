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

                    b.Property<string>("SchoolID");

                    b.Property<string>("ScientificName");

                    b.Property<int>("SurveyID");

                    b.Property<string>("Trophic");

                    b.HasKey("FishId");

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
                    b.Property<int>("SchoolsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommonName");

                    b.Property<double>("FishCount");

                    b.Property<int>("FishId");

                    b.Property<double>("FishLength");

                    b.HasKey("SchoolsID");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Reef.Model.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatchCode");

                    b.Property<int>("FishCount");

                    b.Property<int>("FishId");

                    b.Property<int>("LocationId");

                    b.Property<int>("SurveyIndex");

                    b.Property<int>("SurveyYear");

                    b.HasKey("SurveyId");

                    b.ToTable("Surveys");
                });
#pragma warning restore 612, 618
        }
    }
}
