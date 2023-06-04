using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestServer.Migrations
{
    public partial class MigracionRemota : Migration
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
                    saleprice = table.Column<float>(type: "float", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
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
                    product_id = table.Column<int>(type: "int", nullable: true),
                    supplier_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.id);
                    table.ForeignKey(
                        name: "FK_purchases_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_purchases_suppliers_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "suppliers",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "admins",
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
                    user_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.id);
                    table.ForeignKey(
                        name: "FK_admins_users_user_id",
                        column: x => x.user_id,
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
                    user_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                    table.ForeignKey(
                        name: "FK_clients_users_user_id",
                        column: x => x.user_id,
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
                name: "receptionists",
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
                    user_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receptionists", x => x.id);
                    table.ForeignKey(
                        name: "FK_receptionists_users_user_id",
                        column: x => x.user_id,
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
                table: "admins",
                columns: new[] { "id", "name", "phone", "surname", "user_id" },
                values: new object[,]
                {
                    { 1, "Ximena Guadalupe", "5481-880-068", "Rojas", null },
                    { 2, "Sergio", "500 543 240", "Cruz", null },
                    { 3, "José", "5420-960-808", "Saucedo", null },
                    { 4, "Elsa", "5461-385-684", "Roybal", null },
                    { 5, "Marcela", "524.291.102", "Oquendo", null },
                    { 6, "Kimberly", "548.334.650", "Mena", null },
                    { 7, "Lola", "543.127.715", "Arroyo", null },
                    { 8, "Brandon", "5809-890-304", "Rosado", null },
                    { 9, "Daniel", "502.642.900", "Polanco", null },
                    { 10, "Raúl", "514.103.505", "Olivera", null },
                    { 11, "Mateo", "501137552", "Carrillo", null },
                    { 12, "Zoe", "502980279", "Caballero", null },
                    { 13, "Yaretzi", "5870-472-270", "Rentería", null },
                    { 14, "Juan", "556640919", "Quintero de la cruz", null },
                    { 15, "Valentina", "512.016.707", "Cotto", null },
                    { 16, "Concepción", "530.790.122", "Valles", null },
                    { 17, "Marco Antonio", "572.465.125", "Escamilla", null },
                    { 18, "Patricia", "5134-527-070", "Rodríguez", null },
                    { 19, "Regina", "548.466.246", "Kanea", null },
                    { 20, "José", "514342774", "Negrón", null },
                    { 21, "Victoria", "518915690", "Vázquez", null },
                    { 22, "Ramiro", "599 661 957", "Bueno", null },
                    { 23, "Lizbeth", "597 735 984", "Villalobos", null },
                    { 24, "María Fernanda", "563.788.075", "Kuzmina", null },
                    { 25, "Xochitl", "590 660 808", "Sanches", null },
                    { 26, "Jimena", "531943910", "Baca", null },
                    { 27, "Marisol", "551 507 054", "Carrillo", null },
                    { 28, "Miranda", "586 807 388", "Domínquez", null },
                    { 29, "Miguel Ángel", "573.404.931", "Fierro", null },
                    { 30, "Kevin", "5375-233-868", "Franco", null },
                    { 31, "Elías", "531.397.408", "Preciado", null },
                    { 32, "Rebeca", "5070-732-182", "Duarte", null },
                    { 33, "Adela", "510 402 904", "Xicoy", null },
                    { 34, "Jorge Luis", "5130-900-255", "Jaramillo", null },
                    { 35, "Lourdes", "522 179 868", "Samaniego", null },
                    { 36, "Camila", "525.951.356", "Sosa", null },
                    { 37, "Francisco", "564665727", "Mejía", null },
                    { 38, "Lourdes", "558 543 509", "Adame", null },
                    { 39, "Luis Ángel", "519 573 898", "Arreola", null },
                    { 40, "Ximena", "576072786", "Montaño", null },
                    { 41, "Anita", "575.622.649", "Loera", null },
                    { 42, "María Guadalupe", "562282183", "Perales", null },
                    { 43, "Erick", "583 559 161", "Serrano", null },
                    { 44, "Vicente", "519 006 146", "Prado", null },
                    { 45, "María Cristina", "512 088 703", "Cervántez", null },
                    { 46, "José", "516 099 873", "Sedillo", null },
                    { 47, "Elena", "5296-488-164", "Rojas", null },
                    { 48, "Rodrigo", "550.576.728", "Ávila", null },
                    { 49, "Alexis", "557 680 737", "Atencio", null },
                    { 50, "Vanessa", "5147-257-111", "Alejandro", null },
                    { 51, "Estela", "5765-759-291", "Kanzaki", null },
                    { 52, "Maximiliano", "584.703.093", "Rojo", null },
                    { 53, "Luis Miguel", "527 572 664", "Dávila", null },
                    { 54, "Ximena", "572857552", "Xana", null },
                    { 55, "Santiago", "591579345", "Casillas", null },
                    { 56, "Xochitl", "524659155", "Matías", null },
                    { 57, "Florencia", "571870656", "Quesada", null },
                    { 58, "Carlos", "5308-412-407", "Yago", null },
                    { 59, "Isaac", "5532-680-359", "Cardona", null },
                    { 60, "Ricardo", "5124-811-105", "Carrero", null },
                    { 61, "Juan Manuel", "557.400.543", "Pacheco", null },
                    { 62, "Clara", "546.502.020", "Zamarreno", null },
                    { 63, "Berta", "507.086.662", "Leyva", null },
                    { 64, "Leticia", "522.641.217", "Águilar", null },
                    { 65, "Diego", "5848-707-122", "Vélez", null },
                    { 66, "Lola", "585915860", "Ulibarri", null },
                    { 67, "Esmeralda", "506909975", "Lozano", null },
                    { 68, "Ivan", "5159-141-195", "Munguía", null },
                    { 69, "Naomi", "586.177.706", "Márquez", null },
                    { 70, "Gerardo", "5962-838-446", "Galindo", null },
                    { 71, "Leonor", "5458-960-930", "Pantoja", null },
                    { 72, "Lizbeth", "597.389.178", "Avilés", null },
                    { 73, "Estela", "578.389.612", "Zarate", null },
                    { 74, "Pablo", "505.354.100", "Aguirre", null },
                    { 75, "Eduardo", "558 070 030", "Marroquín", null },
                    { 76, "Juan Manuel", "519.601.229", "Enríquez", null },
                    { 77, "Cristina", "591.398.878", "Delacrúz", null },
                    { 78, "Vicente", "5690-140-011", "Matías", null },
                    { 79, "María Fernanda", "543903769", "Pabón", null },
                    { 80, "Araceli", "557124797", "Arias", null },
                    { 81, "María", "585 683 924", "Rael", null },
                    { 82, "Marilu", "589 368 535", "Cortez", null },
                    { 83, "Abigail", "536098989", "Puga", null },
                    { 84, "Victor Manuel", "518 043 775", "Fajardo", null },
                    { 85, "Sofia", "5595-064-994", "Méndez", null },
                    { 86, "Vicente", "587506620", "Nieto", null },
                    { 87, "Ernesto", "5257-910-862", "Matos", null },
                    { 88, "Lourdes", "512 405 738", "Gamboa", null },
                    { 89, "Guillermo", "520 726 690", "Alanis", null },
                    { 90, "Vicente", "562.568.763", "Saavedra", null },
                    { 91, "Mariana", "5367-051-423", "Orellana", null },
                    { 92, "David", "520.500.916", "Nieto", null },
                    { 93, "Carlota", "5646-383-280", "Cadena", null },
                    { 94, "Tadeo", "5695-953-361", "Aguirre", null },
                    { 95, "Paulina", "551 175 050", "Carrasco", null },
                    { 96, "Tomás", "505 931 445", "Ceja", null },
                    { 97, "Matías", "593.854.228", "Mota", null },
                    { 98, "Kevin", "543.053.859", "Espino", null },
                    { 99, "Isabel", "546.250.756", "Miranda", null },
                    { 100, "Silvia", "503981726", "Armenta", null }
                });

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "address", "email", "name", "phone", "surname", "type", "user_id" },
                values: new object[,]
                {
                    { 1, "Colonia Repúplica de Chile 6 Edificio 2", "AngelGabriel64@yahoo.com", "Ángel Gabriel", "530046268", "Tirado", "Descercador", null },
                    { 2, "Salida Aniceto Ortega 9281", "Martin_Cardona@nearbpo.com", "Martín", "5335-549-596", "Cardona", "Deschapar", null },
                    { 3, "Calleja Francisco I. Madero 31 Edificio 2", "Ariadna_Ozuna@gmail.com", "Ariadna", "5367-887-347", "Ozuna", "Cendrazo", null },
                    { 4, "Parcela Maricarmen Méndez s/n. Puerta 829", "Monica_Alva@hotmail.com", "Mónica", "509093447", "Alva", "Batán", null },
                    { 5, "Calle Repúplica de Cuba 598", "Jesus.Quiroz59@gmail.com", "Jesús", "5124-181-447", "Quiroz", "Cencerra", null },
                    { 6, "Barranco Berta Delvalle 44 Edificio 1", "Marcela.Rosado@hotmail.com", "Marcela", "543.988.795", "Rosado", "General", null },
                    { 7, "Bloque Jicolapa s/n.", "Lucia26@nearbpo.com", "Lucia", "523.368.608", "Gil", "Engarrar", null },
                    { 8, "Ronda Yamileth Cabán 4827", "Monica56@gmail.com", "Mónica", "567762924", "Xicoy", "Cencido", null },
                    { 9, "Municipio Eje 6, 1", "Vicente24@yahoo.com", "Vicente", "593 275 354", "Kara", "Engarronar", null },
                    { 10, "Jardines Abril 3260", "AnaMaria_Serrato72@gmail.com", "Ana María", "514 776 401", "Serrato", "Abadesa", null },
                    { 11, "Terrenos Zapata 3167", "Alexa.Ledesma@gmail.com", "Alexa", "5217-811-983", "Ledesma", "Géminis", null },
                    { 12, "Camino Rafael, 29", "Cecilia.Delgado@nearbpo.com", "Cecilia", "5686-212-405", "Delgado", "Gemir", null },
                    { 13, "Arrabal Piedra del Comal 61 Esc. 324", "Eduardo46@hotmail.com", "Eduardo", "579.320.340", "Saldaña", "Incremento", null },
                    { 14, "Muelle Jicolapa, 18 Puerta 313", "Alejandro_Guerra65@corpfolder.com", "Alejandro", "562680305", "Guerra", "Abacial", null },
                    { 15, "Travesía Luis 044", "JoseMaria_Toro@corpfolder.com", "José María", "539 746 883", "Toro", "Abada", null },
                    { 16, "Puente Jesús 5 Edificio 8", "Sancho73@gmail.com", "Sancho", "551.576.379", "Peralta", "Engarrar", null },
                    { 17, "Chalet Piedra del Comal s/n.", "Brayan_Leiva@hotmail.com", "Brayan", "504925928", "Leiva", "Generalato", null },
                    { 18, "Explanada Eje 6 s/n. Puerta 547", "Aaron.Escobar1@nearbpo.com", "Aarón", "530.416.068", "Escobar", "Abadía", null },
                    { 19, "Paseo José Eduardo 263", "Ana76@gmail.com", "Ana", "5405-242-805", "Santana", "Incorporo", null },
                    { 20, "Arroyo Batalla de Naco 992 Esc. 953", "JoseAntonio7@corpfolder.com", "José Antonio", "567850785", "Estrada", "Abadesa", null },
                    { 21, "Lugar San Miguel, 87", "Dorotea_Hurtado@yahoo.com", "Dorotea", "561.134.606", "Hurtado", "Descensión", null },
                    { 22, "Lado Repúplica de Uruguay s/n.", "Isabela_Yago@hotmail.com", "Isabela", "5216-034-001", "Yago", "Gemólogo", null },
                    { 23, "Bajada Amores, 26 Edificio 8", "Antonio_Davila50@yahoo.com", "Antonio", "507093208", "Dávila", "Fideicomisario", null },
                    { 24, "Grupo Luis s/n. Esc. 944", "Mercedes52@corpfolder.com", "Mercedes", "583660115", "Guerrero", "Batallador", null },
                    { 25, "Quinta Avena 9123 Esc. 433", "Enrique_Cavazos32@gmail.com", "Enrique", "5068-911-591", "Cavazos", "Engarrotar", null },
                    { 26, "Camino La otra banda 05", "MariadelosAngeles.Sevilla83@gmail.com", "María de los Ángeles", "511 049 380", "Sevilla", "Cenal", null },
                    { 27, "Avenida Polotitlan 39 Esc. 220", "Miranda.Ponce@gmail.com", "Miranda", "5308-005-443", "Ponce", "Descerebrar", null },
                    { 28, "Travesía Germán Armendáriz s/n. Puerta 065", "Jennifer_Tapia@gmail.com", "Jennifer", "5967-820-180", "Tapia", "Cencuate", null },
                    { 29, "Camino Calimaya 92", "Miranda.Hinojosa45@hotmail.com", "Miranda", "5740-736-077", "Hinojosa", "Descerrar", null },
                    { 30, "Vía Batalla de Naco 76 Edificio 2", "Victor_Anguiano72@nearbpo.com", "Víctor", "544.698.652", "Anguiano", "Engaste", null },
                    { 31, "Carretera Manzanares, 06", "MariadeJesus.Santana8@gmail.com", "María de Jesús", "5516-501-886", "Santana", "Batavia", null },
                    { 32, "Rambla David, 05 Puerta 667", "Luz.Carrasquillo64@corpfolder.com", "Luz", "532 787 478", "Carrasquillo", "Incrementar", null },
                    { 33, "Lado Naranjo, 3", "Lucas_Rocha@hotmail.com", "Lucas", "5988-042-536", "Rocha", "Batato", null },
                    { 34, "Prolongación Repúplica de Uruguay, 49 Esc. 200", "Guillermo72@corpfolder.com", "Guillermo", "500.706.086", "Terrazas", "Incorporo", null },
                    { 35, "Prolongación Francisco I. Madero 396 Puerta 340", "Carlos_Carmona92@gmail.com", "Carlos", "577.570.534", "Carmona", "Basurear", null },
                    { 36, "Extrarradio Eduardo, 38 Edificio 3", "Daniela.Nevarez7@nearbpo.com", "Daniela", "526.258.510", "Nevárez", "Cendolilla", null },
                    { 37, "Ramal Cinco de Mayo 4371", "Monserrat.Aponte@corpfolder.com", "Monserrat", "5419-343-402", "Aponte", "Ceñar", null },
                    { 38, "Lugar María Guadalupe Paredes, 2", "Miranda.Santacruz3@nearbpo.com", "Miranda", "5124-834-751", "Santacruz", "Incriminar", null },
                    { 39, "Prolongación Valentina Frías 205", "Carolina_Peralta35@yahoo.com", "Carolina", "595 507 369", "Peralta", "Incredulidad", null },
                    { 40, "Rincón Avena, 0", "Conchita48@hotmail.com", "Conchita", "589029095", "Rodrígez", "Bastonazo", null },
                    { 41, "Lado Agustín 58", "Fatima_Caraballo43@nearbpo.com", "Fatima", "546.612.992", "Caraballo", "Incrustación", null },
                    { 42, "Arroyo Xochitl Guzmán, 19", "Caridad_Alcantar31@corpfolder.com", "Caridad", "5795-751-183", "Alcántar", "Incorruptamente", null },
                    { 43, "Carretera Repúplica de Uruguay 45 Puerta 464", "MariadelCarmen_Llamas@hotmail.com", "María del Carmen", "598.318.013", "Llamas", "Cencido", null },
                    { 44, "Lugar Clara Barraza 633", "Anita.Serna6@hotmail.com", "Anita", "5331-156-994", "Serna", "Batayola", null },
                    { 45, "Prolongación Francisco I. Madero, 1 Puerta 064", "MariaGuadalupe39@nearbpo.com", "María Guadalupe", "548412670", "Reyes", "Engarzador", null },
                    { 46, "Arroyo Repúplica de Chile, 5", "Teodoro.Yanes@corpfolder.com", "Teodoro", "5346-854-017", "Yanes", "Fideísmo", null },
                    { 47, "Arrabal Victor Manuel Espinoza s/n.", "MariadelosAngeles_Valdivia69@gmail.com", "María de los Ángeles", "565.423.273", "Valdivia", "Engasgarse", null },
                    { 48, "Conjunto Isabel la Católica s/n. Esc. 592", "Micaela77@yahoo.com", "Micaela", "5481-191-023", "Vigil", "Bateador", null },
                    { 49, "Calleja Paulina Godoy 9 Edificio 6", "Andres54@corpfolder.com", "Andrés", "572 927 861", "Ochoa", "Fideísmo", null },
                    { 50, "Solar Eje Central 2 Edificio 8", "Clemente.Vera22@yahoo.com", "Clemente", "573633618", "Vera", "Geminado", null },
                    { 51, "Torrente Barrio la Lonja 634", "Gilberto_Paz@yahoo.com", "Gilberto", "518.028.907", "Paz", "Descentralización", null },
                    { 52, "Partida Repúplica de Argentina, 2 Esc. 637", "Olivia66@gmail.com", "Olivia", "5851-393-659", "Paredes", "Engarzador", null },
                    { 53, "Masía Mónica Arriaga 0", "Mauricio.Nava83@nearbpo.com", "Mauricio", "563.959.854", "Nava", "Batayola", null },
                    { 54, "Municipio La viga, 2", "Mariana32@nearbpo.com", "Mariana", "500398705", "Jaimes", "Batanga", null },
                    { 55, "Mercado San Miguel 59", "Ricardo.Aleman@hotmail.com", "Ricardo", "537312039", "Alemán", "Engarfiar", null },
                    { 56, "Monte Flor Marina 43 Esc. 680", "Ana90@yahoo.com", "Ana", "539112952", "Vaca", "Cenero", null },
                    { 57, "Rincón Pilar 71", "Daniel38@gmail.com", "Daniel", "543997780", "Galarza", "Cenata", null },
                    { 58, "Poblado Repúplica de Argentina 5705", "Josefina71@yahoo.com", "Josefina", "553.251.345", "Quevedo", "Incrementar", null },
                    { 59, "Solar Valeria, 53", "Ignacio_Salas63@yahoo.com", "Ignacio", "539681184", "Salas", "Fido", null },
                    { 60, "Puente 20 de Noviembre 5 Edificio 5", "Daniela_Solorzano13@corpfolder.com", "Daniela", "535297657", "Solorzano", "Abacero", null },
                    { 61, "Edificio Coruña, 18", "Rosa27@gmail.com", "Rosa", "582952913", "Kortajarena", "Descentralizador", null },
                    { 62, "Colonia Miguel Ángel de Quevedo s/n.", "Elisa_Viera67@yahoo.com", "Elisa", "577 807 226", "Viera", "Incorporo", null },
                    { 63, "Carretera Barrio la Lonja 804 Puerta 819", "Naomi95@hotmail.com", "Naomi", "543401124", "Nava", "Descerar", null },
                    { 64, "Extrarradio Ana María 9695 Puerta 647", "MariaElena_Rael@gmail.com", "María Elena", "569944477", "Rael", "Batalloso", null },
                    { 65, "Manzana Aniceto Ortega 6841", "JoseAntonio87@hotmail.com", "José Antonio", "571139953", "Olvera", "Descensión", null },
                    { 66, "Conjunto Fernando Ballesteros, 7 Edificio 6", "Benito91@yahoo.com", "Benito", "523125217", "Alfaro", "Descentralizar", null },
                    { 67, "Monte Guillermo Rivas s/n. Esc. 767", "Maximiliano33@gmail.com", "Maximiliano", "531745927", "Orozco", "Abajar", null },
                    { 68, "Pasaje Eje 5 64 Edificio 5", "JoseMaria.Laureano@corpfolder.com", "José María", "552124832", "Laureano", "Batallar", null },
                    { 69, "Torrente Polotitlan, 6", "Micaela_Mejia5@corpfolder.com", "Micaela", "5619-222-631", "Mejía", "Cencha", null },
                    { 70, "Rampa Batalla de Naco, 1", "Alexa61@nearbpo.com", "Alexa", "521 242 021", "Kranz sans", "Batanga", null },
                    { 71, "Huerta Concepción Jaimes 99 Puerta 710", "Mauricio37@nearbpo.com", "Mauricio", "510 610 371", "Maldonado", "Descentrar", null },
                    { 72, "Vía Flor Marina 6", "Adela16@nearbpo.com", "Adela", "555 041 567", "Jasso", "Batata", null },
                    { 73, "Rampa Eje 6 s/n.", "Guillermo59@corpfolder.com", "Guillermo", "591 004 938", "Banda", "Géminis", null },
                    { 74, "Calle Margarita 350", "Caridad_Covarrubias@gmail.com", "Caridad", "507921329", "Covarrubias", "Geneático", null },
                    { 75, "Calleja Manzanares, 2", "AngelDaniel_Mota87@gmail.com", "Ángel Daniel", "540.732.752", "Mota", "Incremento", null },
                    { 76, "Travesía Batalla de Naco s/n.", "Beatriz.Aragon@nearbpo.com", "Beatriz", "571 192 179", "Aragón", "Abalanzar", null },
                    { 77, "Apartamento Coruña, 22", "Liliana.Xicoy30@nearbpo.com", "Liliana", "570.295.181", "Xicoy", "Cenero", null },
                    { 78, "Barranco Jalisco s/n.", "Rosalia.Acuna37@hotmail.com", "Rosalia", "5590-856-168", "Acuña", "Incorruptibilidad", null },
                    { 79, "Poblado Avena, 0 Esc. 260", "Gloria51@gmail.com", "Gloria", "554 459 661", "Pineda", "Deschuponar", null },
                    { 80, "Ferrocarril Zacatlán 170", "Carlos_Rolon77@gmail.com", "Carlos", "532864761", "Rolón", "Gencianeo", null },
                    { 81, "Terrenos Eje Central, 49 Edificio 4", "Liliana.Hernandez@hotmail.com", "Liliana", "580 874 335", "Hernández", "Cenata", null },
                    { 82, "Gran Subida Barrio la Lonja 987 Edificio 9", "Luisa.Salcedo78@yahoo.com", "Luisa", "522 352 066", "Salcedo", "Batanar", null },
                    { 83, "Carretera Isabel la Católica 097 Edificio 0", "Blanca76@gmail.com", "Blanca", "5380-084-768", "Marrero", "Engargolado", null },
                    { 84, "Camino Repúplica de Argentina 0240", "Lorenzo.Adame80@nearbpo.com", "Lorenzo", "564765684", "Adame", "Descercar", null },
                    { 85, "Arroyo Mariano Olivárez s/n.", "Raul.Zambrano@corpfolder.com", "Raúl", "5387-140-896", "Zambrano", "Abad", null },
                    { 86, "Sector Manzanares 1 Edificio 8", "Gilberto_Orosco@yahoo.com", "Gilberto", "5874-643-785", "Orosco", "Bataola", null },
                    { 87, "Parcela Izazaga 026", "DulceMaria_Valdes64@yahoo.com", "Dulce María", "529035824", "Valdés", "Cencerrado", null },
                    { 88, "Pasaje Eje 5 9 Edificio 7", "Sara_Barrera73@nearbpo.com", "Sara", "5186-553-344", "Barrera", "Gemiquear", null },
                    { 89, "Colonia Camila Ibarra s/n. Esc. 183", "Esmeralda.Arreola36@hotmail.com", "Esmeralda", "5697-342-468", "Arreola", "Incorrección", null },
                    { 90, "Caserio Repúplica de Uruguay s/n.", "Ester94@yahoo.com", "Ester", "5402-570-553", "Bustamante", "Cencerrado", null },
                    { 91, "Lugar 20 de Noviembre 4", "Renata_Delarosa21@nearbpo.com", "Renata", "513.933.644", "Delarosa", "Cendolilla", null },
                    { 92, "Grupo Manuela Vega 4", "Paola.Puente21@hotmail.com", "Paola", "552.745.458", "Puente", "Descimbramiento", null },
                    { 93, "Grupo Miguel Ángel de Quevedo 59", "Leonor_Corral47@nearbpo.com", "Leonor", "512.274.769", "Corral", "Incriminación", null },
                    { 94, "Arrabal Carla Peña 2", "Estela.Quinterodelacruz@hotmail.com", "Estela", "549.259.266", "Quintero de la cruz", "Fice", null },
                    { 95, "Calleja Repúplica de Argentina, 3", "Ramiro_Padilla@hotmail.com", "Ramiro", "531335386", "Padilla", "Abalada", null },
                    { 96, "Puerta Alberto Delvalle 7 Edificio 8", "Marisol_Farias@yahoo.com", "Marisol", "521937320", "Farías", "Engargolar", null },
                    { 97, "Vía Pública Carlota Guillen, 2 Puerta 574", "Yamileth_Orellana75@yahoo.com", "Yamileth", "5423-461-129", "Orellana", "Batallar", null },
                    { 98, "Quinta Aarón Tejada, 8", "Blanca_Arroyo0@nearbpo.com", "Blanca", "574828429", "Arroyo", "Engarnio", null },
                    { 99, "Explanada La viga 1619", "Ana_Meza76@yahoo.com", "Ana", "571.279.550", "Meza", "Batallona", null },
                    { 100, "Rua Polotitlan 00 Puerta 347", "Tadeo_Cabrera93@gmail.com", "Tadeo", "538828801", "Cabrera", "Descervigar", null }
                });

            migrationBuilder.InsertData(
                table: "mechanics",
                columns: new[] { "id", "address", "commission", "email", "name", "phone", "salary", "surname", "user_id", "role" },
                values: new object[,]
                {
                    { 1, "Monte Calimaya 8327", 20.0, "Isaias64@corpfolder.com", "Isaias", "532 822 368", 428.44999999999999, "Ceja", null, "Master" },
                    { 2, "Pasaje Adela Valenzuela 1 Edificio 6", 20.0, "Damian_Gil@hotmail.com", "Damián", "586 223 273", 75.439999999999998, "Gil", null, "Aprendiz" },
                    { 3, "Gran Subida Repúplica de Cuba 0162 Esc. 829", 20.0, "Manuel.Mesa@gmail.com", "Manuel", "564 239 464", 326.52999999999997, "Mesa", null, "Junior" },
                    { 4, "Sección Cuahutemoc s/n. Edificio 1", 30.0, "Naomi.Noriega29@corpfolder.com", "Naomi", "528203740", 573.63999999999999, "Noriega", null, "Aprendiz" },
                    { 5, "Prolongación Repúplica de Uruguay, 40 Puerta 349", 30.0, "AnaLuisa_Kanea69@yahoo.com", "Ana Luisa", "516.817.120", 405.70999999999998, "Kanea", null, "Master" },
                    { 6, "Jardines Clemente Gamboa, 5 Puerta 902", 40.0, "Isaias3@hotmail.com", "Isaias", "5010-974-240", 531.27999999999997, "González", null, "Aprendiz" },
                    { 7, "Quinta Francisco I. Madero 9 Puerta 326", 40.0, "Martin99@nearbpo.com", "Martín", "522.190.060", 237.63999999999999, "Fajardo", null, "Master" },
                    { 8, "Pasaje Coruña 3", 30.0, "Julia_Sanches59@nearbpo.com", "Julia", "534.418.281", 601.92999999999995, "Sanches", null, "Aprendiz" },
                    { 9, "Manzana Repúplica de Chile 64 Esc. 385", 40.0, "MariaFernanda_Gallardo60@gmail.com", "María Fernanda", "536650477", 51.490000000000002, "Gallardo", null, "Junior" },
                    { 10, "Puente Eje 6, 02", 20.0, "Emilio.Kamal89@hotmail.com", "Emilio", "520297709", 720.66999999999996, "Kamal", null, "Master" },
                    { 11, "Escalinata Cuahutemoc, 30", 20.0, "Berta.Hernadez37@gmail.com", "Berta", "539.473.508", 388.16000000000003, "Hernádez", null, "Aprendiz" },
                    { 12, "Entrada San Miguel 4", 30.0, "JoseEduardo.Anaya@yahoo.com", "José Eduardo", "583.639.880", 216.80000000000001, "Anaya", null, "Junior" },
                    { 13, "Calle María Teresa Miranda, 11 Puerta 220", 20.0, "Gabriela3@gmail.com", "Gabriela", "5434-821-099", 773.87, "Guerra", null, "Master" },
                    { 14, "Conjunto Esmeralda 2 Puerta 421", 30.0, "MariadelCarmen29@corpfolder.com", "María del Carmen", "5757-497-489", 492.18000000000001, "Quezada", null, "Aprendiz" },
                    { 15, "Rincón Cuahutemoc 12", 40.0, "Timoteo_Paez@yahoo.com", "Timoteo", "5627-697-881", 171.97999999999999, "Páez", null, "Junior" },
                    { 16, "Salida Isabel la Católica 5 Edificio 0", 20.0, "Vanessa.Lucero@nearbpo.com", "Vanessa", "5622-881-223", 977.44000000000005, "Lucero", null, "Junior" },
                    { 17, "Conjunto Izazaga 2261 Puerta 037", 40.0, "Armando0@corpfolder.com", "Armando", "5402-362-729", 811.13999999999999, "Macías", null, "Aprendiz" },
                    { 18, "Rincón Francisco I. Madero, 77", 20.0, "Josefina36@gmail.com", "Josefina", "517 664 921", 898.62, "Casanova", null, "Junior" },
                    { 19, "Colonia San Miguel s/n. Puerta 314", 20.0, "Renata10@nearbpo.com", "Renata", "5072-072-941", 349.25, "Huixtlacatl", null, "Junior" },
                    { 20, "Parcela Ester Velasco 3041 Edificio 3", 40.0, "DulceMaria38@corpfolder.com", "Dulce María", "5034-530-236", 312.07999999999998, "Ramón", null, "Master" },
                    { 21, "Aldea Manzanares 3", 40.0, "Kimberly.Cortes@hotmail.com", "Kimberly", "5767-185-545", 29.629999999999999, "Cortés", null, "Aprendiz" },
                    { 22, "Monte Balcón de los edecanes 2133", 30.0, "Daniel_Garza75@corpfolder.com", "Daniel", "505984849", 344.52999999999997, "Garza", null, "Junior" },
                    { 23, "Rampa Piedra del Comal 3 Esc. 290", 20.0, "Alicia.Mojica@gmail.com", "Alicia", "5756-230-774", 677.63, "Mojica", null, "Junior" },
                    { 24, "Poblado Coruña, 00 Edificio 5", 40.0, "Conchita_Godinez@hotmail.com", "Conchita", "598 714 318", 746.45000000000005, "Godínez", null, "Aprendiz" },
                    { 25, "Sector Naranjo 910 Edificio 2", 20.0, "Monica.Duenas28@yahoo.com", "Mónica", "5532-932-372", 19.030000000000001, "Dueñas", null, "Aprendiz" },
                    { 26, "Bloque Izazaga s/n. Esc. 693", 40.0, "Esmeralda.Agosto3@gmail.com", "Esmeralda", "569.001.735", 423.69999999999999, "Agosto", null, "Master" },
                    { 27, "Rincón San Miguel 86", 30.0, "JoseMaria11@nearbpo.com", "José María", "5797-088-308", 771.25, "Saucedo", null, "Master" },
                    { 28, "Apartamento Mauricio 2048", 40.0, "Abigail_Becerra52@nearbpo.com", "Abigail", "5650-917-838", 335.44, "Becerra", null, "Aprendiz" },
                    { 29, "Arrabal Cinco de Mayo 06 Edificio 4", 30.0, "Enrique_Ruelas66@gmail.com", "Enrique", "560.083.019", 630.83000000000004, "Ruelas", null, "Aprendiz" },
                    { 30, "Puente María García 8122", 20.0, "Marcos3@gmail.com", "Marcos", "536 691 919", 888.05999999999995, "Arriaga", null, "Junior" },
                    { 31, "Vía Pública Jalisco 6200 Esc. 921", 30.0, "AnaMaria.Teran@nearbpo.com", "Ana María", "5566-463-602", 901.75999999999999, "Terán", null, "Junior" },
                    { 32, "Conjunto Andrea, 0", 30.0, "Ariadna_Bustamante@hotmail.com", "Ariadna", "517.911.067", 58.590000000000003, "Bustamante", null, "Aprendiz" },
                    { 33, "Mercado Miguel Ángel de Quevedo, 3", 30.0, "Rocio_Guerra@gmail.com", "Rocio", "549 255 308", 673.59000000000003, "Guerra", null, "Master" },
                    { 34, "Huerta Daniel Cruz, 4", 30.0, "Carlota_Navarro3@nearbpo.com", "Carlota", "5370-591-838", 479.94999999999999, "Navarro", null, "Aprendiz" },
                    { 35, "Sección Juárez 238", 40.0, "Manuel91@nearbpo.com", "Manuel", "564.710.794", 374.07999999999998, "Ramírez", null, "Aprendiz" },
                    { 36, "Arroyo Naranjo, 3", 30.0, "Agustin_Castillo@yahoo.com", "Agustín", "537 171 886", 677.75, "Castillo", null, "Master" },
                    { 37, "Ferrocarril Balcón de los edecanes, 1 Esc. 911", 30.0, "Rocio53@corpfolder.com", "Rocio", "550 157 122", 859.38999999999999, "Lara", null, "Junior" },
                    { 38, "Solar Daniela Alcaraz 68 Edificio 7", 40.0, "Gabriel_Robledo@nearbpo.com", "Gabriel", "517.423.202", 791.5, "Robledo", null, "Junior" },
                    { 39, "Mercado Eje Central 709 Edificio 7", 30.0, "JorgeLuis17@nearbpo.com", "Jorge Luis", "555 903 945", 23.989999999999998, "Cordero", null, "Master" },
                    { 40, "Extramuros Piedra del Comal 0999 Puerta 809", 30.0, "Eduardo_Alonzo27@nearbpo.com", "Eduardo", "538.794.820", 634.00999999999999, "Alonzo", null, "Junior" },
                    { 41, "Escalinata Polotitlan s/n. Esc. 389", 40.0, "Armando_Lopez10@nearbpo.com", "Armando", "572.261.300", 806.40999999999997, "López", null, "Junior" },
                    { 42, "Barrio Florencia Arteaga, 73 Puerta 581", 30.0, "MariaEugenia15@nearbpo.com", "María Eugenia", "5419-625-810", 841.09000000000003, "Armijo", null, "Master" },
                    { 43, "Rampa Batalla de Naco, 3", 40.0, "Yaretzi63@gmail.com", "Yaretzi", "500057836", 286.56, "Delao", null, "Master" },
                    { 44, "Polígono Raúl, 4", 20.0, "Cecilia_Verduzco@gmail.com", "Cecilia", "590 920 878", 557.55999999999995, "Verduzco", null, "Aprendiz" },
                    { 45, "Edificio Aniceto Ortega 7587 Edificio 3", 40.0, "Margarita.Carrasco@corpfolder.com", "Margarita", "581 205 849", 251.22999999999999, "Carrasco", null, "Junior" },
                    { 46, "Urbanización Aarón, 12", 30.0, "Guadalupe.Barela1@gmail.com", "Guadalupe", "5572-437-991", 340.48000000000002, "Barela", null, "Junior" },
                    { 47, "Manzana Cinco de Mayo 10", 30.0, "Lourdes_Ibarra@nearbpo.com", "Lourdes", "5083-852-163", 610.17999999999995, "Ibarra", null, "Master" },
                    { 48, "Rua La otra banda 12", 20.0, "Iker15@yahoo.com", "Iker", "510.729.737", 859.86000000000001, "Castro", null, "Master" },
                    { 49, "Grupo Coruña 58", 30.0, "Octavio.Valles@hotmail.com", "Octavio", "560.245.565", 587.42999999999995, "Valles", null, "Master" },
                    { 50, "Entrada Repúplica de Argentina 0", 20.0, "Diana_Meraz@hotmail.com", "Diana", "511 868 752", 296.69, "Meraz", null, "Master" },
                    { 51, "Polígono San Miguel, 91 Edificio 7", 30.0, "Ruben.Arellano@gmail.com", "Rubén", "555.328.075", 157.5, "Arellano", null, "Master" },
                    { 52, "Calleja Barbara 440", 40.0, "Marta49@nearbpo.com", "Marta", "562340145", 805.11000000000001, "Borrego", null, "Master" },
                    { 53, "Mercado Catalina Olivera, 93 Puerta 607", 30.0, "Ramiro_Sanchez@gmail.com", "Ramiro", "553 879 405", 966.28999999999996, "Sánchez", null, "Aprendiz" },
                    { 54, "Conjunto Cedro, 07 Esc. 641", 20.0, "Luisa20@yahoo.com", "Luisa", "560.444.904", 398.51999999999998, "Araña", null, "Junior" },
                    { 55, "Bajada Ramona 71 Puerta 170", 20.0, "Monserrat.Ozuna43@corpfolder.com", "Monserrat", "538.969.030", 622.51999999999998, "Ozuna", null, "Junior" },
                    { 56, "Paseo Repúplica de Argentina 30", 40.0, "Rodrigo38@hotmail.com", "Rodrigo", "577 058 976", 581.10000000000002, "Espinosa", null, "Aprendiz" },
                    { 57, "Paseo Zapata s/n. Edificio 2", 30.0, "Nicolas_Sevilla8@corpfolder.com", "Nicolás", "587821066", 778.40999999999997, "Sevilla", null, "Junior" },
                    { 58, "Polígono Avena, 59 Puerta 373", 20.0, "Iker.Ortiz29@nearbpo.com", "Iker", "5580-017-521", 751.32000000000005, "Ortiz", null, "Junior" },
                    { 59, "Ronda La otra banda 79 Esc. 007", 40.0, "Jesus4@yahoo.com", "Jesús", "599416531", 353.19, "Carrasco", null, "Master" },
                    { 60, "Rambla La otra banda, 01", 20.0, "Gonzalo91@hotmail.com", "Gonzalo", "5064-924-263", 617.52999999999997, "Villalpando", null, "Master" },
                    { 61, "Parcela Avena s/n.", 20.0, "Rosario48@yahoo.com", "Rosario", "548 185 762", 46.68, "Henríquez", null, "Master" },
                    { 62, "Carretera Zacatlán s/n. Edificio 4", 20.0, "Marta47@nearbpo.com", "Marta", "564.284.670", 145.77000000000001, "Crespo", null, "Junior" },
                    { 63, "Chalet Cedro, 2 Edificio 7", 40.0, "Arturo81@nearbpo.com", "Arturo", "577 142 781", 774.41999999999996, "Sánchez", null, "Aprendiz" },
                    { 64, "Urbanización Cedro 17", 20.0, "RosaMaria_Yanez@yahoo.com", "Rosa María", "562.459.938", 988.99000000000001, "Yáñez", null, "Junior" },
                    { 65, "Extrarradio Flor Marina 2 Esc. 838", 30.0, "Esmeralda.Xiana89@hotmail.com", "Esmeralda", "565 310 840", 24.100000000000001, "Xiana", null, "Aprendiz" },
                    { 66, "Riera Polotitlan s/n.", 30.0, "JoseDaniel_Orozco@yahoo.com", "Jose Daniel", "592.808.380", 194.97, "Orozco", null, "Junior" },
                    { 67, "Puente San Miguel 4025", 40.0, "DulceMaria.Colunga@hotmail.com", "Dulce María", "5091-591-718", 395.33999999999997, "Colunga", null, "Master" },
                    { 68, "Sector Eje 5, 38", 20.0, "Teodoro_Barraza33@gmail.com", "Teodoro", "5223-809-679", 112.73999999999999, "Barraza", null, "Junior" },
                    { 69, "Chalet Repúplica de Cuba 5930", 40.0, "Martin.Arias@hotmail.com", "Martín", "561 871 312", 922.51999999999998, "Arias", null, "Master" },
                    { 70, "Barrio Beatriz 4016 Edificio 8", 20.0, "Elisa.Concepcion44@hotmail.com", "Elisa", "501532285", 608.07000000000005, "Concepción", null, "Junior" },
                    { 71, "Plaza Cuahutemoc 8192", 40.0, "Abraham53@yahoo.com", "Abraham", "5021-301-920", 717.53999999999996, "Montañez", null, "Aprendiz" },
                    { 72, "Conjunto Repúplica de Cuba 63", 40.0, "Adriana9@corpfolder.com", "Adriana", "593 371 663", 525.58000000000004, "Segura", null, "Master" },
                    { 73, "Municipio José Eduardo, 0", 20.0, "Hugo.Arroyo1@gmail.com", "Hugo", "569590790", 194.15000000000001, "Arroyo", null, "Junior" },
                    { 74, "Apartamento Balcón de los edecanes 0", 30.0, "Rosa_Otero56@gmail.com", "Rosa", "592 718 537", 650.05999999999995, "Otero", null, "Junior" },
                    { 75, "Rua Donceles 482", 40.0, "Mario15@gmail.com", "Mario", "577.661.238", 741.62, "Guevara", null, "Aprendiz" },
                    { 76, "Extramuros María Luisa Tejada 7281 Esc. 702", 30.0, "MariadelCarmen51@nearbpo.com", "María del Carmen", "522 176 120", 155.28, "Tirado", null, "Junior" },
                    { 77, "Edificio María Paz, 65 Puerta 658", 30.0, "Timoteo.Venegas@yahoo.com", "Timoteo", "526 310 274", 275.92000000000002, "Venegas", null, "Aprendiz" },
                    { 78, "Entrada Mateo s/n.", 40.0, "JuanManuel26@hotmail.com", "Juan Manuel", "508825658", 367.08999999999997, "Paredes", null, "Aprendiz" },
                    { 79, "Vía Pública Miguel Ángel de Quevedo s/n.", 20.0, "Gabriela39@nearbpo.com", "Gabriela", "5813-152-416", 898.86000000000001, "Solís", null, "Aprendiz" }
                });

            migrationBuilder.InsertData(
                table: "mechanics",
                columns: new[] { "id", "address", "commission", "email", "name", "phone", "salary", "surname", "user_id", "role" },
                values: new object[,]
                {
                    { 80, "Colonia Zapata 261", 20.0, "Dolores_Collazo50@corpfolder.com", "Dolores", "598045909", 535.86000000000001, "Collazo", null, "Master" },
                    { 81, "Glorieta Juárez 5721", 30.0, "Luis.Perez4@yahoo.com", "Luis", "5382-586-570", 190.43000000000001, "Pérez", null, "Aprendiz" },
                    { 82, "Chalet Donceles 72 Edificio 5", 20.0, "Abigail89@gmail.com", "Abigail", "534219740", 852.91999999999996, "Torres", null, "Master" },
                    { 83, "Sector San Miguel 8", 30.0, "Pablo.Amaya@corpfolder.com", "Pablo", "5399-569-948", 664.74000000000001, "Amaya", null, "Aprendiz" },
                    { 84, "Camino Juárez, 2 Edificio 0", 20.0, "Jaime_Chapa97@hotmail.com", "Jaime", "574.822.455", 38.5, "Chapa", null, "Junior" },
                    { 85, "Apartamento Graciela Leyva 4 Esc. 686", 40.0, "Luisa_Orta@nearbpo.com", "Luisa", "535697546", 549.67999999999995, "Orta", null, "Master" },
                    { 86, "Pasaje Anita s/n.", 20.0, "Teresa45@yahoo.com", "Teresa", "570 648 079", 209.87, "Salas", null, "Master" },
                    { 87, "Aldea Isabel la Católica 4", 40.0, "Marta.Espino@nearbpo.com", "Marta", "5379-245-588", 288.74000000000001, "Espino", null, "Junior" },
                    { 88, "Lugar Avena s/n.", 40.0, "Andrea.Vera@nearbpo.com", "Andrea", "5469-105-783", 458.13999999999999, "Vera", null, "Aprendiz" },
                    { 89, "Escalinata Lucia Baeza, 3 Esc. 371", 20.0, "Gonzalo.Lugo42@gmail.com", "Gonzalo", "5540-792-742", 684.94000000000005, "Lugo", null, "Junior" },
                    { 90, "Puerta Eduardo Anaya, 3 Edificio 8", 30.0, "MariadeJesus.Dominguez@nearbpo.com", "María de Jesús", "510666428", 192.46000000000001, "Domínguez", null, "Aprendiz" },
                    { 91, "Paseo Batalla de Naco, 77", 30.0, "Gloria37@nearbpo.com", "Gloria", "584 395 989", 610.94000000000005, "Xairo Belmonte", null, "Aprendiz" },
                    { 92, "Mercado Inés s/n.", 40.0, "Bernardo70@yahoo.com", "Bernardo", "551.444.017", 315.62, "Valadez", null, "Junior" },
                    { 93, "Quinta Irene Domínquez, 8 Puerta 457", 40.0, "Leonardo20@hotmail.com", "Leonardo", "5117-551-769", 784.65999999999997, "Ramos", null, "Master" },
                    { 94, "Aldea Izazaga, 5 Puerta 110", 40.0, "Andres57@gmail.com", "Andrés", "556 244 030", 369.06, "Núñez", null, "Aprendiz" },
                    { 95, "Ramal Isabel la Católica s/n. Edificio 0", 30.0, "Araceli36@yahoo.com", "Araceli", "582.831.419", 560.38, "Solorzano", null, "Junior" },
                    { 96, "Municipio Erick Saiz, 15", 30.0, "Jesus45@nearbpo.com", "Jesús", "5553-241-037", 647.92999999999995, "Loya", null, "Master" },
                    { 97, "Urbanización Gloria Rodrígez, 77", 30.0, "Leonor.Posada@yahoo.com", "Leonor", "563 981 896", 661.09000000000003, "Posada", null, "Aprendiz" },
                    { 98, "Edificio Amores, 6", 40.0, "Alejandro_Carrera33@nearbpo.com", "Alejandro", "583926645", 410.18000000000001, "Carrera", null, "Aprendiz" },
                    { 99, "Travesía Cedro s/n. Esc. 380", 30.0, "AnaMaria.Abeyta@hotmail.com", "Ana María", "578360335", 479.50999999999999, "Abeyta", null, "Master" },
                    { 100, "Polígono Balcón de los edecanes 1776 Esc. 494", 40.0, "JoseMiguel_Pelayo30@corpfolder.com", "José Miguel", "523 855 015", 333.73000000000002, "Pelayo", null, "Master" }
                });

            migrationBuilder.InsertData(
                table: "payrolls",
                columns: new[] { "id", "accruals", "deductions", "description", "end_date", "settlement", "star_date" },
                values: new object[,]
                {
                    { 1, 699.28999999999996, 467.35000000000002, "Interno", new DateOnly(2022, 9, 4), 797.15999999999997, new DateOnly(2023, 4, 6) },
                    { 2, 201.12, 555.61000000000001, "Corporativo", new DateOnly(2022, 11, 19), 998.07000000000005, new DateOnly(2023, 3, 26) },
                    { 3, 629.96000000000004, 594.04999999999995, "Interno", new DateOnly(2023, 3, 4), 71.5, new DateOnly(2023, 1, 28) },
                    { 4, 247.90000000000001, 444.00999999999999, "Inversor", new DateOnly(2023, 2, 21), 920.19000000000005, new DateOnly(2022, 11, 1) },
                    { 5, 948.10000000000002, 75.659999999999997, "Inversor", new DateOnly(2022, 7, 22), 773.97000000000003, new DateOnly(2022, 9, 4) },
                    { 6, 468.87, 669.25999999999999, "Director", new DateOnly(2022, 9, 9), 249.55000000000001, new DateOnly(2023, 3, 5) },
                    { 7, 608.78999999999996, 708.63999999999999, "Distrito", new DateOnly(2023, 2, 16), 255.36000000000001, new DateOnly(2022, 7, 17) },
                    { 8, 120.95, 344.95999999999998, "Producto", new DateOnly(2022, 11, 20), 132.63, new DateOnly(2022, 8, 10) },
                    { 9, 394.06999999999999, 378.88999999999999, "Inversor", new DateOnly(2022, 7, 2), 905.69000000000005, new DateOnly(2022, 10, 1) },
                    { 10, 685.94000000000005, 874.45000000000005, "Central", new DateOnly(2023, 1, 10), 420.85000000000002, new DateOnly(2022, 6, 25) },
                    { 11, 65.579999999999998, 395.19999999999999, "SubGerente", new DateOnly(2022, 7, 30), 968.38999999999999, new DateOnly(2022, 9, 4) },
                    { 12, 473.18000000000001, 524.70000000000005, "Distrito", new DateOnly(2022, 12, 4), 929.70000000000005, new DateOnly(2023, 3, 25) },
                    { 13, 618.64999999999998, 747.25, "Futuro", new DateOnly(2022, 9, 12), 581.10000000000002, new DateOnly(2023, 3, 19) },
                    { 14, 470.48000000000002, 467.91000000000003, "Nacional", new DateOnly(2022, 9, 15), 202.38, new DateOnly(2023, 5, 22) },
                    { 15, 998.38, 323.98000000000002, "Distrito", new DateOnly(2023, 5, 9), 680.74000000000001, new DateOnly(2023, 5, 7) },
                    { 16, 345.52999999999997, 411.57999999999998, "Futuro", new DateOnly(2022, 9, 9), 46.619999999999997, new DateOnly(2023, 1, 12) },
                    { 17, 411.97000000000003, 54.189999999999998, "Distrito", new DateOnly(2022, 11, 7), 14.35, new DateOnly(2022, 7, 18) },
                    { 18, 433.20999999999998, 719.24000000000001, "Jefe", new DateOnly(2022, 12, 21), 188.62, new DateOnly(2022, 11, 30) },
                    { 19, 42.869999999999997, 7.7999999999999998, "Director", new DateOnly(2022, 8, 13), 507.32999999999998, new DateOnly(2022, 11, 6) },
                    { 20, 91.819999999999993, 994.59000000000003, "SubGerente", new DateOnly(2023, 3, 13), 723.60000000000002, new DateOnly(2022, 9, 26) },
                    { 21, 361.56, 308.75, "Regional", new DateOnly(2022, 7, 24), 198.90000000000001, new DateOnly(2022, 11, 27) },
                    { 22, 204.08000000000001, 74.230000000000004, "Director", new DateOnly(2023, 1, 10), 122.78, new DateOnly(2023, 5, 14) },
                    { 23, 711.71000000000004, 577.5, "Nacional", new DateOnly(2023, 1, 24), 770.80999999999995, new DateOnly(2023, 4, 23) },
                    { 24, 307.49000000000001, 657.49000000000001, "Producto", new DateOnly(2023, 1, 27), 195.05000000000001, new DateOnly(2023, 1, 23) },
                    { 25, 146.84999999999999, 401.24000000000001, "Dinánmico", new DateOnly(2023, 3, 9), 593.40999999999997, new DateOnly(2023, 4, 29) },
                    { 26, 640.16999999999996, 714.01999999999998, "Interno", new DateOnly(2023, 1, 26), 258.26999999999998, new DateOnly(2022, 9, 28) },
                    { 27, 100.95999999999999, 33.130000000000003, "Cliente", new DateOnly(2022, 10, 3), 736.59000000000003, new DateOnly(2022, 11, 30) },
                    { 28, 937.02999999999997, 608.72000000000003, "Distrito", new DateOnly(2022, 12, 24), 422.50999999999999, new DateOnly(2023, 2, 4) },
                    { 29, 2.5899999999999999, 995.59000000000003, "Cliente", new DateOnly(2023, 5, 18), 327.74000000000001, new DateOnly(2022, 8, 11) },
                    { 30, 873.38999999999999, 314.79000000000002, "SubGerente", new DateOnly(2022, 7, 5), 525.82000000000005, new DateOnly(2022, 11, 27) },
                    { 31, 772.67999999999995, 690.99000000000001, "Directo", new DateOnly(2022, 9, 1), 357.69, new DateOnly(2022, 12, 27) },
                    { 32, 91.349999999999994, 588.54999999999995, "Dinánmico", new DateOnly(2023, 1, 15), 707.97000000000003, new DateOnly(2023, 2, 27) },
                    { 33, 851.14999999999998, 154.63, "Humano", new DateOnly(2022, 7, 26), 227.15000000000001, new DateOnly(2023, 2, 19) },
                    { 34, 724.75, 297.25, "Regional", new DateOnly(2022, 9, 18), 236.80000000000001, new DateOnly(2023, 5, 24) },
                    { 35, 859.16999999999996, 555.13999999999999, "Director", new DateOnly(2022, 6, 24), 1.1599999999999999, new DateOnly(2022, 7, 23) },
                    { 36, 474.91000000000003, 480.01999999999998, "Global", new DateOnly(2023, 3, 23), 340.47000000000003, new DateOnly(2023, 5, 27) },
                    { 37, 222.56999999999999, 320.91000000000003, "Director", new DateOnly(2022, 9, 7), 885.63999999999999, new DateOnly(2022, 10, 24) },
                    { 38, 371.74000000000001, 954.55999999999995, "Nacional", new DateOnly(2022, 6, 12), 959.88, new DateOnly(2023, 2, 8) },
                    { 39, 787.10000000000002, 178.11000000000001, "Inversor", new DateOnly(2022, 10, 19), 106.73, new DateOnly(2023, 1, 16) },
                    { 40, 836.47000000000003, 322.43000000000001, "Jefe", new DateOnly(2022, 8, 23), 566.33000000000004, new DateOnly(2023, 2, 10) },
                    { 41, 124.06999999999999, 603.46000000000004, "Central", new DateOnly(2022, 12, 28), 844.95000000000005, new DateOnly(2022, 8, 21) },
                    { 42, 611.22000000000003, 105.06999999999999, "Heredado", new DateOnly(2022, 7, 17), 799.96000000000004, new DateOnly(2023, 1, 26) },
                    { 43, 301.93000000000001, 739.37, "Regional", new DateOnly(2022, 10, 28), 576.27999999999997, new DateOnly(2023, 2, 16) },
                    { 44, 387.07999999999998, 725.45000000000005, "International", new DateOnly(2022, 6, 22), 825.96000000000004, new DateOnly(2023, 2, 27) },
                    { 45, 313.5, 500.56999999999999, "Humano", new DateOnly(2022, 6, 5), 655.45000000000005, new DateOnly(2023, 1, 20) },
                    { 46, 830.98000000000002, 603.71000000000004, "Heredado", new DateOnly(2022, 9, 22), 329.64999999999998, new DateOnly(2022, 9, 4) },
                    { 47, 750.10000000000002, 616.40999999999997, "Director", new DateOnly(2022, 10, 22), 373.31999999999999, new DateOnly(2022, 9, 24) },
                    { 48, 639.77999999999997, 193.66, "Humano", new DateOnly(2022, 10, 5), 710.70000000000005, new DateOnly(2023, 2, 26) },
                    { 49, 761.70000000000005, 907.75999999999999, "Dinánmico", new DateOnly(2022, 10, 12), 975.78999999999996, new DateOnly(2022, 7, 19) },
                    { 50, 781.46000000000004, 134.81, "Global", new DateOnly(2022, 7, 28), 435.54000000000002, new DateOnly(2023, 5, 4) },
                    { 51, 884.38999999999999, 100.25, "Cliente", new DateOnly(2022, 10, 6), 599.16999999999996, new DateOnly(2022, 8, 15) },
                    { 52, 767.32000000000005, 249.74000000000001, "Nacional", new DateOnly(2022, 6, 26), 788.32000000000005, new DateOnly(2022, 8, 31) },
                    { 53, 873.30999999999995, 30.199999999999999, "Cliente", new DateOnly(2022, 11, 17), 572.91999999999996, new DateOnly(2022, 10, 13) },
                    { 54, 542.21000000000004, 120.40000000000001, "Dinánmico", new DateOnly(2023, 1, 16), 379.05000000000001, new DateOnly(2022, 9, 3) },
                    { 55, 832.10000000000002, 339.54000000000002, "SubGerente", new DateOnly(2023, 5, 14), 608.24000000000001, new DateOnly(2023, 4, 15) },
                    { 56, 929.69000000000005, 104.08, "Corporativo", new DateOnly(2023, 3, 25), 751.47000000000003, new DateOnly(2022, 11, 27) },
                    { 57, 233.81999999999999, 560.32000000000005, "Cliente", new DateOnly(2023, 1, 6), 126.29000000000001, new DateOnly(2022, 10, 3) },
                    { 58, 154.13, 396.01999999999998, "Nacional", new DateOnly(2022, 11, 1), 340.36000000000001, new DateOnly(2022, 8, 30) },
                    { 59, 474.31999999999999, 331.30000000000001, "Directo", new DateOnly(2023, 3, 23), 954.36000000000001, new DateOnly(2023, 3, 19) },
                    { 60, 810.5, 67.430000000000007, "Adelante", new DateOnly(2023, 4, 29), 220.00999999999999, new DateOnly(2023, 4, 21) },
                    { 61, 515.49000000000001, 394.67000000000002, "Global", new DateOnly(2023, 3, 4), 320.54000000000002, new DateOnly(2022, 8, 27) },
                    { 62, 486.75999999999999, 368.88, "Nacional", new DateOnly(2022, 10, 24), 444.77999999999997, new DateOnly(2022, 9, 25) },
                    { 63, 948.25999999999999, 542.84000000000003, "International", new DateOnly(2023, 2, 20), 961.63999999999999, new DateOnly(2022, 11, 10) },
                    { 64, 352.64999999999998, 423.57999999999998, "Jefe", new DateOnly(2023, 2, 16), 453.51999999999998, new DateOnly(2023, 2, 6) },
                    { 65, 710.08000000000004, 912.11000000000001, "Central", new DateOnly(2023, 5, 25), 101.54000000000001, new DateOnly(2022, 9, 9) },
                    { 66, 945.40999999999997, 293.75999999999999, "International", new DateOnly(2023, 1, 12), 768.64999999999998, new DateOnly(2022, 8, 29) },
                    { 67, 346.86000000000001, 828.77999999999997, "Futuro", new DateOnly(2023, 4, 20), 68.819999999999993, new DateOnly(2022, 6, 24) },
                    { 68, 896.63999999999999, 780.98000000000002, "Directo", new DateOnly(2022, 8, 21), 416.86000000000001, new DateOnly(2023, 5, 10) },
                    { 69, 668.14999999999998, 450.54000000000002, "Distrito", new DateOnly(2022, 6, 11), 767.5, new DateOnly(2022, 12, 25) },
                    { 70, 798.04999999999995, 715.21000000000004, "Cliente", new DateOnly(2022, 7, 18), 438.14999999999998, new DateOnly(2022, 7, 12) },
                    { 71, 580.76999999999998, 758.58000000000004, "Futuro", new DateOnly(2022, 11, 13), 210.36000000000001, new DateOnly(2023, 1, 12) },
                    { 72, 275.05000000000001, 945.11000000000001, "Humano", new DateOnly(2023, 3, 5), 982.55999999999995, new DateOnly(2023, 2, 1) },
                    { 73, 82.840000000000003, 854.25, "Interno", new DateOnly(2023, 3, 29), 69.379999999999995, new DateOnly(2022, 12, 2) },
                    { 74, 704.40999999999997, 678.41999999999996, "Humano", new DateOnly(2022, 9, 1), 319.91000000000003, new DateOnly(2023, 4, 22) },
                    { 75, 696.92999999999995, 689.71000000000004, "International", new DateOnly(2022, 9, 4), 217.28, new DateOnly(2022, 9, 5) },
                    { 76, 455.44, 393.17000000000002, "Adelante", new DateOnly(2022, 7, 26), 402.25, new DateOnly(2023, 4, 11) },
                    { 77, 860.49000000000001, 297.14999999999998, "Adelante", new DateOnly(2022, 6, 7), 516.62, new DateOnly(2023, 4, 12) },
                    { 78, 252.71000000000001, 360.23000000000002, "Producto", new DateOnly(2023, 3, 8), 699.13, new DateOnly(2022, 6, 2) },
                    { 79, 220.44999999999999, 977.25999999999999, "Global", new DateOnly(2022, 6, 6), 764.99000000000001, new DateOnly(2022, 8, 19) },
                    { 80, 354.95999999999998, 383.86000000000001, "SubGerente", new DateOnly(2022, 9, 12), 124.48, new DateOnly(2022, 11, 1) },
                    { 81, 129.09, 250.25999999999999, "Senior", new DateOnly(2022, 6, 19), 607.12, new DateOnly(2022, 8, 14) },
                    { 82, 342.70999999999998, 396.35000000000002, "International", new DateOnly(2022, 7, 24), 510.81999999999999, new DateOnly(2023, 1, 25) },
                    { 83, 154.12, 46.299999999999997, "SubGerente", new DateOnly(2022, 5, 31), 774.65999999999997, new DateOnly(2022, 6, 15) },
                    { 84, 421.49000000000001, 60.420000000000002, "Nacional", new DateOnly(2022, 11, 16), 170.09, new DateOnly(2022, 12, 11) },
                    { 85, 551.62, 362.30000000000001, "Director", new DateOnly(2023, 1, 15), 775.53999999999996, new DateOnly(2023, 1, 6) },
                    { 86, 399.22000000000003, 265.94, "Senior", new DateOnly(2022, 10, 29), 888.24000000000001, new DateOnly(2023, 4, 19) },
                    { 87, 452.52999999999997, 290.52999999999997, "Global", new DateOnly(2022, 8, 13), 376.12, new DateOnly(2023, 1, 30) },
                    { 88, 324.70999999999998, 724.88999999999999, "Gerente", new DateOnly(2022, 7, 10), 659.98000000000002, new DateOnly(2023, 2, 7) },
                    { 89, 877.89999999999998, 115.23, "Central", new DateOnly(2022, 11, 24), 728.11000000000001, new DateOnly(2022, 6, 23) },
                    { 90, 75.799999999999997, 76.890000000000001, "SubGerente", new DateOnly(2022, 12, 16), 797.02999999999997, new DateOnly(2022, 11, 28) },
                    { 91, 355.75999999999999, 908.12, "Adelante", new DateOnly(2023, 3, 12), 921.59000000000003, new DateOnly(2023, 5, 21) },
                    { 92, 785.33000000000004, 546.92999999999995, "Futuro", new DateOnly(2022, 12, 3), 475.97000000000003, new DateOnly(2022, 11, 18) },
                    { 93, 374.88999999999999, 778.46000000000004, "Distrito", new DateOnly(2022, 8, 2), 270.19999999999999, new DateOnly(2022, 12, 4) },
                    { 94, 456.37, 936.72000000000003, "Regional", new DateOnly(2023, 4, 12), 514.22000000000003, new DateOnly(2022, 10, 23) },
                    { 95, 329.25, 120.61, "Directo", new DateOnly(2023, 5, 29), 779.74000000000001, new DateOnly(2022, 10, 29) },
                    { 96, 442.62, 470.67000000000002, "Senior", new DateOnly(2022, 9, 11), 946.02999999999997, new DateOnly(2023, 2, 27) },
                    { 97, 397.89999999999998, 842.49000000000001, "Directo", new DateOnly(2022, 9, 28), 121.31, new DateOnly(2023, 2, 16) },
                    { 98, 471.72000000000003, 709.80999999999995, "Cliente", new DateOnly(2022, 12, 13), 699.22000000000003, new DateOnly(2023, 3, 7) },
                    { 99, 624.37, 20.43, "Humano", new DateOnly(2022, 6, 13), 235.63, new DateOnly(2022, 6, 6) },
                    { 100, 333.76999999999998, 585.78999999999996, "Adelante", new DateOnly(2023, 1, 2), 307.08999999999997, new DateOnly(2022, 11, 25) }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "brand", "code", "description", "name", "quantity", "saleprice" },
                values: new object[,]
                {
                    { 1, "Inteligente", "1711364021318", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sin marca Cotton Ensalada", 64, 334571.28f },
                    { 2, "Elegante", "3083794495716", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licencia Acero Bike", 40, 520603.1f },
                    { 3, "Pequeño", "5509627807344", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Increíble Hormigón Embutidos", 31, 498163.16f },
                    { 4, "Sabrosa", "1282567422573", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Hecho a mano Metal Pantalones", 77, 309995.88f },
                    { 5, "Increíble", "1717808314060", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sin marca Hormigón Pescado", 24, 532043.25f },
                    { 6, "Increíble", "1245181469911", "The Football Is Good For Training And Recreational Purposes", "Inteligente Frozen Bike", 45, 584755.75f },
                    { 7, "Gorgeous", "4796148232149", "The Football Is Good For Training And Recreational Purposes", "Artesanal Metal Sombrero", 6, 401574.16f },
                    { 8, "Elegante", "2808984009761", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licencia Soft Pantalones", 51, 361500.78f },
                    { 9, "Increíble", "8109223578418", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Elegante Soft Auto", 23, 383677.22f },
                    { 10, "Práctica", "4000400204035", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Increíble Soft Pelota", 42, 670598.9f },
                    { 11, "Inteligente", "6383943305536", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Genérica Frozen Pelota", 33, 631483.25f },
                    { 12, "Pequeño", "5577257233918", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Increíble Cotton Zapatos", 52, 468625.12f },
                    { 13, "Sabrosa", "5118323022540", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Elegante Granito Ratón", 32, 433479.8f },
                    { 14, "Rústico", "2784451894835", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Genérica Hormigón Pelota", 46, 309746f },
                    { 15, "Artesanal", "5563705314698", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Genérica Plástico Zapatos", 56, 396812.5f },
                    { 16, "Rústico", "7266896415219", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refinado Caucho Pantalones", 72, 506980.3f },
                    { 17, "Increíble", "8550566959943", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licencia Frozen Teclado", 1, 697976.5f },
                    { 18, "Increíble", "2795683350846", "The Football Is Good For Training And Recreational Purposes", "Gorgeous Granito Zapatos", 26, 448207.66f },
                    { 19, "Gorgeous", "3634456340709", "The Football Is Good For Training And Recreational Purposes", "Inteligente Granito Pescado", 33, 648163.44f },
                    { 20, "Refinado", "9875987598762", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Inteligente Caucho Toallas", 71, 517350.75f },
                    { 21, "Sin marca", "8482888652946", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sin marca Granito Tuna", 70, 388955.47f },
                    { 22, "Increíble", "6254040914740", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licencia Cotton Pollo", 40, 383161.53f },
                    { 23, "Refinado", "7122415417785", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Genérica Frozen Zapatos", 60, 602814.6f },
                    { 24, "Licencia", "2846194266895", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Madera Pelota", 67, 520953.25f },
                    { 25, "Sin marca", "1337277580911", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Madera Ratón", 13, 520401.9f },
                    { 26, "Inteligente", "2044796028549", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rústico Soft Camisa", 69, 412251.12f },
                    { 27, "Elegante", "0381127586517", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refinado Fresco Tuna", 69, 564391f },
                    { 28, "Hecho a mano", "0637454011155", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licencia Madera Teclado", 24, 304556f },
                    { 29, "Inteligente", "8474638392547", "The Football Is Good For Training And Recreational Purposes", "Fantástico Plástico Teclado", 17, 347400.9f },
                    { 30, "Artesanal", "5808413000236", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licencia Madera Pelota", 67, 336623.84f },
                    { 31, "Artesanal", "5056461603712", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Genérica Metal Embutidos", 71, 639131.75f },
                    { 32, "Elegante", "6546365347021", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Hecho a mano Plástico Pantalones", 31, 501392.03f },
                    { 33, "Genérica", "7089800175982", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rústico Fresco Tocino", 61, 581752.75f },
                    { 34, "Refinado", "2628576077820", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Increíble Hormigón Toallas", 32, 690577.56f },
                    { 35, "Artesanal", "7089673675213", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sin marca Madera Pelota", 60, 432599.4f },
                    { 36, "Sabrosa", "1954729831812", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonómico Acero Camisa", 38, 677349.25f },
                    { 37, "Ergonómico", "5635662836855", "The Football Is Good For Training And Recreational Purposes", "Hecho a mano Acero Presidente", 73, 331984.28f },
                    { 38, "Sabrosa", "7302528411317", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Pequeño Cotton Camisa", 76, 468767.78f },
                    { 39, "Inteligente", "2741264479796", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sin marca Fresco Presidente", 5, 457282.3f },
                    { 40, "Increíble", "4842840218568", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Hecho a mano Madera Bike", 79, 659117.8f },
                    { 41, "Hecho a mano", "8884990617958", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Práctica Soft Mesa", 21, 675508.44f },
                    { 42, "Ergonómico", "2051325013013", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonómico Madera Ensalada", 60, 639590.4f },
                    { 43, "Licencia", "1953964272428", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Frozen Pizza", 69, 643811.2f },
                    { 44, "Hecho a mano", "9672030668065", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Elegante Soft Auto", 73, 546771.6f },
                    { 45, "Práctica", "5453723788451", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantástico Plástico Zapatos", 3, 585546f },
                    { 46, "Gorgeous", "5027662624394", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Práctica Soft Queso", 60, 679716.25f },
                    { 47, "Pequeño", "7398258344346", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licencia Soft Toallas", 38, 691934.2f },
                    { 48, "Sabrosa", "2784447794156", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonómico Soft Sombrero", 15, 509756.38f },
                    { 49, "Pequeño", "3157646155193", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licencia Caucho Auto", 20, 459818.53f },
                    { 50, "Elegante", "7517126609558", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sin marca Metal Sombrero", 39, 695970.7f },
                    { 51, "Sin marca", "0146867192240", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantástico Cotton Pescado", 54, 388029.28f },
                    { 52, "Rústico", "0131064474190", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantástico Acero Tuna", 12, 469955.66f },
                    { 53, "Licencia", "3471442336977", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sin marca Fresco Tocino", 12, 698185.2f },
                    { 54, "Fantástico", "8498991411929", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Práctica Soft Bike", 62, 580550.3f },
                    { 55, "Genérica", "4945500435784", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Artesanal Frozen Camisa", 31, 491884.75f },
                    { 56, "Pequeño", "9635446730696", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sin marca Madera Presidente", 59, 643443.6f },
                    { 57, "Hecho a mano", "7123423273141", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Increíble Plástico Camisa", 22, 522817.7f },
                    { 58, "Inteligente", "9293897177837", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Inteligente Granito Pollo", 36, 597330f },
                    { 59, "Sin marca", "8534485251661", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Inteligente Madera Mesa", 80, 349654.03f },
                    { 60, "Rústico", "2157770069695", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Artesanal Madera Pollo", 14, 636549.56f },
                    { 61, "Increíble", "6880931198052", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonómico Granito Computadora", 25, 455417.66f },
                    { 62, "Licencia", "6179791800411", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonómico Madera Tuna", 14, 685110.44f },
                    { 63, "Genérica", "8531738379554", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Metal Zapatos", 50, 397841.84f },
                    { 64, "Inteligente", "6561254475692", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sin marca Acero Presidente", 11, 449257.22f },
                    { 65, "Increíble", "7031904787134", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refinado Fresco Camisa", 24, 533511.9f },
                    { 66, "Práctica", "9215514215111", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refinado Madera Tuna", 48, 430563.97f },
                    { 67, "Fantástico", "0545157465406", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Increíble Metal Pizza", 25, 581056f },
                    { 68, "Sabrosa", "2539591932431", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Madera Sombrero", 11, 432085.47f },
                    { 69, "Sin marca", "3055915584241", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Increíble Plástico Tocino", 8, 303341.9f },
                    { 70, "Inteligente", "7528078556463", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licencia Hormigón Pizza", 22, 646709.94f },
                    { 71, "Increíble", "5197881874624", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refinado Madera Auto", 39, 509132.56f },
                    { 72, "Inteligente", "1068124806082", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Increíble Cotton Tocino", 6, 455780.7f },
                    { 73, "Hecho a mano", "6174152387549", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refinado Hormigón Auto", 8, 379520.53f },
                    { 74, "Elegante", "7705111625427", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Hecho a mano Soft Camisa", 27, 652256f },
                    { 75, "Sabrosa", "0491259395649", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Frozen Presidente", 54, 621319.44f },
                    { 76, "Sin marca", "2917045318268", "The Football Is Good For Training And Recreational Purposes", "Sin marca Plástico Guantes", 46, 449327.16f },
                    { 77, "Artesanal", "1051901933156", "The Football Is Good For Training And Recreational Purposes", "Práctica Metal Pescado", 59, 665205.3f },
                    { 78, "Elegante", "0008130359166", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sin marca Soft Queso", 59, 615305.25f },
                    { 79, "Licencia", "4909281094196", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonómico Caucho Ensalada", 69, 657063.3f },
                    { 80, "Inteligente", "7441384391873", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refinado Soft Pollo", 46, 494087.7f },
                    { 81, "Increíble", "9117032392889", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonómico Caucho Queso", 31, 466800.25f },
                    { 82, "Gorgeous", "4892312200317", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rústico Granito Tocino", 40, 362653.44f },
                    { 83, "Sabrosa", "4256152214154", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonómico Hormigón Pizza", 21, 336687.56f },
                    { 84, "Práctica", "9526663215052", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantástico Cotton Pescado", 54, 405047.7f },
                    { 85, "Hecho a mano", "6224522759299", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Genérica Cotton Embutidos", 39, 678073.56f },
                    { 86, "Sabrosa", "6883866094635", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sabrosa Caucho Guantes", 29, 620300.44f },
                    { 87, "Artesanal", "5282608139435", "The Football Is Good For Training And Recreational Purposes", "Práctica Cotton Pollo", 22, 455862.47f },
                    { 88, "Refinado", "8281096806048", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Increíble Cotton Mesa", 52, 389462.72f },
                    { 89, "Fantástico", "5379056828346", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Plástico Sombrero", 48, 506144.4f },
                    { 90, "Fantástico", "7544007277308", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Pequeño Granito Mesa", 20, 329368.53f },
                    { 91, "Increíble", "4496536700174", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sabrosa Caucho Ensalada", 23, 352162.47f },
                    { 92, "Práctica", "4074396266902", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Increíble Plástico Queso", 49, 630145.75f },
                    { 93, "Fantástico", "1407920970014", "The Football Is Good For Training And Recreational Purposes", "Hecho a mano Hormigón Presidente", 37, 527762.94f },
                    { 94, "Rústico", "5899693849134", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Hecho a mano Fresco Pescado", 29, 453948.6f },
                    { 95, "Sin marca", "8658118417672", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rústico Frozen Pollo", 23, 551003.3f },
                    { 96, "Ergonómico", "0840519761036", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sin marca Frozen Pizza", 20, 413024.88f },
                    { 97, "Licencia", "3406130384725", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Genérica Madera Pizza", 54, 653841.6f },
                    { 98, "Elegante", "7792444440940", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Increíble Metal Sombrero", 54, 642231f },
                    { 99, "Ergonómico", "1569476064989", "The Football Is Good For Training And Recreational Purposes", "Rústico Granito Bike", 42, 628746.7f },
                    { 100, "Sin marca", "3756985691531", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonómico Fresco Presidente", 36, 562199f }
                });

            migrationBuilder.InsertData(
                table: "purchases",
                columns: new[] { "id", "code", "description", "product_id", "quantity", "supplier_id", "datepurchase", "purchaseprice", "saleprice" },
                values: new object[,]
                {
                    { 1, "9299144365101", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 52, null, new DateOnly(2022, 9, 5), 287736.3f, 182473.03f },
                    { 2, "9214056627147", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 65, null, new DateOnly(2022, 11, 23), 328465.88f, 464206.38f },
                    { 3, "1500912937627", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 38, null, new DateOnly(2022, 12, 29), 439923f, 465866.88f },
                    { 4, "7010910418850", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 49, null, new DateOnly(2022, 9, 11), 313539.56f, 385573.94f },
                    { 5, "4455484406552", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 51, null, new DateOnly(2022, 12, 30), 108513.18f, 296872.3f },
                    { 6, "5360089944523", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 67, null, new DateOnly(2022, 9, 29), 332809.53f, 211126.64f },
                    { 7, "2082528071364", "The Football Is Good For Training And Recreational Purposes", null, 17, null, new DateOnly(2022, 6, 21), 105208.67f, 298298.38f },
                    { 8, "5201955931806", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 51, null, new DateOnly(2023, 4, 9), 110129.92f, 338978.5f },
                    { 9, "5791183712099", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 12, null, new DateOnly(2022, 12, 6), 307263.75f, 396086.3f },
                    { 10, "1620303275302", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 73, null, new DateOnly(2023, 1, 23), 280905.6f, 419334.6f },
                    { 11, "1494029011045", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 39, null, new DateOnly(2022, 11, 2), 196353.34f, 291668.3f },
                    { 12, "4456946866853", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 70, null, new DateOnly(2023, 1, 18), 491117.62f, 107559.805f },
                    { 13, "5059486548518", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 67, null, new DateOnly(2023, 1, 30), 186984.53f, 103422.195f },
                    { 14, "1377445774797", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 79, null, new DateOnly(2022, 9, 5), 183066f, 282252.94f },
                    { 15, "5759821760727", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 9, null, new DateOnly(2022, 7, 20), 402717f, 280874.7f },
                    { 16, "2786636517430", "The Football Is Good For Training And Recreational Purposes", null, 52, null, new DateOnly(2022, 6, 19), 398118.66f, 452664.6f },
                    { 17, "5338489911001", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 26, null, new DateOnly(2022, 8, 15), 315408.22f, 274182.47f },
                    { 18, "1427269902422", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 32, null, new DateOnly(2022, 10, 25), 318710.5f, 411981.66f },
                    { 19, "6096655486812", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 61, null, new DateOnly(2022, 7, 23), 187048.27f, 349992.44f },
                    { 20, "5207659433462", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 62, null, new DateOnly(2022, 7, 26), 370191.6f, 471985.12f },
                    { 21, "6427311391865", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 68, null, new DateOnly(2023, 5, 19), 289552.62f, 332961.38f },
                    { 22, "7834168748411", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 76, null, new DateOnly(2023, 2, 10), 285872.56f, 248937.02f },
                    { 23, "5409925620860", "The Football Is Good For Training And Recreational Purposes", null, 18, null, new DateOnly(2023, 5, 25), 384980.03f, 444084.78f },
                    { 24, "6554881139747", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 75, null, new DateOnly(2022, 6, 6), 358817.03f, 288184.1f },
                    { 25, "4649145028133", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 54, null, new DateOnly(2022, 7, 3), 389647.06f, 418208.8f },
                    { 26, "1710452813118", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 34, null, new DateOnly(2023, 4, 3), 116908.22f, 319125.97f },
                    { 27, "0255186433696", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 53, null, new DateOnly(2023, 4, 23), 194486.95f, 447317.1f },
                    { 28, "5007898583009", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 3, null, new DateOnly(2022, 7, 24), 258433.94f, 301909.88f },
                    { 29, "9203843005190", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 33, null, new DateOnly(2022, 10, 22), 155311.44f, 340145.84f },
                    { 30, "8797728198110", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 24, null, new DateOnly(2022, 7, 19), 403590.3f, 155123.02f },
                    { 31, "1517194288514", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 70, null, new DateOnly(2023, 4, 19), 486210.1f, 393283.34f },
                    { 32, "2541448903471", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 78, null, new DateOnly(2023, 4, 11), 152302.84f, 470537.7f },
                    { 33, "9037748805094", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 58, null, new DateOnly(2022, 9, 7), 173069.25f, 364706.3f },
                    { 34, "8073944445369", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 14, null, new DateOnly(2022, 10, 31), 306165.2f, 435845.9f },
                    { 35, "8790493636665", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 26, null, new DateOnly(2022, 12, 23), 159132.8f, 292061.88f },
                    { 36, "7681563550213", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 37, null, new DateOnly(2023, 2, 23), 168135.38f, 205306.81f },
                    { 37, "3110532174135", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 30, null, new DateOnly(2023, 1, 6), 324373.25f, 229805.6f },
                    { 38, "8894875721403", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 30, null, new DateOnly(2023, 3, 2), 388884.72f, 225621.3f },
                    { 39, "0133264255036", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 72, null, new DateOnly(2023, 1, 2), 155049.42f, 255855.69f },
                    { 40, "0864581992600", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 41, null, new DateOnly(2023, 1, 27), 475085.38f, 402809.78f },
                    { 41, "2050162438843", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 10, null, new DateOnly(2022, 10, 1), 358894.6f, 145406.98f },
                    { 42, "0191805548597", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 1, null, new DateOnly(2022, 10, 24), 380641.16f, 148721.72f },
                    { 43, "6532522270639", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 67, null, new DateOnly(2022, 9, 28), 145287.86f, 320273.7f },
                    { 44, "0570093892276", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 17, null, new DateOnly(2023, 3, 11), 114988.34f, 460951.1f },
                    { 45, "1942812865769", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 47, null, new DateOnly(2023, 3, 22), 125408.42f, 138716.05f },
                    { 46, "2809884671324", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 30, null, new DateOnly(2023, 3, 11), 123473.92f, 371764.3f },
                    { 47, "8811650501258", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 21, null, new DateOnly(2022, 9, 6), 341043.75f, 117506.266f },
                    { 48, "2017898672675", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 44, null, new DateOnly(2022, 8, 31), 494983.12f, 208733.62f },
                    { 49, "6399730045851", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 51, null, new DateOnly(2023, 4, 28), 465517.7f, 454417.4f },
                    { 50, "3854391407576", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 17, null, new DateOnly(2022, 8, 30), 419905.7f, 127801.37f },
                    { 51, "3011343858224", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 31, null, new DateOnly(2022, 8, 20), 208184.7f, 100542.51f },
                    { 52, "4206061287589", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 72, null, new DateOnly(2022, 7, 30), 365089.44f, 290680.53f },
                    { 53, "7813659634259", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 63, null, new DateOnly(2023, 5, 26), 170364.52f, 122697.43f },
                    { 54, "5858933713895", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 74, null, new DateOnly(2022, 8, 5), 224759.14f, 458908.6f }
                });

            migrationBuilder.InsertData(
                table: "purchases",
                columns: new[] { "id", "code", "description", "product_id", "quantity", "supplier_id", "datepurchase", "purchaseprice", "saleprice" },
                values: new object[,]
                {
                    { 55, "8104576391134", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 19, null, new DateOnly(2022, 6, 29), 400356.8f, 402357.97f },
                    { 56, "6148019599000", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 34, null, new DateOnly(2022, 9, 20), 321745.56f, 234044.47f },
                    { 57, "0205681314600", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 39, null, new DateOnly(2022, 9, 25), 381458.44f, 493614.28f },
                    { 58, "5778615301557", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 12, null, new DateOnly(2023, 3, 20), 439863.8f, 317658.94f },
                    { 59, "8139205600127", "The Football Is Good For Training And Recreational Purposes", null, 72, null, new DateOnly(2023, 2, 23), 224923.1f, 175331.8f },
                    { 60, "6704896432764", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 40, null, new DateOnly(2022, 7, 2), 462464.7f, 326168.28f },
                    { 61, "0232058136879", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 31, null, new DateOnly(2022, 6, 23), 107182.68f, 303887.78f },
                    { 62, "2338429217753", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 22, null, new DateOnly(2023, 1, 22), 497301.47f, 159807.33f },
                    { 63, "8041801263579", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 54, null, new DateOnly(2023, 2, 21), 195035.31f, 414984.78f },
                    { 64, "5145224627796", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 12, null, new DateOnly(2023, 1, 1), 386256.25f, 328259.84f },
                    { 65, "3373232372786", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 58, null, new DateOnly(2022, 7, 27), 199431.52f, 384917.28f },
                    { 66, "7681046222880", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 66, null, new DateOnly(2022, 7, 19), 436138.16f, 228069.52f },
                    { 67, "1403743904335", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 61, null, new DateOnly(2022, 8, 22), 247260.66f, 398980.28f },
                    { 68, "1730789711147", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 46, null, new DateOnly(2023, 2, 27), 337649.94f, 193754.98f },
                    { 69, "4118688224710", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", null, 33, null, new DateOnly(2023, 4, 25), 117729.52f, 326947.06f },
                    { 70, "6871710363464", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 35, null, new DateOnly(2023, 2, 7), 132376.42f, 428319.34f },
                    { 71, "3627985585314", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 21, null, new DateOnly(2022, 7, 21), 334380.66f, 332380.8f },
                    { 72, "1105082863310", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 42, null, new DateOnly(2022, 10, 21), 256427.73f, 485774.06f },
                    { 73, "8052177950512", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 47, null, new DateOnly(2022, 9, 23), 288801.8f, 304573.1f },
                    { 74, "1881834967436", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 42, null, new DateOnly(2023, 1, 9), 391863.84f, 394551.72f },
                    { 75, "6984630115706", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 44, null, new DateOnly(2022, 11, 9), 265536.22f, 183557.31f },
                    { 76, "9920268865078", "The Football Is Good For Training And Recreational Purposes", null, 21, null, new DateOnly(2022, 10, 3), 352796.6f, 105283.49f },
                    { 77, "9264707575969", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", null, 77, null, new DateOnly(2022, 6, 15), 127553.5f, 424526.97f },
                    { 78, "1606657174539", "The Football Is Good For Training And Recreational Purposes", null, 70, null, new DateOnly(2022, 6, 5), 142554.25f, 172626.95f },
                    { 79, "4658957415208", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 24, null, new DateOnly(2022, 9, 13), 352243.75f, 465118.2f },
                    { 80, "8472656039765", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 58, null, new DateOnly(2022, 7, 11), 191994.19f, 447458.2f },
                    { 81, "2258959756860", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", null, 3, null, new DateOnly(2022, 8, 22), 323278.8f, 205532.31f },
                    { 82, "9369743348918", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 52, null, new DateOnly(2022, 9, 3), 213213.06f, 325888.56f },
                    { 83, "2783776186540", "The Football Is Good For Training And Recreational Purposes", null, 48, null, new DateOnly(2023, 1, 23), 194181.08f, 334439.22f },
                    { 84, "1989190581829", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 80, null, new DateOnly(2022, 6, 14), 424147.6f, 240615.75f },
                    { 85, "0192980100112", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 50, null, new DateOnly(2022, 10, 15), 452512.88f, 335605.8f },
                    { 86, "8683284315880", "The Football Is Good For Training And Recreational Purposes", null, 58, null, new DateOnly(2022, 7, 23), 465886.6f, 428492.34f },
                    { 87, "0145330132134", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", null, 70, null, new DateOnly(2022, 11, 21), 394100.97f, 255904.19f },
                    { 88, "8094295495704", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 28, null, new DateOnly(2022, 10, 5), 292766.16f, 361658.75f },
                    { 89, "4986307102882", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 58, null, new DateOnly(2022, 11, 25), 410766.53f, 435524.06f },
                    { 90, "4595774247769", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, 7, null, new DateOnly(2022, 6, 9), 373099.5f, 441634.3f },
                    { 91, "7031518122147", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 64, null, new DateOnly(2022, 10, 20), 391432.5f, 247329.45f },
                    { 92, "5428873558148", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 65, null, new DateOnly(2022, 11, 8), 179200.12f, 182309.58f },
                    { 93, "8753561209185", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, 6, null, new DateOnly(2022, 8, 26), 263719.28f, 206354.86f },
                    { 94, "5858812858617", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 18, null, new DateOnly(2022, 12, 15), 268141.38f, 330701.38f },
                    { 95, "1663752041463", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, 50, null, new DateOnly(2022, 10, 21), 425421.56f, 389234.5f },
                    { 96, "4238402763452", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", null, 71, null, new DateOnly(2022, 11, 4), 358531.38f, 446830.5f },
                    { 97, "3160686234070", "The Football Is Good For Training And Recreational Purposes", null, 43, null, new DateOnly(2022, 8, 30), 426116.8f, 147550.55f },
                    { 98, "3885581713757", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, 25, null, new DateOnly(2023, 1, 13), 159196.39f, 253476.27f },
                    { 99, "4846336923011", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, 75, null, new DateOnly(2023, 5, 8), 193244.6f, 138756.27f },
                    { 100, "7888902956105", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", null, 7, null, new DateOnly(2023, 5, 16), 280528.66f, 393209.1f }
                });

            migrationBuilder.InsertData(
                table: "receptionists",
                columns: new[] { "id", "address", "email", "name", "phone", "salary", "surname", "user_id" },
                values: new object[,]
                {
                    { 1, "Libros", "Isabel_Verduzco55@yahoo.com", "Isabel", "5115-592-656", 3263789.2f, "Verduzco", null },
                    { 2, "Películas, Juguetes & Kids", "Isabela_Garcia23@hotmail.com", "Isabela", "510 549 887", 3852780.5f, "García", null },
                    { 3, "Joyería, Ropa & Deportes", "Jacobo.Zavala46@gmail.com", "Jacobo", "581034895", 2883636.5f, "Zavala", null },
                    { 4, "Hogar", "Hugo21@gmail.com", "Hugo", "5140-818-718", 1730712.1f, "Banda", null },
                    { 5, "Deportes, Industrial & Ropa", "Valeria_Zayas@yahoo.com", "Valeria", "540531328", 3369808.5f, "Zayas", null },
                    { 6, "Ultramarinos & Ropa", "Paulina_Leal44@gmail.com", "Paulina", "542.533.880", 1262455.6f, "Leal", null },
                    { 7, "Kids & Aire libre", "Estela_Tovar@hotmail.com", "Estela", "568690150", 4729436f, "Tovar", null },
                    { 8, "Deportes", "Lorena_Yunta49@corpfolder.com", "Lorena", "586.373.361", 2870440f, "Yunta", null },
                    { 9, "Baby, Salud & Hogar", "Xochitl78@nearbpo.com", "Xochitl", "588 128 960", 2421921.8f, "Lira", null },
                    { 10, "Ultramarinos, Aire libre & Zapatos", "JoseEduardo.Marroquin23@yahoo.com", "José Eduardo", "5794-585-691", 1516981.1f, "Marroquín", null },
                    { 11, "Zapatos & Zapatos", "JoseLuis5@nearbpo.com", "José Luis", "594.232.556", 3658498.8f, "Zambrana", null },
                    { 12, "Kids, Electrónica & Automoción", "Norma18@corpfolder.com", "Norma", "598 601 463", 1080949.9f, "Banda", null },
                    { 13, "Música & Música", "Ricardo59@gmail.com", "Ricardo", "5784-968-536", 2117133.2f, "Grijalva", null },
                    { 14, "Baby", "Ivanna.Narvaez81@nearbpo.com", "Ivanna", "5489-400-610", 4210355f, "Narváez", null },
                    { 15, "Automoción", "Sergio_Lerma@nearbpo.com", "Sergio", "504.000.369", 4211449f, "Lerma", null },
                    { 16, "Deportes, Juguetes & Ropa", "Ana.Jimenez34@nearbpo.com", "Ana", "580 710 854", 1467972.1f, "Jiménez", null },
                    { 17, "Herramientas, Salud & Ropa", "MiguelAngel21@corpfolder.com", "Miguel Ángel", "563 500 672", 1737941.5f, "Caldera", null },
                    { 18, "Belleza & Herramientas", "Rosario_Alonzo@nearbpo.com", "Rosario", "547093946", 2518661.5f, "Alonzo", null },
                    { 19, "Juguetes & Joyería", "Tomas.Armas26@yahoo.com", "Tomás", "526.130.879", 3436744.8f, "Armas", null },
                    { 20, "Libros, Baby & Juguetes", "Hugo83@hotmail.com", "Hugo", "502 799 610", 3845733.5f, "Santiago", null },
                    { 21, "Jardín, Herramientas & Herramientas", "Enrique.Brito@yahoo.com", "Enrique", "516 810 602", 3883658.8f, "Brito", null },
                    { 22, "Joyería & Belleza", "Yolanda_Escobar@nearbpo.com", "Yolanda", "541.856.473", 1324274f, "Escobar", null },
                    { 23, "Electrónica & Industrial", "Isaac_Paredes@gmail.com", "Isaac", "580 969 506", 4973220f, "Paredes", null },
                    { 24, "Belleza & Zapatos", "Concepcion.Serna@gmail.com", "Concepción", "578.738.216", 1276374.6f, "Serna", null },
                    { 25, "Baby, Kids & Ultramarinos", "Rosario_Contreras@yahoo.com", "Rosario", "503 153 963", 1305060.4f, "Contreras", null },
                    { 26, "Juegos & Kids", "Sebastian_Guardado61@hotmail.com", "Sebastian", "577.796.040", 4790884.5f, "Guardado", null },
                    { 27, "Ordenadores", "Paulina.Hernandes@gmail.com", "Paulina", "500.736.060", 4563093f, "Hernandes", null },
                    { 28, "Automoción", "Angela_Arevalo16@nearbpo.com", "Ángela", "596.322.294", 1133023.9f, "Arevalo", null },
                    { 29, "Jardín, Jardín & Música", "Mario_Santiago@gmail.com", "Mario", "5518-039-124", 2031087.1f, "Santiago", null },
                    { 30, "Películas & Libros", "Ricardo_Varela18@nearbpo.com", "Ricardo", "512.897.381", 1181448.5f, "Varela", null },
                    { 31, "Industrial, Kids & Deportes", "MiguelAngel_Roque26@corpfolder.com", "Miguel Ángel", "510 725 025", 1827029.9f, "Roque", null },
                    { 32, "Herramientas, Ordenadores & Belleza", "Esperanza67@yahoo.com", "Esperanza", "543 647 865", 1654734.8f, "Abeyta", null },
                    { 33, "Automoción", "Benjamin55@corpfolder.com", "Benjamín", "537508941", 1584879.4f, "Castellanos", null },
                    { 34, "Zapatos", "Vanessa31@hotmail.com", "Vanessa", "540250251", 4352737f, "Jaime", null },
                    { 35, "Hogar", "Esteban_Gonzalez@hotmail.com", "Esteban", "536.749.475", 3427516.2f, "González", null },
                    { 36, "Automoción & Kids", "JoseEmilio.Castaneda@gmail.com", "José Emilio", "586.696.388", 2524029.5f, "Castañeda", null },
                    { 37, "Baby & Ropa", "Cecilia63@yahoo.com", "Cecilia", "536 014 245", 2905648.5f, "Abeyta", null },
                    { 38, "Hogar", "Armando_Ordonez48@gmail.com", "Armando", "532.942.303", 4966003.5f, "Ordóñez", null },
                    { 39, "Industrial", "Hugo40@nearbpo.com", "Hugo", "503120122", 4210464.5f, "Montez", null },
                    { 40, "Aire libre & Jardín", "Miranda94@nearbpo.com", "Miranda", "5429-374-548", 1322191.6f, "Zamarreno", null },
                    { 41, "Automoción & Juegos", "JoseLuis86@gmail.com", "José Luis", "5461-233-655", 4480712.5f, "Frías", null },
                    { 42, "Música, Ordenadores & Baby", "Ernesto_Rosario82@nearbpo.com", "Ernesto", "594.921.312", 1887022.9f, "Rosario", null },
                    { 43, "Ultramarinos", "Guadalupe_Holguin6@nearbpo.com", "Guadalupe", "524 344 050", 3118062f, "Holguín", null },
                    { 44, "Películas", "Alejandra.Montes45@corpfolder.com", "Alejandra", "579 305 893", 3480067f, "Montes", null },
                    { 45, "Belleza & Ultramarinos", "Gonzalo_Toro10@yahoo.com", "Gonzalo", "581 738 409", 4724373.5f, "Toro", null },
                    { 46, "Herramientas", "Emilia69@hotmail.com", "Emilia", "5187-230-708", 1785551.9f, "Valdés", null },
                    { 47, "Industrial, Ultramarinos & Kids", "Samuel_Quintairos60@yahoo.com", "Samuel", "5012-506-418", 2299010.8f, "Quintairos", null },
                    { 48, "Hogar & Jardín", "Isabel.Santana32@gmail.com", "Isabel", "543.407.669", 2114797.2f, "Santana", null },
                    { 49, "Aire libre", "Conchita21@gmail.com", "Conchita", "595128829", 1308793.1f, "Juárez", null },
                    { 50, "Hogar, Juguetes & Ropa", "MariaCristina.Orosco48@yahoo.com", "María Cristina", "502 895 307", 4972676f, "Orosco", null },
                    { 51, "Películas, Electrónica & Películas", "Irene_Alcantar@corpfolder.com", "Irene", "501 592 603", 2528693.8f, "Alcántar", null },
                    { 52, "Electrónica", "Carla.Ybarra18@yahoo.com", "Carla", "541 849 592", 4921362f, "Ybarra", null },
                    { 53, "Juegos & Electrónica", "Cristian30@corpfolder.com", "Cristian", "5348-202-213", 3234722f, "Morales", null },
                    { 54, "Baby", "Barbara71@nearbpo.com", "Barbara", "571155287", 2038040.9f, "Osorio", null },
                    { 55, "Ropa, Hogar & Belleza", "Alicia52@nearbpo.com", "Alicia", "573 187 199", 2215878f, "Alcala", null },
                    { 56, "Libros", "JoseLuis.Cantu31@corpfolder.com", "José Luis", "508 000 055", 3266746f, "Cantú", null },
                    { 57, "Electrónica", "Marilu52@gmail.com", "Marilu", "539 592 755", 1605925.5f, "Aguilera", null },
                    { 58, "Kids, Jardín & Música", "JulioCesar12@yahoo.com", "Julio César", "5530-078-534", 1784971.6f, "Carrero", null },
                    { 59, "Música & Electrónica", "Clemente36@nearbpo.com", "Clemente", "556354934", 2868305.5f, "Ocasio", null },
                    { 60, "Hogar & Aire libre", "FranciscoJavier_Saldana@yahoo.com", "Francisco Javier", "543943967", 4176763.2f, "Saldaña", null },
                    { 61, "Zapatos & Kids", "Alexander.Vergara@hotmail.com", "Alexander", "548777764", 2876373.8f, "Vergara", null },
                    { 62, "Aire libre & Baby", "Gonzalo.Arias8@corpfolder.com", "Gonzalo", "574081455", 1960712f, "Arias", null },
                    { 63, "Electrónica & Salud", "Federico51@corpfolder.com", "Federico", "576.852.124", 1472289.9f, "Montes", null },
                    { 64, "Belleza", "Veronica_Meraz@nearbpo.com", "Verónica", "570 233 299", 2081168.1f, "Meraz", null },
                    { 65, "Ropa", "MarcoAntonio.Lomeli@gmail.com", "Marco Antonio", "578450995", 2455263f, "Lomeli", null },
                    { 66, "Hogar", "Alfredo49@corpfolder.com", "Alfredo", "5741-219-478", 3951182.8f, "Cepeda", null },
                    { 67, "Libros & Herramientas", "Yaretzi86@gmail.com", "Yaretzi", "508 764 502", 1581212.5f, "Romero", null },
                    { 68, "Juguetes, Ultramarinos & Zapatos", "Veronica_Casarez@corpfolder.com", "Verónica", "519.192.877", 1833702.9f, "Casárez", null },
                    { 69, "Electrónica & Baby", "MariaLuisa.Trujillo39@hotmail.com", "María Luisa", "577 648 958", 4478119.5f, "Trujillo", null },
                    { 70, "Aire libre & Juegos", "Claudia_Barrera62@nearbpo.com", "Claudia", "5960-794-068", 2922887.2f, "Barrera", null },
                    { 71, "Ropa & Electrónica", "Carmen77@gmail.com", "Carmen", "577808394", 1264527.8f, "Rentería", null },
                    { 72, "Joyería, Ordenadores & Juguetes", "Brayan.Vergara@corpfolder.com", "Brayan", "543.910.542", 3003412.5f, "Vergara", null },
                    { 73, "Jardín", "Guillermina_Xiana@corpfolder.com", "Guillermina", "564.665.193", 3722150.2f, "Xiana", null },
                    { 74, "Joyería, Películas & Ultramarinos", "Regina_Avila@nearbpo.com", "Regina", "534.391.825", 4031471.8f, "Ávila", null },
                    { 75, "Ropa", "Xochitl90@corpfolder.com", "Xochitl", "5823-217-634", 3818679f, "Rodríquez", null },
                    { 76, "Películas", "Brandon77@gmail.com", "Brandon", "590023537", 1376586.5f, "Valles", null },
                    { 77, "Salud, Industrial & Zapatos", "Vicente61@hotmail.com", "Vicente", "516.661.886", 3148612f, "Santiago", null },
                    { 78, "Juguetes & Joyería", "Benjamin.Kanea36@nearbpo.com", "Benjamín", "553972593", 2459813.2f, "Kanea", null },
                    { 79, "Automoción & Industrial", "Lourdes.Mota63@nearbpo.com", "Lourdes", "538647524", 2500747.8f, "Mota", null },
                    { 80, "Belleza, Ultramarinos & Herramientas", "Yolanda.Cano72@gmail.com", "Yolanda", "559 729 720", 4866313f, "Cano", null },
                    { 81, "Electrónica, Ultramarinos & Industrial", "Elisa3@corpfolder.com", "Elisa", "552648721", 4027863.5f, "Zayas", null },
                    { 82, "Automoción", "Julia_Grijalva@yahoo.com", "Julia", "567.908.393", 1750773.9f, "Grijalva", null },
                    { 83, "Juguetes", "Julio_Aviles61@hotmail.com", "Julio", "5885-254-839", 2630362f, "Avilés", null },
                    { 84, "Herramientas & Belleza", "MariaGuadalupe_Almanza39@hotmail.com", "María Guadalupe", "5246-912-672", 1400563.8f, "Almanza", null },
                    { 85, "Salud, Baby & Joyería", "Olivia_Puga@corpfolder.com", "Olivia", "542 009 344", 1353971.6f, "Puga", null },
                    { 86, "Aire libre & Ropa", "Gael_Velazquez87@hotmail.com", "Gael", "5481-390-943", 3787849.2f, "Velázquez", null },
                    { 87, "Industrial, Deportes & Películas", "Carlos.Cantu@yahoo.com", "Carlos", "539 442 383", 3336515.8f, "Cantú", null },
                    { 88, "Salud, Herramientas & Juegos", "Marta.Carrasco@gmail.com", "Marta", "508.147.956", 2400364.2f, "Carrasco", null },
                    { 89, "Salud & Industrial", "FranciscoJavier.Guajardo@corpfolder.com", "Francisco Javier", "502.128.099", 1671358.9f, "Guajardo", null },
                    { 90, "Juguetes, Juegos & Industrial", "FernandoJavier_Montenegro80@nearbpo.com", "Fernando Javier", "590.167.487", 1814622.4f, "Montenegro", null },
                    { 91, "Jardín & Salud", "Claudio40@yahoo.com", "Claudio", "5808-434-455", 1439504.2f, "Valdez", null },
                    { 92, "Ropa", "Francisco_Rios@hotmail.com", "Francisco", "504.199.257", 2599898f, "Ríos", null },
                    { 93, "Aire libre & Aire libre", "Carolina_Rael7@hotmail.com", "Carolina", "556 574 382", 1257976.2f, "Rael", null },
                    { 94, "Ropa, Belleza & Música", "JoseAntonio_Prieto61@yahoo.com", "José Antonio", "518 691 776", 2964036f, "Prieto", null },
                    { 95, "Juegos", "Sebastian.Quintero@gmail.com", "Sebastian", "593.312.509", 2904905.5f, "Quintero", null },
                    { 96, "Deportes, Libros & Música", "Cristina.Alanis@corpfolder.com", "Cristina", "566.636.869", 4414157f, "Alanis", null },
                    { 97, "Ultramarinos", "Uriel12@corpfolder.com", "Uriel", "547073214", 1787293.5f, "Fonseca", null },
                    { 98, "Ropa & Industrial", "Adriana.Cardenas@hotmail.com", "Adriana", "5466-983-089", 3858659f, "Cardenas", null },
                    { 99, "Libros & Hogar", "Luis.Cedillo@hotmail.com", "Luis", "539.711.094", 4929059f, "Cedillo", null },
                    { 100, "Zapatos", "Claudia_Trevino@hotmail.com", "Claudia", "564036808", 3657552.2f, "Treviño", null }
                });

            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "id", "type" },
                values: new object[,]
                {
                    { 1, "Nómina" },
                    { 2, "Inventario" },
                    { 3, "Vehiculos" },
                    { 4, "Nómina" },
                    { 5, "Nómina" },
                    { 6, "Vehiculos" },
                    { 7, "Nómina" },
                    { 8, "Clientes" },
                    { 9, "Clientes" },
                    { 10, "Clientes" },
                    { 11, "Vehiculos" },
                    { 12, "Vehiculos" },
                    { 13, "Vehiculos" },
                    { 14, "Inventario" },
                    { 15, "Vehiculos" },
                    { 16, "Nómina" },
                    { 17, "Inventario" },
                    { 18, "Vehiculos" },
                    { 19, "Clientes" },
                    { 20, "Inventario" },
                    { 21, "Inventario" },
                    { 22, "Nómina" },
                    { 23, "Nómina" },
                    { 24, "Clientes" },
                    { 25, "Nómina" },
                    { 26, "Nómina" },
                    { 27, "Nómina" },
                    { 28, "Inventario" },
                    { 29, "Inventario" },
                    { 30, "Vehiculos" },
                    { 31, "Inventario" },
                    { 32, "Nómina" },
                    { 33, "Inventario" },
                    { 34, "Nómina" },
                    { 35, "Clientes" },
                    { 36, "Nómina" },
                    { 37, "Nómina" },
                    { 38, "Clientes" },
                    { 39, "Vehiculos" },
                    { 40, "Nómina" },
                    { 41, "Nómina" },
                    { 42, "Nómina" },
                    { 43, "Clientes" },
                    { 44, "Nómina" },
                    { 45, "Nómina" },
                    { 46, "Clientes" },
                    { 47, "Nómina" },
                    { 48, "Nómina" },
                    { 49, "Clientes" },
                    { 50, "Clientes" },
                    { 51, "Inventario" },
                    { 52, "Nómina" },
                    { 53, "Vehiculos" },
                    { 54, "Nómina" },
                    { 55, "Clientes" },
                    { 56, "Vehiculos" },
                    { 57, "Inventario" },
                    { 58, "Vehiculos" },
                    { 59, "Clientes" },
                    { 60, "Inventario" },
                    { 61, "Inventario" },
                    { 62, "Vehiculos" },
                    { 63, "Clientes" },
                    { 64, "Nómina" },
                    { 65, "Clientes" },
                    { 66, "Nómina" },
                    { 67, "Inventario" },
                    { 68, "Vehiculos" },
                    { 69, "Vehiculos" },
                    { 70, "Inventario" },
                    { 71, "Vehiculos" },
                    { 72, "Clientes" },
                    { 73, "Vehiculos" },
                    { 74, "Vehiculos" },
                    { 75, "Clientes" },
                    { 76, "Nómina" },
                    { 77, "Clientes" },
                    { 78, "Nómina" },
                    { 79, "Inventario" },
                    { 80, "Inventario" },
                    { 81, "Clientes" },
                    { 82, "Inventario" },
                    { 83, "Inventario" },
                    { 84, "Clientes" },
                    { 85, "Clientes" },
                    { 86, "Vehiculos" },
                    { 87, "Inventario" },
                    { 88, "Clientes" },
                    { 89, "Nómina" },
                    { 90, "Inventario" },
                    { 91, "Nómina" },
                    { 92, "Vehiculos" },
                    { 93, "Inventario" },
                    { 94, "Inventario" },
                    { 95, "Nómina" },
                    { 96, "Vehiculos" },
                    { 97, "Inventario" },
                    { 98, "Vehiculos" },
                    { 99, "Inventario" },
                    { 100, "Clientes" }
                });

            migrationBuilder.InsertData(
                table: "services",
                columns: new[] { "id", "category", "description", "name", "price" },
                values: new object[,]
                {
                    { 1, "Batanga", "Engastadura Descerebrar Increpador Generable Abalaustrado.", "Cencivera", 188.46000000000001 },
                    { 2, "Gencianeo", "Fideísmo Descerrumarse Generala Abalaustrado Deschuponar.", "Genciana", 320.31999999999999 },
                    { 3, "Incorrección", "Bástulo Bastonada Genearca Incorrecto Bate.", "Engarrafador", 270.77999999999997 },
                    { 4, "Descercar", "Basurero Batalán Cencapa Descerrar Gen.", "Abajeño", 544.78999999999996 },
                    { 5, "Engarce", "Ficticio Descentrado Descifrar Descerebrar Incorporeidad.", "Batata", 547.57000000000005 },
                    { 6, "Increpación", "Bastonada Incorruptibilidad Gemoterapia Batallola Engarbarse.", "Descentrar", 481.63 },
                    { 7, "Descifrador", "Descimbrar Genearca Fichar Increpación Batanero.", "Ficha", 822.79999999999995 },
                    { 8, "Cenal", "Generacional Batahola Incorrección Generador Cencío.", "Cenco", 567.0 },
                    { 9, "Ceñar", "Céndea Engarmarse Descerebrado Batanar Engarzador.", "Abadesa", 970.71000000000004 },
                    { 10, "Cencha", "Bastonero Basurear Fidecomiso Abadesa Cenco.", "Incrédulo", 275.5 },
                    { 11, "Descifrar", "Descerar Bátavo Batallola Increpar Cenegar.", "Incrustación", 520.90999999999997 },
                    { 12, "Abadejo", "Incrédulo Gemológico Fidalgo Batallar Bastoncillo.", "Incorporar", 779.50999999999999 },
                    { 13, "Genealogía", "Genearca Bataola Engargantar Incrasar Increpador.", "Fichero", 256.44999999999999 },
                    { 14, "Gemología", "Abacero Incrédulamente Engasgarse Cenero Genealógico.", "Basura", 533.12 },
                    { 15, "Cencha", "Cenefa Incrédulamente Descifrable Gemólogo Gemólogo.", "Cencuate", 779.05999999999995 },
                    { 16, "Cencuate", "Ficha Engasgarse Fideo Genealogía Incruentamente.", "Descerebración", 710.42999999999995 },
                    { 17, "Bateaguas", "Batanero Descentrar General Engarrafador Abajamiento.", "Cenata", 33.390000000000001 },
                    { 18, "Batahola", "Descerebrado Incorrecto Gemir Descerebración Descercado.", "Increíble", 571.37 },
                    { 19, "Batatazo", "Engastadura Descervigamiento Incrustación Geminar Ficoideo.", "Cenagoso", 242.19 },
                    { 20, "Gemológico", "Descimbrar Abaco Generador Abalaustrado Engarbarse.", "Descerrajar", 175.56999999999999 },
                    { 21, "Batallola", "Abadiato Abajar Generala Batanero Incorporeidad.", "Bastoncillo", 594.47000000000003 },
                    { 22, "Geminado", "Incredibilidad Gemíparo Incorrupción Fideicomitente Incorregiblemente.", "Cencellada", 274.49000000000001 },
                    { 23, "Descerrajadura", "Fiducia Abalada Descerar Descifre Abadengo.", "Abacalero", 33.109999999999999 },
                    { 24, "Engastador", "Fideero Bataola Incorrección Fideero Bateaguas.", "Descentralizador", 221.5 },
                    { 25, "Abadí", "Batallona Engarzadura Engasgarse Descerebrar Descentrado.", "Incriminar", 457.11000000000001 },
                    { 26, "Gencianáceo", "Cenagar Descerrumarse Incrédulamente Fideicomisario Cencivera.", "Abadesa", 50.759999999999998 },
                    { 27, "Incorporeidad", "Engarbullar Engarbullar Batacazo Gemiqueo Bata.", "Deschapar", 330.0 },
                    { 28, "Incorrecto", "Abajadero Engarzadura Fideicomisario Fichar Incorporalmente.", "Cenco", 318.83999999999997 },
                    { 29, "Engaritar", "Cendrazo Incordio Engarrafador Ficticio Incredibilidad.", "Cencuate", 62.75 },
                    { 30, "Gen", "Cencerril Engargolar Fidelísimo Gencianáceo Batayola.", "Descercar", 701.37 },
                    { 31, "Incredibilidad", "Batallón Incorruptibilidad Geneático Incorruptamente Descifrable.", "Abajadero", 787.25999999999999 },
                    { 32, "Incriminar", "Genealogía Gendarmería Desciframiento Cencerrillas Engarbarse.", "Incorporo", 288.86000000000001 },
                    { 33, "Batayola", "Abadejo Bastonear Abad Incorporo Cendolilla.", "Engarbarse", 682.94000000000005 },
                    { 34, "Descifrador", "Batallaroso Batallón Batallola Incorporo Incorregiblemente.", "Generalato", 722.0 },
                    { 35, "Geneático", "Cencero Engaste Cenero Batazo Descercar.", "Gemológico", 951.61000000000001 },
                    { 36, "Desciframiento", "Ficoideo Engargantar Bate Cencha Batayola.", "Deschapar", 649.10000000000002 },
                    { 37, "Bastonada", "Fideicomisario Céndea Batalloso Engasgarse Abacora.", "Ficoideo", 687.34000000000003 },
                    { 38, "Cencerrillas", "Cenata Bastoncillo Gemíparo Cenca Descharchar.", "Descentralizador", 854.75 },
                    { 39, "Gemiqueo", "Cencerrón Fideicomitente Cendal Batanga Increíble.", "Geneático", 427.76999999999998 },
                    { 40, "Engarronar", "Descerezar Incorpóreo Abacora Cencero Fidecomiso.", "Increpación", 888.16999999999996 },
                    { 41, "Descifrable", "Gemoterapia Cendrado Bastonear Increíblemente Cenestesia.", "Descifre", 919.55999999999995 },
                    { 42, "Gendarmería", "Ceneque Gencianeo Descentralizador Cenefa Abadengo.", "Basurero", 258.61000000000001 },
                    { 43, "Descifrador", "Incorrecto Descerebrado Generalísimo Incrédulo Descenso.", "Bastonada", 852.63999999999999 },
                    { 44, "Abaco", "Incorporalmente Cencío Descercado Abacorar Fidelidad.", "Genciana", 656.39999999999998 },
                    { 45, "Ceneque", "Increado Incorregiblemente Bate Incruentamente Cendrar.", "Batalán", 46.93 },
                    { 46, "Descervigar", "Fideicomitente Bastonero Cendra Ceñar Cenco.", "Incristalizable", 467.95999999999998 },
                    { 47, "Descerco", "Abada Cencuate Descerco Descercar Engarbullar.", "Cencerrear", 726.20000000000005 },
                    { 48, "General", "Increpación Incremento Descervigamiento Generalísimo Cencerrón.", "Generalísimo", 746.04999999999995 },
                    { 49, "Genearca", "Ficha Cenefa Cenca Incorruptibilidad Abajamiento.", "Batalloso", 541.80999999999995 },
                    { 50, "Incriminar", "Generalato Batanear Cencuate Bata Engastador.", "Engarrar", 111.12 },
                    { 51, "Engastar", "Abacial Abajadero Incrasar Engastadura Abadía.", "Deschapar", 130.0 },
                    { 52, "Abacorar", "Generalísimo Engarzadura Batalloso Engargolado Abada.", "Cenceño", 55.649999999999999 },
                    { 53, "Engasgarse", "Bastonada Generación Abaldonadamente Cencerro Descerco.", "Cendradilla", 184.66 },
                    { 54, "Engarrafar", "Cenegar Genearca Incorregiblemente Descentralizar Batata.", "Cencerrada", 458.42000000000002 },
                    { 55, "Batallar", "Batato Batallona Gendarmería Fido Cenceñada.", "Generable", 509.12 },
                    { 56, "Cendradilla", "Generalidad Basurear Abajera Bate Increpar.", "Basural", 133.09999999999999 },
                    { 57, "Batallador", "Engargantadura Genealogista Batallón Batanear Fidelísimo.", "Abajar", 983.29999999999995 },
                    { 58, "Batahola", "Cencerra Abajera Abacorar Bateaguas Cenagoso.", "Abacería", 858.03999999999996 },
                    { 59, "Abacería", "Gemir Abacería Cendradilla Descerrajadura Cencido.", "Fideicomitente", 38.840000000000003 },
                    { 60, "Incordio", "Increpador Ficha Geneático Fichero Incrementar.", "Descerrumarse", 367.69999999999999 },
                    { 61, "Abacalero", "Abadía Engastar Abada Incorporar Incorporación.", "Incruentamente", 313.63999999999999 },
                    { 62, "General", "Incriminar Batallar Incrustación General Generador.", "Engastadura", 841.12 },
                    { 63, "Batatazo", "Abalaustrado Abacalero Descerrajadura Cendalí Descifrador.", "Incredulidad", 246.36000000000001 },
                    { 64, "Batazo", "Incorruptamente Fidalgo Generacional Increíblemente Descimbramiento.", "Descervigamiento", 185.16 },
                    { 65, "Incremento", "Engarronar Géminis Incorregible Cencerril Descimbramiento.", "Cencellada", 70.469999999999999 },
                    { 66, "Fichero", "Descerrumarse Generala Geneático Gemólogo Batallar.", "Ficoideo", 823.78999999999996 },
                    { 67, "Abajar", "Abajo Descentralizar Engaritar Fideero Descervigar.", "Engarce", 326.75 },
                    { 68, "Engarfiar", "Fichero Generalidad Fideicomisario Fideicomisario Descerrar.", "Increpar", 691.46000000000004 },
                    { 69, "Fichero", "Cenata Descerrajadura Cenagar Genearca Batato.", "Cencío", 318.60000000000002 },
                    { 70, "Batalloso", "Descharchar Fideicomisario Cenero Fideísmo Deschavetado.", "Increíble", 762.96000000000004 },
                    { 71, "Descerebrado", "Gemólogo Descentralización Engastar Basura Engarrotar.", "Cenero", 424.06999999999999 },
                    { 72, "Descerar", "Incrédulamente Incorregiblemente Incrasar Fichero Generalato.", "Fideero", 599.53999999999996 },
                    { 73, "Abacero", "Cenal Descentralizador Cendra Incorporal Engarbarse.", "Engarro", 498.07999999999998 },
                    { 74, "Incorrección", "Deschapar Generalato Increíblemente Abadengo Basurear.", "Bateaguas", 416.56999999999999 },
                    { 75, "Incrementar", "Abaco Incrustación Descervigamiento Batanar Abalaustrado.", "Engargantar", 199.49000000000001 },
                    { 76, "Cendalí", "Engarfiar Cencerrada Descimbrar Batallona Incorregibilidad.", "Abadiado", 749.27999999999997 },
                    { 77, "Fideero", "Gencianeo Incorporalmente Descerrumarse Incorruptibilidad Incorporalmente.", "Engarmarse", 560.34000000000003 },
                    { 78, "Incorpóreo", "Batea Engarrotar Incorporación Fidalgo Descifrar.", "Fideero", 152.19999999999999 },
                    { 79, "Batanear", "Bastoncillo Increíble Cencero Descimbramiento Generala.", "Abajera", 220.34 },
                    { 80, "Bate", "Incrédulo Abalar Bate Gemoso Fidalgo.", "Cencerril", 557.69000000000005 },
                    { 81, "Increpación", "Basurero Gen Fiducia Ceneque General.", "Engarronar", 318.57999999999998 },
                    { 82, "Gemir", "Gemíparo Engarrar Incordio Batatazo Gemonias.", "Bastonear", 880.76999999999998 },
                    { 83, "Cencerrillas", "Incorporación Batazo Descerrar Fidelidad Fidecomiso.", "Abalada", 232.22 },
                    { 84, "Cencivera", "Descentralizador Incrédulo Gencianeo Increpación Incrustación.", "Batato", 367.54000000000002 },
                    { 85, "Batata", "Engarbarse Descentrar Engarrafador Ficha Increpación.", "Bástulo", 31.329999999999998 },
                    { 86, "Cencido", "Abad Incristalizable Abadesa Incorregibilidad Geminar.", "Batanga", 203.69 },
                    { 87, "Batallar", "Incordio Fidedigno Engargantadura Ficción Descervigamiento.", "Descensión", 891.60000000000002 },
                    { 88, "Engarronar", "Incorrección Ceñar Gemoso Incorporal Cencerrón.", "Increíblemente", 98.75 },
                    { 89, "Gemiqueo", "Increíble Generable Fiducia Descercador Incorpóreo.", "Fidalgo", 807.57000000000005 },
                    { 90, "Cendra", "Incrementar Incorruptibilidad Batallola Cencuate Cencío.", "Cenceñada", 310.44999999999999 },
                    { 91, "Engasgarse", "Cendrar Engarce Descifrar Cencío Engargantar.", "Abajar", 940.76999999999998 },
                    { 92, "Incorporal", "Bástulo Abadí Bástulo Descerebración Engarbullar.", "Cenaoscuras", 655.82000000000005 },
                    { 93, "Cendra", "Cencerro Abalaustrado Abajar Engastadura Cenceño.", "Batalloso", 991.09000000000003 },
                    { 94, "Cendalí", "Generalidad Abada Generalísimo Geminado Cenaoscuras.", "Engastadura", 596.40999999999997 },
                    { 95, "Incorregiblemente", "Descifrar Fidalgo Gemiqueo Batayola Batalán.", "Abad", 257.85000000000002 },
                    { 96, "Descentrado", "Gemiquear Abadesa Incorporal Incorrecto Descimbramiento.", "Bateador", 109.29000000000001 },
                    { 97, "Fichar", "Cencerra Incrédulo Descercado Bastonear Fidecomiso.", "Cendalí", 881.01999999999998 },
                    { 98, "Batallador", "Descerrumarse Batalla Cencero Descerrumarse Abadiado.", "Increpación", 439.57999999999998 },
                    { 99, "Incorregiblemente", "Abacorar Abalada Descercado Incriminación Bataola.", "Batalla", 89.269999999999996 },
                    { 100, "Batallar", "Cenaoscuras Incorporación Deschavetarse Bastonero Batallón.", "Increpador", 859.04999999999995 }
                });

            migrationBuilder.InsertData(
                table: "suppliers",
                columns: new[] { "id", "address", "company", "email", "name", "nit", "phone", "surname" },
                values: new object[,]
                {
                    { 1, "Juguetes", "Engaste", "Ester.Quintana@corpfolder.com", "Ester", "312", "5529-075-487", "Quintana" },
                    { 2, "Juegos, Juguetes & Ropa", "Cenco", "Lorena.Prado5@corpfolder.com", "Lorena", "566", "5349-804-817", "Prado" },
                    { 3, "Joyería", "Gemoterapia", "Monica_Casillas21@corpfolder.com", "Mónica", "422", "502 228 562", "Casillas" },
                    { 4, "Electrónica", "Descepar", "Leonardo.Quevedo@nearbpo.com", "Leonardo", "976", "522252902", "Quevedo" },
                    { 5, "Automoción, Ropa & Juegos", "Incredulidad", "Monica.Ozuna92@gmail.com", "Mónica", "2", "551153761", "Ozuna" },
                    { 6, "Aire libre & Aire libre", "Cencerreo", "Jesus_Rosas51@hotmail.com", "Jesús", "951", "560163986", "Rosas" },
                    { 7, "Zapatos, Libros & Kids", "Incrasar", "JoseEmilio_Merino97@gmail.com", "José Emilio", "537", "5582-258-532", "Merino" },
                    { 8, "Herramientas, Jardín & Ultramarinos", "Incriminación", "LuisGabino_Calvillo29@nearbpo.com", "Luis Gabino", "115", "548.262.251", "Calvillo" },
                    { 9, "Juguetes & Salud", "Descentralizar", "Alberto54@hotmail.com", "Alberto", "367", "516317711", "Kanzaki" },
                    { 10, "Películas & Jardín", "Engastadura", "Isabela.Duenas74@hotmail.com", "Isabela", "299", "563.828.638", "Dueñas" },
                    { 11, "Jardín & Música", "Geminado", "Patricio_Bustamante@yahoo.com", "Patricio", "729", "540.671.847", "Bustamante" },
                    { 12, "Ultramarinos, Automoción & Películas", "Gemólogo", "Gonzalo69@nearbpo.com", "Gonzalo", "666", "581 461 246", "Gil" },
                    { 13, "Ropa, Jardín & Kids", "Cencerrada", "Teodoro.Velasquez@gmail.com", "Teodoro", "953", "509 964 069", "Velásquez" },
                    { 14, "Herramientas", "Cendrado", "Diego_Rael@nearbpo.com", "Diego", "738", "560097909", "Rael" },
                    { 15, "Música & Joyería", "Fideísmo", "Teresa44@yahoo.com", "Teresa", "176", "538743541", "Vallejo" },
                    { 16, "Ropa, Jardín & Electrónica", "Descimbrar", "Carla_Valladares25@yahoo.com", "Carla", "378", "549 302 013", "Valladares" },
                    { 17, "Jardín & Juegos", "Gen", "Alexis_Oquendo@nearbpo.com", "Alexis", "913", "542.568.295", "Oquendo" },
                    { 18, "Música", "Batán", "Julia33@gmail.com", "Julia", "107", "5650-639-691", "Verdugo" },
                    { 19, "Automoción & Automoción", "Incordio", "MariadelCarmen_Estrada89@yahoo.com", "María del Carmen", "698", "563.780.559", "Estrada" },
                    { 20, "Automoción & Electrónica", "Batea", "Alfredo.deAnda@nearbpo.com", "Alfredo", "543", "539078336", "de Anda" },
                    { 21, "Juegos", "Batata", "XimenaGuadalupe.Batista@yahoo.com", "Ximena Guadalupe", "19", "527.121.215", "Batista" },
                    { 22, "Joyería, Herramientas & Joyería", "Engarrar", "Marcos_Mayorga@gmail.com", "Marcos", "596", "573.061.727", "Mayorga" },
                    { 23, "Baby, Baby & Electrónica", "Abaco", "Ariadna_Alanis25@hotmail.com", "Ariadna", "916", "584.396.152", "Alanis" }
                });

            migrationBuilder.InsertData(
                table: "suppliers",
                columns: new[] { "id", "address", "company", "email", "name", "nit", "phone", "surname" },
                values: new object[,]
                {
                    { 24, "Belleza & Ultramarinos", "Descercado", "Julia.Nieves0@nearbpo.com", "Julia", "276", "566.016.321", "Nieves" },
                    { 25, "Películas", "Abajeño", "AnaLuisa_Esquibel@gmail.com", "Ana Luisa", "901", "5653-398-158", "Esquibel" },
                    { 26, "Juguetes & Electrónica", "Abalar", "JoseDaniel.Kanzaki89@nearbpo.com", "Jose Daniel", "631", "570.961.046", "Kanzaki" },
                    { 27, "Kids, Juguetes & Películas", "Descerezar", "JuanManuel.Puente28@nearbpo.com", "Juan Manuel", "219", "5120-160-565", "Puente" },
                    { 28, "Hogar, Música & Ropa", "Generable", "MariadelosAngeles54@corpfolder.com", "María de los Ángeles", "492", "5316-727-275", "Madera" },
                    { 29, "Jardín & Ordenadores", "Batanero", "Maricarmen_Vergara61@nearbpo.com", "Maricarmen", "652", "591.023.981", "Vergara" },
                    { 30, "Ropa", "Descentrar", "Alexis_Xicoy62@gmail.com", "Alexis", "405", "5135-441-561", "Xicoy" },
                    { 31, "Ultramarinos & Música", "Abadengo", "Gilberto_Maldonado@hotmail.com", "Gilberto", "947", "5192-847-379", "Maldonado" },
                    { 32, "Industrial, Ultramarinos & Música", "Batahola", "Damian.Mejia68@gmail.com", "Damián", "261", "538 584 928", "Mejía" },
                    { 33, "Baby & Hogar", "Fideero", "Guadalupe80@yahoo.com", "Guadalupe", "678", "527 648 058", "Valdés" },
                    { 34, "Hogar, Zapatos & Libros", "Abajar", "Paulina.Zamora35@nearbpo.com", "Paulina", "665", "539697484", "Zamora" },
                    { 35, "Joyería, Ordenadores & Deportes", "Cendal", "AnaLuisa.Quinterodelacruz69@hotmail.com", "Ana Luisa", "587", "532 157 119", "Quintero de la cruz" },
                    { 36, "Jardín", "Descerrajar", "Clemente.Sepulveda@corpfolder.com", "Clemente", "767", "518 127 755", "Sepúlveda" },
                    { 37, "Libros", "Engarrar", "MariadeJesus24@hotmail.com", "María de Jesús", "348", "5367-336-960", "Jiménez" },
                    { 38, "Jardín & Salud", "Fiducia", "MarcoAntonio21@corpfolder.com", "Marco Antonio", "789", "5769-414-332", "Meza" },
                    { 39, "Ultramarinos", "Engastador", "Graciela.Urrutia@yahoo.com", "Graciela", "227", "533 657 819", "Urrutia" },
                    { 40, "Jardín, Libros & Belleza", "Incredulidad", "Amalia.Rosario47@nearbpo.com", "Amalia", "669", "594345959", "Rosario" },
                    { 41, "Aire libre & Industrial", "Abacora", "Rodrigo.Pedroza33@nearbpo.com", "Rodrigo", "780", "5279-214-734", "Pedroza" },
                    { 42, "Libros", "Abacería", "Amalia.Rael27@corpfolder.com", "Amalia", "458", "599.991.979", "Rael" },
                    { 43, "Ordenadores & Belleza", "Engastar", "Evelyn.Zabaleta@corpfolder.com", "Evelyn", "873", "5494-160-620", "Zabaleta" },
                    { 44, "Deportes, Películas & Aire libre", "Abacial", "XimenaGuadalupe16@yahoo.com", "Ximena Guadalupe", "886", "561705926", "Karem" },
                    { 45, "Baby & Juegos", "Fice", "Mariana.Duran@gmail.com", "Mariana", "149", "5782-753-397", "Duran" },
                    { 46, "Herramientas", "Cenagar", "Lorenzo66@nearbpo.com", "Lorenzo", "310", "5436-110-933", "Orozco" },
                    { 47, "Ropa", "Descifre", "Ivanna_Yunta@hotmail.com", "Ivanna", "808", "595073404", "Yunta" },
                    { 48, "Juguetes, Ultramarinos & Juegos", "Descentralización", "Rosario66@gmail.com", "Rosario", "457", "5338-462-909", "Espinosa" },
                    { 49, "Ultramarinos & Juegos", "Batanar", "Carlota29@corpfolder.com", "Carlota", "450", "535.033.008", "Pedroza" },
                    { 50, "Jardín & Películas", "Incriminación", "Israel_Esquivel35@corpfolder.com", "Israel", "883", "5645-403-924", "Esquivel" },
                    { 51, "Libros & Industrial", "Engargantar", "Alan_Yanez68@hotmail.com", "Alan", "396", "527.868.862", "Yáñez" },
                    { 52, "Industrial & Industrial", "Engarmarse", "Vicente_Castro@yahoo.com", "Vicente", "147", "556497706", "Castro" },
                    { 53, "Herramientas, Belleza & Industrial", "Ficha", "Fernando92@hotmail.com", "Fernando", "70", "564764696", "Noriega" },
                    { 54, "Electrónica", "Engargantadura", "Soledad14@hotmail.com", "Soledad", "543", "568.702.318", "Montalvo" },
                    { 55, "Música, Ordenadores & Joyería", "Batanar", "Ricardo_Varela@yahoo.com", "Ricardo", "263", "577702223", "Varela" },
                    { 56, "Automoción, Belleza & Ultramarinos", "Bastoncillo", "Emilio.Narvaez@yahoo.com", "Emilio", "949", "553.405.790", "Narváez" },
                    { 57, "Automoción, Música & Zapatos", "Cenata", "Lorenzo.Roque@gmail.com", "Lorenzo", "633", "570.195.294", "Roque" },
                    { 58, "Automoción", "Descerar", "Carla_Molina23@corpfolder.com", "Carla", "859", "584911322", "Molina" },
                    { 59, "Películas", "Incorrupción", "Elizabeth_Rivas@nearbpo.com", "Elizabeth", "518", "525.710.064", "Rivas" },
                    { 60, "Películas", "Abajera", "Oscar_Camacho87@nearbpo.com", "Óscar", "991", "555464267", "Camacho" },
                    { 61, "Industrial", "Incorporal", "Guillermo.Kamal@hotmail.com", "Guillermo", "861", "569787355", "Kamal" },
                    { 62, "Baby, Jardín & Películas", "Abajadero", "Carolina_Molina45@nearbpo.com", "Carolina", "665", "521.748.074", "Molina" },
                    { 63, "Herramientas, Zapatos & Industrial", "Gemiquear", "Miranda50@yahoo.com", "Miranda", "434", "5008-760-229", "Adame" },
                    { 64, "Industrial & Jardín", "Abacorar", "Lucia.Deleon24@nearbpo.com", "Lucia", "474", "561840284", "Deleón" },
                    { 65, "Zapatos", "Gemológico", "AlondraRomina_Huerta39@corpfolder.com", "Alondra Romina", "627", "501.629.879", "Huerta" },
                    { 66, "Ordenadores & Música", "Fichero", "Teodoro_Benavidez@corpfolder.com", "Teodoro", "429", "515.474.388", "Benavídez" },
                    { 67, "Jardín & Jardín", "Engarzadura", "JuanCarlos15@nearbpo.com", "Juan Carlos", "21", "5740-065-195", "Guerrero" },
                    { 68, "Juegos, Salud & Hogar", "Batanar", "Benjamin.Acosta@corpfolder.com", "Benjamín", "295", "5178-656-387", "Acosta" },
                    { 69, "Automoción & Joyería", "Abaldonamiento", "Saul.Saldivar58@gmail.com", "Saúl", "445", "524.454.515", "Saldivar" },
                    { 70, "Deportes", "Deschavetado", "Aaron.Ceballos16@nearbpo.com", "Aarón", "85", "5046-256-222", "Ceballos" },
                    { 71, "Ropa, Aire libre & Música", "Gemoso", "Paola.Delgado21@gmail.com", "Paola", "29", "531501354", "Delgado" },
                    { 72, "Películas & Música", "Descerrajadura", "Francisco_Alarcon@hotmail.com", "Francisco", "416", "581 649 851", "Alarcón" },
                    { 73, "Automoción, Aire libre & Joyería", "Fichaje", "Pablo.Colon@nearbpo.com", "Pablo", "889", "5726-250-803", "Colón" },
                    { 74, "Baby & Automoción", "Abadesa", "Eloisa.Yebra86@hotmail.com", "Eloisa", "659", "590905146", "Yebra" },
                    { 75, "Música, Música & Automoción", "Abadesa", "Lilia48@nearbpo.com", "Lilia", "438", "507.387.772", "Gálvez" },
                    { 76, "Joyería, Baby & Ultramarinos", "Batanga", "Gloria.Villasenor12@gmail.com", "Gloria", "264", "515.553.380", "Villaseñor" },
                    { 77, "Herramientas", "Fideo", "Emiliano.Karem@corpfolder.com", "Emiliano", "3", "563448619", "Karem" },
                    { 78, "Kids, Kids & Aire libre", "Descifrador", "Araceli.Lovato70@gmail.com", "Araceli", "457", "534.233.326", "Lovato" },
                    { 79, "Hogar & Kids", "Engarzar", "MariaJose.Feliciano@nearbpo.com", "María José", "986", "589 545 110", "Feliciano" },
                    { 80, "Juguetes, Belleza & Jardín", "Abajo", "Uriel_Oquendo@hotmail.com", "Uriel", "214", "571 704 912", "Oquendo" },
                    { 81, "Herramientas", "Abadía", "Abraham_Medina@corpfolder.com", "Abraham", "67", "5788-833-517", "Medina" },
                    { 82, "Deportes & Aire libre", "Incruento", "Gloria.Cotto4@gmail.com", "Gloria", "886", "5617-301-030", "Cotto" },
                    { 83, "Zapatos & Ropa", "Descentrar", "Luz.Serrato@corpfolder.com", "Luz", "428", "547.820.879", "Serrato" },
                    { 84, "Joyería, Joyería & Electrónica", "Incorruptamente", "Axel70@hotmail.com", "Axel", "77", "512.207.797", "Ocampo" },
                    { 85, "Belleza", "Engarzar", "Marilu_Zaragoza32@corpfolder.com", "Marilu", "557", "5603-954-574", "Zaragoza" },
                    { 86, "Ultramarinos, Zapatos & Herramientas", "Incrustación", "Alejandro90@yahoo.com", "Alejandro", "630", "570 629 895", "Armenta" },
                    { 87, "Electrónica, Jardín & Libros", "Batatazo", "Elena98@gmail.com", "Elena", "161", "572.909.989", "Altamirano" },
                    { 88, "Juegos", "Desceñir", "Ramona.Aviles39@gmail.com", "Ramona", "766", "582.655.903", "Avilés" },
                    { 89, "Música, Automoción & Electrónica", "Cencerrón", "JorgeLuis.Pagan@gmail.com", "Jorge Luis", "206", "578.062.780", "Pagan" },
                    { 90, "Ordenadores & Automoción", "Incorruptible", "Beatriz.Delapaz@corpfolder.com", "Beatriz", "179", "5233-953-489", "Delapaz" },
                    { 91, "Ropa & Baby", "Gemiqueo", "Leonardo.Cruz21@yahoo.com", "Leonardo", "556", "570224867", "Cruz" },
                    { 92, "Belleza", "Batavia", "Mariana.Heredia0@yahoo.com", "Mariana", "168", "5752-022-151", "Heredia" },
                    { 93, "Jardín", "Generable", "Gregorio47@nearbpo.com", "Gregorio", "387", "565 845 199", "Peres" },
                    { 94, "Deportes & Industrial", "Descimbrar", "Jaime85@hotmail.com", "Jaime", "685", "594 360 197", "Vázquez" },
                    { 95, "Industrial & Kids", "Ficticio", "Aaron2@corpfolder.com", "Aarón", "923", "506 702 357", "León" },
                    { 96, "Deportes, Jardín & Baby", "Incorregible", "Ariadna37@gmail.com", "Ariadna", "941", "528 130 436", "Ocasio" },
                    { 97, "Libros & Joyería", "Engargolar", "AlondraRomina72@corpfolder.com", "Alondra Romina", "952", "503.868.629", "Urías" },
                    { 98, "Electrónica, Herramientas & Industrial", "Abadiado", "Ramiro_Ocasio62@gmail.com", "Ramiro", "44", "514149453", "Ocasio" },
                    { 99, "Jardín", "Descerebración", "Soledad_Luevano@nearbpo.com", "Soledad", "640", "560.949.316", "Luevano" },
                    { 100, "Música, Aire libre & Automoción", "Incruento", "Mayte_Ornelas42@gmail.com", "Mayte", "614", "5470-466-746", "Ornelas" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "password", "role" },
                values: new object[,]
                {
                    { 1, "MariadelosAngeles_Nazario74@yahoo.com", "Descerrumarse", "Mechanic" },
                    { 2, "Naomi_Roldan68@hotmail.com", "Deschuponar", "Administrator" },
                    { 3, "Yamileth_Pichardo38@hotmail.com", "Cencerrado", "Receptionist" },
                    { 4, "Rafael16@yahoo.com", "Batea", "Administrator" },
                    { 5, "AnaVictoria_Vergara78@yahoo.com", "Cendra", "Administrator" },
                    { 6, "Carla.Mora@gmail.com", "Engargantar", "Receptionist" },
                    { 7, "Teodoro.Garza16@yahoo.com", "Batalloso", "Administrator" },
                    { 8, "Vicente.Pina@corpfolder.com", "Increpar", "Administrator" },
                    { 9, "Josefina68@hotmail.com", "Gencianeo", "Mechanic" },
                    { 10, "Nicole_Mateo94@hotmail.com", "Cencuate", "Administrator" },
                    { 11, "Francisca14@hotmail.com", "Cencerra", "Mechanic" },
                    { 12, "AngelGabriel_Carrillo@corpfolder.com", "Abaldonamiento", "Administrator" },
                    { 13, "Jennifer_Candelaria@hotmail.com", "Genciana", "Administrator" },
                    { 14, "Juan63@corpfolder.com", "Incorporeidad", "Administrator" },
                    { 15, "Julia.Medrano@yahoo.com", "Batazo", "Administrator" },
                    { 16, "Marisol.Patino@corpfolder.com", "Cenero", "Administrator" },
                    { 17, "AlondraRomina47@gmail.com", "Incruentamente", "Receptionist" },
                    { 18, "Mario23@nearbpo.com", "Cendalí", "Receptionist" },
                    { 19, "Xochitl.Duarte53@corpfolder.com", "Engarzadura", "Receptionist" },
                    { 20, "LuisFernando.Gaona@gmail.com", "Descerebración", "Administrator" },
                    { 21, "Paulina_Montenegro97@corpfolder.com", "Cendalí", "Receptionist" },
                    { 22, "Margarita80@hotmail.com", "Bataola", "Administrator" },
                    { 23, "Leonardo.Vera@corpfolder.com", "Abacora", "Administrator" },
                    { 24, "Maria77@gmail.com", "Basural", "Receptionist" },
                    { 25, "Marilu.Raya@yahoo.com", "Abadesa", "Mechanic" },
                    { 26, "Andrea.Alva25@yahoo.com", "Cenco", "Mechanic" },
                    { 27, "Brayan.Duran@yahoo.com", "Incorporalmente", "Administrator" },
                    { 28, "Lucia.Arroyo@gmail.com", "Cendra", "Receptionist" },
                    { 29, "Jeronimo.Sotelo@yahoo.com", "Batallaroso", "Receptionist" },
                    { 30, "Miranda_Fuentes@gmail.com", "Incorporeidad", "Mechanic" },
                    { 31, "Monica_Jaquez77@nearbpo.com", "Abalanzar", "Administrator" },
                    { 32, "Ximena_Sisneros20@nearbpo.com", "Descerebración", "Mechanic" },
                    { 33, "MariaEugenia.Oquendo@hotmail.com", "Gemonias", "Receptionist" },
                    { 34, "Alejandro_Munguia95@gmail.com", "Ficticio", "Mechanic" },
                    { 35, "MariaEugenia_Morales@hotmail.com", "Cenagoso", "Receptionist" },
                    { 36, "Gloria.Sanabria@hotmail.com", "Cencío", "Administrator" },
                    { 37, "Sara80@yahoo.com", "Abacalero", "Administrator" },
                    { 38, "Abraham62@corpfolder.com", "Batallar", "Administrator" },
                    { 39, "Camila.Salcido@hotmail.com", "Fideero", "Administrator" },
                    { 40, "Cristobal.Cano@yahoo.com", "Cenegar", "Mechanic" },
                    { 41, "Sofia28@nearbpo.com", "Cenegar", "Administrator" },
                    { 42, "Miranda.Orozco40@corpfolder.com", "Desciframiento", "Receptionist" },
                    { 43, "Regina57@gmail.com", "Descerrajar", "Administrator" },
                    { 44, "Araceli55@yahoo.com", "Cendolilla", "Receptionist" },
                    { 45, "Tadeo.Murillo85@gmail.com", "Batavia", "Receptionist" },
                    { 46, "Antonia.Cisneros45@gmail.com", "Batayola", "Administrator" },
                    { 47, "Carlota.Mendez1@nearbpo.com", "Cenegar", "Mechanic" },
                    { 48, "Vicente.Delarosa16@hotmail.com", "Fideísmo", "Administrator" },
                    { 49, "Jaime18@yahoo.com", "Descerar", "Administrator" },
                    { 50, "David77@corpfolder.com", "Engarro", "Receptionist" },
                    { 51, "Esmeralda20@nearbpo.com", "Incordio", "Receptionist" },
                    { 52, "LuisAngel9@hotmail.com", "Cenca", "Administrator" },
                    { 53, "Jazmin91@nearbpo.com", "Descharchar", "Mechanic" },
                    { 54, "Axel64@corpfolder.com", "Batazo", "Receptionist" },
                    { 55, "AngelGabriel.Kindelan91@nearbpo.com", "Batayola", "Receptionist" },
                    { 56, "Antonia_Maestas@hotmail.com", "Cenca", "Receptionist" },
                    { 57, "Norma_Lovato15@yahoo.com", "Cencerrado", "Receptionist" },
                    { 58, "Sofia_Camacho6@yahoo.com", "Descifrable", "Receptionist" },
                    { 59, "Marta_Urias88@yahoo.com", "Abacería", "Mechanic" },
                    { 60, "Xochitl71@yahoo.com", "Abalar", "Receptionist" },
                    { 61, "Homero52@gmail.com", "Gemología", "Mechanic" },
                    { 62, "JulioCesar.Cortez12@yahoo.com", "Fideicomisario", "Administrator" },
                    { 63, "Paola79@yahoo.com", "Cencerreo", "Receptionist" },
                    { 64, "Victoria6@corpfolder.com", "Descentrar", "Receptionist" },
                    { 65, "Cristina_Garza@hotmail.com", "Incorporo", "Mechanic" },
                    { 66, "Ester_Quiros@corpfolder.com", "Engarbarse", "Administrator" },
                    { 67, "Eloisa.Alaniz23@gmail.com", "Cencerrada", "Mechanic" },
                    { 68, "Natalia22@yahoo.com", "Cenca", "Mechanic" },
                    { 69, "Benito_Zarate46@hotmail.com", "Abajo", "Mechanic" },
                    { 70, "MariaLuisa_Baez47@yahoo.com", "Cendra", "Receptionist" },
                    { 71, "Paola.Barela@gmail.com", "Bate", "Mechanic" },
                    { 72, "Marilu_Salazar51@yahoo.com", "Descifre", "Administrator" },
                    { 73, "Damian.Roybal16@gmail.com", "Cenceño", "Administrator" },
                    { 74, "Sofia.Valles@gmail.com", "Cencha", "Mechanic" },
                    { 75, "Alejandro_Vela@nearbpo.com", "Incordio", "Receptionist" },
                    { 76, "MariaSoledad_Delapaz@nearbpo.com", "Descercado", "Receptionist" },
                    { 77, "Andrea_Kano49@hotmail.com", "Incorregibilidad", "Receptionist" },
                    { 78, "Jose_Dominquez85@yahoo.com", "Cendalí", "Administrator" },
                    { 79, "JoseMiguel_Lebron70@nearbpo.com", "Gemir", "Mechanic" },
                    { 80, "JoseDaniel.Mojica64@corpfolder.com", "Abadejo", "Mechanic" },
                    { 81, "Teresa22@corpfolder.com", "Abaco", "Receptionist" },
                    { 82, "Carla_Correa87@corpfolder.com", "Gemíparo", "Receptionist" },
                    { 83, "MariaTeresa40@corpfolder.com", "Ficha", "Mechanic" },
                    { 84, "Adan.Quevedo15@gmail.com", "Cencerrón", "Mechanic" },
                    { 85, "Maricarmen.Torrez91@hotmail.com", "Genciana", "Administrator" },
                    { 86, "JoseDaniel_Rincon19@gmail.com", "Incorregibilidad", "Administrator" },
                    { 87, "Silvia23@nearbpo.com", "Bástulo", "Administrator" },
                    { 88, "JulioCesar42@nearbpo.com", "Gendarmería", "Mechanic" },
                    { 89, "Adriana_Perez69@nearbpo.com", "Gemoterapia", "Receptionist" },
                    { 90, "MariaEugenia.Arteaga@gmail.com", "Engargolado", "Administrator" },
                    { 91, "Claudio_Nava@hotmail.com", "Engarzador", "Administrator" },
                    { 92, "Ramona99@hotmail.com", "Desciframiento", "Receptionist" },
                    { 93, "Daniela_Barrera@yahoo.com", "Abalanzar", "Receptionist" },
                    { 94, "Angela43@yahoo.com", "Descentralización", "Administrator" },
                    { 95, "MariaGuadalupe_Briones49@hotmail.com", "Genealogista", "Receptionist" },
                    { 96, "AngelGabriel97@yahoo.com", "Abaldonadamente", "Receptionist" },
                    { 97, "Emily.Cedillo12@yahoo.com", "Bástulo", "Mechanic" },
                    { 98, "Gonzalo_Rosario@hotmail.com", "Gen", "Administrator" },
                    { 99, "LuisMiguel.Gastelum@nearbpo.com", "Fichaje", "Mechanic" },
                    { 100, "Adriana78@corpfolder.com", "Abajo", "Receptionist" }
                });

            migrationBuilder.InsertData(
                table: "requests",
                columns: new[] { "id", "client_id", "end_date", "service_id", "start_date", "state" },
                values: new object[,]
                {
                    { 1, null, new DateOnly(2022, 10, 24), 49, new DateOnly(2022, 7, 6), "Terminado" },
                    { 2, null, new DateOnly(2022, 6, 8), 13, new DateOnly(2022, 8, 4), "Activo" },
                    { 3, null, new DateOnly(2022, 7, 31), 16, new DateOnly(2023, 3, 20), "Activo" },
                    { 4, null, new DateOnly(2022, 12, 31), 25, new DateOnly(2022, 10, 13), "Terminado" },
                    { 5, null, new DateOnly(2023, 4, 24), 16, new DateOnly(2022, 6, 11), "Activo" },
                    { 6, null, new DateOnly(2022, 6, 27), 75, new DateOnly(2022, 11, 23), "Activo" },
                    { 7, null, new DateOnly(2023, 2, 16), 49, new DateOnly(2023, 4, 18), "Terminado" },
                    { 8, null, new DateOnly(2022, 8, 16), 80, new DateOnly(2023, 4, 29), "Terminado" },
                    { 9, null, new DateOnly(2023, 4, 20), 65, new DateOnly(2022, 10, 26), "Terminado" },
                    { 10, null, new DateOnly(2023, 2, 1), 29, new DateOnly(2022, 12, 29), "Activo" },
                    { 11, null, new DateOnly(2022, 8, 10), 73, new DateOnly(2022, 8, 1), "Terminado" },
                    { 12, null, new DateOnly(2022, 9, 2), 10, new DateOnly(2022, 6, 2), "Terminado" },
                    { 13, null, new DateOnly(2023, 5, 23), 74, new DateOnly(2022, 11, 1), "Terminado" },
                    { 14, null, new DateOnly(2023, 3, 14), 8, new DateOnly(2022, 6, 14), "Activo" },
                    { 15, null, new DateOnly(2023, 1, 14), 43, new DateOnly(2022, 12, 6), "Activo" },
                    { 16, null, new DateOnly(2023, 3, 25), 87, new DateOnly(2022, 7, 10), "Terminado" },
                    { 17, null, new DateOnly(2022, 6, 18), 26, new DateOnly(2023, 3, 14), "Activo" },
                    { 18, null, new DateOnly(2022, 12, 6), 81, new DateOnly(2022, 10, 5), "Terminado" },
                    { 19, null, new DateOnly(2022, 9, 11), 7, new DateOnly(2023, 5, 8), "Activo" },
                    { 20, null, new DateOnly(2022, 12, 12), 77, new DateOnly(2022, 10, 7), "Terminado" },
                    { 21, null, new DateOnly(2022, 10, 25), 98, new DateOnly(2022, 6, 2), "Terminado" },
                    { 22, null, new DateOnly(2023, 2, 20), 84, new DateOnly(2022, 8, 11), "Activo" },
                    { 23, null, new DateOnly(2022, 12, 30), 60, new DateOnly(2023, 2, 7), "Activo" },
                    { 24, null, new DateOnly(2022, 9, 16), 52, new DateOnly(2023, 1, 6), "Activo" },
                    { 25, null, new DateOnly(2022, 12, 31), 84, new DateOnly(2023, 1, 29), "Activo" },
                    { 26, null, new DateOnly(2022, 7, 18), 13, new DateOnly(2022, 9, 19), "Terminado" },
                    { 27, null, new DateOnly(2023, 3, 23), 70, new DateOnly(2022, 12, 22), "Terminado" },
                    { 28, null, new DateOnly(2023, 2, 1), 39, new DateOnly(2023, 4, 6), "Activo" },
                    { 29, null, new DateOnly(2022, 8, 7), 43, new DateOnly(2023, 2, 5), "Terminado" },
                    { 30, null, new DateOnly(2023, 5, 24), 38, new DateOnly(2022, 8, 8), "Activo" },
                    { 31, null, new DateOnly(2022, 10, 10), 98, new DateOnly(2023, 1, 5), "Terminado" },
                    { 32, null, new DateOnly(2022, 7, 12), 93, new DateOnly(2022, 12, 26), "Terminado" },
                    { 33, null, new DateOnly(2022, 12, 12), 41, new DateOnly(2023, 2, 19), "Activo" },
                    { 34, null, new DateOnly(2023, 2, 4), 50, new DateOnly(2023, 1, 22), "Terminado" },
                    { 35, null, new DateOnly(2022, 10, 26), 28, new DateOnly(2023, 4, 7), "Terminado" },
                    { 36, null, new DateOnly(2023, 1, 29), 91, new DateOnly(2022, 12, 29), "Activo" },
                    { 37, null, new DateOnly(2022, 11, 15), 85, new DateOnly(2022, 12, 6), "Terminado" },
                    { 38, null, new DateOnly(2023, 4, 19), 8, new DateOnly(2023, 5, 17), "Activo" },
                    { 39, null, new DateOnly(2022, 11, 11), 8, new DateOnly(2023, 3, 28), "Terminado" },
                    { 40, null, new DateOnly(2023, 1, 11), 84, new DateOnly(2022, 11, 3), "Activo" },
                    { 41, null, new DateOnly(2022, 11, 9), 67, new DateOnly(2022, 6, 9), "Terminado" },
                    { 42, null, new DateOnly(2022, 8, 5), 79, new DateOnly(2022, 11, 17), "Activo" },
                    { 43, null, new DateOnly(2022, 6, 20), 8, new DateOnly(2023, 5, 29), "Activo" },
                    { 44, null, new DateOnly(2023, 5, 14), 48, new DateOnly(2022, 12, 28), "Activo" },
                    { 45, null, new DateOnly(2022, 8, 30), 55, new DateOnly(2022, 10, 31), "Terminado" },
                    { 46, null, new DateOnly(2022, 8, 9), 94, new DateOnly(2023, 4, 8), "Terminado" },
                    { 47, null, new DateOnly(2023, 4, 17), 12, new DateOnly(2022, 11, 10), "Activo" },
                    { 48, null, new DateOnly(2022, 9, 21), 78, new DateOnly(2022, 9, 1), "Activo" },
                    { 49, null, new DateOnly(2022, 9, 25), 2, new DateOnly(2022, 11, 11), "Activo" },
                    { 50, null, new DateOnly(2022, 6, 17), 94, new DateOnly(2022, 10, 7), "Terminado" },
                    { 51, null, new DateOnly(2022, 10, 9), 30, new DateOnly(2022, 8, 25), "Terminado" },
                    { 52, null, new DateOnly(2022, 8, 22), 16, new DateOnly(2023, 4, 12), "Activo" },
                    { 53, null, new DateOnly(2022, 7, 27), 90, new DateOnly(2022, 11, 9), "Terminado" },
                    { 54, null, new DateOnly(2022, 11, 16), 40, new DateOnly(2022, 10, 29), "Terminado" },
                    { 55, null, new DateOnly(2023, 5, 20), 69, new DateOnly(2023, 3, 20), "Activo" },
                    { 56, null, new DateOnly(2022, 11, 27), 51, new DateOnly(2023, 3, 19), "Activo" },
                    { 57, null, new DateOnly(2022, 7, 12), 79, new DateOnly(2022, 8, 20), "Terminado" },
                    { 58, null, new DateOnly(2022, 9, 13), 71, new DateOnly(2022, 10, 15), "Activo" },
                    { 59, null, new DateOnly(2022, 11, 26), 65, new DateOnly(2022, 5, 30), "Activo" },
                    { 60, null, new DateOnly(2022, 7, 29), 47, new DateOnly(2023, 2, 21), "Terminado" },
                    { 61, null, new DateOnly(2022, 6, 25), 68, new DateOnly(2022, 8, 18), "Terminado" },
                    { 62, null, new DateOnly(2023, 3, 26), 33, new DateOnly(2022, 9, 18), "Activo" },
                    { 63, null, new DateOnly(2022, 6, 18), 45, new DateOnly(2022, 9, 8), "Activo" },
                    { 64, null, new DateOnly(2023, 5, 18), 78, new DateOnly(2022, 6, 9), "Activo" },
                    { 65, null, new DateOnly(2023, 1, 27), 15, new DateOnly(2022, 6, 14), "Activo" },
                    { 66, null, new DateOnly(2022, 7, 14), 30, new DateOnly(2023, 5, 24), "Terminado" },
                    { 67, null, new DateOnly(2023, 4, 4), 60, new DateOnly(2022, 6, 11), "Terminado" },
                    { 68, null, new DateOnly(2022, 7, 31), 86, new DateOnly(2022, 7, 27), "Terminado" },
                    { 69, null, new DateOnly(2023, 2, 14), 20, new DateOnly(2022, 11, 30), "Activo" },
                    { 70, null, new DateOnly(2023, 3, 13), 84, new DateOnly(2022, 10, 2), "Terminado" },
                    { 71, null, new DateOnly(2022, 11, 9), 48, new DateOnly(2022, 8, 21), "Terminado" },
                    { 72, null, new DateOnly(2023, 4, 12), 45, new DateOnly(2023, 1, 12), "Activo" },
                    { 73, null, new DateOnly(2022, 10, 18), 70, new DateOnly(2022, 6, 28), "Terminado" },
                    { 74, null, new DateOnly(2023, 5, 8), 86, new DateOnly(2023, 1, 20), "Terminado" },
                    { 75, null, new DateOnly(2023, 2, 23), 17, new DateOnly(2023, 3, 24), "Terminado" },
                    { 76, null, new DateOnly(2022, 12, 4), 21, new DateOnly(2023, 4, 15), "Activo" },
                    { 77, null, new DateOnly(2022, 10, 25), 68, new DateOnly(2022, 8, 3), "Terminado" },
                    { 78, null, new DateOnly(2022, 7, 11), 82, new DateOnly(2022, 7, 14), "Terminado" },
                    { 79, null, new DateOnly(2022, 9, 6), 93, new DateOnly(2023, 1, 28), "Terminado" },
                    { 80, null, new DateOnly(2022, 6, 25), 41, new DateOnly(2022, 9, 5), "Terminado" },
                    { 81, null, new DateOnly(2022, 8, 16), 74, new DateOnly(2023, 3, 25), "Terminado" },
                    { 82, null, new DateOnly(2023, 2, 7), 84, new DateOnly(2023, 2, 25), "Activo" },
                    { 83, null, new DateOnly(2023, 4, 19), 16, new DateOnly(2022, 10, 13), "Activo" },
                    { 84, null, new DateOnly(2022, 8, 20), 7, new DateOnly(2023, 5, 28), "Terminado" },
                    { 85, null, new DateOnly(2023, 4, 3), 75, new DateOnly(2022, 7, 11), "Terminado" },
                    { 86, null, new DateOnly(2023, 3, 14), 30, new DateOnly(2022, 6, 23), "Activo" },
                    { 87, null, new DateOnly(2022, 11, 28), 3, new DateOnly(2022, 9, 1), "Activo" },
                    { 88, null, new DateOnly(2023, 4, 19), 9, new DateOnly(2022, 9, 8), "Terminado" },
                    { 89, null, new DateOnly(2022, 12, 24), 94, new DateOnly(2022, 6, 30), "Activo" },
                    { 90, null, new DateOnly(2023, 3, 14), 37, new DateOnly(2023, 3, 28), "Terminado" },
                    { 91, null, new DateOnly(2022, 10, 31), 48, new DateOnly(2023, 1, 23), "Terminado" },
                    { 92, null, new DateOnly(2023, 5, 17), 68, new DateOnly(2022, 7, 9), "Activo" },
                    { 93, null, new DateOnly(2023, 3, 7), 10, new DateOnly(2023, 5, 25), "Activo" },
                    { 94, null, new DateOnly(2023, 3, 26), 82, new DateOnly(2023, 2, 5), "Terminado" },
                    { 95, null, new DateOnly(2023, 4, 18), 86, new DateOnly(2022, 6, 3), "Terminado" },
                    { 96, null, new DateOnly(2022, 7, 21), 76, new DateOnly(2022, 8, 10), "Terminado" },
                    { 97, null, new DateOnly(2023, 3, 30), 48, new DateOnly(2023, 2, 8), "Terminado" },
                    { 98, null, new DateOnly(2022, 6, 19), 50, new DateOnly(2023, 1, 15), "Terminado" },
                    { 99, null, new DateOnly(2023, 3, 9), 23, new DateOnly(2022, 8, 11), "Terminado" },
                    { 100, null, new DateOnly(2022, 12, 3), 49, new DateOnly(2023, 4, 2), "Activo" }
                });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "id", "client_id", "color", "description", "model", "plate", "year" },
                values: new object[,]
                {
                    { 1, 81, "cielo azul", "Hatchback", "Civic", "YFZP01Z223LK54656", "2020" },
                    { 2, 76, "Menta verde", "Passenger Van", "Grand Cherokee", "TC66ZVUQ1MYK53771", "2018" },
                    { 3, 4, "teal", "Convertible", "Wrangler", "8FHUYNVAI7I244567", "2018" },
                    { 4, 30, "fucsia", "Sedan", "Impala", "1A14XZ0QF1IR49837", "2019" },
                    { 5, 49, "cielo azul", "Passenger Van", "Accord", "3G00O6PWMGJK11218", "2019" },
                    { 6, 16, "índigo", "Sedan", "Malibu", "0H6JBF1CHQS149675", "2015" },
                    { 7, 11, "cian", "Hatchback", "2", "EQGF15Q5L6RN61358", "2019" },
                    { 8, 56, "amarillo", "Coupe", "Roadster", "2IJPKGZW3XZ427730", "2021" },
                    { 9, 34, "verde", "Crew Cab Pickup", "Fortwo", "5G1L5KK3WJL139019", "2018" },
                    { 10, 18, "azul", "Hatchback", "Durango", "XXLO4VKVHUQT31362", "2020" },
                    { 11, 24, "turquesa", "Cargo Van", "Focus", "EH3RESC4REVJ56578", "2020" },
                    { 12, 65, "marrón", "Hatchback", "Cruze", "051476Y2ZUOD49485", "2015" },
                    { 13, 75, "salmón", "Crew Cab Pickup", "1", "QP4FHDYDJIXF57767", "2020" },
                    { 14, 55, "magenta", "Passenger Van", "Fortwo", "KLPEKJR1EHL394555", "2018" },
                    { 15, 78, "Menta verde", "Crew Cab Pickup", "Roadster", "7N47B58X5NJF40004", "2019" },
                    { 16, 79, "violeta", "Passenger Van", "CX-9", "Z1K2HO2ATOOF18941", "2021" },
                    { 17, 68, "Lima", "Crew Cab Pickup", "1", "7GZUW0C3J9H069725", "2021" },
                    { 18, 50, "marfil", "Hatchback", "A4", "0KQR643USWAU78203", "2019" },
                    { 19, 72, "lavanda", "Wagon", "LeBaron", "MX67WA7ETVV685915", "2021" },
                    { 20, 54, "turquesa", "Passenger Van", "Ranchero", "SLOEPEO3D3G425801", "2019" },
                    { 21, 20, "orquídea", "Passenger Van", "Expedition", "PC1QWSA7Q0DS12004", "2015" },
                    { 22, 40, "marfil", "Cargo Van", "Charger", "Q6SNE0ZT6EJV66081", "2019" },
                    { 23, 54, "rojo", "Cargo Van", "LeBaron", "COMYIFM186JN43303", "2020" },
                    { 24, 6, "marrón", "Cargo Van", "Volt", "GVTGNBQICTC173080", "2020" },
                    { 25, 78, "marrón", "Extended Cab Pickup", "Beetle", "5E2Y03CQGTH783448", "2015" },
                    { 26, 42, "Rosa", "Convertible", "Durango", "WI9JC4YBCZP029034", "2019" },
                    { 27, 43, "magenta", "Cargo Van", "Golf", "LQRLRHQJZAVI73288", "2020" },
                    { 28, 87, "salmón", "Passenger Van", "Mustang", "6ZFIS4HMJBJF24192", "2021" },
                    { 29, 31, "negro", "Hatchback", "Grand Caravan", "8P5W7ON7CXXQ97194", "2015" },
                    { 30, 26, "blanco", "Passenger Van", "Countach", "7Y6RWE70IAR165730", "2019" },
                    { 31, 34, "índigo", "Passenger Van", "A8", "I7OMOHCAQ9RD94926", "2021" },
                    { 32, 33, "morado", "Minivan", "Challenger", "1V7RLCF22VAV34864", "2018" },
                    { 33, 49, "Naranja", "Minivan", "Malibu", "56YEB9W7DAHT82176", "2020" },
                    { 34, 65, "violeta", "Hatchback", "Land Cruiser", "S4HT41BDK9WF56657", "2015" },
                    { 35, 77, "índigo", "Minivan", "Malibu", "VKTHQOXH3TZ085656", "2015" },
                    { 36, 75, "gris", "Crew Cab Pickup", "A4", "C4G8LBT7PDUR67551", "2015" },
                    { 37, 10, "cielo azul", "Crew Cab Pickup", "Aventador", "VCYTI05OSFDD90050", "2019" },
                    { 38, 74, "fucsia", "Convertible", "Model T", "2KZHT624O4WO53793", "2015" },
                    { 39, 48, "tan", "Coupe", "A4", "ABJR9XMHP8GG85691", "2021" },
                    { 40, 60, "magenta", "Wagon", "Silverado", "W46SL3ROG6SC80589", "2019" },
                    { 41, 12, "Menta verde", "Coupe", "Golf", "WS0TDUXZHRRR93939", "2019" },
                    { 42, 5, "orquídea", "Sedan", "Cruze", "R811AXQGRBBB94841", "2021" },
                    { 43, 2, "gris", "Cargo Van", "Wrangler", "JWQK9VCDANIM55745", "2018" },
                    { 44, 62, "azul", "Extended Cab Pickup", "Prius", "O279BBZWJXYU97234", "2018" },
                    { 45, 55, "lavanda", "Crew Cab Pickup", "Mercielago", "D2SRVGRQESEA95524", "2018" },
                    { 46, 90, "gris", "SUV", "Durango", "DL6JS3PT8HIW42304", "2015" },
                    { 47, 65, "Lima", "Passenger Van", "XC90", "7102AL8LODA368851", "2019" },
                    { 48, 36, "turquesa", "Extended Cab Pickup", "Accord", "S2YOZ6GBY3D968769", "2021" },
                    { 49, 71, "oro", "Crew Cab Pickup", "Golf", "Y6E9WTI5HKMQ58543", "2015" },
                    { 50, 37, "marrón", "Crew Cab Pickup", "V90", "QJW4VL0MTHIO55995", "2020" },
                    { 51, 81, "lavanda", "Extended Cab Pickup", "Aventador", "AMQWES3N10QG66159", "2020" },
                    { 52, 15, "cielo azul", "Hatchback", "ATS", "K69XSLTB9EOI32342", "2019" },
                    { 53, 38, "marfil", "Wagon", "Impala", "TEF8E2PYWIBI91798", "2015" },
                    { 54, 73, "Lima", "Crew Cab Pickup", "Accord", "EQBMI30OLEN082424", "2018" },
                    { 55, 3, "amarillo", "Cargo Van", "Civic", "TQ2ZAY8562R130694", "2021" },
                    { 56, 36, "negro", "Passenger Van", "Alpine", "YE6489KSSQCZ65678", "2015" },
                    { 57, 47, "rojo", "Crew Cab Pickup", "El Camino", "YKWT6NZ1HMBX13303", "2015" },
                    { 58, 36, "orquídea", "Cargo Van", "F-150", "J0ZMU6I95HR745357", "2018" },
                    { 59, 13, "orquídea", "Sedan", "Escalade", "7D91IGX3SOSS40073", "2019" },
                    { 60, 91, "salmón", "Wagon", "Impala", "9JR30CXQV0HK22742", "2019" },
                    { 61, 60, "cielo azul", "Cargo Van", "Roadster", "1M5PFHTDTFXW85375", "2021" },
                    { 62, 50, "verde", "Extended Cab Pickup", "Fortwo", "A7E7XFC005LV73397", "2019" },
                    { 63, 34, "marrón", "Crew Cab Pickup", "Altima", "FU5THSABHZZD24576", "2018" },
                    { 64, 12, "turquesa", "Wagon", "Volt", "1QC4YOUQIRFR96593", "2019" },
                    { 65, 73, "fucsia", "Passenger Van", "Focus", "4H76KBAT4ML940240", "2015" },
                    { 66, 73, "azul", "Sedan", "Silverado", "KHAWFLHS29KM53824", "2021" },
                    { 67, 59, "ciruela", "Convertible", "911", "2N1C71P68AIX13937", "2021" },
                    { 68, 39, "magenta", "Sedan", "Sentra", "023Q6C0HYVRS65710", "2021" },
                    { 69, 84, "oro", "Wagon", "F-150", "50J6X4U02LNH51260", "2018" },
                    { 70, 56, "negro", "Crew Cab Pickup", "Charger", "JSOMD3699IGC55621", "2020" },
                    { 71, 81, "violeta", "Minivan", "Prius", "VVFZTAD2ZNST83693", "2020" },
                    { 72, 44, "oro", "Convertible", "Spyder", "M2X4BR13PRS262848", "2018" },
                    { 73, 35, "oro", "Sedan", "Ranchero", "M772YNRSFDR119598", "2020" },
                    { 74, 76, "plata", "Wagon", "Aventador", "8H370I7TZMLO17439", "2015" },
                    { 75, 91, "gris", "Minivan", "Malibu", "D3OOVSD21NG446567", "2020" },
                    { 76, 70, "oro", "Coupe", "ATS", "KOZXPLDG3DFM37675", "2018" },
                    { 77, 7, "salmón", "Passenger Van", "Taurus", "Z2M4CP2KVFFS31256", "2018" },
                    { 78, 98, "cian", "SUV", "A4", "F6J199YUOWBK24966", "2019" },
                    { 79, 52, "gris", "Coupe", "911", "FCCHSAU4PTRU59965", "2021" },
                    { 80, 67, "marrón", "Minivan", "Spyder", "3QAUHCED35VD53280", "2018" },
                    { 81, 48, "gris", "Extended Cab Pickup", "Spyder", "9SN18YUPF9T974905", "2018" },
                    { 82, 75, "magenta", "Crew Cab Pickup", "Aventador", "3V7PP91OMLBN19229", "2020" },
                    { 83, 83, "azul", "Sedan", "A8", "JM2S672AJKXX43116", "2020" },
                    { 84, 12, "verde", "Sedan", "Wrangler", "DOV21A6XN0K560986", "2018" },
                    { 85, 78, "marrón", "SUV", "Grand Cherokee", "0636R8PQKZL225079", "2015" },
                    { 86, 49, "orquídea", "Hatchback", "Escalade", "W83BAHLV00EJ48945", "2018" },
                    { 87, 84, "oro", "Hatchback", "PT Cruiser", "TTJQMP49LNA659441", "2020" },
                    { 88, 85, "magenta", "Coupe", "CX-9", "XWSU5LZMEDI729074", "2021" },
                    { 89, 34, "Lima", "Hatchback", "Durango", "9ML55Q9AKGUJ85151", "2015" },
                    { 90, 38, "amarillo", "Crew Cab Pickup", "CX-9", "8G296V3Y7WLO34071", "2020" },
                    { 91, 40, "morado", "Extended Cab Pickup", "Element", "OC4QQ6JU9FCF88163", "2015" },
                    { 92, 82, "azul", "Passenger Van", "XC90", "P0UM68PROUPD45203", "2020" },
                    { 93, 26, "lavanda", "Passenger Van", "Impala", "J4T359BCAKMG86618", "2018" },
                    { 94, 39, "lavanda", "Extended Cab Pickup", "XTS", "UQOLTR0VDPBS69368", "2015" },
                    { 95, 21, "orquídea", "Hatchback", "Aventador", "ADF4TYBD6NMX42971", "2021" },
                    { 96, 89, "morado", "Extended Cab Pickup", "PT Cruiser", "NQAB0GMMIUM355125", "2021" },
                    { 97, 7, "verde", "Crew Cab Pickup", "Model 3", "7Q2K76YASTOV47610", "2018" },
                    { 98, 92, "blanco", "Coupe", "Grand Caravan", "ZG9QEV8KCMV172029", "2015" },
                    { 99, 29, "salmón", "Convertible", "Sentra", "RAFD1WD3I8C812400", "2015" },
                    { 100, 32, "verde", "Crew Cab Pickup", "Beetle", "AAAQF952UUDP81276", "2020" }
                });

            migrationBuilder.InsertData(
                table: "inconvenients",
                columns: new[] { "id", "date_act", "days_delay", "description", "request_id", "seen", "service_request_id", "state" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 4, 7), 15, "SubGerente", 67, true, 80, "Social" },
                    { 2, new DateOnly(2022, 10, 25), 9, "Director", 63, false, 47, "Mecanico" },
                    { 3, new DateOnly(2022, 6, 1), 18, "Corporativo", 20, true, 16, "Mecanico" },
                    { 4, new DateOnly(2022, 10, 23), 13, "Humano", 95, false, 81, "Social" },
                    { 5, new DateOnly(2022, 6, 19), 12, "Cliente", 23, false, 50, "Social" },
                    { 6, new DateOnly(2022, 6, 12), 7, "Director", 79, true, 84, "Mecanico" },
                    { 7, new DateOnly(2023, 5, 20), 14, "SubGerente", 24, true, 97, "Social" },
                    { 8, new DateOnly(2022, 10, 20), 15, "Inversor", 77, false, 12, "Tiempo" },
                    { 9, new DateOnly(2023, 5, 18), 17, "Central", 38, true, 27, "Tiempo" },
                    { 10, new DateOnly(2022, 7, 16), 6, "Central", 28, true, 3, "Financiero" },
                    { 11, new DateOnly(2022, 11, 10), 18, "Inversor", 15, true, 50, "Tiempo" },
                    { 12, new DateOnly(2022, 6, 19), 16, "Futuro", 77, true, 32, "Tiempo" },
                    { 13, new DateOnly(2022, 6, 16), 4, "Heredado", 84, true, 82, "Mecanico" },
                    { 14, new DateOnly(2022, 6, 2), 11, "Distrito", 50, true, 68, "Mecanico" },
                    { 15, new DateOnly(2023, 4, 9), 7, "Inversor", 57, true, 89, "Financiero" },
                    { 16, new DateOnly(2023, 3, 22), 7, "Jefe", 42, true, 42, "Tiempo" },
                    { 17, new DateOnly(2023, 1, 2), 9, "Interno", 2, true, 58, "Social" },
                    { 18, new DateOnly(2023, 1, 28), 20, "Central", 46, true, 10, "Financiero" },
                    { 19, new DateOnly(2022, 9, 8), 15, "SubGerente", 16, true, 47, "Financiero" },
                    { 20, new DateOnly(2022, 6, 14), 4, "Adelante", 73, false, 63, "Financiero" },
                    { 21, new DateOnly(2022, 5, 30), 13, "Adelante", 26, true, 77, "Social" },
                    { 22, new DateOnly(2023, 5, 5), 13, "Inversor", 89, false, 89, "Social" },
                    { 23, new DateOnly(2022, 6, 15), 11, "Jefe", 96, true, 3, "Social" },
                    { 24, new DateOnly(2022, 10, 15), 7, "Heredado", 75, true, 9, "Tiempo" },
                    { 25, new DateOnly(2022, 12, 26), 5, "Director", 12, true, 54, "Mecanico" },
                    { 26, new DateOnly(2022, 11, 10), 18, "Producto", 34, false, 83, "Financiero" },
                    { 27, new DateOnly(2022, 6, 30), 10, "Nacional", 6, true, 69, "Financiero" },
                    { 28, new DateOnly(2023, 4, 4), 6, "Futuro", 82, false, 37, "Mecanico" },
                    { 29, new DateOnly(2022, 12, 29), 10, "Regional", 98, true, 19, "Mecanico" },
                    { 30, new DateOnly(2022, 8, 4), 2, "International", 8, false, 54, "Tiempo" },
                    { 31, new DateOnly(2023, 2, 8), 10, "Distrito", 38, true, 87, "Tiempo" },
                    { 32, new DateOnly(2023, 5, 29), 12, "Gerente", 56, true, 56, "Tiempo" },
                    { 33, new DateOnly(2022, 9, 3), 17, "Directo", 85, true, 19, "Mecanico" },
                    { 34, new DateOnly(2022, 7, 17), 3, "International", 41, true, 4, "Financiero" },
                    { 35, new DateOnly(2023, 4, 20), 20, "Nacional", 56, true, 47, "Financiero" },
                    { 36, new DateOnly(2023, 3, 9), 5, "Producto", 22, true, 22, "Financiero" },
                    { 37, new DateOnly(2023, 1, 9), 14, "Directo", 41, true, 42, "Financiero" },
                    { 38, new DateOnly(2023, 5, 25), 16, "Producto", 53, true, 88, "Financiero" },
                    { 39, new DateOnly(2022, 9, 7), 10, "Corporativo", 89, true, 65, "Financiero" },
                    { 40, new DateOnly(2022, 8, 23), 15, "Corporativo", 90, false, 58, "Social" },
                    { 41, new DateOnly(2023, 2, 8), 2, "Interno", 28, false, 34, "Tiempo" },
                    { 42, new DateOnly(2022, 9, 1), 18, "Central", 28, false, 82, "Mecanico" },
                    { 43, new DateOnly(2022, 9, 2), 6, "Humano", 91, false, 30, "Financiero" },
                    { 44, new DateOnly(2022, 9, 27), 10, "SubGerente", 16, true, 5, "Mecanico" },
                    { 45, new DateOnly(2023, 5, 11), 14, "Humano", 15, false, 77, "Mecanico" },
                    { 46, new DateOnly(2023, 4, 6), 1, "International", 22, true, 33, "Mecanico" },
                    { 47, new DateOnly(2022, 11, 20), 6, "SubGerente", 76, false, 56, "Tiempo" },
                    { 48, new DateOnly(2022, 11, 20), 10, "Central", 42, false, 88, "Social" },
                    { 49, new DateOnly(2023, 3, 2), 16, "Heredado", 83, true, 92, "Financiero" },
                    { 50, new DateOnly(2022, 8, 27), 11, "Senior", 50, false, 48, "Tiempo" },
                    { 51, new DateOnly(2023, 3, 24), 8, "Senior", 40, false, 4, "Tiempo" },
                    { 52, new DateOnly(2023, 4, 16), 20, "Humano", 75, true, 76, "Tiempo" },
                    { 53, new DateOnly(2023, 5, 12), 20, "Senior", 1, false, 26, "Financiero" },
                    { 54, new DateOnly(2022, 8, 3), 17, "Distrito", 75, true, 5, "Financiero" },
                    { 55, new DateOnly(2023, 2, 2), 10, "Jefe", 31, true, 6, "Social" },
                    { 56, new DateOnly(2023, 4, 1), 7, "Dinánmico", 18, false, 46, "Mecanico" },
                    { 57, new DateOnly(2022, 12, 15), 11, "Director", 25, true, 65, "Mecanico" },
                    { 58, new DateOnly(2022, 8, 3), 9, "Directo", 22, true, 91, "Tiempo" },
                    { 59, new DateOnly(2022, 10, 23), 3, "Regional", 88, false, 59, "Financiero" },
                    { 60, new DateOnly(2023, 2, 22), 1, "Senior", 4, false, 45, "Mecanico" },
                    { 61, new DateOnly(2022, 6, 30), 10, "International", 58, true, 27, "Mecanico" },
                    { 62, new DateOnly(2022, 11, 6), 5, "Global", 65, true, 5, "Social" },
                    { 63, new DateOnly(2022, 8, 28), 1, "SubGerente", 32, true, 73, "Financiero" },
                    { 64, new DateOnly(2023, 2, 2), 13, "SubGerente", 56, true, 2, "Social" },
                    { 65, new DateOnly(2022, 10, 1), 19, "Interno", 63, true, 74, "Tiempo" },
                    { 66, new DateOnly(2023, 4, 4), 20, "Distrito", 13, true, 10, "Financiero" },
                    { 67, new DateOnly(2023, 5, 25), 12, "Directo", 77, true, 71, "Mecanico" },
                    { 68, new DateOnly(2023, 5, 1), 2, "Cliente", 49, false, 66, "Mecanico" },
                    { 69, new DateOnly(2022, 7, 9), 17, "Central", 26, false, 84, "Mecanico" },
                    { 70, new DateOnly(2023, 5, 2), 20, "Jefe", 5, true, 34, "Financiero" },
                    { 71, new DateOnly(2022, 9, 10), 9, "Central", 5, true, 25, "Tiempo" },
                    { 72, new DateOnly(2022, 6, 8), 10, "Corporativo", 12, true, 43, "Mecanico" },
                    { 73, new DateOnly(2023, 1, 21), 5, "Gerente", 32, true, 88, "Mecanico" },
                    { 74, new DateOnly(2022, 6, 20), 6, "Directo", 1, false, 83, "Mecanico" },
                    { 75, new DateOnly(2022, 8, 8), 5, "Futuro", 28, false, 8, "Tiempo" },
                    { 76, new DateOnly(2022, 11, 18), 4, "Distrito", 10, true, 47, "Tiempo" },
                    { 77, new DateOnly(2022, 12, 5), 10, "Humano", 30, false, 1, "Financiero" },
                    { 78, new DateOnly(2022, 10, 23), 5, "Humano", 31, false, 27, "Social" },
                    { 79, new DateOnly(2022, 10, 19), 1, "Futuro", 5, true, 94, "Financiero" },
                    { 80, new DateOnly(2023, 4, 29), 12, "Jefe", 34, true, 86, "Financiero" },
                    { 81, new DateOnly(2022, 10, 10), 5, "Humano", 10, false, 59, "Tiempo" },
                    { 82, new DateOnly(2023, 2, 13), 14, "Directo", 35, false, 93, "Tiempo" },
                    { 83, new DateOnly(2023, 4, 16), 15, "Producto", 71, false, 49, "Mecanico" },
                    { 84, new DateOnly(2023, 1, 25), 9, "Senior", 11, false, 56, "Financiero" },
                    { 85, new DateOnly(2023, 5, 14), 3, "Inversor", 11, false, 89, "Tiempo" },
                    { 86, new DateOnly(2022, 12, 15), 14, "International", 9, true, 72, "Financiero" },
                    { 87, new DateOnly(2022, 10, 19), 2, "Producto", 23, true, 95, "Mecanico" },
                    { 88, new DateOnly(2022, 9, 19), 13, "Adelante", 31, true, 37, "Social" },
                    { 89, new DateOnly(2022, 11, 7), 20, "International", 96, true, 90, "Social" },
                    { 90, new DateOnly(2022, 10, 21), 20, "Corporativo", 68, true, 74, "Financiero" },
                    { 91, new DateOnly(2023, 5, 9), 15, "Interno", 27, true, 19, "Financiero" },
                    { 92, new DateOnly(2023, 1, 3), 15, "Gerente", 28, false, 98, "Tiempo" },
                    { 93, new DateOnly(2022, 9, 2), 5, "Jefe", 37, true, 55, "Social" },
                    { 94, new DateOnly(2022, 11, 17), 3, "Producto", 64, false, 76, "Tiempo" },
                    { 95, new DateOnly(2022, 10, 22), 10, "Humano", 64, true, 74, "Financiero" },
                    { 96, new DateOnly(2022, 9, 18), 5, "Gerente", 37, true, 23, "Tiempo" },
                    { 97, new DateOnly(2022, 6, 15), 17, "Regional", 39, true, 27, "Social" },
                    { 98, new DateOnly(2022, 12, 1), 13, "SubGerente", 29, false, 15, "Social" },
                    { 99, new DateOnly(2023, 4, 27), 11, "Central", 20, true, 5, "Financiero" },
                    { 100, new DateOnly(2023, 4, 11), 13, "Cliente", 60, true, 98, "Mecanico" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_admins_user_id",
                table: "admins",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clients_user_id",
                table: "clients",
                column: "user_id",
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
                name: "IX_purchases_product_id",
                table: "purchases",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchases_supplier_id",
                table: "purchases",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_receptionists_user_id",
                table: "receptionists",
                column: "user_id",
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
                name: "admins");

            migrationBuilder.DropTable(
                name: "inconvenients");

            migrationBuilder.DropTable(
                name: "PayrollMechanic");

            migrationBuilder.DropTable(
                name: "ProductRequest");

            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.DropTable(
                name: "receptionists");

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
