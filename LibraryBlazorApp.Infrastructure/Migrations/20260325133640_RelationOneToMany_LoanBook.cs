using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryBlazorApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelationOneToMany_LoanBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Loans_BookId",
                table: "Loans");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Clients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "BirthDate", "CreatedAt", "DeathDate", "Name", "Nationality", "Surname" },
                values: new object[,]
                {
                    { 1, "Polski pisarz specjalizujący się w literaturze kryminalnej i thrillerach psychologicznych.", new DateTime(1980, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), null, "Jan", "Polska", "Kowalski" },
                    { 2, "Autorka bestsellerowych powieści obyczajowych i romansów.", new DateTime(1975, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, "Anna", "Polska", "Nowak" },
                    { 3, "Twórca epickich powieści fantasy inspirowanych mitologią słowiańską.", new DateTime(1990, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), null, "Marek", "Polska", "Zieliński" },
                    { 4, "Pisarka science fiction, koncentrująca się na sztucznej inteligencji i przyszłości technologii.", new DateTime(1985, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, "Katarzyna", "Polska", "Wiśniewska" },
                    { 5, "Autor książek popularnonaukowych z zakresu psychologii i rozwoju osobistego.", new DateTime(1978, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tomasz", "Polska", "Lewandowski" },
                    { 6, "Autor pozostający w ukryciu. Tożsamość nieznana, brak potwierdzonych informacji biograficznych.", null, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, "Anonim", "Nieznana", "" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "adam.nowicki@example.com", "Adam", "500100200", "Nowicki" },
                    { 2, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), "ewa.kaczmarek@example.com", "Ewa", "501200300", "Kaczmarek" },
                    { 3, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "piotr.mazur@example.com", "Piotr", "502300400", "Mazur" },
                    { 4, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "karolina.dabrowska@example.com", "Karolina", "503400500", "Dąbrowska" },
                    { 5, new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "michal.piotrowski@example.com", "Michał", "504500600", "Piotrowski" },
                    { 6, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), "natalia.grabowska@example.com", "Natalia", "505600700", "Grabowska" },
                    { 7, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "krzysztof.pawlak@example.com", "Krzysztof", "506700800", "Pawlak" },
                    { 8, new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), "magdalena.michalska@example.com", "Magdalena", "507800900", "Michalska" },
                    { 9, new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "pawel.krol@example.com", "Paweł", "508900100", "Król" },
                    { 10, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Utc), "agnieszka.wieczorek@example.com", "Agnieszka", "509100200", "Wieczorek" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "ClientId", "Country", "CreatedAt", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Warszawa", 1, "Polska", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "00-001", "Kwiatowa 1" },
                    { 2, "Kraków", 2, "Polska", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), "30-002", "Słoneczna 5" },
                    { 3, "Gdańsk", 3, "Polska", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "80-003", "Leśna 10" },
                    { 4, "Wrocław", 4, "Polska", new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "50-004", "Polna 3" },
                    { 5, "Poznań", 5, "Polska", new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "60-005", "Szkolna 7" },
                    { 6, "Łódź", 6, "Polska", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), "90-006", "Ogrodowa 12" },
                    { 7, "Katowice", 7, "Polska", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "40-007", "Lipowa 9" },
                    { 8, "Lublin", 8, "Polska", new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), "20-008", "Brzozowa 15" },
                    { 9, "Szczecin", 9, "Polska", new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "70-009", "Wiślana 20" },
                    { 10, "Bydgoszcz", 10, "Polska", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Utc), "85-010", "Zielona 8" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Description", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Tajemnicza historia książki i jej autora", 5, "Cień Wiatru" },
                    { 2, 2, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Thriller technologiczny o sztucznej inteligencji", 3, "Kod Przeznaczenia" },
                    { 3, 3, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Fantastyczna opowieść o upadłym królestwie", 7, "Ostatni Strażnik" },
                    { 4, 4, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kryminał noir w futurystycznym świecie", 4, "Miasto Cieni" },
                    { 5, 5, new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Popularnonaukowa książka o psychologii", 6, "Sekrety Umysłu" },
                    { 6, 1, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Zagadka ukryta w historii", 2, "Zaginiony Symbol" },
                    { 7, 2, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Filozofia i rozwój osobisty", 8, "Droga Wojownika" },
                    { 8, 3, new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Saga rodzinna na przestrzeni pokoleń", 3, "Echo Przeszłości" },
                    { 9, 4, new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Sci-fi o podróżach między wymiarami", 5, "Granice Rzeczywistości" },
                    { 10, 5, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Dramat psychologiczny", 4, "Czas Milczenia" },
                    { 11, 1, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Fantastyczna historia o manipulacji snami", 6, "Złodziej Snów" },
                    { 12, 2, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Śledztwo pełne zwrotów akcji", 2, "Labirynt Prawdy" },
                    { 13, 3, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Epicka fantasy o walce o tron", 9, "Królestwo Popiołów" },
                    { 14, 4, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Programista odkrywa globalny spisek", 3, "Algorytm Chaosu" },
                    { 15, 5, new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Kryminał sądowy", 5, "Milczący Świadek" },
                    { 16, 1, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Kosmiczna ekspedycja", 7, "Podróż bez Powrotu" },
                    { 17, 1, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Genetyka i przyszłość ludzkości", 4, "Tajemnice DNA" },
                    { 18, 1, new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Historia wielkiego państwa", 6, "Upadek Imperium" },
                    { 19, 1, new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Thriller polityczny", 2, "Czarna Lista" },
                    { 20, 6, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Inspirująca opowieść o nadziei", 8, "Światło w Ciemności" }
                });

            migrationBuilder.InsertData(
                table: "LibraryCards",
                columns: new[] { "Id", "ClientId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 2, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 3, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 4, new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, 5, new DateTime(2019, 9, 14, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, 6, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, 7, new DateTime(2017, 2, 5, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, 8, new DateTime(2016, 4, 18, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, 9, new DateTime(2015, 6, 25, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, 10, new DateTime(2014, 8, 12, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "BookId", "BorrowDate", "LibraryCardId", "ReturnedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null },
                    { 2, 2, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 4, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3, null },
                    { 5, 5, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), 3, null },
                    { 6, 6, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, 7, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), 5, null },
                    { 9, 9, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), 5, null },
                    { 10, 10, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, 11, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, 12, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), 6, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, 13, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), 6, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, 14, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), 7, null },
                    { 15, 15, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null },
                    { 16, 16, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), 7, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, 17, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), 8, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, 18, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), 9, null },
                    { 19, 19, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), 9, null },
                    { 20, 20, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), 9, null },
                    { 21, 1, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), 9, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 22, 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), 9, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 23, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), 10, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 24, 4, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), 10, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Loans_BookId",
                table: "Loans");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LibraryCards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId",
                unique: true);
        }
    }
}
