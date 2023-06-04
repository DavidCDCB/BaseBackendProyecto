using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestServer.Migrations
{
    public partial class databasefullv9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "payrolls",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    star_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    accruals = table.Column<double>(type: "double", nullable: false),
                    deductions = table.Column<double>(type: "double", nullable: false),
                    settlement = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payrolls", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    brand = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    saleprice = table.Column<float>(type: "float", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "reports",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reports", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<double>(type: "double", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nit = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "purchases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchaseprice = table.Column<float>(type: "float", nullable: false),
                    saleprice = table.Column<float>(type: "float", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    datepurchase = table.Column<DateOnly>(type: "date", nullable: false),
                    productid = table.Column<int>(type: "int", nullable: true),
                    supplierid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.id);
                    table.ForeignKey(
                        name: "FK_purchases_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_purchases_suppliers_supplierid",
                        column: x => x.supplierid,
                        principalTable: "suppliers",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "administrators",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrators", x => x.id);
                    table.ForeignKey(
                        name: "FK_administrators_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                    table.ForeignKey(
                        name: "FK_clients_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mechanics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    commission = table.Column<double>(type: "double", nullable: false),
                    salary = table.Column<double>(type: "double", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mechanics", x => x.id);
                    table.ForeignKey(
                        name: "FK_mechanics_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "recepcionists",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    salary = table.Column<float>(type: "float", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recepcionists", x => x.id);
                    table.ForeignKey(
                        name: "FK_recepcionists_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "requests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false),
                    state = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_id = table.Column<int>(type: "int", nullable: true),
                    service_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_requests", x => x.id);
                    table.ForeignKey(
                        name: "FK_requests_clients_client_id",
                        column: x => x.client_id,
                        principalTable: "clients",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_requests_services_service_id",
                        column: x => x.service_id,
                        principalTable: "services",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    plate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    year = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.id);
                    table.ForeignKey(
                        name: "FK_vehicles_clients_client_id",
                        column: x => x.client_id,
                        principalTable: "clients",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PayrollMechanic",
                columns: table => new
                {
                    MechanicsId = table.Column<int>(type: "int", nullable: false),
                    PayrollsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollMechanic", x => new { x.MechanicsId, x.PayrollsId });
                    table.ForeignKey(
                        name: "FK_PayrollMechanic_mechanics_MechanicsId",
                        column: x => x.MechanicsId,
                        principalTable: "mechanics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayrollMechanic_payrolls_PayrollsId",
                        column: x => x.PayrollsId,
                        principalTable: "payrolls",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inconvenients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date_act = table.Column<DateOnly>(type: "date", nullable: false),
                    state = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    days_delay = table.Column<int>(type: "int", nullable: false),
                    service_request_id = table.Column<int>(type: "int", nullable: false),
                    seen = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    request_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inconvenients", x => x.id);
                    table.ForeignKey(
                        name: "FK_inconvenients_requests_request_id",
                        column: x => x.request_id,
                        principalTable: "requests",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductRequest",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    RequestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRequest", x => new { x.ProductsId, x.RequestsId });
                    table.ForeignKey(
                        name: "FK_ProductRequest_products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRequest_requests_RequestsId",
                        column: x => x.RequestsId,
                        principalTable: "requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RequestMechanic",
                columns: table => new
                {
                    MechanicsId = table.Column<int>(type: "int", nullable: false),
                    RequestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMechanic", x => new { x.MechanicsId, x.RequestsId });
                    table.ForeignKey(
                        name: "FK_RequestMechanic_mechanics_MechanicsId",
                        column: x => x.MechanicsId,
                        principalTable: "mechanics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestMechanic_requests_RequestsId",
                        column: x => x.RequestsId,
                        principalTable: "requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "administrators",
                columns: new[] { "id", "name", "phone", "surname", "userid" },
                values: new object[,]
                {
                    { 1, "Melissa", "592.666.807", "Ulloa", null },
                    { 2, "Pedro", "518.287.754", "Alanis", null },
                    { 3, "Mariana", "5935-468-567", "Fajardo", null },
                    { 4, "Miranda", "530.534.465", "Alarcón", null },
                    { 5, "Hugo", "522 527 135", "Frías", null },
                    { 6, "Emilio", "529510515", "Vaca", null },
                    { 7, "María de Jesús", "554077748", "Valenzuela", null },
                    { 8, "Abraham", "532.299.849", "Chávez", null },
                    { 9, "Matías", "508925872", "Ocasio", null },
                    { 10, "Ana Victoria", "527694895", "Angulo", null },
                    { 11, "Hugo", "510 315 481", "Yáñez", null },
                    { 12, "Benito", "5166-325-265", "González", null },
                    { 13, "César", "552932340", "Mondragón", null },
                    { 14, "Norma", "525.901.712", "Zamora", null },
                    { 15, "Julia", "548 355 271", "Guerra", null },
                    { 16, "Ana", "569819905", "Farías", null },
                    { 17, "María Teresa", "577 234 385", "de Jesús", null },
                    { 18, "José María", "560057222", "Roybal", null },
                    { 19, "Gregorio", "5790-436-868", "Huerta", null },
                    { 20, "Alejandra", "5143-794-999", "Serna", null },
                    { 21, "Alejandro", "557 930 537", "Laureano", null },
                    { 22, "Natalia", "5376-079-512", "Mascareñas", null },
                    { 23, "Antonio", "536.264.591", "Burgos", null },
                    { 24, "Concepción", "561364823", "Cerda", null },
                    { 25, "María Teresa", "587 518 469", "Mayorga", null },
                    { 26, "Paulina", "576335006", "Valverde", null },
                    { 27, "Araceli", "559306650", "Montes", null },
                    { 28, "Laura", "570776370", "Ulibarri", null },
                    { 29, "Nicole", "536.053.372", "Olivárez", null },
                    { 30, "Marcela", "525115785", "Zamarreno", null },
                    { 31, "Aarón", "596935277", "Rodríquez", null },
                    { 32, "Andrés", "571 087 536", "Hernádez", null },
                    { 33, "Jose Daniel", "581 003 527", "Hernandes", null },
                    { 34, "Maricarmen", "501486738", "Puente", null },
                    { 35, "José", "5540-867-735", "Santiago", null },
                    { 36, "Jesús", "559 827 722", "Beltrán", null },
                    { 37, "Ximena Guadalupe", "572269436", "Bonilla", null },
                    { 38, "Inés", "587272872", "Banda", null },
                    { 39, "Emmanuel", "569414390", "Paz", null },
                    { 40, "Camila", "537.063.412", "Balderas", null },
                    { 41, "Nicole", "506 211 001", "Armenta", null },
                    { 42, "Andrea", "571 214 531", "Murillo", null },
                    { 43, "Sofia", "547.169.551", "Delapaz", null },
                    { 44, "Micaela", "548685962", "Santana", null },
                    { 45, "Miguel", "596 456 152", "Delapaz", null },
                    { 46, "Emilio", "5970-618-357", "Casárez", null },
                    { 47, "Tadeo", "534 596 284", "Linares", null },
                    { 48, "Sofia", "598 874 855", "Yami", null },
                    { 49, "Emilio", "595 465 636", "Barraza", null },
                    { 50, "Manuel", "5861-007-709", "Muñiz", null },
                    { 51, "Ramiro", "582159005", "Maestas", null },
                    { 52, "Ana Luisa", "535.025.409", "Ávalos", null },
                    { 53, "Ana", "584.093.259", "Luevano", null },
                    { 54, "Luis Miguel", "539.439.688", "Kano", null },
                    { 55, "José Miguel", "5364-238-083", "Rincón", null },
                    { 56, "Victoria", "5098-686-936", "Bonilla", null },
                    { 57, "Lucas", "548887390", "Segovia", null },
                    { 58, "Alexis", "587 934 465", "Kuzmina", null },
                    { 59, "Barbara", "519399056", "Saldivar", null },
                    { 60, "Débora", "560 431 361", "Velasco", null },
                    { 61, "Alberto", "526.096.761", "Pérez", null },
                    { 62, "Alexis", "5798-093-318", "Luna", null },
                    { 63, "Felipe", "531 834 218", "Contreras", null },
                    { 64, "Mateo", "533 133 210", "Matías", null },
                    { 65, "Gilberto", "513490121", "García", null },
                    { 66, "Jorge", "521733496", "Trejo", null },
                    { 67, "Juana", "5987-025-275", "Valadez", null },
                    { 68, "Isabela", "564429195", "Laureano", null },
                    { 69, "Javier", "5291-527-575", "Magaña", null },
                    { 70, "Lucas", "5621-111-121", "Duarte", null },
                    { 71, "Yolanda", "534859320", "Dueñas", null },
                    { 72, "Isaac", "544.249.006", "Herrera", null },
                    { 73, "Elías", "594 744 212", "Flores", null },
                    { 74, "Ángela", "524403591", "Salas", null },
                    { 75, "Gregorio", "523 855 532", "Chavarría", null },
                    { 76, "Francisco Javier", "532.111.858", "Lara", null },
                    { 77, "Ivanna", "537 792 892", "Jaramillo", null },
                    { 78, "Hernán", "5020-491-036", "Casárez", null },
                    { 79, "Gonzalo", "5491-844-961", "Galván", null },
                    { 80, "Matías", "545975660", "Brito", null },
                    { 81, "Melissa", "560 012 705", "Ocasio", null },
                    { 82, "Ivanna", "549314155", "Sepúlveda", null },
                    { 83, "Lucia", "533 763 463", "Viera", null },
                    { 84, "Marcos", "5062-777-543", "Franco", null },
                    { 85, "Brayan", "5545-428-336", "Alfaro", null },
                    { 86, "Clara", "501.923.329", "Ozuna", null },
                    { 87, "Claudio", "520.519.607", "Almanza", null },
                    { 88, "Julio César", "574 061 713", "Girón", null },
                    { 89, "Emilio", "591443148", "Garica", null },
                    { 90, "Conchita", "575758072", "Brito", null },
                    { 91, "Pablo", "538 293 704", "Valdez", null },
                    { 92, "Emily", "5260-419-878", "Valverde", null },
                    { 93, "Francisco", "539.855.388", "Tovar", null },
                    { 94, "Eva", "503 676 307", "Núñez", null },
                    { 95, "Ximena Guadalupe", "556834122", "Ocampo", null },
                    { 96, "Julio", "530 237 717", "Sauceda", null },
                    { 97, "Natalia", "520.101.109", "Espino", null },
                    { 98, "Concepción", "574.111.439", "Fonseca", null },
                    { 99, "María Fernanda", "506 757 795", "Gollum", null },
                    { 100, "Martín", "578.131.825", "Ontiveros", null }
                });

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "address", "email", "name", "phone", "surname", "type", "userid" },
                values: new object[,]
                {
                    { 1, "Travesía Alfonso, 1", "Cristian_Cordova@gmail.com", "Cristian", "533.448.265", "Córdova", "Incorporo", null },
                    { 2, "Lugar Lorenzo, 7 Esc. 577", "Raquel45@corpfolder.com", "Raquel", "552858190", "Delvalle", "Fideicomitente", null },
                    { 3, "Barranco La otra banda, 6 Esc. 115", "Margarita89@nearbpo.com", "Margarita", "5570-160-982", "Esquivel", "Fideo", null },
                    { 4, "Municipio Repúplica de Cuba 28", "Marcela.Valentin@hotmail.com", "Marcela", "5957-815-265", "Valentín", "Batea", null },
                    { 5, "Parcela Ramiro 6260", "Yamileth82@hotmail.com", "Yamileth", "5709-453-979", "Velásquez", "Batanero", null },
                    { 6, "Parcela Naranjo, 39 Puerta 962", "Evelyn_Esparza@nearbpo.com", "Evelyn", "579543713", "Esparza", "Engaritar", null },
                    { 7, "Prolongación La otra banda 211", "Cesar_Quintero@corpfolder.com", "César", "5190-509-476", "Quintero", "Gemíparo", null },
                    { 8, "Partida Damián, 2 Puerta 844", "MariaEugenia_Kortahernandez82@hotmail.com", "María Eugenia", "537 790 279", "Korta hernandez", "Genealógico", null },
                    { 9, "Puerta Elías Palomo 82", "Teresa85@gmail.com", "Teresa", "582.601.472", "Menéndez", "Abalar", null },
                    { 10, "Monte Donceles 04 Puerta 657", "Emmanuel.Barrera18@nearbpo.com", "Emmanuel", "5755-851-156", "Barrera", "Descerrar", null },
                    { 11, "Senda San Miguel 30", "Horacio14@corpfolder.com", "Horacio", "585.204.713", "Gaytán", "Batata", null },
                    { 12, "Vía Aniceto Ortega 9 Puerta 589", "Ramiro_Rangel65@corpfolder.com", "Ramiro", "560222429", "Rangel", "Abaldonadamente", null },
                    { 13, "Municipio Cedro s/n.", "JuanPablo_Quintairos28@gmail.com", "Juan Pablo", "540 126 794", "Quintairos", "Cenceño", null },
                    { 14, "Muelle Eje 5 817 Puerta 131", "Octavio_Paz@nearbpo.com", "Octavio", "519 571 793", "Paz", "Incorporación", null },
                    { 15, "Torrente Jerónimo, 71 Edificio 8", "Esperanza.Carranza0@corpfolder.com", "Esperanza", "5337-941-411", "Carranza", "Incorrectamente", null },
                    { 16, "Chalet Barbara López s/n.", "Timoteo.Montenegro@hotmail.com", "Timoteo", "554.854.909", "Montenegro", "Batazo", null },
                    { 17, "Colegio La otra banda 1057", "Lucia23@gmail.com", "Lucia", "5139-762-019", "Lomeli", "Abacería", null },
                    { 18, "Lugar Avena s/n. Edificio 5", "Homero.Montalvo6@corpfolder.com", "Homero", "505 000 734", "Montalvo", "Engarce", null },
                    { 19, "Conjunto San Miguel 00", "Rosalia_Gonzalez@corpfolder.com", "Rosalia", "523446834", "González", "Increpador", null },
                    { 20, "Gran Subida Fernando Javier Delatorre s/n. Edificio 5", "Fernando_Ruiz31@corpfolder.com", "Fernando", "5289-223-618", "Ruiz", "Incorruptibilidad", null },
                    { 21, "Municipio Jalisco 4 Esc. 387", "JorgeLuis_Bueno96@yahoo.com", "Jorge Luis", "5754-193-160", "Bueno", "Incrementar", null },
                    { 22, "Poblado Flor Marina, 60", "Estefania9@yahoo.com", "Estefanía", "5966-937-803", "Holguín", "Cencivera", null },
                    { 23, "Glorieta Jimena Godínez 59 Edificio 8", "Evelyn.Villagomez@corpfolder.com", "Evelyn", "595.528.537", "Villagómez", "Incorporal", null },
                    { 24, "Muelle Coruña, 97", "Hugo_Cruz91@gmail.com", "Hugo", "566245402", "Cruz", "Batallar", null },
                    { 25, "Grupo Repúplica de Cuba, 2 Edificio 2", "Oscar.Quinterocruz@yahoo.com", "Óscar", "512529453", "Quintero cruz", "Incruento", null },
                    { 26, "Paseo Rafael 8718", "Yolanda41@gmail.com", "Yolanda", "5912-391-559", "de Jesús", "Bateador", null },
                    { 27, "Lado Zacatlán, 8 Edificio 4", "Raquel.Galarza@corpfolder.com", "Raquel", "5892-006-147", "Galarza", "Cenal", null },
                    { 28, "Carretera Horacio Figueroa 51 Esc. 603", "Diana.Alba@yahoo.com", "Diana", "504 429 942", "Alba", "Cenegar", null },
                    { 29, "Lugar Claudio Carranza, 88 Puerta 874", "Gerardo.Pedroza8@gmail.com", "Gerardo", "5853-126-476", "Pedroza", "Cenero", null },
                    { 30, "Gran Subida Aniceto Ortega 8979", "LuisMiguel_Guardado83@yahoo.com", "Luis Miguel", "524 046 740", "Guardado", "Cencellada", null },
                    { 31, "Polígono Eje 5, 3 Edificio 4", "Valeria33@gmail.com", "Valeria", "526 168 277", "Kanaria", "Cencío", null },
                    { 32, "Quinta Donceles 919 Esc. 224", "Raquel_Chavez97@nearbpo.com", "Raquel", "554030717", "Chávez", "Cencellada", null },
                    { 33, "Ronda Zapata, 5", "Josefina16@gmail.com", "Josefina", "5328-513-392", "Rosas", "Bate", null },
                    { 34, "Arrabal Eje Central 025", "Salvador.Cervantez@nearbpo.com", "Salvador", "557984616", "Cervántez", "Abada", null },
                    { 35, "Solar Uriel s/n.", "Araceli.Benavides90@nearbpo.com", "Araceli", "5099-084-562", "Benavides", "Incorregible", null },
                    { 36, "Pasaje Barrio la Lonja s/n.", "Sancho_Espinal88@yahoo.com", "Sancho", "547.345.477", "Espinal", "Incorrupto", null },
                    { 37, "Manzana Zapata s/n.", "Sonia.Carreon@gmail.com", "Sonia", "5231-950-144", "Carreón", "Basurero", null },
                    { 38, "Jardines Eje 6 4008", "Marilu5@nearbpo.com", "Marilu", "565 627 928", "Varela", "Increpador", null },
                    { 39, "Conjunto Isabel la Católica 7283", "Alberto.Amador@gmail.com", "Alberto", "5060-737-386", "Amador", "Bataola", null },
                    { 40, "Solar María Eugenia Salas, 8", "Isaias.Alcaraz15@hotmail.com", "Isaias", "514176085", "Alcaraz", "Engargante", null },
                    { 41, "Escalinata Isabel la Católica 646", "Juana.Naranjo5@yahoo.com", "Juana", "517 850 969", "Naranjo", "Cenagoso", null },
                    { 42, "Puente Donceles 2543", "Melany55@nearbpo.com", "Melany", "5746-858-957", "Palomino", "Incorporeidad", null },
                    { 43, "Grupo Repúplica de Uruguay 567", "Evelyn.Patino@yahoo.com", "Evelyn", "572 230 902", "Patiño", "Incrédulamente", null },
                    { 44, "Lado Flor Solvestre, 68", "Regina_Fernandez@gmail.com", "Regina", "572477539", "Fernández", "Increíblemente", null },
                    { 45, "Rincón Piedra del Comal, 18", "Hugo_Arana18@hotmail.com", "Hugo", "574.850.956", "Araña", "Fideísmo", null },
                    { 46, "Calle Balcón de los edecanes, 28", "Soledad.Hernandez@yahoo.com", "Soledad", "597.924.651", "Hernández", "Fideero", null },
                    { 47, "Aldea Cinco de Mayo, 7", "Esteban.Correa@hotmail.com", "Esteban", "568.725.564", "Correa", "Engarzadura", null },
                    { 48, "Paseo Izazaga 68 Esc. 801", "Regina13@gmail.com", "Regina", "574 997 338", "Vallejo", "Increado", null },
                    { 49, "Chalet Eje Central 48", "Adela_Cardenas@yahoo.com", "Adela", "513 246 898", "Cardenas", "Batallón", null },
                    { 50, "Colonia San Miguel 0141 Puerta 071", "Laura_Alba@corpfolder.com", "Laura", "5949-479-245", "Alba", "Bátavo", null },
                    { 51, "Entrada Uriel 07", "Camila_Alcantar@hotmail.com", "Camila", "5654-979-506", "Alcántar", "Increíble", null },
                    { 52, "Puente Fernando, 7", "Claudia18@hotmail.com", "Claudia", "515.502.895", "Rosas", "Bátavo", null },
                    { 53, "Senda Jalisco, 52", "Fatima.Sanches53@nearbpo.com", "Fatima", "506.647.568", "Sanches", "Geneático", null },
                    { 54, "Rincón Berta Calderón 7 Puerta 032", "Santiago_Zuniga@gmail.com", "Santiago", "564205556", "Zúñiga", "Cencha", null },
                    { 55, "Plaza Izazaga, 97", "Berta.Abrego60@gmail.com", "Berta", "5267-818-970", "Abrego", "Engaritar", null },
                    { 56, "Ramal Repúplica de Cuba 66 Puerta 264", "Abraham6@corpfolder.com", "Abraham", "528903769", "Padilla", "Abadiato", null },
                    { 57, "Lado Luis Sáenz 32", "Caridad69@gmail.com", "Caridad", "510634359", "Garza", "Abacorar", null },
                    { 58, "Escalinata Avena 754", "Lourdes_Carrasco@nearbpo.com", "Lourdes", "560 142 527", "Carrasco", "Gemiquear", null },
                    { 59, "Rincón Calimaya 14 Esc. 276", "Angela.Casillas@gmail.com", "Ángela", "588.998.329", "Casillas", "Cenegar", null },
                    { 60, "Ferrocarril Anita 116", "FranciscoJavier_Ybarra17@yahoo.com", "Francisco Javier", "505 666 446", "Ybarra", "Gemológico", null },
                    { 61, "Rambla Balcón de los edecanes, 54", "Lucia.Laureano58@gmail.com", "Lucia", "586.594.889", "Laureano", "Ficticio", null },
                    { 62, "Colegio Amores 2227 Edificio 1", "Timoteo.Gaona@hotmail.com", "Timoteo", "561.155.842", "Gaona", "Engarro", null },
                    { 63, "Extrarradio Repúplica de Argentina s/n. Esc. 797", "Cristobal_Ocasio90@hotmail.com", "Cristobal", "528.201.948", "Ocasio", "Cenceño", null },
                    { 64, "Apartamento Rocio Alarcón, 1 Puerta 881", "Andres_Orosco@nearbpo.com", "Andrés", "538019750", "Orosco", "Cencuate", null },
                    { 65, "Plaza Manzanares, 3", "Axel_Luevano73@yahoo.com", "Axel", "582.586.176", "Luevano", "Ficticio", null },
                    { 66, "Muelle Cinco de Mayo 09 Edificio 4", "Ernesto15@yahoo.com", "Ernesto", "5425-194-305", "Curiel", "Abaldonadamente", null },
                    { 67, "Mercado Avena, 5 Puerta 386", "Roberto_Cepeda96@hotmail.com", "Roberto", "5457-727-084", "Cepeda", "Engargolar", null },
                    { 68, "Aldea Mayte, 4", "Isaias_Gonzales@corpfolder.com", "Isaias", "5852-678-384", "Gonzales", "Desceñir", null },
                    { 69, "Lugar Elsa s/n.", "Nicolas16@gmail.com", "Nicolás", "591822635", "Colón", "Incorrección", null },
                    { 70, "Lado María de los Ángeles Posada 7601 Puerta 368", "Antonio.Quevedo@gmail.com", "Antonio", "524 463 747", "Quevedo", "Batata", null },
                    { 71, "Barranco Izazaga 456", "Miranda.Ortiz55@hotmail.com", "Miranda", "597 090 943", "Ortiz", "Gemoterapia", null },
                    { 72, "Quinta Repúplica de Uruguay s/n.", "Carla_Gil80@gmail.com", "Carla", "588.031.281", "Gil", "Descerezar", null },
                    { 73, "Salida La viga, 65", "Lourdes.Villareal@corpfolder.com", "Lourdes", "508 191 811", "Villareal", "Basurero", null },
                    { 74, "Lugar Manuela 1 Edificio 0", "Luisa_Guerra59@corpfolder.com", "Luisa", "513774839", "Guerra", "Descifrable", null },
                    { 75, "Vía Pública José Emilio 3 Puerta 233", "Guadalupe2@hotmail.com", "Guadalupe", "571.871.208", "Solorzano", "Fido", null },
                    { 76, "Parque Isabel la Católica s/n. Edificio 6", "Guadalupe_Guzman95@yahoo.com", "Guadalupe", "575236283", "Guzmán", "Engastadura", null },
                    { 77, "Ferrocarril Donceles 99 Edificio 3", "Rafael49@nearbpo.com", "Rafael", "508.183.017", "Jurado", "Incorporalmente", null },
                    { 78, "Quinta Coyoacán 147", "Soledad.Laboy81@gmail.com", "Soledad", "530867416", "Laboy", "Genciana", null },
                    { 79, "Ramal Concepción Perales, 0 Esc. 097", "Rosa15@yahoo.com", "Rosa", "516 168 025", "Frías", "Abacalero", null },
                    { 80, "Apartamento Repúplica de Argentina 5514", "Manuela.Davila66@corpfolder.com", "Manuela", "565 275 569", "Dávila", "Fidelísimo", null },
                    { 81, "Rampa Aniceto Ortega 2316", "Adriana65@yahoo.com", "Adriana", "551.981.349", "Vázquez", "Cencerrado", null },
                    { 82, "Mercado Clemente, 5 Puerta 888", "Emmanuel_Cervantes90@yahoo.com", "Emmanuel", "562 177 266", "Cervantes", "Descepar", null },
                    { 83, "Calle Cuahutemoc 91 Edificio 9", "Esmeralda.Cano74@hotmail.com", "Esmeralda", "578869215", "Cano", "Cencerrada", null },
                    { 84, "Prolongación Sara Korta hernandez, 33 Edificio 4", "Felipe29@hotmail.com", "Felipe", "550016707", "Caraballo", "Géminis", null },
                    { 85, "Monte La viga 9", "Mayte.Zayas@corpfolder.com", "Mayte", "530396075", "Zayas", "Gen", null },
                    { 86, "Pasaje Luis Ángel, 57", "Fatima43@nearbpo.com", "Fatima", "536256129", "Rodrígez", "Cenegar", null },
                    { 87, "Entrada Aniceto Ortega 1", "Estefania_Renteria@corpfolder.com", "Estefanía", "506 336 474", "Rentería", "Generalidad", null },
                    { 88, "Solar José Luis Espino 1", "Estefania_Mayorga@nearbpo.com", "Estefanía", "566247367", "Mayorga", "Gemológico", null },
                    { 89, "Caserio Eje Central 6 Puerta 451", "Diana.Collazo@yahoo.com", "Diana", "5282-046-110", "Collazo", "Abadía", null },
                    { 90, "Avenida San Miguel 181 Puerta 379", "Israel.Navarrete47@gmail.com", "Israel", "5624-931-596", "Navarrete", "Abaldonamiento", null },
                    { 91, "Rua Flor Marina 3672", "Caridad_Rojas@gmail.com", "Caridad", "552 640 948", "Rojas", "Descerezar", null },
                    { 92, "Barranco María Fernanda 92 Edificio 6", "Sergio.Montanez@nearbpo.com", "Sergio", "575 672 874", "Montañez", "Fidedigno", null },
                    { 93, "Extramuros Aniceto Ortega 0701", "Isaias.Kyra45@corpfolder.com", "Isaias", "574 441 326", "Kyra", "Batahola", null },
                    { 94, "Rambla Flor Solvestre s/n. Edificio 8", "Abraham64@gmail.com", "Abraham", "5228-520-951", "Mateo", "Abacalero", null },
                    { 95, "Torrente Calimaya 1", "Jimena57@yahoo.com", "Jimena", "5306-828-608", "Xiana", "Incorporalmente", null },
                    { 96, "Colonia Mayte Pedraza, 64 Puerta 764", "Samuel.Robledo@hotmail.com", "Samuel", "509140472", "Robledo", "Fidecomiso", null },
                    { 97, "Calle San Miguel 6918 Edificio 2", "Gloria_Colon@yahoo.com", "Gloria", "522543096", "Colón", "Incordio", null },
                    { 98, "Avenida Francisco I. Madero s/n. Puerta 819", "Bernardo_Marroquin@hotmail.com", "Bernardo", "5314-436-561", "Marroquín", "Increíblemente", null },
                    { 99, "Aldea Flor Marina, 7 Esc. 208", "Victor.Raya@yahoo.com", "Víctor", "587802641", "Raya", "Basural", null },
                    { 100, "Quinta Repúplica de Chile s/n.", "Mauricio58@yahoo.com", "Mauricio", "502 095 948", "Ortega", "Cendrada", null }
                });

            migrationBuilder.InsertData(
                table: "mechanics",
                columns: new[] { "id", "address", "commission", "email", "name", "phone", "role", "salary", "surname", "user_id" },
                values: new object[,]
                {
                    { 1, "Lado Donceles 3852 Puerta 749", 30.0, "MariaCristina_Ocasio@nearbpo.com", "María Cristina", "520 601 130", "Aprendiz", 473.37, "Ocasio", null },
                    { 2, "Plaza Batalla de Naco s/n.", 30.0, "Esteban22@nearbpo.com", "Esteban", "549160031", "Junior", 529.10000000000002, "Jáquez", null },
                    { 3, "Ronda Jicolapa 369", 40.0, "Lizbeth.Soto@gmail.com", "Lizbeth", "550489538", "Junior", 161.06999999999999, "Soto", null },
                    { 4, "Colonia Repúplica de Argentina 02 Puerta 055", 20.0, "Manuel.Delgadillo@gmail.com", "Manuel", "5162-918-788", "Master", 81.579999999999998, "Delgadillo", null },
                    { 5, "Senda La viga, 4", 20.0, "Gerardo.Toro@gmail.com", "Gerardo", "5400-382-432", "Aprendiz", 208.84, "Toro", null },
                    { 6, "Extramuros Jerónimo Valadez 9", 30.0, "Monserrat91@hotmail.com", "Monserrat", "563 007 330", "Master", 652.51999999999998, "Prieto", null },
                    { 7, "Calle Horacio Pabón 841 Edificio 1", 20.0, "Laura_Abreu28@nearbpo.com", "Laura", "507.779.996", "Junior", 448.52999999999997, "Abreu", null },
                    { 8, "Gran Subida Aniceto Ortega s/n. Edificio 9", 40.0, "Gael94@gmail.com", "Gael", "554.565.252", "Junior", 57.530000000000001, "Velasco", null },
                    { 9, "Barrio Juárez, 09", 30.0, "Julia58@nearbpo.com", "Julia", "5173-532-777", "Aprendiz", 559.33000000000004, "León", null },
                    { 10, "Riera Zapata 7", 40.0, "Vanessa.Quintanilla@corpfolder.com", "Vanessa", "585 618 618", "Junior", 431.95999999999998, "Quintanilla", null },
                    { 11, "Explanada Calimaya 2852 Edificio 7", 20.0, "Andrea_Alvarado@gmail.com", "Andrea", "591 505 820", "Master", 94.019999999999996, "Alvarado", null },
                    { 12, "Calle Barrio la Lonja, 9", 20.0, "Tomas_Ulibarri@corpfolder.com", "Tomás", "512.427.173", "Aprendiz", 661.02999999999997, "Ulibarri", null },
                    { 13, "Extramuros Cuahutemoc s/n. Puerta 070", 20.0, "Reina.Guerra90@yahoo.com", "Reina", "586557845", "Junior", 761.99000000000001, "Guerra", null },
                    { 14, "Puente María Luisa, 9", 30.0, "MariaGuadalupe_Koenig@gmail.com", "María Guadalupe", "5781-512-073", "Aprendiz", 66.769999999999996, "Koenig", null },
                    { 15, "Lado Coyoacán 364 Puerta 178", 20.0, "JorgeLuis_Ledesma96@corpfolder.com", "Jorge Luis", "548 880 012", "Aprendiz", 511.60000000000002, "Ledesma", null },
                    { 16, "Caserio Maximiliano s/n.", 40.0, "Ignacio.Fernandez8@corpfolder.com", "Ignacio", "5842-768-734", "Master", 155.36000000000001, "Fernández", null },
                    { 17, "Prolongación Repúplica de Chile 58 Esc. 720", 30.0, "Isabel_Miramontes36@nearbpo.com", "Isabel", "5869-759-376", "Aprendiz", 178.78, "Miramontes", null },
                    { 18, "Edificio Cinco de Mayo, 7 Edificio 8", 20.0, "MariaEugenia99@yahoo.com", "María Eugenia", "5217-900-966", "Master", 171.99000000000001, "Atencio", null },
                    { 19, "Extrarradio Batalla de Naco 41", 30.0, "Marcos.Abrego@nearbpo.com", "Marcos", "5833-774-969", "Master", 46.659999999999997, "Abrego", null },
                    { 20, "Puente Barrio la Lonja 82 Esc. 117", 40.0, "Andres25@nearbpo.com", "Andrés", "532355697", "Aprendiz", 686.80999999999995, "Carrera", null },
                    { 21, "Lugar Batalla de Naco, 2 Esc. 697", 40.0, "Abigail75@nearbpo.com", "Abigail", "560.757.406", "Aprendiz", 650.05999999999995, "Laboy", null },
                    { 22, "Rampa Zapata, 32 Puerta 953", 40.0, "Rosalia_Peres@gmail.com", "Rosalia", "521 980 557", "Master", 105.33, "Peres", null },
                    { 23, "Travesía Repúplica de Uruguay s/n.", 40.0, "MariadeJesus.Padilla47@yahoo.com", "María de Jesús", "518127093", "Master", 491.94999999999999, "Padilla", null },
                    { 24, "Parque Zapata 5", 40.0, "Berta.Adorno@yahoo.com", "Berta", "517381871", "Master", 37.670000000000002, "Adorno", null },
                    { 25, "Cuesta Jalisco 7 Edificio 4", 40.0, "LuisGabino38@corpfolder.com", "Luis Gabino", "540678867", "Aprendiz", 857.32000000000005, "Cuellar", null },
                    { 26, "Plaza Aniceto Ortega 7825", 20.0, "MariaSoledad75@hotmail.com", "María Soledad", "5680-675-794", "Aprendiz", 408.01999999999998, "Kindelan", null },
                    { 27, "Torrente Cedro 891", 40.0, "Isaias.Frias@corpfolder.com", "Isaias", "585.104.517", "Master", 702.74000000000001, "Frías", null },
                    { 28, "Avenida Yaretzi 8157 Edificio 7", 40.0, "Sebastian.Rosado52@nearbpo.com", "Sebastian", "581278083", "Aprendiz", 748.94000000000005, "Rosado", null },
                    { 29, "Colonia Leonor, 9 Puerta 173", 40.0, "Cristina_Olivera@gmail.com", "Cristina", "5232-146-072", "Junior", 26.09, "Olivera", null },
                    { 30, "Carretera Julieta s/n. Edificio 6", 20.0, "Estefania_Loera@yahoo.com", "Estefanía", "507131543", "Master", 124.77, "Loera", null },
                    { 31, "Vía 20 de Noviembre 925", 20.0, "Oscar_Suarez@gmail.com", "Óscar", "5274-418-174", "Aprendiz", 38.159999999999997, "Suárez", null },
                    { 32, "Paseo Donceles, 9", 20.0, "Armando.Santacruz@nearbpo.com", "Armando", "540 202 557", "Master", 573.75, "Santacruz", null },
                    { 33, "Camino Eje Central, 3", 30.0, "Elsa.Tapia37@hotmail.com", "Elsa", "595.342.500", "Master", 787.25999999999999, "Tapia", null },
                    { 34, "Aldea Calimaya 8637", 40.0, "Vicente99@gmail.com", "Vicente", "5576-468-988", "Junior", 616.80999999999995, "Yami", null },
                    { 35, "Solar La otra banda 1 Esc. 527", 20.0, "Alejandro_Medina18@gmail.com", "Alejandro", "524 520 655", "Aprendiz", 659.55999999999995, "Medina", null },
                    { 36, "Grupo Zacatlán 480", 30.0, "LuisFernando.Quevedo9@corpfolder.com", "Luis Fernando", "530.013.927", "Junior", 322.47000000000003, "Quevedo", null },
                    { 37, "Rampa Repúplica de Cuba 9 Puerta 776", 40.0, "Rocio_Veliz32@hotmail.com", "Rocio", "593077332", "Junior", 524.92999999999995, "Véliz", null },
                    { 38, "Gran Subida Zacatlán 288", 40.0, "Gregorio_Rivera@nearbpo.com", "Gregorio", "574 041 683", "Aprendiz", 369.70999999999998, "Rivera", null },
                    { 39, "Jardines Repúplica de Cuba, 6", 40.0, "Carlos33@hotmail.com", "Carlos", "524 241 262", "Junior", 582.10000000000002, "Granados", null },
                    { 40, "Camino Clemente, 58", 30.0, "Daniel19@nearbpo.com", "Daniel", "5872-560-938", "Aprendiz", 953.78999999999996, "Cabrera", null },
                    { 41, "Caserio Polotitlan s/n.", 30.0, "Abigail.Briones@corpfolder.com", "Abigail", "532657209", "Junior", 802.27999999999997, "Briones", null },
                    { 42, "Extrarradio Raquel Girón 7931", 30.0, "MariaEugenia_Oquendo@corpfolder.com", "María Eugenia", "592 123 369", "Master", 239.37, "Oquendo", null },
                    { 43, "Barrio Repúplica de Chile s/n. Esc. 788", 40.0, "Ramon_Padron56@corpfolder.com", "Ramón", "5610-952-631", "Aprendiz", 519.45000000000005, "Padrón", null },
                    { 44, "Conjunto Amores s/n. Esc. 733", 30.0, "Melissa.Flores@gmail.com", "Melissa", "579 214 449", "Master", 472.63999999999999, "Flores", null },
                    { 45, "Arrabal Isabel la Católica 63", 20.0, "Patricio_Madera@yahoo.com", "Patricio", "5693-679-514", "Junior", 988.72000000000003, "Madera", null },
                    { 46, "Prolongación Hugo 53", 30.0, "Sara47@corpfolder.com", "Sara", "593.346.556", "Aprendiz", 54.719999999999999, "Kuzmina", null },
                    { 47, "Avenida Amores 4", 30.0, "Zoe10@yahoo.com", "Zoe", "519570810", "Junior", 77.739999999999995, "Hurtado", null },
                    { 48, "Bajada La viga 4", 40.0, "Gonzalo81@yahoo.com", "Gonzalo", "545699246", "Master", 112.28, "Padilla", null },
                    { 49, "Gran Subida Balcón de los edecanes 1088", 30.0, "Evelyn.Melgar@corpfolder.com", "Evelyn", "500238677", "Aprendiz", 678.75, "Melgar", null },
                    { 50, "Polígono Natalia Xiana, 0", 30.0, "Lourdes.Curiel@hotmail.com", "Lourdes", "590 942 573", "Junior", 679.49000000000001, "Curiel", null },
                    { 51, "Poblado Fernando Bueno, 73", 20.0, "Homero.Polanco5@gmail.com", "Homero", "562608786", "Aprendiz", 474.33999999999997, "Polanco", null },
                    { 52, "Sector Juárez 049 Edificio 3", 40.0, "MariaFernanda_Maestas@gmail.com", "María Fernanda", "5768-203-310", "Aprendiz", 189.06999999999999, "Maestas", null },
                    { 53, "Parque Francisco I. Madero 9450 Edificio 7", 30.0, "Eloisa_Carvajal82@nearbpo.com", "Eloisa", "589776152", "Aprendiz", 251.06, "Carvajal", null },
                    { 54, "Muelle Flor Solvestre 42 Esc. 528", 20.0, "Diego.Villanueva28@hotmail.com", "Diego", "500364561", "Master", 605.75999999999999, "Villanueva", null },
                    { 55, "Glorieta Avena 363", 40.0, "Leonor_Casas@gmail.com", "Leonor", "593 010 819", "Aprendiz", 598.71000000000004, "Casas", null },
                    { 56, "Senda Cuahutemoc 5646", 40.0, "Adela62@yahoo.com", "Adela", "505936856", "Aprendiz", 951.30999999999995, "Valverde", null },
                    { 57, "Calle Isabel la Católica 66 Esc. 468", 40.0, "Bernardo.Barajas@gmail.com", "Bernardo", "5223-350-010", "Junior", 910.47000000000003, "Barajas", null },
                    { 58, "Salida Barrio la Lonja 223", 20.0, "Cristobal81@hotmail.com", "Cristobal", "5346-374-291", "Junior", 587.35000000000002, "Escamilla", null },
                    { 59, "Municipio Cecilia Oquendo s/n.", 20.0, "Raquel84@corpfolder.com", "Raquel", "5772-825-266", "Aprendiz", 727.88, "Olmos", null },
                    { 60, "Lugar Avena, 46 Esc. 850", 20.0, "MariaTeresa99@hotmail.com", "María Teresa", "580 684 384", "Junior", 550.33000000000004, "Almanza", null },
                    { 61, "Solar Miguel, 39 Puerta 323", 20.0, "Oscar_Bravo@hotmail.com", "Óscar", "586.656.137", "Aprendiz", 708.64999999999998, "Bravo", null },
                    { 62, "Paseo Francisco I. Madero s/n. Edificio 9", 40.0, "Raquel39@yahoo.com", "Raquel", "505 500 946", "Aprendiz", 553.15999999999997, "Alva", null },
                    { 63, "Colegio Flor Marina, 7", 30.0, "Abraham15@corpfolder.com", "Abraham", "578162337", "Junior", 226.31, "Kara", null },
                    { 64, "Ronda Juan Pablo Casillas, 7 Edificio 6", 30.0, "MariaSoledad32@hotmail.com", "María Soledad", "5139-716-693", "Master", 168.69, "Paz", null },
                    { 65, "Plaza San Miguel, 96 Esc. 894", 20.0, "Ramon89@nearbpo.com", "Ramón", "587.398.949", "Master", 481.22000000000003, "Curiel", null },
                    { 66, "Conjunto Aniceto Ortega 7530", 20.0, "Jazmin34@nearbpo.com", "Jazmin", "5509-800-215", "Master", 416.13999999999999, "Kyra", null },
                    { 67, "Paseo Naranjo, 5", 30.0, "Alfonso_Agosto@nearbpo.com", "Alfonso", "506.170.081", "Aprendiz", 694.24000000000001, "Agosto", null },
                    { 68, "Municipio Cedro 77", 40.0, "Liliana_Delvalle@yahoo.com", "Liliana", "501042374", "Aprendiz", 19.59, "Delvalle", null },
                    { 69, "Ramal Valeria Yebra, 58 Edificio 4", 20.0, "Cesar.Gallardo@nearbpo.com", "César", "573.599.349", "Aprendiz", 465.89999999999998, "Gallardo", null },
                    { 70, "Arrabal Juárez 338", 40.0, "Natalia.Lovato@gmail.com", "Natalia", "574 132 865", "Aprendiz", 508.25999999999999, "Lovato", null },
                    { 71, "Muelle Juárez 910 Edificio 1", 30.0, "Mercedes4@hotmail.com", "Mercedes", "587 656 221", "Junior", 188.0, "Guajardo", null },
                    { 72, "Extrarradio Naranjo, 36", 20.0, "Isaias83@corpfolder.com", "Isaias", "560 710 697", "Master", 279.41000000000003, "Kamat", null },
                    { 73, "Subida Francisco I. Madero 5243 Puerta 368", 40.0, "Ivanna_Carreon30@yahoo.com", "Ivanna", "577212878", "Master", 218.21000000000001, "Carreón", null },
                    { 74, "Senda Antonio, 2 Edificio 6", 30.0, "Catalina10@nearbpo.com", "Catalina", "535.431.977", "Junior", 821.91999999999996, "Becerra", null },
                    { 75, "Gran Subida Jorge Madrigal 7 Edificio 3", 40.0, "Gregorio97@corpfolder.com", "Gregorio", "567.083.748", "Aprendiz", 228.12, "Arreola", null },
                    { 76, "Solar Eva s/n. Puerta 051", 30.0, "Eloisa_Arana67@corpfolder.com", "Eloisa", "5684-941-454", "Aprendiz", 446.61000000000001, "Araña", null },
                    { 77, "Huerta Antonio s/n. Esc. 980", 20.0, "Agustin3@yahoo.com", "Agustín", "5757-990-857", "Master", 793.26999999999998, "Nájera", null },
                    { 78, "Jardines Vanessa, 91", 20.0, "Cristina.Aragon36@nearbpo.com", "Cristina", "573.631.578", "Master", 913.00999999999999, "Aragón", null },
                    { 79, "Riera Jicolapa, 01 Esc. 159", 20.0, "Teresa.Delafuente37@hotmail.com", "Teresa", "544.159.758", "Master", 341.33999999999997, "Delafuente", null }
                });

            migrationBuilder.InsertData(
                table: "mechanics",
                columns: new[] { "id", "address", "commission", "email", "name", "phone", "role", "salary", "surname", "user_id" },
                values: new object[,]
                {
                    { 80, "Masía La otra banda, 18 Esc. 318", 30.0, "MariaGuadalupe.Kanea@corpfolder.com", "María Guadalupe", "527.948.070", "Aprendiz", 425.43000000000001, "Kanea", null },
                    { 81, "Monte Cinco de Mayo s/n. Esc. 163", 40.0, "Uriel81@yahoo.com", "Uriel", "511664532", "Junior", 197.71000000000001, "Korta hernandez", null },
                    { 82, "Camino La otra banda 7061", 30.0, "FernandoJavier2@hotmail.com", "Fernando Javier", "529 686 917", "Master", 631.74000000000001, "Pizarro", null },
                    { 83, "Barrio Naranjo s/n. Puerta 637", 40.0, "Erick.Krasnova@corpfolder.com", "Erick", "549.237.684", "Junior", 321.94, "Krasnova", null },
                    { 84, "Ronda Barrio la Lonja s/n.", 40.0, "Regina_Valenzuela@nearbpo.com", "Regina", "568904533", "Master", 973.87, "Valenzuela", null },
                    { 85, "Municipio Repúplica de Cuba 527 Esc. 758", 20.0, "Julio.Giron@corpfolder.com", "Julio", "589115017", "Aprendiz", 891.44000000000005, "Girón", null },
                    { 86, "Puerta Repúplica de Uruguay s/n. Edificio 6", 20.0, "Alan_Jaramillo@hotmail.com", "Alan", "511 331 147", "Aprendiz", 274.74000000000001, "Jaramillo", null },
                    { 87, "Cuesta Miguel Ángel de Quevedo, 46", 30.0, "Lorena_Padilla62@gmail.com", "Lorena", "5792-463-985", "Aprendiz", 833.75999999999999, "Padilla", null },
                    { 88, "Barranco San Miguel 065 Esc. 324", 20.0, "Eduardo35@gmail.com", "Eduardo", "504393578", "Aprendiz", 805.14999999999998, "Ulibarri", null },
                    { 89, "Jardines Ana Quiroz, 7", 40.0, "Benito65@hotmail.com", "Benito", "522 091 583", "Aprendiz", 950.27999999999997, "Bravo", null },
                    { 90, "Solar Pilar Rubio s/n. Esc. 511", 40.0, "Ruben_Pantoja88@corpfolder.com", "Rubén", "5214-683-336", "Master", 524.62, "Pantoja", null },
                    { 91, "Quinta Zacatlán s/n. Edificio 5", 40.0, "JoseMiguel11@corpfolder.com", "José Miguel", "583028882", "Junior", 769.71000000000004, "Mondragón", null },
                    { 92, "Apartamento Hugo Ulibarri 105", 20.0, "Natalia_Robles@corpfolder.com", "Natalia", "533 665 780", "Master", 385.23000000000002, "Robles", null },
                    { 93, "Barrio Zapata 763", 30.0, "Alejandro.Blanco@hotmail.com", "Alejandro", "5879-238-179", "Aprendiz", 729.97000000000003, "Blanco", null },
                    { 94, "Apartamento Miguel Ángel de Quevedo s/n.", 20.0, "Alexander.Gallardo@nearbpo.com", "Alexander", "5518-535-193", "Master", 769.99000000000001, "Gallardo", null },
                    { 95, "Ronda Liliana Zepeda, 15", 30.0, "Oscar.Gamez@gmail.com", "Óscar", "534 423 475", "Master", 184.22999999999999, "Gamez", null },
                    { 96, "Prolongación Repúplica de Cuba, 6 Edificio 7", 40.0, "Claudia_Lucio@hotmail.com", "Claudia", "565062522", "Aprendiz", 89.359999999999999, "Lucio", null },
                    { 97, "Subida Repúplica de Chile 0493 Edificio 6", 20.0, "Clara26@yahoo.com", "Clara", "501.462.415", "Junior", 703.05999999999995, "Miramontes", null },
                    { 98, "Chalet Jazmin 31", 20.0, "Eva77@yahoo.com", "Eva", "517 663 707", "Aprendiz", 926.07000000000005, "Zapata", null },
                    { 99, "Edificio Amores 091 Edificio 0", 40.0, "Andres.Kara@nearbpo.com", "Andrés", "515874573", "Master", 906.85000000000002, "Kara", null },
                    { 100, "Entrada Calimaya 2643 Esc. 742", 30.0, "Isabela_Mendez@hotmail.com", "Isabela", "5517-221-800", "Master", 239.33000000000001, "Méndez", null }
                });

            migrationBuilder.InsertData(
                table: "payrolls",
                columns: new[] { "id", "accruals", "deductions", "description", "end_date", "settlement", "star_date" },
                values: new object[,]
                {
                    { 1, 771.08000000000004, 366.14999999999998, "Humano", new DateOnly(2022, 11, 22), 396.54000000000002, new DateOnly(2022, 7, 17) },
                    { 2, 610.47000000000003, 421.44999999999999, "Regional", new DateOnly(2022, 12, 23), 909.91999999999996, new DateOnly(2022, 6, 17) },
                    { 3, 575.38, 205.99000000000001, "Central", new DateOnly(2022, 7, 22), 79.390000000000001, new DateOnly(2022, 8, 6) },
                    { 4, 996.53999999999996, 621.57000000000005, "Dinánmico", new DateOnly(2023, 3, 26), 187.91999999999999, new DateOnly(2022, 12, 16) },
                    { 5, 383.92000000000002, 899.39999999999998, "Dinánmico", new DateOnly(2022, 9, 27), 347.69999999999999, new DateOnly(2022, 7, 24) },
                    { 6, 277.24000000000001, 286.20999999999998, "Directo", new DateOnly(2022, 9, 30), 228.93000000000001, new DateOnly(2022, 5, 10) },
                    { 7, 822.80999999999995, 191.41, "Interno", new DateOnly(2023, 3, 12), 456.70999999999998, new DateOnly(2022, 8, 30) },
                    { 8, 302.63999999999999, 743.36000000000001, "Adelante", new DateOnly(2023, 2, 6), 330.69, new DateOnly(2023, 1, 27) },
                    { 9, 480.47000000000003, 475.55000000000001, "Interno", new DateOnly(2022, 8, 16), 412.68000000000001, new DateOnly(2022, 7, 12) },
                    { 10, 152.87, 633.53999999999996, "Inversor", new DateOnly(2022, 5, 30), 991.00999999999999, new DateOnly(2023, 3, 6) },
                    { 11, 573.10000000000002, 771.72000000000003, "Humano", new DateOnly(2022, 10, 12), 215.66999999999999, new DateOnly(2022, 6, 29) },
                    { 12, 645.63, 153.36000000000001, "Global", new DateOnly(2023, 4, 17), 732.50999999999999, new DateOnly(2022, 6, 22) },
                    { 13, 723.87, 720.59000000000003, "Directo", new DateOnly(2022, 11, 4), 454.19999999999999, new DateOnly(2022, 9, 20) },
                    { 14, 111.06, 182.99000000000001, "Interno", new DateOnly(2022, 5, 14), 813.15999999999997, new DateOnly(2023, 3, 9) },
                    { 15, 711.08000000000004, 568.41999999999996, "Interno", new DateOnly(2022, 10, 27), 831.26999999999998, new DateOnly(2023, 3, 18) },
                    { 16, 955.09000000000003, 581.62, "Adelante", new DateOnly(2022, 6, 4), 182.30000000000001, new DateOnly(2022, 12, 29) },
                    { 17, 45.780000000000001, 531.94000000000005, "International", new DateOnly(2022, 12, 7), 651.75, new DateOnly(2022, 11, 16) },
                    { 18, 476.18000000000001, 815.48000000000002, "Corporativo", new DateOnly(2023, 3, 15), 296.48000000000002, new DateOnly(2022, 7, 7) },
                    { 19, 62.039999999999999, 79.959999999999994, "Corporativo", new DateOnly(2023, 3, 4), 298.63, new DateOnly(2022, 12, 10) },
                    { 20, 816.88, 34.640000000000001, "Futuro", new DateOnly(2022, 11, 26), 249.41, new DateOnly(2023, 4, 18) },
                    { 21, 30.16, 127.09999999999999, "Humano", new DateOnly(2023, 4, 17), 661.09000000000003, new DateOnly(2022, 6, 1) },
                    { 22, 386.95999999999998, 588.50999999999999, "Producto", new DateOnly(2022, 11, 25), 578.65999999999997, new DateOnly(2022, 12, 28) },
                    { 23, 143.27000000000001, 580.30999999999995, "Central", new DateOnly(2022, 8, 13), 704.22000000000003, new DateOnly(2022, 7, 31) },
                    { 24, 586.15999999999997, 883.03999999999996, "Adelante", new DateOnly(2023, 4, 3), 854.00999999999999, new DateOnly(2023, 1, 23) },
                    { 25, 638.23000000000002, 542.00999999999999, "Cliente", new DateOnly(2023, 3, 14), 526.30999999999995, new DateOnly(2022, 9, 5) },
                    { 26, 513.69000000000005, 763.39999999999998, "Corporativo", new DateOnly(2022, 9, 5), 193.81, new DateOnly(2022, 9, 23) },
                    { 27, 239.34, 811.75, "Regional", new DateOnly(2022, 6, 15), 493.72000000000003, new DateOnly(2022, 11, 4) },
                    { 28, 671.72000000000003, 898.20000000000005, "Global", new DateOnly(2022, 6, 12), 899.21000000000004, new DateOnly(2023, 2, 27) },
                    { 29, 872.61000000000001, 272.16000000000003, "Jefe", new DateOnly(2023, 4, 17), 614.95000000000005, new DateOnly(2023, 2, 11) },
                    { 30, 492.44, 780.51999999999998, "Directo", new DateOnly(2022, 11, 21), 81.560000000000002, new DateOnly(2022, 11, 5) },
                    { 31, 420.56999999999999, 343.93000000000001, "Cliente", new DateOnly(2022, 11, 7), 310.0, new DateOnly(2022, 9, 29) },
                    { 32, 958.53999999999996, 547.70000000000005, "Futuro", new DateOnly(2022, 11, 30), 269.35000000000002, new DateOnly(2023, 3, 22) },
                    { 33, 877.72000000000003, 935.03999999999996, "Global", new DateOnly(2022, 6, 1), 576.45000000000005, new DateOnly(2022, 11, 7) },
                    { 34, 391.45999999999998, 837.10000000000002, "Director", new DateOnly(2022, 12, 29), 990.58000000000004, new DateOnly(2023, 1, 5) },
                    { 35, 732.24000000000001, 776.48000000000002, "Producto", new DateOnly(2022, 5, 27), 547.22000000000003, new DateOnly(2022, 11, 28) },
                    { 36, 828.49000000000001, 945.42999999999995, "Central", new DateOnly(2022, 8, 13), 913.38999999999999, new DateOnly(2023, 4, 23) },
                    { 37, 188.56999999999999, 566.62, "Senior", new DateOnly(2023, 5, 3), 529.22000000000003, new DateOnly(2023, 4, 19) },
                    { 38, 493.88, 798.86000000000001, "Distrito", new DateOnly(2022, 10, 3), 660.83000000000004, new DateOnly(2023, 1, 25) },
                    { 39, 364.89999999999998, 186.34999999999999, "Regional", new DateOnly(2022, 6, 24), 775.42999999999995, new DateOnly(2022, 9, 3) },
                    { 40, 763.79999999999995, 758.85000000000002, "International", new DateOnly(2023, 3, 23), 510.14999999999998, new DateOnly(2022, 7, 3) },
                    { 41, 295.42000000000002, 421.43000000000001, "Corporativo", new DateOnly(2023, 5, 5), 349.98000000000002, new DateOnly(2022, 11, 5) },
                    { 42, 665.82000000000005, 374.50999999999999, "Senior", new DateOnly(2022, 7, 26), 493.48000000000002, new DateOnly(2022, 8, 19) },
                    { 43, 746.33000000000004, 826.23000000000002, "Jefe", new DateOnly(2022, 7, 3), 344.83999999999997, new DateOnly(2022, 10, 3) },
                    { 44, 208.08000000000001, 637.72000000000003, "Cliente", new DateOnly(2022, 10, 27), 257.25999999999999, new DateOnly(2023, 3, 4) },
                    { 45, 517.57000000000005, 282.76999999999998, "Senior", new DateOnly(2022, 8, 17), 686.34000000000003, new DateOnly(2022, 5, 11) },
                    { 46, 420.99000000000001, 94.310000000000002, "Distrito", new DateOnly(2023, 1, 1), 417.44, new DateOnly(2022, 6, 2) },
                    { 47, 294.18000000000001, 623.11000000000001, "Humano", new DateOnly(2022, 9, 6), 397.91000000000003, new DateOnly(2022, 8, 28) },
                    { 48, 437.0, 247.03999999999999, "Central", new DateOnly(2022, 11, 13), 280.08999999999997, new DateOnly(2022, 11, 20) },
                    { 49, 898.03999999999996, 669.05999999999995, "Director", new DateOnly(2023, 2, 15), 621.57000000000005, new DateOnly(2022, 11, 4) },
                    { 50, 170.25999999999999, 621.32000000000005, "Corporativo", new DateOnly(2022, 8, 29), 295.23000000000002, new DateOnly(2022, 6, 11) },
                    { 51, 582.27999999999997, 969.53999999999996, "Directo", new DateOnly(2022, 6, 8), 713.25999999999999, new DateOnly(2022, 11, 12) },
                    { 52, 972.92999999999995, 448.54000000000002, "Cliente", new DateOnly(2022, 12, 19), 115.06999999999999, new DateOnly(2022, 8, 4) },
                    { 53, 239.94999999999999, 618.67999999999995, "Jefe", new DateOnly(2022, 8, 15), 575.16999999999996, new DateOnly(2022, 11, 12) },
                    { 54, 394.13, 48.060000000000002, "Futuro", new DateOnly(2022, 11, 30), 777.57000000000005, new DateOnly(2022, 7, 5) },
                    { 55, 614.63999999999999, 388.66000000000003, "Regional", new DateOnly(2022, 8, 1), 805.49000000000001, new DateOnly(2022, 7, 6) },
                    { 56, 598.07000000000005, 279.06999999999999, "SubGerente", new DateOnly(2022, 10, 12), 177.08000000000001, new DateOnly(2022, 9, 3) },
                    { 57, 326.63, 405.57999999999998, "Central", new DateOnly(2022, 6, 3), 489.45999999999998, new DateOnly(2022, 10, 20) },
                    { 58, 517.75, 991.87, "Adelante", new DateOnly(2023, 2, 6), 406.38, new DateOnly(2023, 3, 17) },
                    { 59, 42.039999999999999, 61.850000000000001, "Senior", new DateOnly(2022, 12, 26), 392.06, new DateOnly(2023, 4, 18) },
                    { 60, 51.32, 114.63, "Futuro", new DateOnly(2022, 5, 9), 396.26999999999998, new DateOnly(2022, 5, 29) },
                    { 61, 672.85000000000002, 635.05999999999995, "Nacional", new DateOnly(2022, 8, 18), 417.69, new DateOnly(2022, 11, 28) },
                    { 62, 355.45999999999998, 153.34999999999999, "Cliente", new DateOnly(2022, 6, 2), 203.75999999999999, new DateOnly(2022, 6, 19) },
                    { 63, 231.25, 224.00999999999999, "Central", new DateOnly(2022, 8, 11), 326.32999999999998, new DateOnly(2023, 2, 24) },
                    { 64, 224.43000000000001, 636.46000000000004, "Humano", new DateOnly(2022, 8, 10), 194.81999999999999, new DateOnly(2022, 7, 29) },
                    { 65, 772.85000000000002, 385.13999999999999, "Humano", new DateOnly(2023, 5, 4), 316.24000000000001, new DateOnly(2022, 9, 10) },
                    { 66, 559.79999999999995, 287.56, "SubGerente", new DateOnly(2022, 7, 22), 295.27999999999997, new DateOnly(2022, 6, 12) },
                    { 67, 622.49000000000001, 257.45999999999998, "Adelante", new DateOnly(2023, 3, 19), 685.33000000000004, new DateOnly(2023, 2, 28) },
                    { 68, 147.84, 130.91999999999999, "Nacional", new DateOnly(2022, 9, 15), 751.45000000000005, new DateOnly(2022, 8, 14) },
                    { 69, 771.50999999999999, 203.88999999999999, "Jefe", new DateOnly(2022, 8, 4), 170.11000000000001, new DateOnly(2023, 3, 18) },
                    { 70, 458.63, 235.69999999999999, "Distrito", new DateOnly(2022, 10, 22), 750.59000000000003, new DateOnly(2022, 10, 19) },
                    { 71, 419.23000000000002, 96.739999999999995, "Interno", new DateOnly(2022, 5, 19), 883.59000000000003, new DateOnly(2023, 3, 23) },
                    { 72, 349.86000000000001, 185.94999999999999, "Global", new DateOnly(2022, 9, 11), 43.530000000000001, new DateOnly(2022, 11, 20) },
                    { 73, 282.72000000000003, 896.40999999999997, "Cliente", new DateOnly(2022, 6, 16), 145.77000000000001, new DateOnly(2022, 5, 9) },
                    { 74, 508.58999999999997, 892.61000000000001, "SubGerente", new DateOnly(2022, 12, 9), 334.95999999999998, new DateOnly(2022, 11, 12) },
                    { 75, 377.44, 608.16999999999996, "International", new DateOnly(2022, 9, 26), 553.89999999999998, new DateOnly(2023, 1, 29) },
                    { 76, 97.079999999999998, 911.75, "Gerente", new DateOnly(2022, 12, 13), 813.53999999999996, new DateOnly(2022, 11, 13) },
                    { 77, 814.09000000000003, 520.58000000000004, "Senior", new DateOnly(2022, 10, 13), 743.35000000000002, new DateOnly(2022, 6, 24) },
                    { 78, 791.66999999999996, 490.54000000000002, "Director", new DateOnly(2023, 1, 25), 51.5, new DateOnly(2022, 9, 8) },
                    { 79, 58.299999999999997, 844.87, "Interno", new DateOnly(2022, 12, 22), 631.27999999999997, new DateOnly(2022, 8, 10) },
                    { 80, 282.37, 2.98, "International", new DateOnly(2023, 3, 17), 815.75999999999999, new DateOnly(2022, 11, 14) },
                    { 81, 352.99000000000001, 396.29000000000002, "Humano", new DateOnly(2023, 4, 2), 710.44000000000005, new DateOnly(2023, 1, 16) },
                    { 82, 549.63, 778.37, "Global", new DateOnly(2022, 6, 25), 255.91, new DateOnly(2022, 8, 26) },
                    { 83, 220.18000000000001, 174.5, "Humano", new DateOnly(2022, 5, 20), 890.49000000000001, new DateOnly(2022, 8, 12) },
                    { 84, 263.86000000000001, 194.21000000000001, "Jefe", new DateOnly(2023, 3, 20), 675.62, new DateOnly(2022, 8, 15) },
                    { 85, 821.20000000000005, 443.41000000000003, "Adelante", new DateOnly(2023, 3, 6), 281.14999999999998, new DateOnly(2022, 8, 28) },
                    { 86, 892.71000000000004, 190.84999999999999, "Global", new DateOnly(2023, 3, 24), 771.62, new DateOnly(2022, 12, 27) },
                    { 87, 134.0, 112.65000000000001, "Cliente", new DateOnly(2022, 10, 14), 580.98000000000002, new DateOnly(2022, 7, 30) },
                    { 88, 882.09000000000003, 181.22, "Heredado", new DateOnly(2022, 8, 1), 61.399999999999999, new DateOnly(2022, 8, 22) },
                    { 89, 943.58000000000004, 514.0, "Dinánmico", new DateOnly(2023, 2, 17), 104.47, new DateOnly(2022, 7, 30) },
                    { 90, 819.26999999999998, 869.02999999999997, "Corporativo", new DateOnly(2022, 10, 10), 399.69, new DateOnly(2023, 4, 3) },
                    { 91, 267.61000000000001, 36.689999999999998, "Director", new DateOnly(2023, 1, 30), 928.65999999999997, new DateOnly(2023, 2, 6) },
                    { 92, 592.24000000000001, 194.18000000000001, "Cliente", new DateOnly(2022, 8, 2), 91.359999999999999, new DateOnly(2023, 5, 2) },
                    { 93, 869.25, 810.37, "Distrito", new DateOnly(2022, 6, 21), 237.15000000000001, new DateOnly(2022, 8, 17) },
                    { 94, 434.05000000000001, 790.25, "Global", new DateOnly(2022, 11, 12), 618.42999999999995, new DateOnly(2023, 3, 24) },
                    { 95, 854.73000000000002, 560.50999999999999, "Senior", new DateOnly(2022, 10, 31), 396.05000000000001, new DateOnly(2023, 3, 2) },
                    { 96, 628.5, 929.84000000000003, "Central", new DateOnly(2023, 2, 18), 341.89999999999998, new DateOnly(2023, 5, 3) },
                    { 97, 414.62, 83.560000000000002, "Nacional", new DateOnly(2022, 6, 12), 330.81999999999999, new DateOnly(2023, 3, 25) },
                    { 98, 56.240000000000002, 956.24000000000001, "Central", new DateOnly(2022, 9, 13), 641.92999999999995, new DateOnly(2022, 6, 28) },
                    { 99, 93.609999999999999, 404.18000000000001, "Global", new DateOnly(2022, 9, 18), 842.09000000000003, new DateOnly(2023, 2, 16) },
                    { 100, 155.44, 346.62, "Senior", new DateOnly(2022, 11, 24), 307.68000000000001, new DateOnly(2023, 2, 13) }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "brand", "code", "description", "name", "quantity", "saleprice" },
                values: new object[,]
                {
                    { 1, "Rústico", "8940541365386", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Hecho a mano Plástico Ensalada", 29, 669911.6f },
                    { 2, "Gorgeous", "6525701840075", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Increíble Frozen Pollo", 38, 330736.38f },
                    { 3, "Sin marca", "6877346273221", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Fresco Pizza", 59, 444442.34f },
                    { 4, "Inteligente", "1809174522528", "The Football Is Good For Training And Recreational Purposes", "Artesanal Plástico Tuna", 46, 400454.06f },
                    { 5, "Genérica", "3530578478774", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonómico Plástico Embutidos", 41, 660721.9f },
                    { 6, "Pequeño", "7892501522197", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonómico Madera Guantes", 15, 671286.2f },
                    { 7, "Elegante", "2489232246840", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Genérica Metal Pantalones", 80, 337542.3f },
                    { 8, "Sin marca", "5383586579401", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sin marca Granito Mesa", 19, 334062.03f },
                    { 9, "Refinado", "7022099644142", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Increíble Plástico Sombrero", 77, 666547f },
                    { 10, "Elegante", "0644150915847", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Increíble Madera Pizza", 61, 685552.06f },
                    { 11, "Artesanal", "3552232338293", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rústico Granito Sombrero", 78, 560682.9f },
                    { 12, "Genérica", "1325101561298", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Hecho a mano Madera Camisa", 72, 616293.56f },
                    { 13, "Licencia", "2976346655922", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Artesanal Fresco Tocino", 57, 515186.84f },
                    { 14, "Sabrosa", "0881088557965", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Increíble Plástico Zapatos", 62, 643443.5f },
                    { 15, "Increíble", "7735458627891", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonómico Fresco Pollo", 44, 370550.8f },
                    { 16, "Práctica", "6492845203793", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Inteligente Cotton Camisa", 26, 477247f },
                    { 17, "Inteligente", "6292550069741", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Increíble Frozen Toallas", 33, 593854.75f },
                    { 18, "Gorgeous", "5530852687203", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refinado Acero Pelota", 48, 685652.06f },
                    { 19, "Ergonómico", "5430322585698", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Artesanal Acero Jabón", 25, 685276.44f },
                    { 20, "Hecho a mano", "5334175860936", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Increíble Fresco Pizza", 4, 361601.66f },
                    { 21, "Increíble", "4889376657720", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sin marca Acero Queso", 60, 508286.5f },
                    { 22, "Artesanal", "9691089215600", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonómico Madera Ensalada", 71, 436540.53f },
                    { 23, "Hecho a mano", "1786132221023", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Pequeño Metal Toallas", 33, 577446.25f },
                    { 24, "Ergonómico", "5645977298781", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rústico Granito Pizza", 28, 477605.6f },
                    { 25, "Refinado", "6829088291995", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonómico Plástico Computadora", 1, 488219.53f },
                    { 26, "Sabrosa", "6310000333607", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonómico Frozen Ratón", 79, 406235.38f },
                    { 27, "Artesanal", "8464331125788", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Increíble Granito Pescado", 70, 369590.97f },
                    { 28, "Sin marca", "9294694947968", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sin marca Fresco Auto", 17, 315541.8f },
                    { 29, "Gorgeous", "2963826091936", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refinado Soft Tuna", 1, 368184.6f },
                    { 30, "Ergonómico", "8800851522179", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sabrosa Frozen Tocino", 8, 565322.06f },
                    { 31, "Sin marca", "0578940790027", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Frozen Presidente", 16, 304570.34f },
                    { 32, "Rústico", "6870126368681", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refinado Granito Pelota", 56, 558613.9f },
                    { 33, "Sabrosa", "5078932060039", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sin marca Cotton Toallas", 29, 361894.4f },
                    { 34, "Refinado", "9416386242223", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licencia Hormigón Pollo", 58, 477120.22f },
                    { 35, "Pequeño", "2620595765764", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Elegante Fresco Camisa", 67, 397642.56f },
                    { 36, "Hecho a mano", "4754825526998", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Increíble Plástico Embutidos", 60, 482343.66f },
                    { 37, "Elegante", "1153480940270", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Práctica Acero Zapatos", 7, 655721.7f },
                    { 38, "Sin marca", "0309359652879", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Increíble Acero Sombrero", 24, 397066.38f },
                    { 39, "Artesanal", "3253659857939", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rústico Metal Pantalones", 38, 464108.84f },
                    { 40, "Gorgeous", "7758663204800", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sin marca Caucho Guantes", 79, 403336.66f },
                    { 41, "Sabrosa", "1196041876823", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Frozen Ensalada", 50, 606290.7f },
                    { 42, "Práctica", "2624714963796", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refinado Frozen Computadora", 21, 632950.7f },
                    { 43, "Práctica", "0122325300464", "The Football Is Good For Training And Recreational Purposes", "Increíble Hormigón Teclado", 77, 564059.9f },
                    { 44, "Inteligente", "1785053058763", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rústico Cotton Sombrero", 49, 395893.66f },
                    { 45, "Artesanal", "5113965104463", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Inteligente Soft Embutidos", 79, 643031.5f },
                    { 46, "Rústico", "9494087441992", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sin marca Fresco Embutidos", 66, 395160.2f },
                    { 47, "Artesanal", "7558003064633", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Práctica Cotton Pizza", 59, 537499.2f },
                    { 48, "Genérica", "2713481346793", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sin marca Caucho Auto", 57, 598903.6f },
                    { 49, "Refinado", "9180810171990", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Inteligente Soft Zapatos", 56, 310457.47f },
                    { 50, "Artesanal", "2118108541702", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refinado Hormigón Camisa", 43, 461251.06f },
                    { 51, "Artesanal", "0705800531807", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rústico Frozen Teclado", 10, 495914.5f },
                    { 52, "Ergonómico", "3903699977325", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Genérica Madera Embutidos", 9, 418581.44f },
                    { 53, "Gorgeous", "9305329051605", "The Football Is Good For Training And Recreational Purposes", "Sin marca Granito Teclado", 50, 611394.44f },
                    { 54, "Refinado", "1338013645598", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Artesanal Fresco Toallas", 22, 463160.25f },
                    { 55, "Pequeño", "8138684622804", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Genérica Caucho Sombrero", 35, 574915f },
                    { 56, "Pequeño", "1664584684163", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Fresco Pelota", 54, 363895.62f },
                    { 57, "Increíble", "5707878743293", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Elegante Plástico Bike", 26, 698742.25f },
                    { 58, "Hecho a mano", "8173164914307", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Genérica Madera Computadora", 72, 439928.7f },
                    { 59, "Ergonómico", "6036326387093", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Acero Presidente", 11, 639207.8f },
                    { 60, "Inteligente", "4807169332760", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refinado Metal Computadora", 28, 634577.3f },
                    { 61, "Práctica", "2668140088296", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantástico Granito Sombrero", 30, 387227.6f },
                    { 62, "Elegante", "8174997133415", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Increíble Soft Pizza", 42, 400227.7f },
                    { 63, "Pequeño", "7484326503866", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sin marca Caucho Jabón", 64, 355109.16f },
                    { 64, "Genérica", "8515564139742", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sabrosa Hormigón Jabón", 80, 561355.2f },
                    { 65, "Rústico", "2827478626116", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licencia Madera Tocino", 30, 430973.62f },
                    { 66, "Sin marca", "8435510378516", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licencia Caucho Guantes", 36, 458103.8f },
                    { 67, "Sabrosa", "5719485573156", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Inteligente Soft Embutidos", 41, 412776.9f },
                    { 68, "Genérica", "3956521782833", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Inteligente Frozen Tocino", 43, 393531.72f },
                    { 69, "Increíble", "6226411529617", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sabrosa Madera Teclado", 44, 509595.16f },
                    { 70, "Artesanal", "9348799975040", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantástico Cotton Guantes", 62, 647779.56f },
                    { 71, "Increíble", "2647895037629", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Increíble Granito Computadora", 23, 369222.25f },
                    { 72, "Práctica", "5379313139338", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Hormigón Sombrero", 27, 617355f },
                    { 73, "Pequeño", "0525619608923", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Increíble Madera Zapatos", 33, 409743.88f },
                    { 74, "Inteligente", "4527198467706", "The Football Is Good For Training And Recreational Purposes", "Increíble Granito Queso", 11, 455776.03f },
                    { 75, "Inteligente", "8355965870871", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Genérica Cotton Pantalones", 47, 316279.3f },
                    { 76, "Fantástico", "2799262749007", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Increíble Acero Teclado", 78, 546103.5f },
                    { 77, "Gorgeous", "1455397918718", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Increíble Plástico Teclado", 70, 593300.1f },
                    { 78, "Genérica", "7095419967986", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licencia Plástico Tocino", 24, 391106.12f },
                    { 79, "Increíble", "3699773232885", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Increíble Hormigón Teclado", 44, 564173.6f },
                    { 80, "Fantástico", "1393342031153", "The Football Is Good For Training And Recreational Purposes", "Genérica Acero Teclado", 54, 417092.28f },
                    { 81, "Gorgeous", "6941309905877", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Práctica Plástico Queso", 26, 566532f },
                    { 82, "Refinado", "5400925168994", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantástico Acero Computadora", 44, 317464.53f },
                    { 83, "Elegante", "1557023050615", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Increíble Hormigón Mesa", 33, 574670.6f },
                    { 84, "Fantástico", "1128653586753", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Increíble Plástico Pollo", 46, 350206.6f },
                    { 85, "Fantástico", "3630682626365", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Elegante Plástico Camisa", 3, 666006.4f },
                    { 86, "Fantástico", "5225680303004", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Elegante Cotton Pantalones", 34, 610748.3f },
                    { 87, "Increíble", "4191672909916", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sin marca Acero Pizza", 30, 328149.47f },
                    { 88, "Gorgeous", "7865796556215", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Inteligente Cotton Queso", 72, 504588.97f },
                    { 89, "Fantástico", "2295778616333", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Hecho a mano Frozen Ratón", 26, 635292.25f },
                    { 90, "Rústico", "1488444173044", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rústico Madera Toallas", 60, 424249.2f },
                    { 91, "Gorgeous", "5174498614010", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Increíble Acero Teclado", 29, 410845.56f },
                    { 92, "Increíble", "2389487834222", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rústico Fresco Pantalones", 77, 359197.72f },
                    { 93, "Hecho a mano", "7318957377179", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Hecho a mano Plástico Toallas", 23, 517686.9f },
                    { 94, "Licencia", "8972368453786", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Pequeño Madera Queso", 60, 619595.56f },
                    { 95, "Fantástico", "3999688813026", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonómico Acero Teclado", 8, 489127.94f },
                    { 96, "Sin marca", "2896264067020", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refinado Acero Tuna", 31, 571350.6f },
                    { 97, "Ergonómico", "1268083569893", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Elegante Caucho Ensalada", 33, 677422.75f },
                    { 98, "Hecho a mano", "4840864095455", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licencia Hormigón Tocino", 52, 532456.7f },
                    { 99, "Hecho a mano", "2913849684875", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Elegante Caucho Bike", 38, 375422.25f },
                    { 100, "Fantástico", "7778685529613", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantástico Plástico Ensalada", 4, 495767.53f }
                });

            migrationBuilder.InsertData(
                table: "purchases",
                columns: new[] { "id", "code", "description", "productid", "quantity", "supplierid", "datepurchase", "purchaseprice", "saleprice" },
                values: new object[,]
                {
                    { 1, "3036833030201", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 36, null, new DateOnly(2022, 8, 15), 478272.53f, 423103.78f },
                    { 2, "4729052847994", "The Football Is Good For Training And Recreational Purposes", null, 14, null, new DateOnly(2022, 6, 9), 383325.06f, 483498.03f },
                    { 3, "7735824574712", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 73, null, new DateOnly(2022, 7, 19), 473386.3f, 458759.47f },
                    { 4, "3372794471197", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 31, null, new DateOnly(2023, 2, 23), 101665.1f, 222873.34f },
                    { 5, "0292670009418", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, 66, null, new DateOnly(2022, 12, 19), 104313.23f, 144963.44f },
                    { 6, "5668260323656", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, 43, null, new DateOnly(2022, 9, 1), 455761.53f, 215931.2f },
                    { 7, "5748312890593", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 37, null, new DateOnly(2022, 8, 5), 330688.66f, 447723.2f },
                    { 8, "2701084841388", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 31, null, new DateOnly(2022, 8, 25), 143789.23f, 415083.62f },
                    { 9, "8191915193450", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 48, null, new DateOnly(2023, 3, 1), 390432f, 379511.03f },
                    { 10, "8770691223553", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 19, null, new DateOnly(2023, 2, 18), 166929.08f, 229575.19f },
                    { 11, "2814447500621", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 57, null, new DateOnly(2023, 2, 11), 474392.5f, 481979.84f },
                    { 12, "4317878076874", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 26, null, new DateOnly(2023, 3, 24), 486074.47f, 463212.44f },
                    { 13, "6406687204535", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 3, null, new DateOnly(2023, 3, 13), 165002.1f, 116453.164f },
                    { 14, "4113951387635", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 27, null, new DateOnly(2022, 7, 14), 428447.78f, 185250.75f },
                    { 15, "4999883457697", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 28, null, new DateOnly(2022, 10, 26), 202763.38f, 274029.84f },
                    { 16, "7127759179658", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 54, null, new DateOnly(2023, 4, 12), 116591.61f, 132283.6f },
                    { 17, "7447090323955", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 27, null, new DateOnly(2022, 10, 7), 416631.38f, 399199.6f },
                    { 18, "9253108810779", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 42, null, new DateOnly(2022, 5, 16), 318531.6f, 428148.25f },
                    { 19, "1816320277911", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 45, null, new DateOnly(2022, 12, 17), 118896.36f, 440015.56f },
                    { 20, "7117575832721", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 43, null, new DateOnly(2022, 8, 8), 392492.7f, 273814.62f },
                    { 21, "9490216976380", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 20, null, new DateOnly(2022, 10, 5), 338401.84f, 374778.72f },
                    { 22, "6429861585060", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 35, null, new DateOnly(2022, 9, 5), 189796.77f, 488310.6f },
                    { 23, "8451903293006", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 74, null, new DateOnly(2023, 4, 25), 238018.58f, 471976.78f },
                    { 24, "8032674776365", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 41, null, new DateOnly(2022, 9, 20), 149834.25f, 129490.5f },
                    { 25, "0860856339590", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 52, null, new DateOnly(2023, 5, 4), 231945.56f, 130966.195f },
                    { 26, "9404721359538", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 18, null, new DateOnly(2023, 2, 15), 133075.94f, 349422.44f },
                    { 27, "9529035948022", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 42, null, new DateOnly(2022, 10, 1), 384474.9f, 409406.62f },
                    { 28, "3205292036165", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 37, null, new DateOnly(2022, 11, 23), 125359.31f, 452396.03f },
                    { 29, "6367975658549", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 78, null, new DateOnly(2022, 10, 29), 336912.62f, 368322.12f },
                    { 30, "1450078371653", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 57, null, new DateOnly(2022, 8, 6), 384756.7f, 194396.88f },
                    { 31, "4460209401446", "The Football Is Good For Training And Recreational Purposes", null, 5, null, new DateOnly(2022, 9, 13), 296533.84f, 271178.12f },
                    { 32, "3868024025099", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 43, null, new DateOnly(2022, 8, 25), 444304.44f, 439560.1f },
                    { 33, "5839063740906", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 17, null, new DateOnly(2022, 11, 3), 321507.28f, 445465.84f },
                    { 34, "5660220118777", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 6, null, new DateOnly(2022, 11, 26), 232988.98f, 423347f },
                    { 35, "8597963009994", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 8, null, new DateOnly(2022, 8, 4), 334216.28f, 338785.16f },
                    { 36, "3209969424217", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 45, null, new DateOnly(2022, 11, 3), 224882.83f, 300669.3f },
                    { 37, "9779634264171", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 12, null, new DateOnly(2022, 12, 2), 157446.11f, 202048.64f },
                    { 38, "4788678202365", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 37, null, new DateOnly(2022, 11, 30), 473467.4f, 304841.47f },
                    { 39, "7197580156708", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 32, null, new DateOnly(2022, 12, 1), 250887.47f, 357319f },
                    { 40, "2432449691774", "The Football Is Good For Training And Recreational Purposes", null, 56, null, new DateOnly(2022, 9, 22), 496248.66f, 490276.6f },
                    { 41, "6980183004641", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 34, null, new DateOnly(2022, 7, 7), 114317.21f, 304555.47f },
                    { 42, "0582445279284", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 67, null, new DateOnly(2022, 7, 5), 371958.47f, 487838.16f },
                    { 43, "8011994194509", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 65, null, new DateOnly(2022, 6, 4), 189079.67f, 467718.97f },
                    { 44, "4271991540943", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 61, null, new DateOnly(2022, 11, 1), 343868.16f, 175854.22f },
                    { 45, "7474588867967", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 7, null, new DateOnly(2022, 11, 25), 319197f, 126506.47f },
                    { 46, "0187863721591", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 59, null, new DateOnly(2022, 11, 25), 232098.42f, 220804.62f },
                    { 47, "5158651773455", "The Football Is Good For Training And Recreational Purposes", null, 27, null, new DateOnly(2023, 4, 7), 232628.28f, 490002.3f },
                    { 48, "9719058528817", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 1, null, new DateOnly(2023, 2, 8), 456362.97f, 187967.08f },
                    { 49, "9015517173148", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, 68, null, new DateOnly(2022, 9, 14), 343767.4f, 262786.4f },
                    { 50, "5371511564875", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 32, null, new DateOnly(2022, 8, 2), 159421.88f, 116004.414f },
                    { 51, "6672976846780", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 21, null, new DateOnly(2022, 11, 22), 396270.22f, 459069.8f },
                    { 52, "4843271604012", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 40, null, new DateOnly(2022, 11, 18), 132256.05f, 263928.56f },
                    { 53, "2014968052351", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 64, null, new DateOnly(2023, 5, 3), 189553.44f, 297151.9f },
                    { 54, "2752586121904", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 47, null, new DateOnly(2022, 9, 8), 155420.56f, 446098.03f }
                });

            migrationBuilder.InsertData(
                table: "purchases",
                columns: new[] { "id", "code", "description", "productid", "quantity", "supplierid", "datepurchase", "purchaseprice", "saleprice" },
                values: new object[,]
                {
                    { 55, "0716602231383", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 51, null, new DateOnly(2022, 5, 25), 200769.12f, 153304.31f },
                    { 56, "4971940504018", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 9, null, new DateOnly(2022, 7, 24), 436557.44f, 315187.66f },
                    { 57, "7498955335163", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 3, null, new DateOnly(2022, 7, 11), 252955.52f, 142442.5f },
                    { 58, "4208709687638", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 57, null, new DateOnly(2022, 7, 18), 174417.3f, 375813.03f },
                    { 59, "9203046364681", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 64, null, new DateOnly(2022, 5, 7), 443058.28f, 401022.34f },
                    { 60, "6775326968788", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 3, null, new DateOnly(2023, 1, 22), 419991.62f, 209533.14f },
                    { 61, "1095393254351", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 21, null, new DateOnly(2022, 10, 22), 395453.22f, 101637.34f },
                    { 62, "8231441362774", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 65, null, new DateOnly(2022, 5, 9), 153429.14f, 317323.3f },
                    { 63, "1180110349752", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 51, null, new DateOnly(2022, 7, 29), 125091.27f, 340417.06f },
                    { 64, "8381098591277", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 27, null, new DateOnly(2022, 12, 22), 178296.17f, 434632.16f },
                    { 65, "4415539603800", "The Football Is Good For Training And Recreational Purposes", null, 65, null, new DateOnly(2022, 6, 19), 320643.5f, 419360.47f },
                    { 66, "7962391087851", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, 27, null, new DateOnly(2023, 2, 12), 497041.12f, 469669.7f },
                    { 67, "4327104235739", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 30, null, new DateOnly(2023, 1, 6), 368709.44f, 429799.34f },
                    { 68, "5222527272523", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 71, null, new DateOnly(2023, 3, 7), 381005.47f, 246992.06f },
                    { 69, "8395081699475", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 35, null, new DateOnly(2023, 2, 13), 184598.19f, 234810.9f },
                    { 70, "4887140386562", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 64, null, new DateOnly(2023, 3, 19), 344781.66f, 465121.53f },
                    { 71, "7699380696922", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 1, null, new DateOnly(2023, 3, 23), 103711.984f, 195699.89f },
                    { 72, "9137314710217", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 42, null, new DateOnly(2022, 10, 4), 187518.11f, 477524.5f },
                    { 73, "9669591365304", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 65, null, new DateOnly(2022, 10, 28), 228003.89f, 205723.22f },
                    { 74, "8552630009738", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 20, null, new DateOnly(2023, 2, 28), 487503.72f, 267362.34f },
                    { 75, "7509530831960", "The Football Is Good For Training And Recreational Purposes", null, 9, null, new DateOnly(2022, 12, 15), 389760.75f, 480385.34f },
                    { 76, "1885247467002", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 70, null, new DateOnly(2022, 8, 16), 464227.9f, 225619.55f },
                    { 77, "1698949215426", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 59, null, new DateOnly(2022, 10, 23), 439424.8f, 218717.8f },
                    { 78, "2745678355394", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 38, null, new DateOnly(2022, 7, 12), 233427.17f, 110234.49f },
                    { 79, "3668649674043", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 13, null, new DateOnly(2022, 8, 13), 247170.16f, 250539.6f },
                    { 80, "6036488023136", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 30, null, new DateOnly(2022, 8, 31), 364600.38f, 385085.12f },
                    { 81, "8300971156501", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 56, null, new DateOnly(2023, 4, 11), 254107.81f, 394588.8f },
                    { 82, "1564589395012", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 59, null, new DateOnly(2022, 10, 22), 244911.25f, 365366.53f },
                    { 83, "9537091586805", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 78, null, new DateOnly(2023, 4, 29), 216754.9f, 282395.6f },
                    { 84, "9237591943961", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 30, null, new DateOnly(2022, 12, 15), 372313.9f, 100516.195f },
                    { 85, "1113477543754", "The Football Is Good For Training And Recreational Purposes", null, 25, null, new DateOnly(2022, 8, 28), 127585.84f, 398315.06f },
                    { 86, "6576957961182", "The Football Is Good For Training And Recreational Purposes", null, 6, null, new DateOnly(2022, 12, 6), 391755.4f, 391702.47f },
                    { 87, "5296624811848", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 76, null, new DateOnly(2022, 12, 15), 383395.8f, 380972.5f },
                    { 88, "0297645456792", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 20, null, new DateOnly(2023, 4, 20), 289907.47f, 336850.2f },
                    { 89, "2092489655053", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 71, null, new DateOnly(2023, 4, 19), 155890.72f, 152749.56f },
                    { 90, "6607802363537", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 28, null, new DateOnly(2022, 8, 11), 418779.88f, 195461.3f },
                    { 91, "9890040516392", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 35, null, new DateOnly(2022, 9, 7), 364576.75f, 490972.56f },
                    { 92, "1701655635362", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 17, null, new DateOnly(2022, 11, 3), 148851.11f, 117615.87f },
                    { 93, "9671783812312", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 42, null, new DateOnly(2023, 4, 22), 465691.97f, 369614.6f },
                    { 94, "9537104587591", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 78, null, new DateOnly(2022, 10, 10), 193629.31f, 399745f },
                    { 95, "2057355277326", "The Football Is Good For Training And Recreational Purposes", null, 52, null, new DateOnly(2022, 11, 17), 337105.38f, 262490.9f },
                    { 96, "0755111526252", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 45, null, new DateOnly(2023, 2, 17), 209649.06f, 342042.97f },
                    { 97, "3677019446104", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, 48, null, new DateOnly(2022, 10, 28), 458134.3f, 336015.16f },
                    { 98, "7306321338345", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 39, null, new DateOnly(2023, 2, 24), 469664.22f, 265487.4f },
                    { 99, "6600733469309", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 16, null, new DateOnly(2022, 12, 18), 415387.1f, 126113.88f },
                    { 100, "0953484318591", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 18, null, new DateOnly(2022, 11, 27), 174121.28f, 271548.62f }
                });

            migrationBuilder.InsertData(
                table: "recepcionists",
                columns: new[] { "id", "address", "email", "name", "phone", "salary", "surname", "userid" },
                values: new object[,]
                {
                    { 1, "Joyería, Kids & Hogar", "Gustavo66@nearbpo.com", "Gustavo", "5987-726-540", 3986367.2f, "Mojica", null },
                    { 2, "Ordenadores & Zapatos", "Sofia.Franco55@corpfolder.com", "Sofia", "566.905.783", 4663370f, "Franco", null },
                    { 3, "Herramientas & Hogar", "MariadelosAngeles.Matias8@nearbpo.com", "María de los Ángeles", "596 478 132", 2455850.8f, "Matías", null },
                    { 4, "Zapatos, Joyería & Aire libre", "JuanCarlos.Peres@gmail.com", "Juan Carlos", "588 211 660", 1490025.5f, "Peres", null },
                    { 5, "Hogar, Deportes & Aire libre", "Octavio_Chapa81@nearbpo.com", "Octavio", "537 624 267", 2124316f, "Chapa", null },
                    { 6, "Baby", "Fernando35@gmail.com", "Fernando", "5985-354-326", 2917644f, "Alemán", null },
                    { 7, "Películas & Industrial", "MarcoAntonio_Chavez@hotmail.com", "Marco Antonio", "5458-311-735", 4784942.5f, "Chávez", null },
                    { 8, "Libros", "Ester_Zayas98@nearbpo.com", "Ester", "559.264.415", 2319188.2f, "Zayas", null },
                    { 9, "Hogar & Jardín", "Gerardo53@nearbpo.com", "Gerardo", "563225569", 3451192.5f, "Kara", null },
                    { 10, "Jardín", "Nicolas13@hotmail.com", "Nicolás", "5609-186-383", 2487995f, "Arce", null },
                    { 11, "Salud, Ropa & Electrónica", "Horacio_Nieves19@hotmail.com", "Horacio", "5536-429-188", 4308990f, "Nieves", null },
                    { 12, "Herramientas, Baby & Automoción", "JoseAntonio_Baca@yahoo.com", "José Antonio", "519 954 058", 1662305.5f, "Baca", null },
                    { 13, "Ropa", "Elias_Herrera@nearbpo.com", "Elías", "5244-528-746", 4148113.5f, "Herrera", null },
                    { 14, "Automoción & Jardín", "Camila76@nearbpo.com", "Camila", "505 101 572", 1692025.1f, "Munguía", null },
                    { 15, "Películas & Música", "Estefania2@gmail.com", "Estefanía", "5535-436-654", 2521062f, "Gollum", null },
                    { 16, "Ordenadores", "JorgeLuis.Olivo@hotmail.com", "Jorge Luis", "525 979 969", 3042234.8f, "Olivo", null },
                    { 17, "Electrónica & Automoción", "Melissa46@yahoo.com", "Melissa", "517.840.244", 4998219.5f, "Alva", null },
                    { 18, "Juguetes & Aire libre", "Catalina.Olmos@gmail.com", "Catalina", "532455425", 2660706.8f, "Olmos", null },
                    { 19, "Zapatos", "Amalia74@nearbpo.com", "Amalia", "580.591.109", 1402830.8f, "Abrego", null },
                    { 20, "Belleza", "Barbara79@yahoo.com", "Barbara", "5129-385-679", 2193154f, "Lira", null },
                    { 21, "Ultramarinos & Ropa", "JuanCarlos23@hotmail.com", "Juan Carlos", "589930030", 1697629.6f, "Caraballo", null },
                    { 22, "Industrial, Joyería & Herramientas", "Diego.Rodrigez@hotmail.com", "Diego", "584.826.106", 4196189f, "Rodrígez", null },
                    { 23, "Joyería, Kids & Baby", "Blanca52@corpfolder.com", "Blanca", "5864-893-642", 4410290f, "Rodríquez", null },
                    { 24, "Ropa", "Bernardo.Rosales@yahoo.com", "Bernardo", "572 278 876", 1469616.5f, "Rosales", null },
                    { 25, "Juegos, Kids & Ordenadores", "Maria.Cotto@nearbpo.com", "María", "5110-827-900", 3418139.8f, "Cotto", null },
                    { 26, "Ropa & Salud", "Anita_Hinojosa@corpfolder.com", "Anita", "566 956 129", 2595591f, "Hinojosa", null },
                    { 27, "Jardín", "Leonardo_Huixtlacatl91@gmail.com", "Leonardo", "574596305", 4626948.5f, "Huixtlacatl", null },
                    { 28, "Automoción", "Uriel41@yahoo.com", "Uriel", "535 659 445", 4891888.5f, "Alcántar", null },
                    { 29, "Herramientas, Hogar & Películas", "Ricardo.Rodarte@gmail.com", "Ricardo", "501329364", 2215073.2f, "Rodarte", null },
                    { 30, "Aire libre", "Melissa96@yahoo.com", "Melissa", "5605-459-621", 2463870f, "Griego", null },
                    { 31, "Deportes, Ropa & Kids", "Tadeo.Tejada@nearbpo.com", "Tadeo", "5125-911-695", 3921781f, "Tejada", null },
                    { 32, "Música", "German46@hotmail.com", "Germán", "5660-522-042", 1686825.8f, "Esparza", null },
                    { 33, "Ordenadores", "Damian27@gmail.com", "Damián", "5436-215-154", 4278788f, "Huerta", null },
                    { 34, "Automoción & Ropa", "Adela64@yahoo.com", "Adela", "516282519", 2897629.5f, "Valdez", null },
                    { 35, "Electrónica", "Elizabeth_Marrero@nearbpo.com", "Elizabeth", "534 998 629", 3667381.2f, "Marrero", null },
                    { 36, "Kids, Música & Deportes", "Estela.Alanis39@corpfolder.com", "Estela", "509 225 639", 4490844f, "Alanis", null },
                    { 37, "Música, Herramientas & Electrónica", "Pablo40@corpfolder.com", "Pablo", "573 339 911", 1450927.6f, "Tapia", null },
                    { 38, "Automoción, Automoción & Música", "Jazmin40@hotmail.com", "Jazmin", "5311-839-588", 1308487.2f, "Piña", null },
                    { 39, "Ultramarinos, Automoción & Salud", "Regina92@hotmail.com", "Regina", "514.687.714", 1113206.2f, "Alcaraz", null },
                    { 40, "Salud", "MariaFernanda_Xiana69@gmail.com", "María Fernanda", "587.882.745", 3410635.8f, "Xiana", null },
                    { 41, "Deportes", "Alfonso_Abeyta75@yahoo.com", "Alfonso", "590.828.068", 4864008.5f, "Abeyta", null },
                    { 42, "Ropa, Ultramarinos & Ordenadores", "Jazmin_Serrato78@hotmail.com", "Jazmin", "5521-315-345", 1249692.8f, "Serrato", null },
                    { 43, "Aire libre", "Juana_Pedraza13@yahoo.com", "Juana", "543 478 029", 2247419.5f, "Pedraza", null },
                    { 44, "Kids & Deportes", "Julia_Carbajal@nearbpo.com", "Julia", "515.089.942", 2373429.8f, "Carbajal", null },
                    { 45, "Libros", "Irene25@yahoo.com", "Irene", "591.283.799", 1264276.6f, "Téllez", null },
                    { 46, "Ordenadores & Música", "Pedro_Koenig19@nearbpo.com", "Pedro", "5979-552-132", 1263134.5f, "Koenig", null },
                    { 47, "Jardín & Automoción", "Isaac.Tijerina@corpfolder.com", "Isaac", "513 564 667", 2238909.5f, "Tijerina", null },
                    { 48, "Películas, Industrial & Joyería", "Marilu4@nearbpo.com", "Marilu", "512336998", 2934725.5f, "Rosado", null },
                    { 49, "Deportes, Ropa & Hogar", "Lucia17@hotmail.com", "Lucia", "5223-921-432", 1475023.4f, "Fernández", null },
                    { 50, "Jardín & Deportes", "Laura49@hotmail.com", "Laura", "5270-551-491", 1546834.8f, "Rincón", null },
                    { 51, "Herramientas & Industrial", "Juan91@yahoo.com", "Juan", "520.611.212", 1128771.9f, "Abeyta", null },
                    { 52, "Industrial, Kids & Ordenadores", "Mayte62@nearbpo.com", "Mayte", "563 410 366", 3507226f, "Juárez", null },
                    { 53, "Kids", "Alexa_Pedraza@nearbpo.com", "Alexa", "597.054.717", 2731992.2f, "Pedraza", null },
                    { 54, "Electrónica", "Concepcion_Urias43@gmail.com", "Concepción", "557 317 507", 3020056.8f, "Urías", null },
                    { 55, "Ropa & Ordenadores", "Guillermo.Lovato65@yahoo.com", "Guillermo", "553228441", 1911697.4f, "Lovato", null },
                    { 56, "Música, Joyería & Automoción", "Margarita.Zabaleta9@gmail.com", "Margarita", "573283939", 4140280.2f, "Zabaleta", null },
                    { 57, "Joyería & Ordenadores", "Camila_Arellano@corpfolder.com", "Camila", "5947-639-534", 1617136.6f, "Arellano", null },
                    { 58, "Baby & Películas", "Matias.Madrigal3@gmail.com", "Matías", "5938-777-390", 1582939.4f, "Madrigal", null },
                    { 59, "Deportes", "Kimberly38@yahoo.com", "Kimberly", "549802686", 1063234.2f, "Porras", null },
                    { 60, "Baby & Automoción", "Federico.Hernadez@corpfolder.com", "Federico", "531570941", 1865008.6f, "Hernádez", null },
                    { 61, "Zapatos, Libros & Industrial", "Isaac.Barreto82@nearbpo.com", "Isaac", "559 013 108", 1268106.2f, "Barreto", null },
                    { 62, "Salud", "JulioCesar.Lira68@gmail.com", "Julio César", "5238-639-863", 3665093.8f, "Lira", null },
                    { 63, "Hogar", "Fernando58@corpfolder.com", "Fernando", "5850-211-502", 1692153.1f, "Granado", null },
                    { 64, "Juguetes, Automoción & Baby", "Carolina83@gmail.com", "Carolina", "505.504.918", 2523758.8f, "Enríquez", null },
                    { 65, "Juguetes", "Elena.Nevarez@nearbpo.com", "Elena", "533 568 682", 1021575.6f, "Nevárez", null },
                    { 66, "Aire libre", "Maricarmen66@hotmail.com", "Maricarmen", "585 403 240", 1963263.6f, "Dávila", null },
                    { 67, "Ropa", "Alicia49@yahoo.com", "Alicia", "589 824 216", 3269598.2f, "Villareal", null },
                    { 68, "Baby, Ultramarinos & Automoción", "Aaron69@nearbpo.com", "Aarón", "533.633.101", 1246243.8f, "Frías", null },
                    { 69, "Herramientas & Automoción", "Jesus_Alonso76@yahoo.com", "Jesús", "525 609 970", 1048907.5f, "Alonso", null },
                    { 70, "Juegos, Música & Ordenadores", "Timoteo.Uribe@nearbpo.com", "Timoteo", "562032730", 3451462f, "Uribe", null },
                    { 71, "Juegos, Zapatos & Jardín", "VictorManuel26@corpfolder.com", "Victor Manuel", "591 533 783", 1645462.1f, "Corrales", null },
                    { 72, "Juegos", "Ariadna.Valdez@gmail.com", "Ariadna", "5824-335-633", 2164867.8f, "Valdez", null },
                    { 73, "Industrial, Jardín & Kids", "Brandon.Guevara24@yahoo.com", "Brandon", "5530-565-552", 4380267.5f, "Guevara", null },
                    { 74, "Juguetes & Ropa", "Elvira_Santacruz@corpfolder.com", "Elvira", "5476-251-061", 1689861f, "Santacruz", null },
                    { 75, "Libros", "Evelyn.Colon@corpfolder.com", "Evelyn", "588 444 443", 1436302.9f, "Colón", null },
                    { 76, "Juegos", "Julia.Palacios@gmail.com", "Julia", "558.659.690", 4614473.5f, "Palacios", null },
                    { 77, "Automoción & Jardín", "JuanCarlos93@nearbpo.com", "Juan Carlos", "549156907", 2874184f, "Alonso", null },
                    { 78, "Belleza, Automoción & Ropa", "Anita_Suarez@hotmail.com", "Anita", "5016-720-711", 3897367f, "Suárez", null },
                    { 79, "Hogar, Industrial & Juguetes", "Carolina.Yanez6@hotmail.com", "Carolina", "582 728 264", 2824178f, "Yáñez", null },
                    { 80, "Ropa", "Monica_Urena35@yahoo.com", "Mónica", "5856-926-896", 2172587f, "Ureña", null },
                    { 81, "Películas & Películas", "Ignacio.Partida@yahoo.com", "Ignacio", "509219007", 4470399f, "Partida", null },
                    { 82, "Jardín, Belleza & Aire libre", "DulceMaria.Mireles56@corpfolder.com", "Dulce María", "517.665.706", 3908630.5f, "Mireles", null },
                    { 83, "Películas, Belleza & Deportes", "Cristian.Valle@yahoo.com", "Cristian", "573843778", 4251300.5f, "Valle", null },
                    { 84, "Zapatos, Electrónica & Juguetes", "Araceli_Barreto@hotmail.com", "Araceli", "592572920", 2812464.2f, "Barreto", null },
                    { 85, "Salud & Juguetes", "Nicole_Godinez@hotmail.com", "Nicole", "536705309", 1303102.4f, "Godínez", null },
                    { 86, "Juegos & Jardín", "Manuel_Cepeda@nearbpo.com", "Manuel", "557 145 421", 2980823.5f, "Cepeda", null },
                    { 87, "Automoción, Joyería & Juegos", "Luis_Olivo@yahoo.com", "Luis", "592 106 444", 1893869.1f, "Olivo", null },
                    { 88, "Electrónica", "Margarita_Patino@gmail.com", "Margarita", "535.464.610", 2952726.8f, "Patiño", null },
                    { 89, "Zapatos", "JorgeLuis.Valle72@yahoo.com", "Jorge Luis", "580.768.256", 3884234f, "Valle", null },
                    { 90, "Películas & Juegos", "Elizabeth.Agosto@nearbpo.com", "Elizabeth", "525.475.838", 1638446.6f, "Agosto", null },
                    { 91, "Industrial, Hogar & Ultramarinos", "Ivan_Montes14@nearbpo.com", "Ivan", "5966-191-315", 2184953.5f, "Montes", null },
                    { 92, "Kids, Herramientas & Hogar", "Juana4@hotmail.com", "Juana", "590373790", 3757756.2f, "Guajardo", null },
                    { 93, "Aire libre", "Mercedes.Razo73@yahoo.com", "Mercedes", "557.182.737", 1611900f, "Razo", null },
                    { 94, "Herramientas & Ordenadores", "Abril47@gmail.com", "Abril", "553 943 398", 1842727.4f, "Campos", null },
                    { 95, "Juguetes & Ropa", "Claudia_Hinojosa89@hotmail.com", "Claudia", "5760-894-406", 4494981f, "Hinojosa", null },
                    { 96, "Libros", "MariaFernanda_Rascon@gmail.com", "María Fernanda", "521 780 842", 1100840f, "Rascón", null },
                    { 97, "Electrónica", "Elizabeth.Teran@gmail.com", "Elizabeth", "5224-030-845", 2227641.5f, "Terán", null },
                    { 98, "Baby", "Clara_Saldana@hotmail.com", "Clara", "525.739.627", 4134538.2f, "Saldaña", null },
                    { 99, "Industrial & Ultramarinos", "Guadalupe22@gmail.com", "Guadalupe", "521.051.460", 4611482.5f, "Mesa", null },
                    { 100, "Películas, Joyería & Ultramarinos", "Cristina.Bravo72@gmail.com", "Cristina", "507 528 176", 1971529.1f, "Bravo", null }
                });

            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "id", "type" },
                values: new object[,]
                {
                    { 1, "Clientes" },
                    { 2, "Clientes" },
                    { 3, "Nómina" },
                    { 4, "Nómina" },
                    { 5, "Vehiculos" },
                    { 6, "Clientes" },
                    { 7, "Inventario" },
                    { 8, "Inventario" },
                    { 9, "Nómina" },
                    { 10, "Vehiculos" },
                    { 11, "Vehiculos" },
                    { 12, "Nómina" },
                    { 13, "Nómina" },
                    { 14, "Vehiculos" },
                    { 15, "Clientes" },
                    { 16, "Nómina" },
                    { 17, "Nómina" },
                    { 18, "Nómina" },
                    { 19, "Inventario" },
                    { 20, "Vehiculos" },
                    { 21, "Clientes" },
                    { 22, "Vehiculos" },
                    { 23, "Nómina" },
                    { 24, "Nómina" },
                    { 25, "Inventario" },
                    { 26, "Clientes" },
                    { 27, "Clientes" },
                    { 28, "Clientes" },
                    { 29, "Nómina" },
                    { 30, "Clientes" },
                    { 31, "Nómina" },
                    { 32, "Clientes" },
                    { 33, "Inventario" },
                    { 34, "Clientes" },
                    { 35, "Clientes" },
                    { 36, "Vehiculos" },
                    { 37, "Clientes" },
                    { 38, "Clientes" },
                    { 39, "Vehiculos" },
                    { 40, "Vehiculos" },
                    { 41, "Inventario" },
                    { 42, "Nómina" },
                    { 43, "Clientes" },
                    { 44, "Vehiculos" },
                    { 45, "Nómina" },
                    { 46, "Clientes" },
                    { 47, "Inventario" },
                    { 48, "Clientes" },
                    { 49, "Clientes" },
                    { 50, "Vehiculos" },
                    { 51, "Clientes" },
                    { 52, "Vehiculos" },
                    { 53, "Nómina" },
                    { 54, "Nómina" },
                    { 55, "Nómina" },
                    { 56, "Nómina" },
                    { 57, "Vehiculos" },
                    { 58, "Clientes" },
                    { 59, "Nómina" },
                    { 60, "Clientes" },
                    { 61, "Nómina" },
                    { 62, "Nómina" },
                    { 63, "Vehiculos" },
                    { 64, "Clientes" },
                    { 65, "Inventario" },
                    { 66, "Inventario" },
                    { 67, "Inventario" },
                    { 68, "Nómina" },
                    { 69, "Nómina" },
                    { 70, "Inventario" },
                    { 71, "Nómina" },
                    { 72, "Clientes" },
                    { 73, "Vehiculos" },
                    { 74, "Clientes" },
                    { 75, "Inventario" },
                    { 76, "Clientes" },
                    { 77, "Clientes" },
                    { 78, "Clientes" },
                    { 79, "Clientes" },
                    { 80, "Nómina" },
                    { 81, "Vehiculos" },
                    { 82, "Vehiculos" },
                    { 83, "Nómina" },
                    { 84, "Inventario" },
                    { 85, "Nómina" },
                    { 86, "Nómina" },
                    { 87, "Vehiculos" },
                    { 88, "Inventario" },
                    { 89, "Clientes" },
                    { 90, "Vehiculos" },
                    { 91, "Clientes" },
                    { 92, "Inventario" },
                    { 93, "Clientes" },
                    { 94, "Nómina" },
                    { 95, "Clientes" },
                    { 96, "Vehiculos" },
                    { 97, "Vehiculos" },
                    { 98, "Inventario" },
                    { 99, "Inventario" },
                    { 100, "Inventario" }
                });

            migrationBuilder.InsertData(
                table: "services",
                columns: new[] { "id", "category", "description", "name", "price" },
                values: new object[,]
                {
                    { 1, "Abacería", "Cencerril Gemíparo Cencerra Incordio Geminado.", "Abadí", 35.990000000000002 },
                    { 2, "Generalato", "Engarberar Generador Fice Engarfiar Descepar.", "Incremento", 87.049999999999997 },
                    { 3, "Ceneque", "Engarfiar Descentralización Abad Abajeño Increíble.", "Descerar", 574.14999999999998 },
                    { 4, "Engarrafador", "Gemológico Abad Cencerro Abaco Cencerrillas.", "Gemiquear", 480.94 },
                    { 5, "Engarzadura", "Cenagar Incorruptamente Incorporeidad Geminación Batallar.", "Descimbrar", 648.27999999999997 },
                    { 6, "Increíblemente", "Batán Bataola Engarfiar Incorrecto Cenceñada.", "Basural", 623.51999999999998 },
                    { 7, "Engargantadura", "Ficha Bata Bátavo Gemiqueo Abadejo.", "Batallón", 461.69 },
                    { 8, "Descimbrar", "Descerezar Engargolado Batallola Cencerreo Bateaguas.", "Cencerrón", 935.32000000000005 },
                    { 9, "Batazo", "Descentrar Incorporo Engarronar Batatazo Engaste.", "Cenata", 105.33 },
                    { 10, "Abadernar", "Incorrectamente Cenceño Cencapa Cenal Incorpóreo.", "Abadengo", 430.38999999999999 },
                    { 11, "Bateador", "Incruento Ficha Cenca Fichero Cendradilla.", "Descervigamiento", 306.77999999999997 },
                    { 12, "Fideo", "Incorrección Cenal Abadejo Gemoso Gemiqueo.", "Abalaustrado", 705.82000000000005 },
                    { 13, "Descerebrado", "Descensión Batea Bateaguas Cenceñada Descentralizar.", "Cencerrada", 878.95000000000005 },
                    { 14, "Cenaoscuras", "Generalidad Engarrotar Basura Bataola Incrédulamente.", "Basura", 746.65999999999997 },
                    { 15, "Cendrazo", "Ficha Engaste Abacería Cendradilla Gemológico.", "Engargolado", 175.83000000000001 },
                    { 16, "Engarzadura", "Batalla Ficha Desceñir Deschuponar Generalato.", "Ceñar", 361.17000000000002 },
                    { 17, "Descharchar", "Cencerra Descerrumarse Descerezar Batacazo Cencuate.", "Bata", 893.42999999999995 },
                    { 18, "Engastadura", "Bastonazo Fidedigno Fideicomisario Gemonias Cenaoscuras.", "Incorruptible", 494.69999999999999 },
                    { 19, "Incorrección", "Bastoncillo Desciframiento Engarronar Cencivera Descerrar.", "Engaritar", 93.609999999999999 },
                    { 20, "Cendal", "Incriminar Deschapar Abacorar Descimbrar Batallón.", "Abacería", 53.539999999999999 },
                    { 21, "Cencío", "Abad Géminis Abadiado Engarmarse Genealogista.", "Fice", 921.46000000000004 },
                    { 22, "Abaldonadamente", "Bástulo Descerezar Fichero Cenero Batallón.", "Fideicomiso", 423.06999999999999 },
                    { 23, "Incorregible", "Bastonear Cendrazo Batán Céndea Cenceñada.", "Fichaje", 169.44 },
                    { 24, "Incriminación", "Engaste Desciframiento Cencero Geminado Incredulidad.", "Bastonada", 220.80000000000001 },
                    { 25, "Batallón", "Engarzar Genealógico Descifre Incruentamente Cenco.", "Cendalí", 916.20000000000005 },
                    { 26, "Incorrecto", "Abad Bataola Abajadero Incorporalmente Cendolilla.", "Incruento", 161.83000000000001 },
                    { 27, "Batallar", "Céndea Batallola Genealógico Batahola Incorrupción.", "Engargolado", 915.90999999999997 },
                    { 28, "Generalato", "Generala Abajadero Engargantar Increíble Basurear.", "Abadí", 555.44000000000005 },
                    { 29, "Fiducia", "Ceñar Geminar Incorporo Fidelísimo Engarro.", "Engarrafador", 308.13 },
                    { 30, "Incrementar", "Descerebrado Abaldonamiento Abajamiento Cencerreo Batanar.", "Engarronar", 189.11000000000001 },
                    { 31, "Abalanzar", "Descerebración Engasgarse Cencerra Batanear Engarbullar.", "Deschapar", 640.20000000000005 },
                    { 32, "Engaste", "Descercado Engastar Abacalero Incredibilidad Genealogía.", "Engarmarse", 879.30999999999995 },
                    { 33, "Cendrar", "Cencerra Abalaustrado Fidalgo Abadejo Ficción.", "Bástulo", 42.759999999999998 },
                    { 34, "Incorporo", "Fidedigno Batayola Cencerril Abajeño Gemiqueo.", "Gemíparo", 533.07000000000005 },
                    { 35, "Cencido", "Fideo Abadí Abadiado Incremento Engarro.", "Engarrafar", 333.76999999999998 },
                    { 36, "Gemonias", "Fiducia Increado Fideo Engastadura Gendarmería.", "Descercar", 847.03999999999996 },
                    { 37, "Descifre", "Batallar Incorporeidad Gemológico Cencido Cencerro.", "Engargantadura", 662.38999999999999 },
                    { 38, "Gencianeo", "Incorrupción Ceñar Engastador Increpación Cendolilla.", "Incorrecto", 429.04000000000002 },
                    { 39, "Increíblemente", "Cencero Descerar Incorrecto Batacazo Fidelidad.", "Abaldonadamente", 928.88999999999999 },
                    { 40, "Genearca", "Incorrupto Géminis Engargantar Abajo Cenagoso.", "Descercado", 56.93 },
                    { 41, "Abada", "Engargantar Descerezar Descervigamiento Engaritar Cencivera.", "Batalloso", 986.02999999999997 },
                    { 42, "Batayola", "Abajadero Cencerrear Batanar Descercar Descifrable.", "Cendal", 570.42999999999995 },
                    { 43, "Descentralizar", "Descerebrado Engasgarse Incriminar Descimbrar Batalán.", "Géminis", 925.14999999999998 },
                    { 44, "Abadesa", "Engargante Geneático Increpar General Gemólogo.", "Batanear", 17.920000000000002 },
                    { 45, "Bástulo", "Batacazo Cencellada Géminis Abaldonamiento Increíblemente.", "Incordio", 205.94999999999999 },
                    { 46, "Descercar", "Abadengo Fidedigno Abajadero Engarnio Ficción.", "Bastoncillo", 725.00999999999999 },
                    { 47, "Gemológico", "Cendrada Engastador Increíble Cenceñada Incorregibilidad.", "Incorrupto", 39.270000000000003 },
                    { 48, "Geneático", "Bastoncillo Geneático Cencivera Engastar Incorrectamente.", "Fidelidad", 406.95999999999998 },
                    { 49, "Engaritar", "Engasgarse Geminado Incrédulo Incorruptamente Cenceño.", "Incorporo", 622.26999999999998 },
                    { 50, "Incorrupto", "Bastonear Gemiqueo Abadernar Abajeño Generable.", "Cenegar", 411.39999999999998 },
                    { 51, "Engasgarse", "Increpador Abajera Incruentamente Fideicomisario Geminado.", "Basurear", 892.86000000000001 },
                    { 52, "Cencerrada", "Abad Gemir Ceñar Incorrección Cencapa.", "Descifrable", 368.97000000000003 },
                    { 53, "Abadía", "Geminar Gemiquear Abajar Gémino Incremento.", "Engargante", 192.36000000000001 },
                    { 54, "Batalla", "Geminado Gendarme Cencerro Engargante Generalidad.", "Generación", 21.239999999999998 },
                    { 55, "Engarrotar", "Gemología Batayola Engarro Incorregiblemente Incorruptamente.", "Incredibilidad", 898.22000000000003 },
                    { 56, "Cencerreo", "Genciana Cencerrado Cencivera Incorrección Engarrotar.", "Engastadura", 619.44000000000005 },
                    { 57, "Incorrecto", "Abajeño Cendrar Engasgarse Descentralizar Fice.", "Batanar", 656.21000000000004 },
                    { 58, "Ficoideo", "Genealogista Engarzador Incriminar Batallón Abaldonamiento.", "Cendal", 926.25999999999999 },
                    { 59, "Cendradilla", "Bastonazo Geminar Cencerrear Abalar Cenal.", "Generalidad", 857.94000000000005 },
                    { 60, "Batalán", "Generala Engarzar Generala Bátavo Gendarmería.", "Genearca", 883.77999999999997 },
                    { 61, "Incorrupto", "Engarnio Basurear Increpación Descerco Cencero.", "Engarbullar", 474.72000000000003 },
                    { 62, "Deschavetado", "Incredulidad Generalato Engarzador Incrasar Geminar.", "Bátavo", 411.44 },
                    { 63, "Geneático", "Descepar Increado Incorruptible Engarce Generador.", "Incrementar", 739.88 },
                    { 64, "Batatazo", "Descentrado Gendarmería Engarzador Incorporación Cencha.", "Bastonear", 34.799999999999997 },
                    { 65, "Ficha", "Abad Batallaroso Batea Engastadura Incorruptible.", "Engasgarse", 671.47000000000003 },
                    { 66, "Engarbarse", "Increpar Abajar Desceñir Abalanzar Cenceñada.", "Batavia", 797.87 },
                    { 67, "Fichar", "Incredulidad Abajo Engastadura Basural Engarrafador.", "Abacora", 938.12 },
                    { 68, "Cenca", "Descentralización Fidelísimo Abajadero Incorpóreo Generalato.", "Cenagoso", 252.56 },
                    { 69, "Incorporal", "Abadí Batata Incorporación Abadiado Abajo.", "Increíble", 447.63 },
                    { 70, "Descerco", "Cenata Cendalí Cencerra Cencha Basurero.", "Increpar", 762.03999999999996 },
                    { 71, "Descerebración", "Genciana Gemólogo Incorrección Engarrar Increpar.", "Gemiqueo", 32.350000000000001 },
                    { 72, "Descerrajar", "Abadernar Incorregible Cenata Incorpóreo Cendradilla.", "Engarbullar", 554.38999999999999 },
                    { 73, "Incorporación", "Abadernar Abad Cenata Descifre Descerrumarse.", "Descentralización", 959.20000000000005 },
                    { 74, "Gendarmería", "Fideero Batata Cencha Batallona Batea.", "Descifre", 286.19 },
                    { 75, "Engarro", "Engarrotar Cenca Descerrumarse Engastadura Batalla.", "Cencapa", 827.49000000000001 },
                    { 76, "Ficoideo", "Descimbrar Cenca Ficha Incorregible Desceñir.", "Cendra", 716.13 },
                    { 77, "Batalloso", "Gémino Cencivera Bastonazo Cencuate Incorrupto.", "Cenceñada", 228.47999999999999 },
                    { 78, "Incremento", "Descifrable Ficha Deschavetarse Bátavo Incruento.", "Bateaguas", 939.80999999999995 },
                    { 79, "Incorruptibilidad", "Generalato Engasgarse Gemología Generalísimo Deschavetarse.", "Batea", 415.75 },
                    { 80, "Fideicomitente", "Generable Abajamiento Incrustación Batazo Batallar.", "Deschapar", 305.80000000000001 },
                    { 81, "Fideo", "Batazo Incorrectamente Abacorar Batazo Cendrada.", "Descercador", 644.10000000000002 },
                    { 82, "Generalísimo", "Engastar Generalidad Batanero Descerebrar Incorruptibilidad.", "Ceñar", 217.68000000000001 },
                    { 83, "Abadengo", "Generalísimo Batallona Gendarmería Bateaguas Engargolado.", "Incredulidad", 378.47000000000003 },
                    { 84, "Cendrada", "Batanear Bastonear Batatazo Engarrar Incorporeidad.", "Deschavetado", 356.80000000000001 },
                    { 85, "Incremento", "Cendra Descercado Gen Cencha Bastonear.", "Abajar", 747.19000000000005 },
                    { 86, "Fichar", "Descifre Abadí Incorrupto Descerrar Incorporar.", "Abacería", 91.430000000000007 },
                    { 87, "Engarberar", "Fideísmo Abacalero Generalidad Abajadero Engarnio.", "Cenceño", 302.56999999999999 },
                    { 88, "Abacería", "Engarzador Cencerril Generala Incorporo Engarnio.", "Gemoterapia", 871.40999999999997 },
                    { 89, "Engarrotar", "Engarbarse Engarro Fideo Batalloso Incorpóreo.", "Batavia", 958.82000000000005 },
                    { 90, "Descerrar", "Descercador Batalán Abajo Descerrar Gemíparo.", "Descharchar", 456.81 },
                    { 91, "Gemonias", "Gemoterapia Abadía Engargante Bastonear Bateador.", "Fiducia", 365.48000000000002 },
                    { 92, "Abadía", "Abacorar Batazo Cencerrada Deschavetado Incorporo.", "Fichero", 192.18000000000001 },
                    { 93, "Increíblemente", "Batahola Bastonazo Increpador Abadesa Abacero.", "Fidecomiso", 763.40999999999997 },
                    { 94, "Bata", "Fideicomiso Gemiqueo Descifre Cencerreo Cendradilla.", "Engargolado", 820.67999999999995 },
                    { 95, "Incorrecto", "Increíble Abada Cenefa Engarnio Engarrafar.", "Abadengo", 47.0 },
                    { 96, "Incorporalmente", "Abadía Bate Descharchar Bataola Cencapa.", "Batán", 627.78999999999996 },
                    { 97, "Incorporal", "Incorruptible Cencerrón Abaldonamiento Genciana Cenero.", "Descervigar", 536.61000000000001 },
                    { 98, "Fideicomitente", "Descerrajado Batalla Batallona Abajadero Abacora.", "Incriminación", 969.60000000000002 },
                    { 99, "Incorrupción", "Engarzador Incorpóreo Fidelidad Descerrajado Desciframiento.", "Incredibilidad", 265.70999999999998 },
                    { 100, "Basura", "Engarrar Gemonias Incorrupción Descerrar Abajo.", "Descercar", 984.07000000000005 }
                });

            migrationBuilder.InsertData(
                table: "suppliers",
                columns: new[] { "id", "address", "company", "email", "name", "nit", "phone", "surname" },
                values: new object[,]
                {
                    { 1, "Películas & Automoción", "Batalán", "Francisca_Macias@nearbpo.com", "Francisca", "180220950", "562 723 047", "Macías" },
                    { 2, "Electrónica", "Basural", "Benito55@gmail.com", "Benito", "223049611", "541.593.875", "Ávila" },
                    { 3, "Ropa", "Fideo", "Jaime88@yahoo.com", "Jaime", "256879664", "5533-040-985", "Cardenas" },
                    { 4, "Ultramarinos, Juegos & Jardín", "Bátavo", "Leonardo_Gil@gmail.com", "Leonardo", "207254842", "5590-076-523", "Gil" },
                    { 5, "Belleza, Belleza & Libros", "Fiducia", "Matias.Arteaga35@corpfolder.com", "Matías", "274288389", "5462-401-752", "Arteaga" },
                    { 6, "Ropa, Baby & Aire libre", "Deschavetarse", "Hugo.Garica18@corpfolder.com", "Hugo", "186394420", "559 689 967", "Garica" },
                    { 7, "Ultramarinos", "Incorregiblemente", "Cristobal.Quinonez64@hotmail.com", "Cristobal", "251240622", "581777457", "Quiñónez" },
                    { 8, "Automoción, Música & Joyería", "Deschuponar", "Conchita0@gmail.com", "Conchita", "276483693", "5670-523-142", "Haro" },
                    { 9, "Jardín & Salud", "Desceñir", "Magdalena.Delgado@gmail.com", "Magdalena", "108320480", "589.078.266", "Delgado" },
                    { 10, "Juegos, Aire libre & Automoción", "Abadiato", "Gustavo_Valverde@yahoo.com", "Gustavo", "287606708", "5716-484-850", "Valverde" },
                    { 11, "Aire libre, Belleza & Salud", "Descifre", "Gonzalo_Sisneros@corpfolder.com", "Gonzalo", "254229000", "558299189", "Sisneros" },
                    { 12, "Juguetes, Salud & Ordenadores", "Descerco", "Adela_Kortahernandez@gmail.com", "Adela", "234759038", "535.676.247", "Korta hernandez" },
                    { 13, "Libros, Juegos & Joyería", "Gemiquear", "Mauricio_Barrios10@corpfolder.com", "Mauricio", "217864015", "544396520", "Barrios" },
                    { 14, "Kids, Ropa & Kids", "Abad", "Cristina41@hotmail.com", "Cristina", "122451740", "547 926 903", "Grijalva" },
                    { 15, "Kids & Ultramarinos", "Geminación", "Patricio.Ybarra@corpfolder.com", "Patricio", "293793468", "595584808", "Ybarra" },
                    { 16, "Música, Música & Electrónica", "Descercado", "Miguel.Galvez49@yahoo.com", "Miguel", "270416790", "5837-963-601", "Gálvez" },
                    { 17, "Películas & Hogar", "Cenagoso", "Ramiro_Davila@hotmail.com", "Ramiro", "278223427", "579.695.080", "Dávila" },
                    { 18, "Películas", "Gemoso", "Ramon83@corpfolder.com", "Ramón", "164748512", "559 270 456", "Navarro" },
                    { 19, "Libros", "Generable", "Emilio.Pina@hotmail.com", "Emilio", "253818877", "540.347.986", "Piña" },
                    { 20, "Ultramarinos", "Batato", "Benito69@gmail.com", "Benito", "238393917", "510707740", "Razo" },
                    { 21, "Baby", "Incorporo", "Iker69@yahoo.com", "Iker", "227112873", "5757-248-686", "Nájera" },
                    { 22, "Electrónica", "Incrédulamente", "JoseMaria.Barrios@yahoo.com", "José María", "218658028", "598 325 598", "Barrios" },
                    { 23, "Automoción, Hogar & Zapatos", "Cencerrón", "Alicia29@hotmail.com", "Alicia", "220314047", "580.704.817", "Delacrúz" }
                });

            migrationBuilder.InsertData(
                table: "suppliers",
                columns: new[] { "id", "address", "company", "email", "name", "nit", "phone", "surname" },
                values: new object[,]
                {
                    { 24, "Hogar", "Gencianáceo", "Jorge56@nearbpo.com", "Jorge", "117465127", "578 787 921", "Águilar" },
                    { 25, "Hogar", "Incorrección", "Adela.Kranzsans@corpfolder.com", "Adela", "221572210", "525 123 594", "Kranz sans" },
                    { 26, "Juguetes, Industrial & Joyería", "Descercado", "Lucas_Sanchez99@yahoo.com", "Lucas", "157024393", "578913123", "Sánchez" },
                    { 27, "Joyería, Aire libre & Ultramarinos", "Incorporal", "MarcoAntonio_Quiroz@hotmail.com", "Marco Antonio", "241961920", "575.659.680", "Quiroz" },
                    { 28, "Juguetes, Películas & Salud", "Deschavetado", "MariaTeresa_Centeno@nearbpo.com", "María Teresa", "273599585", "536 010 593", "Centeno" },
                    { 29, "Industrial", "Cenceño", "Alexander.Villagomez75@corpfolder.com", "Alexander", "285663887", "5983-699-562", "Villagómez" },
                    { 30, "Ordenadores & Herramientas", "Fice", "Francisco_Cantu77@yahoo.com", "Francisco", "199105200", "5654-903-965", "Cantú" },
                    { 31, "Zapatos", "Engargolar", "Marilu_Porras@nearbpo.com", "Marilu", "273883119", "583.895.888", "Porras" },
                    { 32, "Libros, Hogar & Deportes", "Abaldonamiento", "Guillermo40@nearbpo.com", "Guillermo", "285609890", "531.822.028", "Terrazas" },
                    { 33, "Salud", "Cencerrada", "Alicia_Munoz@hotmail.com", "Alicia", "123821789", "562084826", "Muñoz" },
                    { 34, "Jardín, Aire libre & Automoción", "Cencerrear", "Caridad_Partida95@yahoo.com", "Caridad", "238971120", "547090242", "Partida" },
                    { 35, "Belleza", "Fidelidad", "Angela8@gmail.com", "Ángela", "147219981", "532 380 286", "Almonte" },
                    { 36, "Joyería, Baby & Ropa", "Gemológico", "Ruben_Posada92@hotmail.com", "Rubén", "286475189", "590734938", "Posada" },
                    { 37, "Jardín & Aire libre", "Cencerrón", "Emiliano15@gmail.com", "Emiliano", "260635103", "506 515 018", "Soto" },
                    { 38, "Industrial, Salud & Automoción", "General", "Clara.Valentin73@gmail.com", "Clara", "269108327", "545158524", "Valentín" },
                    { 39, "Aire libre, Joyería & Joyería", "Deschapar", "Pilar90@corpfolder.com", "Pilar", "225688123", "581.284.915", "Acosta" },
                    { 40, "Música", "Engarzar", "Agustin_Lebron15@yahoo.com", "Agustín", "263693007", "524140062", "Lebrón" },
                    { 41, "Juguetes & Hogar", "Batea", "Julia_Gamboa@nearbpo.com", "Julia", "296343250", "565.631.453", "Gamboa" },
                    { 42, "Jardín & Baby", "Abajera", "Carmen.Nieves@nearbpo.com", "Carmen", "202532780", "562 912 149", "Nieves" },
                    { 43, "Salud & Ropa", "Géminis", "Brandon66@hotmail.com", "Brandon", "117964085", "573 661 223", "Alejandro" },
                    { 44, "Juegos, Música & Libros", "Cenaoscuras", "Alan22@yahoo.com", "Alan", "102257477", "501.027.895", "Torres" },
                    { 45, "Herramientas", "Generalidad", "AnaLuisa96@hotmail.com", "Ana Luisa", "222992484", "540423121", "Kanimal" },
                    { 46, "Salud, Hogar & Herramientas", "Gemología", "Patricia.Dominquez41@nearbpo.com", "Patricia", "240904036", "5518-987-836", "Domínquez" },
                    { 47, "Zapatos", "Genealogista", "Cristian.Velez@hotmail.com", "Cristian", "218333820", "5244-606-727", "Vélez" },
                    { 48, "Ultramarinos & Películas", "Gencianeo", "Carolina_Ojeda@corpfolder.com", "Carolina", "215229878", "518 662 801", "Ojeda" },
                    { 49, "Herramientas, Salud & Juguetes", "Descerebrado", "Naomi92@hotmail.com", "Naomi", "261325604", "597.374.517", "Nieto" },
                    { 50, "Aire libre, Deportes & Juegos", "Descharchar", "Julieta.Olivares@gmail.com", "Julieta", "187894027", "556 467 505", "Olivares" },
                    { 51, "Automoción & Belleza", "Cendrado", "Ivanna_Pantoja9@corpfolder.com", "Ivanna", "203430212", "577433793", "Pantoja" },
                    { 52, "Juguetes & Juegos", "Descifre", "Carlota_Baca@gmail.com", "Carlota", "132611430", "5607-619-157", "Baca" },
                    { 53, "Zapatos, Salud & Kids", "Cencerrada", "Maximiliano66@nearbpo.com", "Maximiliano", "160408822", "554 523 468", "Naranjo" },
                    { 54, "Jardín", "Incorrupción", "Manuel_Aguirre4@nearbpo.com", "Manuel", "212849018", "567 332 553", "Aguirre" },
                    { 55, "Juguetes & Hogar", "Engarzadura", "Caridad_Kyra15@yahoo.com", "Caridad", "251347940", "586.997.509", "Kyra" },
                    { 56, "Herramientas, Hogar & Ordenadores", "Engargantadura", "Alberto.Patino@gmail.com", "Alberto", "136289991", "508541368", "Patiño" },
                    { 57, "Zapatos, Herramientas & Industrial", "Céndea", "Adriana61@hotmail.com", "Adriana", "150171030", "5539-603-965", "Nevárez" },
                    { 58, "Electrónica", "Géminis", "Daniel.Rocha@hotmail.com", "Daniel", "282128166", "5743-670-776", "Rocha" },
                    { 59, "Hogar", "Fideísmo", "Paulina_Chacon@nearbpo.com", "Paulina", "266502970", "5030-560-240", "Chacón" },
                    { 60, "Juegos", "Incruento", "Alfonso72@nearbpo.com", "Alfonso", "280917473", "5208-559-758", "Alvarado" },
                    { 61, "Baby", "Cenco", "AnaMaria_Kadarrodriguez39@yahoo.com", "Ana María", "288336950", "5832-901-587", "Kadar rodriguez" },
                    { 62, "Baby", "Desceñir", "Emilia_Centeno71@hotmail.com", "Emilia", "283544201", "525.238.520", "Centeno" },
                    { 63, "Hogar & Libros", "Descenso", "Guillermina.Manzanares@hotmail.com", "Guillermina", "190613734", "521.398.307", "Manzanares" },
                    { 64, "Música", "Bástulo", "Diego71@yahoo.com", "Diego", "244104166", "5430-800-843", "Olivera" },
                    { 65, "Películas & Baby", "Abalaustrado", "Emilio_Urbina31@corpfolder.com", "Emilio", "150727615", "535 787 748", "Urbina" },
                    { 66, "Herramientas, Aire libre & Automoción", "Cencerrear", "Mayte_Arredondo@gmail.com", "Mayte", "189421193", "5436-951-839", "Arredondo" },
                    { 67, "Electrónica", "Basural", "Conchita.Alonso36@hotmail.com", "Conchita", "216382246", "5285-756-283", "Alonso" },
                    { 68, "Hogar", "Incorporeidad", "Liliana60@yahoo.com", "Liliana", "227052722", "513 172 115", "Sandoval" },
                    { 69, "Películas", "Cencivera", "Yaretzi_Ozuna23@hotmail.com", "Yaretzi", "261990659", "519 806 914", "Ozuna" },
                    { 70, "Zapatos & Kids", "Batata", "Cesar_Padilla33@yahoo.com", "César", "235763896", "523.213.905", "Padilla" },
                    { 71, "Ropa", "Incorrupto", "Ernesto.Jiminez10@yahoo.com", "Ernesto", "216000351", "5222-167-772", "Jimínez" },
                    { 72, "Libros & Kids", "Cendra", "Daniel36@corpfolder.com", "Daniel", "183403886", "583 560 047", "Leal" },
                    { 73, "Juguetes", "Desceñir", "MariaGuadalupe_Rosas@hotmail.com", "María Guadalupe", "179322150", "575.802.024", "Rosas" },
                    { 74, "Baby, Salud & Aire libre", "Incorporeidad", "AnaMaria_Zamarripa@nearbpo.com", "Ana María", "156095734", "553 228 175", "Zamarripa" },
                    { 75, "Herramientas, Deportes & Automoción", "Cenagar", "Lucia52@corpfolder.com", "Lucia", "189268263", "592 967 816", "Rivera" },
                    { 76, "Belleza, Belleza & Hogar", "Incrasar", "Diego66@corpfolder.com", "Diego", "273862065", "527738126", "Rivas" },
                    { 77, "Automoción & Joyería", "Batallaroso", "Paola_Gaona82@hotmail.com", "Paola", "119368285", "534413752", "Gaona" },
                    { 78, "Ropa", "Fideicomitente", "Salvador32@corpfolder.com", "Salvador", "151901163", "562 084 351", "Karam" },
                    { 79, "Salud & Música", "Bastoncillo", "Valentina29@nearbpo.com", "Valentina", "242312543", "5678-679-225", "Cornejo" },
                    { 80, "Herramientas & Belleza", "Incredulidad", "Maximiliano_Samaniego53@corpfolder.com", "Maximiliano", "161451594", "583.945.633", "Samaniego" },
                    { 81, "Automoción", "Abacero", "Gustavo.Farias@yahoo.com", "Gustavo", "235619531", "5975-406-732", "Farías" },
                    { 82, "Herramientas, Ropa & Belleza", "Cenefa", "Barbara_Pena@hotmail.com", "Barbara", "147872057", "512899076", "Peña" },
                    { 83, "Salud, Salud & Automoción", "Deschavetado", "Gabriel_Burgos95@corpfolder.com", "Gabriel", "293098344", "548544041", "Burgos" },
                    { 84, "Automoción, Baby & Herramientas", "Batallar", "Maricarmen.Carrion@corpfolder.com", "Maricarmen", "242442358", "5879-413-539", "Carrion" },
                    { 85, "Libros", "Bastonear", "Jimena69@nearbpo.com", "Jimena", "232037701", "5606-091-548", "Viera" },
                    { 86, "Música", "Generalidad", "Cristobal_Naranjo@corpfolder.com", "Cristobal", "150153376", "5856-969-455", "Naranjo" },
                    { 87, "Industrial, Joyería & Jardín", "Bastonazo", "Norma.XairoBelmonte@gmail.com", "Norma", "110999061", "560380179", "Xairo Belmonte" },
                    { 88, "Hogar, Baby & Juegos", "Incorporación", "Gabriel_Solorzano6@yahoo.com", "Gabriel", "129466506", "5225-642-459", "Solorzano" },
                    { 89, "Hogar", "Increado", "Evelyn97@corpfolder.com", "Evelyn", "102014515", "5488-446-058", "Báez" },
                    { 90, "Baby & Deportes", "Incorporar", "Maricarmen_Ornelas@corpfolder.com", "Maricarmen", "251963110", "574.569.989", "Ornelas" },
                    { 91, "Kids, Joyería & Aire libre", "Engastadura", "Sergio.Ordonez@hotmail.com", "Sergio", "199629293", "582.816.322", "Ordóñez" },
                    { 92, "Juguetes & Aire libre", "Fichar", "Armando.Burgos@yahoo.com", "Armando", "214399265", "5778-839-236", "Burgos" },
                    { 93, "Automoción, Ropa & Electrónica", "Cencío", "Aaron.Pedraza83@hotmail.com", "Aarón", "229282148", "5179-655-314", "Pedraza" },
                    { 94, "Electrónica & Herramientas", "Abadiato", "Alfonso.Pacheco0@hotmail.com", "Alfonso", "147020867", "5235-571-285", "Pacheco" },
                    { 95, "Kids & Ordenadores", "Bastonear", "JoseEduardo_Valenzuela59@corpfolder.com", "José Eduardo", "195225368", "549152208", "Valenzuela" },
                    { 96, "Herramientas, Joyería & Juguetes", "Generacional", "Homero.Lugo68@corpfolder.com", "Homero", "138307024", "5250-116-673", "Lugo" },
                    { 97, "Ropa & Baby", "Incorpóreo", "Pablo82@gmail.com", "Pablo", "123219566", "592 200 134", "Garay" },
                    { 98, "Ordenadores, Industrial & Zapatos", "Incorporalmente", "AnaVictoria_Haro@yahoo.com", "Ana Victoria", "180616188", "5477-350-008", "Haro" },
                    { 99, "Automoción, Juguetes & Ultramarinos", "Fideicomisario", "Sergio.Rosas@hotmail.com", "Sergio", "208900888", "512045779", "Rosas" },
                    { 100, "Joyería", "Céndea", "VictorManuel51@gmail.com", "Victor Manuel", "290728495", "5449-480-183", "Montaño" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "password", "role" },
                values: new object[,]
                {
                    { 1, "JoseAntonio76@corpfolder.com", "Incrasar", "Administrator" },
                    { 2, "David31@hotmail.com", "Descerrajar", "Mechanic" },
                    { 3, "JoseDaniel_Coronado61@nearbpo.com", "Fidecomiso", "Administrator" },
                    { 4, "AnaSofia7@yahoo.com", "Descerrumarse", "Administrator" },
                    { 5, "Abril_Aranda96@hotmail.com", "Cenagar", "Administrator" },
                    { 6, "Cristian35@hotmail.com", "Basurear", "Recepcionist" },
                    { 7, "AnaLuisa_Lucio@hotmail.com", "Cendrazo", "Mechanic" },
                    { 8, "Leonor.Farias@gmail.com", "Batanear", "Recepcionist" },
                    { 9, "RosaMaria93@hotmail.com", "Engastadura", "Recepcionist" },
                    { 10, "Guillermo.Segovia32@gmail.com", "Batallaroso", "Administrator" },
                    { 11, "Fatima.Romo66@hotmail.com", "Basurear", "Recepcionist" },
                    { 12, "Elena25@yahoo.com", "Cendra", "Administrator" },
                    { 13, "Josefina_Morales73@corpfolder.com", "Increpador", "Mechanic" },
                    { 14, "Gabriel74@yahoo.com", "Cenca", "Administrator" },
                    { 15, "Graciela.Adorno@nearbpo.com", "Cendrado", "Recepcionist" },
                    { 16, "Marta18@nearbpo.com", "Abaldonamiento", "Mechanic" },
                    { 17, "Silvia_Xana61@yahoo.com", "Abajar", "Mechanic" },
                    { 18, "MiguelAngel65@gmail.com", "Cenceñada", "Recepcionist" },
                    { 19, "Magdalena.Zayas@yahoo.com", "Cencerril", "Recepcionist" },
                    { 20, "Zoe_Lovato@yahoo.com", "Cencerro", "Administrator" },
                    { 21, "Elizabeth.Baca@corpfolder.com", "Batallar", "Administrator" },
                    { 22, "Gael_Saavedra49@yahoo.com", "Engarronar", "Mechanic" },
                    { 23, "Regina38@hotmail.com", "Desciframiento", "Recepcionist" },
                    { 24, "Emilio_Saiz@yahoo.com", "Abadiado", "Mechanic" },
                    { 25, "Norma.Noriega@corpfolder.com", "Abadí", "Mechanic" },
                    { 26, "Guadalupe10@nearbpo.com", "Genealogía", "Administrator" },
                    { 27, "Alberto_Nevarez83@nearbpo.com", "Generacional", "Recepcionist" },
                    { 28, "Isaias87@yahoo.com", "Cencapa", "Recepcionist" },
                    { 29, "Alejandro_Lomeli@nearbpo.com", "Generacional", "Administrator" },
                    { 30, "JulioCesar10@corpfolder.com", "Cendrar", "Administrator" },
                    { 31, "Antonia_Urena72@nearbpo.com", "Incrustación", "Recepcionist" },
                    { 32, "Alexander55@yahoo.com", "Descepar", "Recepcionist" },
                    { 33, "David_Espinosa@gmail.com", "Genealogía", "Recepcionist" },
                    { 34, "Manuela_Flores11@nearbpo.com", "Incorregible", "Recepcionist" },
                    { 35, "Sonia.Baez@nearbpo.com", "Cendal", "Mechanic" },
                    { 36, "MiguelAngel0@yahoo.com", "Cencerrada", "Mechanic" },
                    { 37, "Laura63@yahoo.com", "Cenco", "Mechanic" },
                    { 38, "JoseAntonio.Mota1@gmail.com", "Fichero", "Administrator" },
                    { 39, "Leonor80@hotmail.com", "Incorregibilidad", "Administrator" },
                    { 40, "JoseMiguel_Cardenas4@gmail.com", "Incordio", "Recepcionist" },
                    { 41, "Armando56@hotmail.com", "Batatazo", "Recepcionist" },
                    { 42, "Ramona9@corpfolder.com", "Incorrupto", "Recepcionist" },
                    { 43, "Evelyn51@yahoo.com", "Engastadura", "Mechanic" },
                    { 44, "Adriana.Tellez@hotmail.com", "Deschavetado", "Recepcionist" },
                    { 45, "Alejandro.Cerda57@yahoo.com", "Batallador", "Administrator" },
                    { 46, "MariaSoledad34@corpfolder.com", "Basura", "Administrator" },
                    { 47, "Yolanda.Curiel26@gmail.com", "Cenefa", "Recepcionist" },
                    { 48, "Renata49@nearbpo.com", "Fice", "Administrator" },
                    { 49, "Leonardo62@nearbpo.com", "Cenegar", "Administrator" },
                    { 50, "Miguel.Tejada22@nearbpo.com", "Batalloso", "Recepcionist" },
                    { 51, "Vanessa_Zaragoza@corpfolder.com", "Cendra", "Recepcionist" },
                    { 52, "Ximena_Calvillo40@gmail.com", "Cencellada", "Mechanic" },
                    { 53, "Fatima.Guardado@hotmail.com", "Cencapa", "Mechanic" },
                    { 54, "Axel_Aranda5@corpfolder.com", "Abajar", "Mechanic" },
                    { 55, "MariadeJesus.Canales@corpfolder.com", "Incrédulamente", "Mechanic" },
                    { 56, "Elsa.Ornelas54@gmail.com", "Desciframiento", "Administrator" },
                    { 57, "Santiago_deAnda82@corpfolder.com", "Cencellada", "Recepcionist" },
                    { 58, "Leticia64@nearbpo.com", "Engarrotar", "Administrator" },
                    { 59, "Ramiro_Casarez72@yahoo.com", "Incorregiblemente", "Mechanic" },
                    { 60, "Francisco75@yahoo.com", "Descerrajadura", "Administrator" },
                    { 61, "Jazmin42@corpfolder.com", "Cenero", "Recepcionist" },
                    { 62, "Lilia.Zuniga@gmail.com", "Descenso", "Administrator" },
                    { 63, "AnaSofia.Perales13@nearbpo.com", "Cencío", "Mechanic" },
                    { 64, "JoseMaria_Lebron@nearbpo.com", "Ceneque", "Administrator" },
                    { 65, "Andrea19@corpfolder.com", "Gemir", "Recepcionist" },
                    { 66, "Marta.Benavidez79@nearbpo.com", "Engarbullar", "Recepcionist" },
                    { 67, "JoseAntonio48@gmail.com", "Cencivera", "Recepcionist" },
                    { 68, "Cesar36@corpfolder.com", "Gemonias", "Mechanic" },
                    { 69, "Manuela.Camarillo55@corpfolder.com", "Desciframiento", "Administrator" },
                    { 70, "Cristian.Rincon78@corpfolder.com", "Deschavetarse", "Mechanic" },
                    { 71, "Patricia.Delapaz28@corpfolder.com", "Abaco", "Mechanic" },
                    { 72, "Alexis84@yahoo.com", "Cenagar", "Administrator" },
                    { 73, "Nicole81@yahoo.com", "Bastonear", "Recepcionist" },
                    { 74, "Pedro.Jaimes31@nearbpo.com", "Abacalero", "Administrator" },
                    { 75, "JoseMiguel.Alvarez26@hotmail.com", "Cendra", "Mechanic" },
                    { 76, "Francisco.Galindo0@gmail.com", "Abacería", "Administrator" },
                    { 77, "Pedro.Menendez@nearbpo.com", "Cencapa", "Mechanic" },
                    { 78, "Juan.Agosto@gmail.com", "Gemonias", "Recepcionist" },
                    { 79, "Adela.Romero34@corpfolder.com", "Batallola", "Administrator" },
                    { 80, "Enrique.Gastelum38@corpfolder.com", "Deschuponar", "Mechanic" },
                    { 81, "Lorenzo79@yahoo.com", "Cenceño", "Recepcionist" },
                    { 82, "Mariano85@corpfolder.com", "Abad", "Mechanic" },
                    { 83, "DulceMaria_Jasso@yahoo.com", "Cendal", "Administrator" },
                    { 84, "Lorenzo90@gmail.com", "Cencerrear", "Mechanic" },
                    { 85, "Maximiliano_Kamal@yahoo.com", "Cenaoscuras", "Administrator" },
                    { 86, "Elena_Gallegos21@corpfolder.com", "Abaldonamiento", "Administrator" },
                    { 87, "Liliana_Vaca@corpfolder.com", "Gemir", "Administrator" },
                    { 88, "Marcos_Barreto@corpfolder.com", "Gen", "Administrator" },
                    { 89, "Juan27@nearbpo.com", "Gemíparo", "Administrator" },
                    { 90, "Abigail_Rojo@nearbpo.com", "Batallador", "Recepcionist" },
                    { 91, "Armando94@yahoo.com", "Ceneque", "Administrator" },
                    { 92, "Benito_Acuna@nearbpo.com", "Cencerril", "Recepcionist" },
                    { 93, "Bernardo.Tello94@corpfolder.com", "Cendrazo", "Administrator" },
                    { 94, "Guadalupe60@nearbpo.com", "Incorrupto", "Administrator" },
                    { 95, "Zoe.Valle@nearbpo.com", "Incorregibilidad", "Administrator" },
                    { 96, "Jacobo.Romo@corpfolder.com", "Descharchar", "Mechanic" },
                    { 97, "FernandoJavier43@nearbpo.com", "Abaldonamiento", "Recepcionist" },
                    { 98, "Monserrat.XairoBelmonte36@yahoo.com", "Batallaroso", "Administrator" },
                    { 99, "Elizabeth43@gmail.com", "Fideísmo", "Recepcionist" },
                    { 100, "Santiago.Bueno@yahoo.com", "Descerrajar", "Mechanic" }
                });

            migrationBuilder.InsertData(
                table: "requests",
                columns: new[] { "id", "client_id", "end_date", "service_id", "start_date", "state" },
                values: new object[,]
                {
                    { 1, null, new DateOnly(2022, 7, 21), 69, new DateOnly(2022, 8, 26), "Activo" },
                    { 2, null, new DateOnly(2022, 9, 11), 11, new DateOnly(2022, 8, 1), "Activo" },
                    { 3, null, new DateOnly(2023, 1, 26), 69, new DateOnly(2022, 7, 13), "Activo" },
                    { 4, null, new DateOnly(2023, 3, 30), 26, new DateOnly(2023, 1, 31), "Activo" },
                    { 5, null, new DateOnly(2023, 1, 24), 6, new DateOnly(2022, 6, 25), "Activo" },
                    { 6, null, new DateOnly(2022, 5, 19), 99, new DateOnly(2022, 12, 6), "Terminado" },
                    { 7, null, new DateOnly(2023, 3, 27), 40, new DateOnly(2023, 1, 30), "Terminado" },
                    { 8, null, new DateOnly(2022, 5, 23), 28, new DateOnly(2023, 1, 15), "Activo" },
                    { 9, null, new DateOnly(2022, 7, 23), 70, new DateOnly(2022, 9, 20), "Terminado" },
                    { 10, null, new DateOnly(2022, 5, 18), 8, new DateOnly(2022, 6, 29), "Terminado" },
                    { 11, null, new DateOnly(2022, 8, 16), 41, new DateOnly(2023, 2, 6), "Terminado" },
                    { 12, null, new DateOnly(2022, 7, 14), 93, new DateOnly(2022, 10, 13), "Activo" },
                    { 13, null, new DateOnly(2022, 11, 20), 34, new DateOnly(2022, 8, 10), "Terminado" },
                    { 14, null, new DateOnly(2022, 6, 23), 13, new DateOnly(2022, 9, 21), "Terminado" },
                    { 15, null, new DateOnly(2022, 11, 5), 81, new DateOnly(2022, 5, 19), "Terminado" },
                    { 16, null, new DateOnly(2022, 5, 16), 57, new DateOnly(2022, 6, 19), "Activo" },
                    { 17, null, new DateOnly(2022, 12, 9), 39, new DateOnly(2022, 9, 3), "Terminado" },
                    { 18, null, new DateOnly(2022, 8, 14), 39, new DateOnly(2022, 5, 23), "Activo" },
                    { 19, null, new DateOnly(2022, 10, 8), 78, new DateOnly(2023, 3, 20), "Terminado" },
                    { 20, null, new DateOnly(2022, 8, 6), 64, new DateOnly(2022, 9, 14), "Activo" },
                    { 21, null, new DateOnly(2022, 8, 4), 14, new DateOnly(2023, 4, 27), "Terminado" },
                    { 22, null, new DateOnly(2022, 9, 14), 5, new DateOnly(2022, 10, 20), "Terminado" },
                    { 23, null, new DateOnly(2022, 11, 6), 71, new DateOnly(2023, 4, 7), "Terminado" },
                    { 24, null, new DateOnly(2022, 9, 17), 41, new DateOnly(2022, 7, 27), "Activo" },
                    { 25, null, new DateOnly(2022, 7, 20), 63, new DateOnly(2022, 5, 25), "Terminado" },
                    { 26, null, new DateOnly(2022, 9, 10), 64, new DateOnly(2022, 8, 16), "Activo" },
                    { 27, null, new DateOnly(2022, 11, 6), 75, new DateOnly(2023, 3, 9), "Activo" },
                    { 28, null, new DateOnly(2022, 11, 2), 50, new DateOnly(2022, 7, 19), "Terminado" },
                    { 29, null, new DateOnly(2023, 2, 19), 82, new DateOnly(2022, 6, 5), "Activo" },
                    { 30, null, new DateOnly(2022, 11, 27), 39, new DateOnly(2022, 8, 20), "Activo" },
                    { 31, null, new DateOnly(2022, 7, 2), 59, new DateOnly(2023, 1, 14), "Activo" },
                    { 32, null, new DateOnly(2022, 12, 15), 62, new DateOnly(2022, 8, 5), "Activo" },
                    { 33, null, new DateOnly(2022, 8, 19), 58, new DateOnly(2022, 11, 8), "Terminado" },
                    { 34, null, new DateOnly(2022, 6, 15), 8, new DateOnly(2022, 9, 9), "Terminado" },
                    { 35, null, new DateOnly(2022, 7, 29), 2, new DateOnly(2023, 3, 3), "Terminado" },
                    { 36, null, new DateOnly(2022, 10, 24), 48, new DateOnly(2023, 2, 23), "Activo" },
                    { 37, null, new DateOnly(2022, 8, 30), 25, new DateOnly(2022, 5, 29), "Activo" },
                    { 38, null, new DateOnly(2023, 4, 2), 39, new DateOnly(2023, 1, 24), "Activo" },
                    { 39, null, new DateOnly(2023, 4, 16), 1, new DateOnly(2022, 10, 1), "Terminado" },
                    { 40, null, new DateOnly(2023, 4, 6), 18, new DateOnly(2022, 9, 6), "Activo" },
                    { 41, null, new DateOnly(2022, 12, 27), 71, new DateOnly(2022, 10, 29), "Activo" },
                    { 42, null, new DateOnly(2023, 4, 5), 60, new DateOnly(2023, 4, 28), "Terminado" },
                    { 43, null, new DateOnly(2022, 9, 11), 94, new DateOnly(2022, 12, 13), "Terminado" },
                    { 44, null, new DateOnly(2022, 5, 30), 78, new DateOnly(2022, 9, 1), "Terminado" },
                    { 45, null, new DateOnly(2022, 8, 6), 55, new DateOnly(2023, 2, 23), "Activo" },
                    { 46, null, new DateOnly(2022, 11, 14), 26, new DateOnly(2023, 1, 9), "Terminado" },
                    { 47, null, new DateOnly(2023, 2, 4), 76, new DateOnly(2023, 2, 21), "Terminado" },
                    { 48, null, new DateOnly(2022, 11, 1), 16, new DateOnly(2023, 4, 23), "Activo" },
                    { 49, null, new DateOnly(2023, 4, 20), 51, new DateOnly(2023, 1, 24), "Terminado" },
                    { 50, null, new DateOnly(2022, 9, 7), 12, new DateOnly(2022, 5, 13), "Activo" },
                    { 51, null, new DateOnly(2022, 12, 14), 39, new DateOnly(2022, 7, 22), "Terminado" },
                    { 52, null, new DateOnly(2023, 3, 15), 28, new DateOnly(2022, 6, 18), "Terminado" },
                    { 53, null, new DateOnly(2022, 11, 19), 94, new DateOnly(2023, 4, 14), "Activo" },
                    { 54, null, new DateOnly(2022, 8, 26), 57, new DateOnly(2022, 9, 30), "Terminado" },
                    { 55, null, new DateOnly(2022, 7, 16), 9, new DateOnly(2023, 4, 8), "Terminado" },
                    { 56, null, new DateOnly(2023, 3, 30), 76, new DateOnly(2022, 8, 23), "Activo" },
                    { 57, null, new DateOnly(2022, 7, 27), 15, new DateOnly(2023, 4, 27), "Activo" },
                    { 58, null, new DateOnly(2022, 8, 21), 32, new DateOnly(2023, 4, 30), "Terminado" },
                    { 59, null, new DateOnly(2022, 6, 24), 31, new DateOnly(2023, 2, 1), "Terminado" },
                    { 60, null, new DateOnly(2022, 10, 17), 75, new DateOnly(2023, 1, 26), "Activo" },
                    { 61, null, new DateOnly(2022, 8, 17), 22, new DateOnly(2023, 3, 4), "Terminado" },
                    { 62, null, new DateOnly(2023, 5, 6), 6, new DateOnly(2022, 9, 6), "Terminado" },
                    { 63, null, new DateOnly(2022, 9, 8), 62, new DateOnly(2023, 4, 9), "Activo" },
                    { 64, null, new DateOnly(2022, 10, 22), 69, new DateOnly(2022, 6, 14), "Terminado" },
                    { 65, null, new DateOnly(2023, 1, 10), 40, new DateOnly(2022, 12, 4), "Activo" },
                    { 66, null, new DateOnly(2022, 8, 4), 44, new DateOnly(2023, 1, 10), "Terminado" },
                    { 67, null, new DateOnly(2022, 11, 13), 58, new DateOnly(2022, 7, 19), "Activo" },
                    { 68, null, new DateOnly(2022, 6, 6), 29, new DateOnly(2023, 4, 26), "Activo" },
                    { 69, null, new DateOnly(2022, 5, 10), 45, new DateOnly(2022, 9, 22), "Terminado" },
                    { 70, null, new DateOnly(2023, 3, 26), 55, new DateOnly(2023, 2, 14), "Terminado" },
                    { 71, null, new DateOnly(2023, 2, 13), 41, new DateOnly(2022, 9, 29), "Terminado" },
                    { 72, null, new DateOnly(2023, 1, 25), 60, new DateOnly(2022, 9, 20), "Activo" },
                    { 73, null, new DateOnly(2022, 12, 3), 62, new DateOnly(2022, 5, 21), "Terminado" },
                    { 74, null, new DateOnly(2023, 4, 15), 37, new DateOnly(2022, 7, 27), "Activo" },
                    { 75, null, new DateOnly(2022, 9, 20), 43, new DateOnly(2022, 9, 25), "Activo" },
                    { 76, null, new DateOnly(2022, 9, 8), 23, new DateOnly(2023, 3, 19), "Activo" },
                    { 77, null, new DateOnly(2023, 4, 14), 98, new DateOnly(2023, 3, 9), "Terminado" },
                    { 78, null, new DateOnly(2023, 1, 26), 83, new DateOnly(2022, 6, 3), "Terminado" },
                    { 79, null, new DateOnly(2023, 1, 8), 30, new DateOnly(2022, 5, 22), "Terminado" },
                    { 80, null, new DateOnly(2022, 8, 5), 71, new DateOnly(2022, 6, 9), "Activo" },
                    { 81, null, new DateOnly(2022, 12, 20), 4, new DateOnly(2022, 5, 7), "Terminado" },
                    { 82, null, new DateOnly(2022, 10, 17), 29, new DateOnly(2023, 1, 4), "Terminado" },
                    { 83, null, new DateOnly(2023, 5, 7), 82, new DateOnly(2022, 11, 14), "Activo" },
                    { 84, null, new DateOnly(2022, 8, 17), 14, new DateOnly(2023, 4, 20), "Activo" },
                    { 85, null, new DateOnly(2022, 6, 6), 80, new DateOnly(2022, 11, 11), "Activo" },
                    { 86, null, new DateOnly(2023, 4, 10), 49, new DateOnly(2022, 6, 14), "Terminado" },
                    { 87, null, new DateOnly(2023, 1, 21), 55, new DateOnly(2022, 9, 25), "Activo" },
                    { 88, null, new DateOnly(2022, 7, 11), 20, new DateOnly(2022, 11, 1), "Activo" },
                    { 89, null, new DateOnly(2022, 11, 7), 28, new DateOnly(2022, 6, 4), "Activo" },
                    { 90, null, new DateOnly(2023, 5, 6), 3, new DateOnly(2023, 4, 23), "Terminado" },
                    { 91, null, new DateOnly(2022, 10, 20), 21, new DateOnly(2022, 7, 16), "Activo" },
                    { 92, null, new DateOnly(2023, 3, 9), 2, new DateOnly(2022, 6, 2), "Terminado" },
                    { 93, null, new DateOnly(2022, 9, 17), 6, new DateOnly(2023, 3, 5), "Terminado" },
                    { 94, null, new DateOnly(2022, 8, 9), 88, new DateOnly(2022, 11, 29), "Activo" },
                    { 95, null, new DateOnly(2023, 1, 16), 45, new DateOnly(2023, 3, 1), "Terminado" },
                    { 96, null, new DateOnly(2022, 8, 18), 95, new DateOnly(2022, 11, 3), "Terminado" },
                    { 97, null, new DateOnly(2022, 7, 25), 17, new DateOnly(2022, 5, 29), "Terminado" },
                    { 98, null, new DateOnly(2022, 6, 23), 5, new DateOnly(2023, 2, 4), "Activo" },
                    { 99, null, new DateOnly(2023, 2, 1), 25, new DateOnly(2022, 6, 19), "Terminado" },
                    { 100, null, new DateOnly(2022, 8, 25), 53, new DateOnly(2023, 1, 8), "Activo" }
                });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "id", "client_id", "color", "description", "model", "plate", "year" },
                values: new object[,]
                {
                    { 1, 86, "rojo", "Extended Cab Pickup", "V90", "QPN4O4ABLHDU44220", "2018" },
                    { 2, 57, "fucsia", "SUV", "Durango", "WHDP1RBS0VXF54473", "2019" },
                    { 3, 4, "marfil", "SUV", "Grand Caravan", "ZU8JMIBM2YQE81934", "2021" },
                    { 4, 34, "orquídea", "Wagon", "Focus", "RJVX2KPYVZT445963", "2019" },
                    { 5, 95, "gris", "Crew Cab Pickup", "El Camino", "8Z0QRJZJZ9IQ66116", "2019" },
                    { 6, 49, "Lima", "Cargo Van", "Grand Cherokee", "IUOVHVB813EP64495", "2021" },
                    { 7, 57, "negro", "Extended Cab Pickup", "Cruze", "1339Z5MSRHH319500", "2021" },
                    { 8, 99, "verde", "Minivan", "XC90", "N6ONCQKDKMAZ37104", "2020" },
                    { 9, 17, "lavanda", "Minivan", "Challenger", "GLDSG3FBE5PQ13742", "2019" },
                    { 10, 14, "aceituna", "SUV", "Focus", "V928B5J4TOWN50765", "2015" },
                    { 11, 12, "azul", "Minivan", "Spyder", "T3NUGWN2ZMHJ91154", "2019" },
                    { 12, 68, "turquesa", "Hatchback", "Spyder", "CV6BFI7IS9Y219017", "2018" },
                    { 13, 28, "morado", "Minivan", "F-150", "YKN2PU5OKWPB27555", "2015" },
                    { 14, 19, "blanco", "Sedan", "Mustang", "UGK6NA543TKT97647", "2015" },
                    { 15, 90, "amarillo", "Convertible", "Expedition", "N4CMX9DLLTF833372", "2019" },
                    { 16, 81, "ciruela", "Minivan", "Land Cruiser", "HOHTU403WGD594635", "2018" },
                    { 17, 56, "aceituna", "Sedan", "Taurus", "YFXXLCT5IUSF39337", "2018" },
                    { 18, 86, "azul", "Wagon", "PT Cruiser", "B2UZ62IUEHES21182", "2015" },
                    { 19, 30, "rojo", "Wagon", "Grand Caravan", "Y73U13FQWNGC86757", "2021" },
                    { 20, 64, "fucsia", "Extended Cab Pickup", "Aventador", "PPFD8D1IUDR060391", "2020" },
                    { 21, 45, "Naranja", "Wagon", "V90", "WD2NHQHR7XVK24592", "2019" },
                    { 22, 91, "orquídea", "Passenger Van", "Grand Caravan", "ZCUMZFNQZ1IQ68110", "2020" },
                    { 23, 38, "rojo", "Convertible", "Expedition", "MCJFOXLLS7S323612", "2021" },
                    { 24, 88, "fucsia", "Extended Cab Pickup", "Silverado", "AVK9WGB4OEUU95428", "2019" },
                    { 25, 61, "cielo azul", "Hatchback", "Sentra", "B5GJK91MJDZG39213", "2018" },
                    { 26, 30, "amarillo", "Passenger Van", "Explorer", "0FATMV5BIHZQ97021", "2018" },
                    { 27, 52, "verde", "Cargo Van", "Impala", "6P4HE8JKDUEN74074", "2019" },
                    { 28, 82, "teal", "Wagon", "Countach", "ZXV55XOXCVY944007", "2015" },
                    { 29, 64, "lavanda", "SUV", "Prius", "939DXGAR5YI116108", "2015" },
                    { 30, 58, "cielo azul", "Sedan", "Aventador", "OFTOW6UIE0LB49476", "2019" },
                    { 31, 60, "negro", "Passenger Van", "Cruze", "NYJSRRAIA4W426215", "2015" },
                    { 32, 44, "cielo azul", "Convertible", "Model T", "U7QN8EFVZ5KS26427", "2018" },
                    { 33, 40, "fucsia", "Crew Cab Pickup", "Expedition", "IYAJKDPS21E640481", "2018" },
                    { 34, 81, "fucsia", "Convertible", "Escalade", "Q6L3AO2BANXZ22444", "2015" },
                    { 35, 39, "turquesa", "Crew Cab Pickup", "Taurus", "MQYWMSGJVCXF24446", "2019" },
                    { 36, 69, "cian", "Extended Cab Pickup", "LeBaron", "P6920VMDCAKX74359", "2019" },
                    { 37, 69, "índigo", "Extended Cab Pickup", "2", "G6OTQ0INI9RL41169", "2021" },
                    { 38, 79, "plata", "Coupe", "Roadster", "C1B7QTRNKTQG45003", "2020" },
                    { 39, 61, "Naranja", "Extended Cab Pickup", "PT Cruiser", "NC4OCGI5ZLA961436", "2021" },
                    { 40, 22, "orquídea", "Sedan", "Roadster", "GKTEAZSF0POO96772", "2020" },
                    { 41, 20, "turquesa", "Hatchback", "Countach", "M59LP8I40QVK21309", "2020" },
                    { 42, 19, "azul", "Minivan", "V90", "7R51FNVA9XLD43082", "2018" },
                    { 43, 91, "morado", "Convertible", "CTS", "B77GW4WNQNMC93711", "2019" },
                    { 44, 18, "Rosa", "Crew Cab Pickup", "Focus", "TB1FBCNDCAZI24028", "2018" },
                    { 45, 71, "plata", "Cargo Van", "XC90", "1JKLJVF11JJV93158", "2018" },
                    { 46, 96, "morado", "Convertible", "Alpine", "XNN42XVFHVDG57221", "2019" },
                    { 47, 43, "plata", "Extended Cab Pickup", "Cruze", "KOCU4YDRI3GI19020", "2019" },
                    { 48, 27, "amarillo", "Coupe", "El Camino", "7Y96EW5UZPI893713", "2020" },
                    { 49, 54, "tan", "Passenger Van", "Impala", "3LYKQJMK9XN296864", "2018" },
                    { 50, 3, "magenta", "Hatchback", "V90", "CJZZ71X5F7AS53078", "2020" },
                    { 51, 39, "magenta", "Passenger Van", "PT Cruiser", "4RJ6MWOYVWBP42288", "2021" },
                    { 52, 12, "oro", "Coupe", "Impala", "XZFH2HVOC4MN18975", "2019" },
                    { 53, 23, "azul", "Minivan", "Countach", "4Q37ET2QT8LW41111", "2020" },
                    { 54, 86, "teal", "Extended Cab Pickup", "Model 3", "I5QHUH3J2RU643678", "2020" },
                    { 55, 98, "blanco", "Crew Cab Pickup", "V90", "NR5MK7G0O0MM88485", "2015" },
                    { 56, 43, "Naranja", "Cargo Van", "F-150", "VULGTI45PCDI91225", "2019" },
                    { 57, 14, "azul", "SUV", "Sentra", "J2A0TGE17XAM39085", "2020" },
                    { 58, 23, "blanco", "Passenger Van", "Camaro", "50E9DJTTFJZP76228", "2020" },
                    { 59, 59, "rojo", "Convertible", "Camry", "8UPRLBYRUHRV68512", "2021" },
                    { 60, 14, "tan", "Cargo Van", "Expedition", "BE2M6U4HUTL478134", "2019" },
                    { 61, 13, "aceituna", "Crew Cab Pickup", "1", "6LGZDP88VGN420079", "2018" },
                    { 62, 55, "teal", "Coupe", "CTS", "CVBGOC7VX2MF87451", "2015" },
                    { 63, 34, "Menta verde", "Crew Cab Pickup", "Corvette", "ASNA4QU7D3I532237", "2018" },
                    { 64, 26, "verde", "Minivan", "Ranchero", "ZOWDBHJNQQDM36620", "2018" },
                    { 65, 72, "aceituna", "Hatchback", "A8", "86L4BBI9VSRG20031", "2021" },
                    { 66, 42, "Naranja", "Crew Cab Pickup", "Corvette", "1GJ4IUOVSEEV61893", "2021" },
                    { 67, 50, "Rosa", "Wagon", "Fortwo", "9FZY3Z282ULD37630", "2018" },
                    { 68, 90, "Rosa", "Coupe", "ATS", "TXM8JDZDMXC569676", "2021" },
                    { 69, 23, "violeta", "Convertible", "Corvette", "MZIJBUR3CRHX61161", "2018" },
                    { 70, 45, "turquesa", "Cargo Van", "LeBaron", "5TIOFE73ALJ432503", "2020" },
                    { 71, 76, "lavanda", "Coupe", "Altima", "MVKEDS9JRUW973786", "2015" },
                    { 72, 93, "negro", "Passenger Van", "Model T", "OV10A8S02CBS30513", "2020" },
                    { 73, 43, "cielo azul", "Coupe", "Fortwo", "MOHBQC71B2YL69374", "2019" },
                    { 74, 80, "amarillo", "Convertible", "2", "BJXD57PN5TBI51445", "2018" },
                    { 75, 98, "salmón", "Sedan", "Aventador", "NTIA36951UM340533", "2020" },
                    { 76, 54, "teal", "Sedan", "Impala", "NM7W51H3ODT887395", "2020" },
                    { 77, 94, "rojo", "Convertible", "Cruze", "BLJ3YD359AJ652758", "2015" },
                    { 78, 35, "marrón", "Crew Cab Pickup", "Wrangler", "VV5XS5S791O511008", "2020" },
                    { 79, 75, "marfil", "Wagon", "Challenger", "CYQ2LHITVTH816245", "2020" },
                    { 80, 86, "violeta", "Coupe", "Altima", "7EFT3VD96SYT47545", "2019" },
                    { 81, 9, "índigo", "Hatchback", "Fiesta", "86GR6E2R3DXJ51861", "2019" },
                    { 82, 78, "rojo", "Sedan", "PT Cruiser", "TSM2B0OS1ZZT53851", "2021" },
                    { 83, 2, "Lima", "Convertible", "LeBaron", "YL7C99APNZYC47601", "2015" },
                    { 84, 40, "marrón", "Crew Cab Pickup", "Accord", "CXD6Y3UA7ATW70901", "2020" },
                    { 85, 8, "rojo", "Coupe", "Camry", "PAHYAYIO83OW45133", "2020" },
                    { 86, 88, "lavanda", "Minivan", "PT Cruiser", "M49W0LEWDGHS40169", "2020" },
                    { 87, 15, "fucsia", "Crew Cab Pickup", "Colorado", "3ZUM1MP47LEJ70946", "2020" },
                    { 88, 90, "Menta verde", "Minivan", "Mustang", "3UH11GGW9NEM53117", "2019" },
                    { 89, 96, "magenta", "Sedan", "Altima", "G3X8AK3SY7LY54668", "2015" },
                    { 90, 39, "azul", "Coupe", "Fortwo", "IQBDNQ2GTLKW86311", "2021" },
                    { 91, 82, "morado", "SUV", "A8", "AIV54VPWLBXI77854", "2019" },
                    { 92, 19, "orquídea", "Minivan", "Explorer", "LEM67ABSWTRY70662", "2020" },
                    { 93, 95, "verde", "Crew Cab Pickup", "XC90", "VIB2D41VYMWM96512", "2018" },
                    { 94, 58, "salmón", "Convertible", "XC90", "FLY1QUWXAWRC54824", "2015" },
                    { 95, 8, "marrón", "Coupe", "CTS", "IR6EMI2E8IHN70829", "2018" },
                    { 96, 67, "morado", "Coupe", "F-150", "E06AI1VFPAMI72989", "2019" },
                    { 97, 1, "cian", "Extended Cab Pickup", "Golf", "EL6EZJAQ17UY87319", "2015" },
                    { 98, 9, "aceituna", "Sedan", "Durango", "5GFR3K7D68IN26664", "2019" },
                    { 99, 89, "tan", "Cargo Van", "Alpine", "AS3KNOZUUJOJ76845", "2020" },
                    { 100, 24, "rojo", "Cargo Van", "Alpine", "HAPLAKIE0OIK36967", "2019" }
                });

            migrationBuilder.InsertData(
                table: "inconvenients",
                columns: new[] { "id", "date_act", "days_delay", "description", "request_id", "seen", "service_request_id", "state" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 2, 27), 5, "Nacional", 41, false, 84, "Social" },
                    { 2, new DateOnly(2022, 9, 14), 10, "Dinánmico", 12, true, 50, "Mecanico" },
                    { 3, new DateOnly(2022, 9, 27), 5, "Humano", 89, false, 75, "Tiempo" },
                    { 4, new DateOnly(2022, 12, 8), 6, "SubGerente", 7, false, 75, "Mecanico" },
                    { 5, new DateOnly(2022, 10, 15), 19, "Central", 89, true, 16, "Social" },
                    { 6, new DateOnly(2022, 8, 17), 13, "Jefe", 4, false, 99, "Tiempo" },
                    { 7, new DateOnly(2023, 2, 13), 1, "Humano", 7, true, 8, "Social" },
                    { 8, new DateOnly(2022, 9, 11), 19, "Heredado", 74, true, 65, "Social" },
                    { 9, new DateOnly(2023, 4, 22), 7, "Distrito", 73, true, 78, "Mecanico" },
                    { 10, new DateOnly(2023, 3, 15), 5, "Humano", 74, false, 80, "Social" },
                    { 11, new DateOnly(2022, 11, 23), 6, "International", 16, true, 48, "Mecanico" },
                    { 12, new DateOnly(2022, 12, 22), 5, "Interno", 37, true, 34, "Tiempo" },
                    { 13, new DateOnly(2023, 4, 18), 7, "Jefe", 17, true, 70, "Financiero" },
                    { 14, new DateOnly(2022, 5, 8), 4, "Producto", 74, true, 8, "Financiero" },
                    { 15, new DateOnly(2022, 11, 30), 11, "Directo", 42, false, 67, "Financiero" },
                    { 16, new DateOnly(2022, 7, 2), 7, "Central", 34, false, 90, "Financiero" },
                    { 17, new DateOnly(2022, 7, 31), 12, "Cliente", 44, true, 64, "Tiempo" },
                    { 18, new DateOnly(2023, 1, 21), 3, "Corporativo", 81, true, 72, "Mecanico" },
                    { 19, new DateOnly(2022, 9, 19), 2, "Cliente", 13, true, 40, "Mecanico" },
                    { 20, new DateOnly(2022, 6, 17), 8, "Dinánmico", 3, true, 49, "Social" },
                    { 21, new DateOnly(2022, 7, 8), 16, "Regional", 72, true, 63, "Mecanico" },
                    { 22, new DateOnly(2022, 10, 31), 10, "Futuro", 57, false, 40, "Mecanico" },
                    { 23, new DateOnly(2022, 6, 2), 13, "Senior", 4, true, 25, "Social" },
                    { 24, new DateOnly(2022, 6, 28), 7, "Distrito", 23, true, 7, "Mecanico" },
                    { 25, new DateOnly(2023, 3, 15), 8, "Global", 27, false, 61, "Mecanico" },
                    { 26, new DateOnly(2023, 2, 17), 5, "Corporativo", 1, true, 78, "Financiero" },
                    { 27, new DateOnly(2022, 5, 11), 11, "Director", 8, true, 92, "Tiempo" },
                    { 28, new DateOnly(2022, 12, 29), 16, "Heredado", 55, false, 50, "Mecanico" },
                    { 29, new DateOnly(2023, 1, 4), 10, "Interno", 40, true, 50, "Tiempo" },
                    { 30, new DateOnly(2022, 12, 11), 4, "Director", 39, true, 4, "Financiero" },
                    { 31, new DateOnly(2022, 10, 17), 5, "Interno", 53, true, 34, "Tiempo" },
                    { 32, new DateOnly(2022, 12, 10), 10, "Inversor", 15, true, 15, "Mecanico" },
                    { 33, new DateOnly(2022, 12, 2), 2, "Interno", 29, true, 86, "Financiero" },
                    { 34, new DateOnly(2023, 1, 24), 11, "Senior", 53, true, 55, "Mecanico" },
                    { 35, new DateOnly(2022, 6, 17), 4, "Director", 84, true, 8, "Financiero" },
                    { 36, new DateOnly(2023, 2, 11), 15, "Heredado", 27, true, 53, "Tiempo" },
                    { 37, new DateOnly(2022, 12, 18), 12, "Heredado", 79, true, 64, "Financiero" },
                    { 38, new DateOnly(2022, 9, 6), 6, "Interno", 78, false, 3, "Mecanico" },
                    { 39, new DateOnly(2022, 9, 15), 10, "Interno", 19, true, 38, "Mecanico" },
                    { 40, new DateOnly(2023, 4, 24), 10, "Nacional", 83, false, 2, "Social" },
                    { 41, new DateOnly(2022, 10, 23), 12, "Gerente", 15, true, 63, "Tiempo" },
                    { 42, new DateOnly(2022, 11, 17), 16, "International", 71, true, 79, "Social" },
                    { 43, new DateOnly(2022, 11, 8), 13, "Distrito", 56, false, 74, "Social" },
                    { 44, new DateOnly(2023, 1, 27), 17, "Adelante", 94, false, 68, "Mecanico" },
                    { 45, new DateOnly(2022, 7, 20), 7, "Senior", 22, true, 17, "Financiero" },
                    { 46, new DateOnly(2023, 5, 3), 6, "Corporativo", 54, false, 4, "Financiero" },
                    { 47, new DateOnly(2023, 2, 21), 4, "Interno", 85, true, 84, "Social" },
                    { 48, new DateOnly(2022, 10, 23), 11, "Humano", 11, false, 40, "Social" },
                    { 49, new DateOnly(2023, 2, 9), 16, "Adelante", 38, false, 95, "Social" },
                    { 50, new DateOnly(2023, 3, 22), 1, "Corporativo", 86, false, 18, "Tiempo" },
                    { 51, new DateOnly(2022, 9, 6), 1, "International", 21, false, 25, "Mecanico" },
                    { 52, new DateOnly(2022, 9, 21), 13, "Global", 81, false, 5, "Tiempo" },
                    { 53, new DateOnly(2023, 1, 8), 11, "Futuro", 59, false, 87, "Tiempo" },
                    { 54, new DateOnly(2023, 4, 30), 8, "Inversor", 79, false, 76, "Social" },
                    { 55, new DateOnly(2022, 7, 17), 12, "Regional", 10, true, 78, "Tiempo" },
                    { 56, new DateOnly(2022, 12, 16), 13, "Central", 32, true, 40, "Social" },
                    { 57, new DateOnly(2023, 2, 17), 2, "Gerente", 58, true, 58, "Tiempo" },
                    { 58, new DateOnly(2022, 11, 13), 15, "Humano", 35, true, 87, "Financiero" },
                    { 59, new DateOnly(2022, 9, 24), 14, "Adelante", 59, true, 17, "Financiero" },
                    { 60, new DateOnly(2022, 5, 11), 19, "Producto", 40, true, 40, "Mecanico" },
                    { 61, new DateOnly(2023, 4, 22), 20, "Gerente", 70, true, 66, "Mecanico" },
                    { 62, new DateOnly(2023, 4, 17), 2, "Heredado", 67, false, 72, "Mecanico" },
                    { 63, new DateOnly(2022, 5, 8), 13, "Dinánmico", 86, true, 66, "Tiempo" },
                    { 64, new DateOnly(2022, 11, 18), 8, "Nacional", 28, true, 87, "Mecanico" },
                    { 65, new DateOnly(2023, 3, 13), 9, "Directo", 72, false, 27, "Mecanico" },
                    { 66, new DateOnly(2022, 6, 24), 9, "Senior", 6, false, 39, "Social" },
                    { 67, new DateOnly(2023, 1, 5), 19, "Dinánmico", 2, false, 50, "Financiero" },
                    { 68, new DateOnly(2022, 11, 14), 2, "Dinánmico", 49, false, 63, "Social" },
                    { 69, new DateOnly(2022, 5, 16), 20, "Interno", 17, true, 53, "Mecanico" },
                    { 70, new DateOnly(2023, 3, 14), 20, "Dinánmico", 93, false, 22, "Social" },
                    { 71, new DateOnly(2022, 9, 20), 18, "Directo", 45, false, 88, "Mecanico" },
                    { 72, new DateOnly(2022, 10, 29), 1, "Inversor", 95, false, 32, "Social" },
                    { 73, new DateOnly(2022, 7, 6), 20, "Interno", 11, true, 94, "Mecanico" },
                    { 74, new DateOnly(2023, 3, 15), 11, "Cliente", 83, true, 91, "Financiero" },
                    { 75, new DateOnly(2022, 12, 12), 15, "International", 4, false, 62, "Financiero" },
                    { 76, new DateOnly(2023, 3, 18), 9, "Central", 68, false, 20, "Mecanico" },
                    { 77, new DateOnly(2022, 7, 15), 15, "SubGerente", 10, false, 92, "Tiempo" },
                    { 78, new DateOnly(2022, 7, 29), 2, "Global", 73, false, 50, "Mecanico" },
                    { 79, new DateOnly(2022, 10, 18), 10, "Interno", 34, true, 23, "Mecanico" },
                    { 80, new DateOnly(2022, 5, 11), 16, "Heredado", 9, false, 33, "Social" },
                    { 81, new DateOnly(2023, 2, 24), 12, "Regional", 45, true, 10, "Social" },
                    { 82, new DateOnly(2022, 7, 14), 15, "International", 71, false, 2, "Mecanico" },
                    { 83, new DateOnly(2022, 11, 8), 8, "SubGerente", 75, false, 25, "Tiempo" },
                    { 84, new DateOnly(2022, 11, 21), 3, "Dinánmico", 14, false, 60, "Social" },
                    { 85, new DateOnly(2022, 10, 25), 18, "Inversor", 32, false, 54, "Mecanico" },
                    { 86, new DateOnly(2023, 3, 10), 2, "Central", 52, true, 23, "Social" },
                    { 87, new DateOnly(2022, 10, 5), 14, "Jefe", 39, true, 38, "Tiempo" },
                    { 88, new DateOnly(2022, 5, 22), 17, "Dinánmico", 87, false, 52, "Social" },
                    { 89, new DateOnly(2022, 6, 4), 15, "Central", 54, false, 15, "Financiero" },
                    { 90, new DateOnly(2022, 7, 12), 11, "Humano", 9, true, 28, "Financiero" },
                    { 91, new DateOnly(2022, 12, 23), 1, "Nacional", 32, false, 63, "Tiempo" },
                    { 92, new DateOnly(2023, 1, 9), 4, "Directo", 58, false, 95, "Mecanico" },
                    { 93, new DateOnly(2022, 7, 18), 2, "Jefe", 69, true, 35, "Mecanico" },
                    { 94, new DateOnly(2023, 3, 30), 4, "Jefe", 64, false, 90, "Tiempo" },
                    { 95, new DateOnly(2022, 5, 18), 17, "Futuro", 80, false, 74, "Mecanico" },
                    { 96, new DateOnly(2022, 10, 12), 13, "Regional", 44, true, 27, "Tiempo" },
                    { 97, new DateOnly(2022, 9, 11), 11, "Gerente", 99, false, 42, "Social" },
                    { 98, new DateOnly(2023, 3, 29), 1, "Distrito", 39, true, 98, "Financiero" },
                    { 99, new DateOnly(2022, 10, 29), 11, "Heredado", 73, true, 13, "Tiempo" },
                    { 100, new DateOnly(2023, 1, 7), 12, "Futuro", 77, true, 88, "Social" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_administrators_userid",
                table: "administrators",
                column: "userid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clients_userid",
                table: "clients",
                column: "userid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_inconvenients_request_id",
                table: "inconvenients",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_mechanics_user_id",
                table: "mechanics",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayrollMechanic_PayrollsId",
                table: "PayrollMechanic",
                column: "PayrollsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRequest_RequestsId",
                table: "ProductRequest",
                column: "RequestsId");

            migrationBuilder.CreateIndex(
                name: "IX_purchases_productid",
                table: "purchases",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_purchases_supplierid",
                table: "purchases",
                column: "supplierid");

            migrationBuilder.CreateIndex(
                name: "IX_recepcionists_userid",
                table: "recepcionists",
                column: "userid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestMechanic_RequestsId",
                table: "RequestMechanic",
                column: "RequestsId");

            migrationBuilder.CreateIndex(
                name: "IX_requests_client_id",
                table: "requests",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_requests_service_id",
                table: "requests",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_client_id",
                table: "vehicles",
                column: "client_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administrators");

            migrationBuilder.DropTable(
                name: "inconvenients");

            migrationBuilder.DropTable(
                name: "PayrollMechanic");

            migrationBuilder.DropTable(
                name: "ProductRequest");

            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.DropTable(
                name: "recepcionists");

            migrationBuilder.DropTable(
                name: "reports");

            migrationBuilder.DropTable(
                name: "RequestMechanic");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "payrolls");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "mechanics");

            migrationBuilder.DropTable(
                name: "requests");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
