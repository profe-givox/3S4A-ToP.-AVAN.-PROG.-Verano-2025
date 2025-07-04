using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiSCAR.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Residentes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Apellido = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Telefono = table.Column<string>(type: "longtext", nullable: false),
                    Direccion = table.Column<string>(type: "longtext", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residentes", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Residentes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Invitados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Apellido = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Telefono = table.Column<string>(type: "longtext", nullable: false),
                    FechaVisita = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: false),
                    ResidenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invitados_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BitacorasRegistro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FechaHoraEntrada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaHoraSalida = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ResidenteId = table.Column<int>(type: "int", nullable: true),
                    InvitadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitacorasRegistro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BitacorasRegistro_Invitados_InvitadoId",
                        column: x => x.InvitadoId,
                        principalTable: "Invitados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BitacorasRegistro_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "UserId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "pass1", "user1" },
                    { 2, "pass2", "user2" },
                    { 3, "pass3", "user3" },
                    { 4, "pass4", "user4" },
                    { 5, "pass5", "user5" }
                });

            migrationBuilder.InsertData(
                table: "Residentes",
                columns: new[] { "UserId", "Apellido", "Direccion", "Email", "FechaNacimiento", "FechaRegistro", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Pérez", "Calle 1", "juan1@mail.com", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 6, 30, 38, 346, DateTimeKind.Local).AddTicks(9586), "Juan", "1111111" },
                    { 2, "García", "Calle 2", "ana2@mail.com", new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(4793), "Ana", "2222222" },
                    { 3, "Martínez", "Calle 3", "luis3@mail.com", new DateTime(1992, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(4813), "Luis", "3333333" },
                    { 4, "López", "Calle 4", "sofia4@mail.com", new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(4817), "Sofía", "4444444" },
                    { 5, "Ruiz", "Calle 5", "carlos5@mail.com", new DateTime(1994, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(4820), "Carlos", "5555555" }
                });

            migrationBuilder.InsertData(
                table: "BitacorasRegistro",
                columns: new[] { "Id", "FechaHoraEntrada", "FechaHoraSalida", "InvitadoId", "ResidenteId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 1, 30, 38, 350, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 7, 4, 2, 30, 38, 350, DateTimeKind.Local).AddTicks(685), null, 1 },
                    { 2, new DateTime(2025, 7, 4, 3, 30, 38, 350, DateTimeKind.Local).AddTicks(1736), new DateTime(2025, 7, 4, 4, 30, 38, 350, DateTimeKind.Local).AddTicks(1739), null, 2 },
                    { 3, new DateTime(2025, 7, 4, 5, 30, 38, 350, DateTimeKind.Local).AddTicks(1743), null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Invitados",
                columns: new[] { "Id", "Apellido", "Email", "FechaVisita", "Nombre", "ResidenteId", "Telefono", "Token" },
                values: new object[,]
                {
                    { 1, "Ap1", "inv1@mail.com", new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(8103), "Inv1", 1, "1000001", "token1" },
                    { 2, "Ap2", "inv2@mail.com", new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(8941), "Inv2", 2, "1000002", "token2" },
                    { 3, "Ap3", "inv3@mail.com", new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(8945), "Inv3", 3, "1000003", "token3" },
                    { 4, "Ap4", "inv4@mail.com", new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(8949), "Inv4", 4, "1000004", "token4" },
                    { 5, "Ap5", "inv5@mail.com", new DateTime(2025, 7, 4, 6, 30, 38, 349, DateTimeKind.Local).AddTicks(8952), "Inv5", 5, "1000005", "token5" }
                });

            migrationBuilder.InsertData(
                table: "BitacorasRegistro",
                columns: new[] { "Id", "FechaHoraEntrada", "FechaHoraSalida", "InvitadoId", "ResidenteId" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 7, 4, 0, 30, 38, 350, DateTimeKind.Local).AddTicks(1746), new DateTime(2025, 7, 4, 1, 30, 38, 350, DateTimeKind.Local).AddTicks(1747), 1, null },
                    { 5, new DateTime(2025, 7, 3, 23, 30, 38, 350, DateTimeKind.Local).AddTicks(1750), new DateTime(2025, 7, 4, 0, 30, 38, 350, DateTimeKind.Local).AddTicks(1752), 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BitacorasRegistro_InvitadoId",
                table: "BitacorasRegistro",
                column: "InvitadoId");

            migrationBuilder.CreateIndex(
                name: "IX_BitacorasRegistro_ResidenteId",
                table: "BitacorasRegistro",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitados_ResidenteId",
                table: "Invitados",
                column: "ResidenteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitacorasRegistro");

            migrationBuilder.DropTable(
                name: "Invitados");

            migrationBuilder.DropTable(
                name: "Residentes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
