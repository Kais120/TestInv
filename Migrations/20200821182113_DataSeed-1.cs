using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class DataSeed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Uid",
                table: "Invoice",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Uid",
                table: "Company",
                nullable: false,
                defaultValueSql: "(newsequentialid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Uid", "Address", "Name", "RegDate", "Telephone" },
                values: new object[,]
                {
                    { new Guid("3f3342a7-0bd7-44da-b5da-ac1e00ec8a8a"), "253 Fulton Circle Menasha, WI 54952", "Ecstatic Systems", new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "431-393-0117" },
                    { new Guid("8cfc1265-46b6-48ca-b7af-ac1e00ec8a8a"), "580 N. Liberty Dr. Orange Park, FL 32065", "Chiefoods", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "975-663-2423" },
                    { new Guid("536da5bf-d737-47be-b644-ac1e00ec8a8a"), "9459 North Mill Ave. Roanoke Rapids, NC 27870", "Essensecurity", new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "966-722-2521" },
                    { new Guid("7ac80ccb-d181-483d-bc95-ac1e00ec8a8a"), "543 White Drive New Bedford, MA 02740", "Elitelligence", new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "606-752-7843" },
                    { new Guid("ff8bd24f-1a07-4b9f-97fb-ac1e00ec8a8a"), "96 Armstrong Lane Cary, NC 27511", "Daydreamotors", new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "838-383-3934" },
                    { new Guid("96ef9d31-5bb1-4941-be9d-ac1e00ec8a8a"), "8561 Glen Eagles Circle Natick, MA 01760", "Heartstone", new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "509-760-3953" },
                    { new Guid("5e8f7378-6d23-4591-87bf-ac1e00ec8a8a"), "37 East Logan Lane Eugene, OR 97402", "Lagoonmaster", new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "827-418-5289" },
                    { new Guid("9cdc0b8b-87ff-4331-bd83-ac1e00ec8a8a"), "53 Hickory Court Klamath Falls, OR 97603", "Shadecloud", new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "629-202-6953" },
                    { new Guid("3fba17da-8e2b-4cd4-9692-ac1e00ec8a8a"), "8352 Marsh St. Indian Trail, NC 28079", "Pinnacle Aviation", new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "937-490-6629" },
                    { new Guid("77b77f58-1487-4c25-bb33-ac1e00ec8a8a"), "9825 Pilgrim Ave. Ontario, CA 91762", "Neptune Solutions", new DateTime(2019, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "713-210-5080" },
                    { new Guid("eeace729-abee-4982-be5c-ac1e00ec8a8a"), "2 Fordham Drive Merrick, NY 11566", "Night Networks", new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "865-503-5762" },
                    { new Guid("42960bff-2eb9-4305-a512-ac1e00ec8a8a"), "292 Jones Lane Lanham, MD 20706", "Forestics", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "845-892-1111" },
                    { new Guid("b5bff7d5-2beb-4fd3-9f2f-ac1e00ec8a8a"), "91 Amerige Ave. Muscatine, IA 52761", "Bearings", new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "984-496-5436" },
                    { new Guid("032410ac-af50-4818-b4c9-ac1e00ec8a8a"), "788B Miles Ave. Fairport, NY 14450", "Mermedia", new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "905-246-2186" },
                    { new Guid("7ddb9506-e3b3-4044-8f2f-ac1e00ec8a8a"), "8403 Goldfield Ave. King Of Prussia, PA 19406", "Fairiprises", new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "519-259-6669" },
                    { new Guid("fa627a80-77b2-4eb2-866b-ac1e00ec8a8a"), "7507 Wakehurst Avenue Murfreesboro, TN 37128", "Mountaintime", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "801-871-4863" },
                    { new Guid("457d8223-f297-4a5d-bc9d-ac1e00ec8a8a"), "153 Old Lancaster Street Princeton, NJ 08540", "Fireworth", new DateTime(2019, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "264-712-5689" },
                    { new Guid("d9e18060-a9f8-49cc-8b82-ac1e00ec8a8a"), "108 Canterbury Avenue Reston, VA 20191", "Cloudworld", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "314-535-5117" },
                    { new Guid("5779ad22-48f4-4678-b4b6-ac1e00ec8a8a"), "2 Howard Ave. Germantown, MD 20874", "Red Security", new DateTime(2020, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "931-970-0832" },
                    { new Guid("c39c20b0-7f4e-4ce8-9fa6-ac1e00ec8a8a"), "506 South Gregory Lane Cumming, GA 30040", "Silver", new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "467-454-5805" },
                    { new Guid("62b61f8d-1794-4b20-8c71-ac1e00ec8a8a"), "8638 Santa Clara St. Yuba City, CA 95993", "Twilight Corporation", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "551-996-8865" },
                    { new Guid("a2185710-7ec1-41a2-ad00-ac1e00ec8a8a"), "39 Tarkiln Hill St. West Hempstead, NY 11552", "Hoglight", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "392-458-6631" },
                    { new Guid("b8b866ab-728d-46a2-affe-ac1e00ec8a8a"), "55 Shub Farm Court Yuma, AZ 85365", "Red Limited", new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "887-738-4272" },
                    { new Guid("be70744e-6732-4f03-89b7-ac1e00ec8a8a"), "8863 Howard Court Traverse City, MI 49684", "Primal Electronics", new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "909-467-1181" },
                    { new Guid("c3c6ee6a-58d2-4ce0-9e9d-ac1e00ec8a8a"), "813 Pheasant Street Huntley, IL 60142", "Surprisystems", new DateTime(2019, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "558-663-2657" },
                    { new Guid("6526d18f-2182-45c9-8aec-ac1e00ec8a8a"), "5 Boston St. Patchogue, NY 11772", "Gorillacoustics", new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "208-652-0972" },
                    { new Guid("007b720a-ad72-4909-beb4-ac1e00ec8a8a"), "39 Jockey Hollow St. Passaic, NJ 07055", "Silver Linetworks", new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "754-934-6607" },
                    { new Guid("1089419e-3e69-4f00-812e-ac1e00ec8a8a"), "8 Main St. Bridgeton, NJ 08302", "Dwarfoods", new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "428-213-6913" },
                    { new Guid("5c88ad00-f764-4970-9b8f-ac1e00ec8a8a"), "9801 Mammoth Drive Winston Salem, NC 27103", "Greenaid", new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "453-539-9934" },
                    { new Guid("9a8dab0b-5210-4e55-945a-ac1e00ec8a8a"), "49 Talbot Street Stroudsburg, PA 18360", "Squidwood", new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "925-925-3730" },
                    { new Guid("c0418675-64b3-4dc0-8c55-ac1e00ec8a8a"), "932 Locust Ave. Minot, ND 58701", "Alp Arts", new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "542-361-0307" },
                    { new Guid("2f052098-a9dc-4454-9c01-ac1e00ec8a8a"), "7566 Hawthorne Drive Port Chester, NY 10573", "Thunderwares", new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "922-481-4794" },
                    { new Guid("32c17641-e450-4e49-a877-ac1e00ec8a8a"), "14 Academy Street Arlington, MA 02474", "Angel Systems", new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "374-323-7205" },
                    { new Guid("08fb9f52-b72e-44b2-8e90-ac1e00ec8a8a"), "8959 Pennsylvania Court Hoboken, NJ 07030", "Ecstatic Enterprises", new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "992-452-6822" },
                    { new Guid("2479d94e-5b9d-430f-9829-ac1e00ec8a8a"), "8501 James St. Southampton, PA 18966", "Starecords", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "798-594-7742" },
                    { new Guid("664b404b-3005-49a6-a9ea-ac1e00ec8a8a"), "9022 Branch St. Montgomery Village, MD 20886", "Apexi", new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "350-813-1923" },
                    { new Guid("c2208630-d4e7-471d-9f3c-ac1e00ec8a8a"), "100 Old Oxford Ave. Norwich, CT 06360", "Galerprises", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "520-872-8810" },
                    { new Guid("9260b2d5-1b95-4595-a330-ac1e00ec8a8a"), "443 Gates Avenue Memphis, TN 38106", "Quaductions", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "799-500-7874" },
                    { new Guid("17a98816-d184-45b6-ab07-ac1e00ec8a8a"), "85 Marlborough Dr. Zeeland, MI 49464", "Wavemedia", new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "773-728-4669" },
                    { new Guid("e0637e15-834d-4ba4-bcb9-ac1e00ec8a8a"), "890 Wood Street Baltimore, MD 21206", "Pixywater", new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "244-916-5331" },
                    { new Guid("83539186-9cda-4ed2-9e27-ac1e00ec8a8a"), "9337 East Dr. Meadville, PA 16335", "Tundra Brews", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "771-896-0645" },
                    { new Guid("897aa125-268a-4488-9592-ac1e00ec8a8a"), "47 Glenridge Ave. Tupelo, MS 38801", "Timber Security", new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "744-230-2997" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("007b720a-ad72-4909-beb4-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("032410ac-af50-4818-b4c9-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("08fb9f52-b72e-44b2-8e90-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("1089419e-3e69-4f00-812e-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("17a98816-d184-45b6-ab07-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("2479d94e-5b9d-430f-9829-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("2f052098-a9dc-4454-9c01-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("32c17641-e450-4e49-a877-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("3f3342a7-0bd7-44da-b5da-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("3fba17da-8e2b-4cd4-9692-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("42960bff-2eb9-4305-a512-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("457d8223-f297-4a5d-bc9d-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("536da5bf-d737-47be-b644-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("5779ad22-48f4-4678-b4b6-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("5c88ad00-f764-4970-9b8f-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("5e8f7378-6d23-4591-87bf-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("62b61f8d-1794-4b20-8c71-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("6526d18f-2182-45c9-8aec-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("664b404b-3005-49a6-a9ea-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("77b77f58-1487-4c25-bb33-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("7ac80ccb-d181-483d-bc95-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("7ddb9506-e3b3-4044-8f2f-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("83539186-9cda-4ed2-9e27-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("897aa125-268a-4488-9592-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("8cfc1265-46b6-48ca-b7af-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("9260b2d5-1b95-4595-a330-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("96ef9d31-5bb1-4941-be9d-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("9a8dab0b-5210-4e55-945a-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("9cdc0b8b-87ff-4331-bd83-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("a2185710-7ec1-41a2-ad00-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("b5bff7d5-2beb-4fd3-9f2f-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("b8b866ab-728d-46a2-affe-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("be70744e-6732-4f03-89b7-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("c0418675-64b3-4dc0-8c55-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("c2208630-d4e7-471d-9f3c-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("c39c20b0-7f4e-4ce8-9fa6-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("c3c6ee6a-58d2-4ce0-9e9d-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("d9e18060-a9f8-49cc-8b82-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("e0637e15-834d-4ba4-bcb9-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("eeace729-abee-4982-be5c-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("fa627a80-77b2-4eb2-866b-ac1e00ec8a8a"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Uid",
                keyValue: new Guid("ff8bd24f-1a07-4b9f-97fb-ac1e00ec8a8a"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Uid",
                table: "Invoice",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newsequentialid())");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "Uid",
                table: "Company",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "(newsequentialid())");
        }
    }
}
