﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(JardineriaContext))]
    partial class JardineriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Boss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Cellphone")
                        .HasColumnType("int")
                        .HasColumnName("cellphone");

                    b.Property<int?>("DentificationArd")
                        .HasColumnType("int")
                        .HasColumnName("dentification_ard");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("boss", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdStateFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdStateFk" }, "Fk_IdState");

                    b.ToTable("city", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("client_code");

                    b.Property<string>("ClientName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("client_name");

                    b.Property<decimal>("CreditLimit")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("credit_limit");

                    b.Property<int>("IdContactFk")
                        .HasColumnType("int")
                        .HasColumnName("IdContactFK");

                    b.Property<int>("IdEmployeeFk")
                        .HasColumnType("int")
                        .HasColumnName("IdEmployeeFK");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdContactFk" }, "FK_Contact");

                    b.HasIndex(new[] { "IdEmployeeFk" }, "FK_Employee_FK");

                    b.ToTable("client", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ContactLastName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("contact_last_name");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("contact_name");

                    b.Property<string>("ContactNumbrer")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("contact_numbrer");

                    b.Property<string>("Fax")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("fax");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("contact", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("employee_code");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Extension")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("extension");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<int>("IdBossFk")
                        .HasColumnType("int");

                    b.Property<string>("LastName1")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name1");

                    b.Property<string>("LastName2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name2");

                    b.Property<string>("OfficeCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("office_code");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("position");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdBossFk" }, "Fk_IdBossFk");

                    b.HasIndex(new[] { "OfficeCode" }, "Fk_OfficeCodeFk");

                    b.ToTable("employee", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.LocationClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bis")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("bis")
                        .IsFixedLength();

                    b.Property<string>("Cardinal")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinal")
                        .IsFixedLength();

                    b.Property<string>("CardinalSec")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinalSec")
                        .IsFixedLength();

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<int>("IdCityFk")
                        .HasColumnType("int")
                        .HasColumnName("idCityFk");

                    b.Property<int>("IdClientFk")
                        .HasColumnType("int")
                        .HasColumnName("idClientFk");

                    b.Property<string>("Letra")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letra")
                        .IsFixedLength();

                    b.Property<string>("Letrasec")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letrasec")
                        .IsFixedLength();

                    b.Property<string>("Letrater")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letrater")
                        .IsFixedLength();

                    b.Property<short>("NumeroPri")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroPri");

                    b.Property<short>("NumeroSec")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroSec");

                    b.Property<short>("NumeroTer")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroTer");

                    b.Property<string>("PostCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TipoDeVia")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipoDeVia");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClientFk" }, "Fk1_idClientFk");

                    b.HasIndex(new[] { "IdCityFk" }, "Fk2_idCityFk");

                    b.ToTable("location_customer", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.LocationOffice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bis")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("bis")
                        .IsFixedLength();

                    b.Property<string>("Cardinal")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinal")
                        .IsFixedLength();

                    b.Property<string>("CardinalSec")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinalSec")
                        .IsFixedLength();

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<int>("IdCityFk")
                        .HasColumnType("int")
                        .HasColumnName("idCityFk");

                    b.Property<string>("Letra")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letra")
                        .IsFixedLength();

                    b.Property<string>("Letrasec")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letrasec")
                        .IsFixedLength();

                    b.Property<string>("Letrater")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letrater")
                        .IsFixedLength();

                    b.Property<short>("NumeroPri")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroPri");

                    b.Property<short>("NumeroSec")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroSec");

                    b.Property<short>("NumeroTer")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroTer");

                    b.Property<string>("PostCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TipoDeVia")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipoDeVia");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCityFk" }, "Fk1_idCityFk");

                    b.ToTable("location_office", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Office", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("office_code");

                    b.Property<int>("LocationOfficeFk")
                        .HasColumnType("int")
                        .HasColumnName("location_office_FK");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "LocationOfficeFk" }, "fk_office_location_customer_copy11_idx");

                    b.ToTable("office", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("order_code");

                    b.Property<int>("ClientCode")
                        .HasColumnType("int")
                        .HasColumnName("client_code");

                    b.Property<string>("Comments")
                        .HasColumnType("text")
                        .HasColumnName("comments");

                    b.Property<DateOnly?>("DeliveryDate")
                        .HasColumnType("date")
                        .HasColumnName("delivery_date");

                    b.Property<DateOnly>("ExpectedDate")
                        .HasColumnType("date")
                        .HasColumnName("expected_date");

                    b.Property<DateOnly>("OrderDate")
                        .HasColumnType("date")
                        .HasColumnName("order_date");

                    b.Property<string>("Status")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ClientCode" }, "Fk_client_code");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("order_code");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("product_code");

                    b.Property<short>("LineNumber")
                        .HasColumnType("smallint")
                        .HasColumnName("line_number");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("unit_price");

                    b.HasKey("Id", "ProductCode")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "ProductCode" }, "Fk2_product_code");

                    b.ToTable("order_detail", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ClientCode")
                        .HasColumnType("int")
                        .HasColumnName("client_code");

                    b.Property<DateOnly>("PaymentDate")
                        .HasColumnType("date")
                        .HasColumnName("payment_date");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("payment_method");

                    b.Property<decimal>("Total")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("total");

                    b.Property<string>("TransactionId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("transaction_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ClientCode" }, "Fk_cliente_code");

                    b.ToTable("payment", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Dimensions")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("dimensions");

                    b.Property<int>("IdProviderFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("name");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("product_code");

                    b.Property<string>("ProductLine")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("product_line");

                    b.Property<decimal>("SellingPrice")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("selling_price");

                    b.Property<short>("StockQuantity")
                        .HasColumnType("smallint")
                        .HasColumnName("stock_quantity");

                    b.Property<string>("Supplier")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("supplier");

                    b.Property<decimal>("SupplierPrice")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("supplier_price");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdProviderFk" }, "Fk_IdproviderFk");

                    b.HasIndex(new[] { "ProductLine" }, "Fk_product_line");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProductLine", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("product_line");

                    b.Property<string>("DescriptionHtml")
                        .HasColumnType("text")
                        .HasColumnName("description_html");

                    b.Property<string>("DescriptionText")
                        .HasColumnType("text")
                        .HasColumnName("description_text");

                    b.Property<string>("Image")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("image");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("product_line", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Cellphone")
                        .HasColumnType("int")
                        .HasColumnName("cellphone");

                    b.Property<int>("DentificationArd")
                        .HasColumnType("int")
                        .HasColumnName("dentification_ard");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("provider", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdCountryFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdCountryFk" }, "Fk_IdCountry");

                    b.ToTable("state", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Password");

                    b.Property<string>("email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Email");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.HasOne("Domain.Entities.State", "IdStateFkNavigation")
                        .WithMany("Cities")
                        .HasForeignKey("IdStateFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk_IdState");

                    b.Navigation("IdStateFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.HasOne("Domain.Entities.Contact", "IdContactFkNavigation")
                        .WithMany("Clients")
                        .HasForeignKey("IdContactFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Contact");

                    b.HasOne("Domain.Entities.Employee", "IdEmployeeFkNavigation")
                        .WithMany("Clients")
                        .HasForeignKey("IdEmployeeFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Employee_FK");

                    b.Navigation("IdContactFkNavigation");

                    b.Navigation("IdEmployeeFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.HasOne("Domain.Entities.Boss", "IdBossFkNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("IdBossFk")
                        .IsRequired()
                        .HasConstraintName("Fk_IdBossFk");

                    b.HasOne("Domain.Entities.Office", "OfficeCodeNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeCode")
                        .HasConstraintName("Fk_OfficeCodeFk");

                    b.Navigation("IdBossFkNavigation");

                    b.Navigation("OfficeCodeNavigation");
                });

            modelBuilder.Entity("Domain.Entities.LocationClient", b =>
                {
                    b.HasOne("Domain.Entities.City", "IdCityFkNavigation")
                        .WithMany("LocationClients")
                        .HasForeignKey("IdCityFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk2_idCityFk");

                    b.HasOne("Domain.Entities.Client", "IdClientFkNavigation")
                        .WithMany("LocationClients")
                        .HasForeignKey("IdClientFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk1_idClientFk");

                    b.Navigation("IdCityFkNavigation");

                    b.Navigation("IdClientFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.LocationOffice", b =>
                {
                    b.HasOne("Domain.Entities.City", "IdCityFkNavigation")
                        .WithMany("LocationOffices")
                        .HasForeignKey("IdCityFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk1_idCityFk");

                    b.Navigation("IdCityFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Office", b =>
                {
                    b.HasOne("Domain.Entities.LocationOffice", "LocationOfficeFkNavigation")
                        .WithMany("Offices")
                        .HasForeignKey("LocationOfficeFk")
                        .IsRequired()
                        .HasConstraintName("fk_office_location_customer_copy11");

                    b.Navigation("LocationOfficeFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.HasOne("Domain.Entities.Client", "ClientCodeNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("ClientCode")
                        .IsRequired()
                        .HasConstraintName("Fk_client_code");

                    b.Navigation("ClientCodeNavigation");
                });

            modelBuilder.Entity("Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("Domain.Entities.Order", "OrderCodeNavigation")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Id")
                        .IsRequired()
                        .HasConstraintName("Fk1_order_code");

                    b.HasOne("Domain.Entities.Product", "ProductCodeNavigation")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductCode")
                        .IsRequired()
                        .HasConstraintName("Fk2_product_code");

                    b.Navigation("OrderCodeNavigation");

                    b.Navigation("ProductCodeNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.HasOne("Domain.Entities.Client", "ClientCodeNavigation")
                        .WithMany("Payments")
                        .HasForeignKey("ClientCode")
                        .IsRequired()
                        .HasConstraintName("Fk_cliente_code");

                    b.Navigation("ClientCodeNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Proveedor", "IdProviderFkNavigation")
                        .WithMany("Products")
                        .HasForeignKey("IdProviderFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk_IdproviderFk");

                    b.HasOne("Domain.Entities.ProductLine", "ProductLineNavigation")
                        .WithMany("Products")
                        .HasForeignKey("ProductLine")
                        .HasConstraintName("Fk_product_line");

                    b.Navigation("IdProviderFkNavigation");

                    b.Navigation("ProductLineNavigation");
                });

            modelBuilder.Entity("Domain.Entities.State", b =>
                {
                    b.HasOne("Domain.Entities.Country", "IdCountryFkNavigation")
                        .WithMany("States")
                        .HasForeignKey("IdCountryFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk_IdCountry");

                    b.Navigation("IdCountryFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Boss", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Navigation("LocationClients");

                    b.Navigation("LocationOffices");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Navigation("LocationClients");

                    b.Navigation("Orders");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("Domain.Entities.LocationOffice", b =>
                {
                    b.Navigation("Offices");
                });

            modelBuilder.Entity("Domain.Entities.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Domain.Entities.ProductLine", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}