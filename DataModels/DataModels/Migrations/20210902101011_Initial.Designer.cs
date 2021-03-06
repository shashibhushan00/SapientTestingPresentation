// <auto-generated />
using System;
using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataModels.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210902101011_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModels.api_configuration", b =>
                {
                    b.Property<int>("api_configuration_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("api_publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("scheduling_time")
                        .HasColumnType("datetime2");

                    b.HasKey("api_configuration_id");

                    b.ToTable("api_configurations");
                });

            modelBuilder.Entity("DataModels.api_endpoint", b =>
                {
                    b.Property<int>("api_endpoint_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apiEndpoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("api_publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("headers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("method_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parameters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("third_party_api_id")
                        .HasColumnType("int");

                    b.HasKey("api_endpoint_id");

                    b.HasIndex("third_party_api_id");

                    b.ToTable("api_endpoints");
                });

            modelBuilder.Entity("DataModels.api_endpoint", b =>
                {
                    b.HasOne("DataModels.api_configuration", "api_configuration")
                        .WithMany("api_endpoints")
                        .HasForeignKey("third_party_api_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("api_configuration");
                });

            modelBuilder.Entity("DataModels.api_configuration", b =>
                {
                    b.Navigation("api_endpoints");
                });
#pragma warning restore 612, 618
        }
    }
}
