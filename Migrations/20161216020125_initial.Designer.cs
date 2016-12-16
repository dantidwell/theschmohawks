using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Schmohawks.Database;

namespace theschmohawks.Migrations
{
    [DbContext(typeof(SchmohawksDbContext))]
    [Migration("20161216020125_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("Schmohawks.Database.Gig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("StartTime");

                    b.Property<string>("Venue");

                    b.Property<string>("VenueCity");

                    b.Property<string>("VenueState");

                    b.HasKey("Id");

                    b.ToTable("Gigs");
                });
        }
    }
}
