﻿// <auto-generated />
using System;
using DataModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataModels.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210902135055_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModels.Models.ApiConfiguration", b =>
                {
                    b.Property<int>("ApiConfigurationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApiPublisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SchedulingTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ApiConfigurationId");

                    b.ToTable("ApiConfigurations");
                });

            modelBuilder.Entity("DataModels.Models.ApiEndpoint", b =>
                {
                    b.Property<int>("ApiEndpointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApiEndpointUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApiPublisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parameters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThirdPartyApiId")
                        .HasColumnType("int");

                    b.HasKey("ApiEndpointId");

                    b.HasIndex("ThirdPartyApiId");

                    b.ToTable("ApiEndpoints");
                });

            modelBuilder.Entity("DataModels.Models.MarketQuote", b =>
                {
                    b.Property<int>("MarketQuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ForwardPE")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumberOfShares")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceToSales")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("QuoteType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RegularMarketChange")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RegularMarketChangePercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RegularMarketDayHigh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RegularMarketDayLow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RegularMarketOpen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("RegularMarketVolume")
                        .HasColumnType("bigint");

                    b.Property<int>("SymbolId")
                        .HasColumnType("int");

                    b.Property<bool>("Tradable")
                        .HasColumnType("bit");

                    b.Property<decimal>("TrailingPE")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MarketQuoteId");

                    b.HasIndex("SymbolId");

                    b.ToTable("MarketQuotes");
                });

            modelBuilder.Entity("DataModels.Models.Symbol", b =>
                {
                    b.Property<int>("SymbolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymbolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThirdPartyApiId")
                        .HasColumnType("int");

                    b.HasKey("SymbolId");

                    b.HasIndex("ThirdPartyApiId");

                    b.ToTable("Symbols");
                });

            modelBuilder.Entity("DataModels.Models.User", b =>
                {
                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("UserRole")
                        .HasColumnType("bit");

                    b.HasKey("EmailId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataModels.Models.UserGridView", b =>
                {
                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GridViewEncoding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GridViewName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailId");

                    b.ToTable("UserGridViews");
                });

            modelBuilder.Entity("DataModels.Models.ApiEndpoint", b =>
                {
                    b.HasOne("DataModels.Models.ApiConfiguration", "ApiConfigurations")
                        .WithMany("ApiEndpoints")
                        .HasForeignKey("ThirdPartyApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiConfigurations");
                });

            modelBuilder.Entity("DataModels.Models.MarketQuote", b =>
                {
                    b.HasOne("DataModels.Models.Symbol", "Symbols")
                        .WithMany("MarketQuotes")
                        .HasForeignKey("SymbolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Symbols");
                });

            modelBuilder.Entity("DataModels.Models.Symbol", b =>
                {
                    b.HasOne("DataModels.Models.ApiConfiguration", "ApiConfigurations")
                        .WithMany("Symbols")
                        .HasForeignKey("ThirdPartyApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiConfigurations");
                });

            modelBuilder.Entity("DataModels.Models.UserGridView", b =>
                {
                    b.HasOne("DataModels.Models.User", "Users")
                        .WithMany("UserGridViews")
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataModels.Models.ApiConfiguration", b =>
                {
                    b.Navigation("ApiEndpoints");

                    b.Navigation("Symbols");
                });

            modelBuilder.Entity("DataModels.Models.Symbol", b =>
                {
                    b.Navigation("MarketQuotes");
                });

            modelBuilder.Entity("DataModels.Models.User", b =>
                {
                    b.Navigation("UserGridViews");
                });
#pragma warning restore 612, 618
        }
    }
}
