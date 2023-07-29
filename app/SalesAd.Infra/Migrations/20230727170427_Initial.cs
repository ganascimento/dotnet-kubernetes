using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesAd.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_OWNER",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Phone = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_OWNER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_ANNOUNCEMENT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    RoomsNumber = table.Column<short>(type: "smallint", nullable: true),
                    Value = table.Column<decimal>(type: "numeric(15,2)", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ANNOUNCEMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ANNOUNCEMENT_TB_OWNER_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "TB_OWNER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ANNOUNCEMENT_ADDRESS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StreetName = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    Neighborhood = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: true),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    AnnouncementId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ANNOUNCEMENT_ADDRESS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ANNOUNCEMENT_ADDRESS_TB_ANNOUNCEMENT_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "TB_ANNOUNCEMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_OWNER",
                columns: new[] { "Id", "Active", "BirthDate", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("042ad764-addc-43f9-92dd-d050a16e1801"), true, new DateTime(2001, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3695), "luizr@email.com", "Luiz Rodrigues", "11912345658", new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3696) },
                    { new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"), true, new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(2195), "marcossantos@email.com", "Marcos dos Santos", "11912345678", new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(2196) },
                    { new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"), true, new DateTime(1999, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4142), "mariaalves@email.com", "Maria Alves", "11912345620", new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4142) },
                    { new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"), true, new DateTime(2005, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3488), "anaferreira@email.com", "Ana Ferreira", "11912345679", new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3488) },
                    { new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), true, new DateTime(1999, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3904), "marionas@email.com", "Mario Nascimento", "11912345620", new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3905) }
                });

            migrationBuilder.InsertData(
                table: "TB_ANNOUNCEMENT",
                columns: new[] { "Id", "CreatedAt", "Description", "OwnerId", "RoomsNumber", "Size", "Type", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("1f5b4a80-a1c7-46a1-9c89-c78c531e01e3"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7160), "Ground test 3 e1298a81", new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), null, 453, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7161), 330000m },
                    { new Guid("352d501d-8dc4-4e27-b115-0970da692159"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6165), "Ground test 4 b692b631", new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"), null, 551, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6165), 410000m },
                    { new Guid("3f8d2b1d-eca9-4134-8fe4-d121179898ee"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5946), "Ground test 2 b692b631", new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"), null, 351, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5947), 210000m },
                    { new Guid("45e13dca-8889-49ce-ad3c-29fd92a22e2b"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7511), "Ground test 5 e1298a81", new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), null, 653, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7512), 530000m },
                    { new Guid("4d690858-a5af-4015-8742-605cfeecf814"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6526), "Ground test 2 042ad764", new Guid("042ad764-addc-43f9-92dd-d050a16e1801"), null, 352, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6527), 220000m },
                    { new Guid("62b4fbbc-8208-4fa3-95b2-36d1a0f598aa"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6370), "Ground test 5 b692b631", new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"), null, 651, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6371), 510000m },
                    { new Guid("69d3b780-ce77-4371-ab2b-20649da8e09f"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6700), "Ground test 3 042ad764", new Guid("042ad764-addc-43f9-92dd-d050a16e1801"), null, 452, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6701), 320000m },
                    { new Guid("720676f8-c5e1-4e0e-88ba-de39602ba8f1"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5835), "Ground test 5 59401ca7", new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"), null, 650, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5835), 500000m },
                    { new Guid("7e97f86c-ada4-4b73-86a6-d02e67e69aa2"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6899), "Ground test 5 042ad764", new Guid("042ad764-addc-43f9-92dd-d050a16e1801"), null, 652, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6900), 520000m },
                    { new Guid("8f6f2986-c5aa-4f7d-97e0-4105e7948754"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5571), "Ground test 4 59401ca7", new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"), null, 550, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5571), 400000m },
                    { new Guid("9791b2ff-53cf-41c9-a3d2-eb81fea8af12"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6795), "Ground test 4 042ad764", new Guid("042ad764-addc-43f9-92dd-d050a16e1801"), null, 552, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6795), 420000m },
                    { new Guid("9e0ceef7-24d6-4ab8-b643-0a4f67722360"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(8045), "Ground test 5 5db55f64", new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"), null, 653, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(8046), 540000m },
                    { new Guid("a3961af0-a4e3-4388-9cd4-01ce1d0ee2fe"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7608), "Ground test 2 5db55f64", new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"), null, 353, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7609), 240000m },
                    { new Guid("baa1d23f-ebe5-49f1-9926-106ec760b737"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7047), "Ground test 2 e1298a81", new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), null, 353, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7048), 230000m },
                    { new Guid("cb5442e5-d8ca-4783-987f-9b10bf398e4b"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7417), "Ground test 4 e1298a81", new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), null, 553, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7418), 430000m },
                    { new Guid("d6940989-0b2f-4f44-969b-6408defca4af"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5276), "Ground test 2 59401ca7", new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"), null, 350, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5277), 200000m },
                    { new Guid("d7095d49-64f5-4385-aeeb-05b2b8926b4e"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7729), "Ground test 3 5db55f64", new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"), null, 453, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7730), 340000m },
                    { new Guid("e3e651a6-2c3d-466f-b701-fa94bac8f44b"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5414), "Ground test 3 59401ca7", new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"), null, 450, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5415), 300000m },
                    { new Guid("eee36630-ea54-49b3-916e-71239a59688b"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4825), "Ground test 1", new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"), null, 250, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4826), 100000m },
                    { new Guid("f0123afa-c030-4b1e-9553-cf57d4d0769b"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6047), "Ground test 3 b692b631", new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"), null, 451, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6047), 310000m },
                    { new Guid("f91eae07-e620-4c26-9f54-21c5ae1abd02"), new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7819), "Ground test 4 5db55f64", new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"), null, 553, 2, new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7820), 440000m }
                });

            migrationBuilder.InsertData(
                table: "TB_ANNOUNCEMENT_ADDRESS",
                columns: new[] { "Id", "AnnouncementId", "Country", "Neighborhood", "Number", "State", "StreetName", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("17c44cbe-9a76-4348-b7c1-b2821e68260c"), new Guid("9e0ceef7-24d6-4ab8-b643-0a4f67722360"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("2cdf86ca-dd76-49e2-9f09-28af4a480f90"), new Guid("45e13dca-8889-49ce-ad3c-29fd92a22e2b"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("2ff5dd3c-e5e1-4579-b4b0-4b659a8d2c5e"), new Guid("7e97f86c-ada4-4b73-86a6-d02e67e69aa2"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("344a58c6-3e45-46a5-ad9d-61541a6c72b4"), new Guid("720676f8-c5e1-4e0e-88ba-de39602ba8f1"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("3edb6789-27b3-463f-ad68-2dd2659f0692"), new Guid("62b4fbbc-8208-4fa3-95b2-36d1a0f598aa"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("47f4bf2f-c0f7-4291-978e-d1ffe0b0a421"), new Guid("3f8d2b1d-eca9-4134-8fe4-d121179898ee"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("589f5d67-8027-4d1d-b542-6f16fc0d2f48"), new Guid("e3e651a6-2c3d-466f-b701-fa94bac8f44b"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("6e8762ff-4c31-4cf8-bacd-bb2aeee423fa"), new Guid("f91eae07-e620-4c26-9f54-21c5ae1abd02"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("74ee1759-5dc6-4296-b140-c14c7a8aeac8"), new Guid("baa1d23f-ebe5-49f1-9926-106ec760b737"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("89ea1c81-10c3-448e-877d-0eb4dab35cef"), new Guid("9791b2ff-53cf-41c9-a3d2-eb81fea8af12"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("8fe96bd5-4e21-40a3-b54a-b772635d19bc"), new Guid("69d3b780-ce77-4371-ab2b-20649da8e09f"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("9913e01f-3f76-4f68-aa29-f0a0e6366430"), new Guid("f0123afa-c030-4b1e-9553-cf57d4d0769b"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("9e467400-bfef-4dba-8aad-be41d60013a8"), new Guid("1f5b4a80-a1c7-46a1-9c89-c78c531e01e3"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("afdf8857-990e-4201-8027-b0342987b8ce"), new Guid("8f6f2986-c5aa-4f7d-97e0-4105e7948754"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("bb2ad1bc-e49b-4be8-b3c5-830d758ca69f"), new Guid("a3961af0-a4e3-4388-9cd4-01ce1d0ee2fe"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("c003c7d2-fc8c-462f-aa54-5ae63fbbf61c"), new Guid("d6940989-0b2f-4f44-969b-6408defca4af"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("c01cf521-e2f8-422f-91fa-3946139dc2c5"), new Guid("cb5442e5-d8ca-4783-987f-9b10bf398e4b"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("c4076ee7-16b1-41a9-8e6e-eae21551b6e9"), new Guid("4d690858-a5af-4015-8742-605cfeecf814"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("d3b9afbd-ee69-4730-ae85-cdf84b1e0e80"), new Guid("eee36630-ea54-49b3-916e-71239a59688b"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("dba3543d-f088-4e84-bd60-5d219da88f65"), new Guid("352d501d-8dc4-4e27-b115-0970da692159"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" },
                    { new Guid("f2c5d447-6e98-4371-8866-5535ba174d66"), new Guid("d7095d49-64f5-4385-aeeb-05b2b8926b4e"), "BR", "Bairro 1", 12, "MG", "Street DOTNET 7", "14785000" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANNOUNCEMENT_OwnerId",
                table: "TB_ANNOUNCEMENT",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANNOUNCEMENT_ADDRESS_AnnouncementId",
                table: "TB_ANNOUNCEMENT_ADDRESS",
                column: "AnnouncementId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ANNOUNCEMENT_ADDRESS");

            migrationBuilder.DropTable(
                name: "TB_ANNOUNCEMENT");

            migrationBuilder.DropTable(
                name: "TB_OWNER");
        }
    }
}
