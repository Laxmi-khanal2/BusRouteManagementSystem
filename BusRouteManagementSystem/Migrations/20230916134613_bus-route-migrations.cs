using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusRouteManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class busroutemigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusStop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Busstop_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusStop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusBusStop",
                columns: table => new
                {
                    BusesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StopsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusBusStop", x => new { x.BusesId, x.StopsId });
                    table.ForeignKey(
                        name: "FK_BusBusStop_BusStop_StopsId",
                        column: x => x.StopsId,
                        principalTable: "BusStop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusBusStop_Bus_BusesId",
                        column: x => x.BusesId,
                        principalTable: "Bus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusBusStops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusStopNo = table.Column<int>(type: "int", nullable: false),
                    BusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BusStopId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusBusStops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusBusStops_BusStop_BusStopId",
                        column: x => x.BusStopId,
                        principalTable: "BusStop",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusBusStops_Bus_BusId",
                        column: x => x.BusId,
                        principalTable: "Bus",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Bus",
                columns: new[] { "Id", "BusName", "BusNumber" },
                values: new object[,]
                {
                    { new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), "Mahasagar yatayat", "MY3" },
                    { new Guid("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f"), "Gokerneshwor", "MY7" },
                    { new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), "Micro BUS", "MY6" },
                    { new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), "Gagalfedi yatayat", "MY4" },
                    { new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), "Mahanagar yatayat", "MY1" },
                    { new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), "saja yatayat", "MY2" }
                });

            migrationBuilder.InsertData(
                table: "BusStop",
                columns: new[] { "Id", "Busstop_Name" },
                values: new object[,]
                {
                    { new Guid("1e24207f-623a-4ab9-aa5a-16d21d986b82"), "Bhaktapur" },
                    { new Guid("2c171bb1-63a7-42d9-91e2-83de835c85a1"), "Medical college" },
                    { new Guid("42d08f38-8756-4c09-b5df-6a65b5f8d0fe"), "Ratnapark" },
                    { new Guid("5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df"), "Thali" },
                    { new Guid("6a65a3eb-901e-418f-bb3f-9ac0c68a9c64"), "Koteshwor " },
                    { new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), "Gausala" },
                    { new Guid("7fe7e1cb-63a2-4c6e-940f-63e7c85728c7"), "Gangabu " },
                    { new Guid("9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"), "Mulpani" },
                    { new Guid("b8fbbac3-e95a-47c7-950f-75e73a2ea4c9"), "Kalanki " },
                    { new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), "Chabhil" },
                    { new Guid("cc376167-8b1a-4df7-bfd3-48e3542f73c5"), "Sankhu " },
                    { new Guid("d2722cf0-2bfa-4e0e-b5c0-2c482c74b6a2"), "Sundarijal " },
                    { new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), "Bouddha" },
                    { new Guid("e4b9c7d3-1f8a-4672-92e5-6c3dab7f5e9d"), "Makalbari" },
                    { new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), "Jorpati" }
                });

            migrationBuilder.InsertData(
                table: "BusBusStops",
                columns: new[] { "Id", "BusId", "BusStopId", "BusStopNo" },
                values: new object[,]
                {
                    { new Guid("04f7fc1a-1dcd-4a98-94f3-22a54a9b6c72"), new Guid("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f"), new Guid("e4b9c7d3-1f8a-4672-92e5-6c3dab7f5e9d"), 1 },
                    { new Guid("160c50e6-1b24-45a6-9db1-0d0b387c9c07"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("7fe7e1cb-63a2-4c6e-940f-63e7c85728c7"), 5 },
                    { new Guid("1785c8eb-6c10-4c0f-88a3-2a5f3ef1ce2a"), new Guid("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f"), new Guid("6a65a3eb-901e-418f-bb3f-9ac0c68a9c64"), 6 },
                    { new Guid("18cb1a0e-2c4b-4ea7-b93f-43914d106d5e"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 4 },
                    { new Guid("1a72f6a8-c7b9-45e1-8f59-3b45d81c71ac"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 4 },
                    { new Guid("2c7c191e-6bc7-46d5-a71d-9b73fbbef4b0"), new Guid("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f"), new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), 5 },
                    { new Guid("2e871889-45a4-4ab5-aa65-7f6cc9e95115"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 2 },
                    { new Guid("32a0e99a-8e4a-45c6-9f87-95cc71a35877"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), 5 },
                    { new Guid("36e5411d-42a3-4d3f-9c0c-4bb4b6a2820c"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("6a65a3eb-901e-418f-bb3f-9ac0c68a9c64"), 8 },
                    { new Guid("3b6c7d2b-89f6-4f70-ae6b-147dab2e9243"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), 5 },
                    { new Guid("3e9d01b6-894d-4f26-b17b-8c5d5d5d18e1"), new Guid("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f"), new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), 3 },
                    { new Guid("3f7a2db2-e1d7-4923-bb42-1e5a1db41633"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 6 },
                    { new Guid("48656d8f-4ee6-45b3-9602-180e913f0a47"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 4 },
                    { new Guid("4fb2deac-87b7-4717-b82c-7db77197f846"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"), 2 },
                    { new Guid("501d3e3b-4c2d-432f-b81d-94b5d9814322"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("2c171bb1-63a7-42d9-91e2-83de835c85a1"), 2 },
                    { new Guid("5dc48e06-50f7-47b5-9e0d-72d856ec3a63"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df"), 1 },
                    { new Guid("64a3c1f0-8931-4d9d-b739-aa5920f38388"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("6a65a3eb-901e-418f-bb3f-9ac0c68a9c64"), 8 },
                    { new Guid("6d418f6c-2fe6-4c92-9c53-15e33a157a3b"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 6 },
                    { new Guid("6d9f5e0d-4cf2-4a6d-8f1f-835fbf30753d"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 2 },
                    { new Guid("6dbf0e5e-85a9-4e02-bc77-b67d7711c18d"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("42d08f38-8756-4c09-b5df-6a65b5f8d0fe"), 6 },
                    { new Guid("6eaa7ef5-81a7-4151-a1f7-4f2a82b7679b"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 5 },
                    { new Guid("75a17dd9-1a63-4e5d-97b5-26b219d69597"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("b8fbbac3-e95a-47c7-950f-75e73a2ea4c9"), 6 },
                    { new Guid("7d1f8e45-7c3e-4c63-8cfc-d8a73c1a70a5"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 3 },
                    { new Guid("7e9b530e-ae19-4b91-b53b-44f96b0e6011"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"), 3 },
                    { new Guid("7f52c417-63e1-4a7a-9fe6-9b2ca63c3e0e"), new Guid("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 4 },
                    { new Guid("82378d4c-7a7d-4b18-89d5-c1a0fe738b2e"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 2 },
                    { new Guid("82daafaf-6090-4e66-979b-1a939df19f29"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("c4e4a12d-2b5a-4a97-8493-327ad0869f6a"), 4 },
                    { new Guid("894af329-0137-4f1b-99f1-6f1a58f4e22a"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("42d08f38-8756-4c09-b5df-6a65b5f8d0fe"), 6 },
                    { new Guid("8e5b193c-96c5-43a3-9e2e-19ce508cee53"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), 7 },
                    { new Guid("8eef0d79-717d-4da1-bbb7-881c830b57e3"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 4 },
                    { new Guid("91e3ca2e-99a3-4b36-8801-7844d7cb82d9"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), 5 },
                    { new Guid("94f9630b-e4c9-42d5-b71b-7d44219ab77c"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("42d08f38-8756-4c09-b5df-6a65b5f8d0fe"), 7 },
                    { new Guid("986dbec4-3e16-4a8d-9b3b-06d9ac10543b"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("2c171bb1-63a7-42d9-91e2-83de835c85a1"), 1 },
                    { new Guid("9af1d2f0-52bb-4d3f-8a47-cbdfcb85b4d9"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"), 3 },
                    { new Guid("a2e8f174-7fb3-40a5-bf65-47c0a8b36525"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), 4 },
                    { new Guid("a5f8e7d1-4b9c-4e2d-93c7-8fd291c874a0"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("42d08f38-8756-4c09-b5df-6a65b5f8d0fe"), 6 },
                    { new Guid("b3e92c52-581c-4f69-9c02-d6b96e12f64d"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"), 1 },
                    { new Guid("b63685df-2e68-4c25-8919-25b20f372e2a"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 4 },
                    { new Guid("b654fad3-e38e-49d7-9ef5-d10a80a9a12e"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), 7 },
                    { new Guid("b8ed93df-8b5d-4d13-a99f-794f7be43c46"), new Guid("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 2 },
                    { new Guid("bcf3e70c-3f4b-48e6-b1b9-c6e01b07f0f4"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), 3 },
                    { new Guid("c57193d8-4b0d-421f-82f1-06ff1ac50d75"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df"), 2 },
                    { new Guid("c75a12e7-6e4c-4be0-8e48-33de929cd6b7"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), 6 },
                    { new Guid("d1286c35-42df-4777-9c9b-7402b9b3285c"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("cc376167-8b1a-4df7-bfd3-48e3542f73c5"), 1 },
                    { new Guid("d5788ea1-7403-48c9-874d-0d5c3edf1ea2"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"), 1 },
                    { new Guid("e0ce685a-5867-401e-bb7e-91b59b1bea3a"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), 5 },
                    { new Guid("e302d6ac-7a6f-4e9d-aae7-46d8b2a9948e"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("7a3f1d02-5c79-4803-9a2f-1c8559d3077d"), 5 },
                    { new Guid("e5ea6b7d-4d03-46f1-a3f7-54a58a5047e1"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("d2722cf0-2bfa-4e0e-b5c0-2c482c74b6a2"), 1 },
                    { new Guid("ebae82c2-8db4-4630-b1d4-7c3e56c3d44d"), new Guid("59f6e2c2-7355-4c9b-80bb-41db468cf1ab"), new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), 3 },
                    { new Guid("ec788798-6b1a-45e3-9ef1-3d589f8626d3"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("cc376167-8b1a-4df7-bfd3-48e3542f73c5"), 1 },
                    { new Guid("f3a4e1c9-0c09-4fe4-812d-1b2ff591a195"), new Guid("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18"), new Guid("b8fbbac3-e95a-47c7-950f-75e73a2ea4c9"), 8 },
                    { new Guid("f3d98ed6-38fe-49e5-9075-0b2c300d5e5a"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"), 3 },
                    { new Guid("f3e05278-9f5e-41d3-b37b-5d40c636d9f0"), new Guid("b5f8236a-927e-471e-8c75-66cf17f06df7"), new Guid("1e24207f-623a-4ab9-aa5a-16d21d986b82"), 9 },
                    { new Guid("f43b6e6a-665b-47e3-b698-5d396c62cabe"), new Guid("0a97006a-8769-456a-8c85-674a547c1e2a"), new Guid("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"), 3 },
                    { new Guid("f95f792b-0b47-4eeb-8e9a-652edbd46c9d"), new Guid("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca"), new Guid("5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df"), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusBusStop_StopsId",
                table: "BusBusStop",
                column: "StopsId");

            migrationBuilder.CreateIndex(
                name: "IX_BusBusStops_BusId",
                table: "BusBusStops",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusBusStops_BusStopId",
                table: "BusBusStops",
                column: "BusStopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusBusStop");

            migrationBuilder.DropTable(
                name: "BusBusStops");

            migrationBuilder.DropTable(
                name: "BusStop");

            migrationBuilder.DropTable(
                name: "Bus");
        }
    }
}
