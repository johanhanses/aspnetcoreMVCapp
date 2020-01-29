using Microsoft.EntityFrameworkCore.Migrations;

namespace Shoppen.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Metal", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Hard Rock", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Progressive Metal", null });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsAlbumOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Tool-Opiate.jpg/220px-Tool-Opiate.jpg", "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Tool-Opiate.jpg/220px-Tool-Opiate.jpg", true, true, "Opiate is an EP by American rock band Tool. It was produced and engineered by Sylvia Massy and former Minor Threat bassist Steve Hansgen. Released in 1992, it was the result of some two years of the band playing together after their formation in 1990. Opiate preceded Tool's first full-length release, Undertow, by a year. It is named after a quote by Karl Marx: 'religion... is the opiate of the masses'. As of July 7, 2010, Opiate has sold 1,155,000 copies in the US and is certified Platinum by the RIAA. The EP charted on several international charts when Tool released their catalog to online streaming in August 2019", "Opiate", 12.95m, "Tool - Opiate" },
                    { 4, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/6/63/Tool_-_Lateralus.jpg/220px-Tool_-_Lateralus.jpg", "https://upload.wikimedia.org/wikipedia/en/thumb/6/63/Tool_-_Lateralus.jpg/220px-Tool_-_Lateralus.jpg", true, false, "Lateralus (/ˌlætəˈræləs/) is the third studio album by American rock band Tool. It was released on May 15, 2001 through Volcano Entertainment. The album was recorded at Cello Studios in Hollywood and The Hook, Big Empty Space, and The Lodge, in North Hollywood, between October 2000 and January 2001. David Bottrill, who had produced the band's two previous releases Ænima and Salival, produced the album along with the band.", "Lateralus", 15.95m, "Tool - Lateralus" },
                    { 2, 2, "https://upload.wikimedia.org/wikipedia/en/thumb/8/82/Tool-Undertow.jpg/220px-Tool-Undertow.jpg", "https://upload.wikimedia.org/wikipedia/en/thumb/8/82/Tool-Undertow.jpg/220px-Tool-Undertow.jpg", true, false, "Undertow is the debut studio album by American rock band Tool, released on April 6, 1993 by Zoo Entertainment. Produced by the band and Sylvia Massy, it was recorded from October to December 1992 at Sound City Studios in Van Nuys and Grandmaster Recorders in Hollywood. The album includes some tracks the band decided to not release on their debut EP Opiate", "Undertow", 18.95m, "Tool - Undertow" },
                    { 3, 2, "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Aenima.jpg/220px-Aenima.jpg", "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Aenima.jpg/220px-Aenima.jpg", true, false, "Ænima (/ˈɑːnɪmə/ AH-ni-mə)[5] is the second studio album by American rock band Tool. It was released in vinyl format on September 17, 1996, and in compact disc format on October 1, 1996, through Zoo Entertainment. The album was recorded and cut at Ocean Way in Hollywood and The Hook in North Hollywood from 1995 to 1996. The album was produced by David Bottrill. ", "Aenima", 18.95m, "Tool - Aenima" },
                    { 5, 3, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f8/10000Days.jpg/220px-10000Days.jpg", "https://upload.wikimedia.org/wikipedia/en/thumb/f/f8/10000Days.jpg/220px-10000Days.jpg", true, false, "10,000 Days is the fourth studio album by American rock band Tool. The album was released by Tool Dissectional and Volcano Entertainment on April 28, 2006 in parts of Europe, April 29, 2006 in Australia, May 1, 2006 in the United Kingdom, and on May 2, 2006 in North America. Recording took place at O'Henry Sound Studios in Burbank, California, The Loft, and Grandmaster Studios (both in Hollywood, California). It marked the first time since recording 1993's Undertow that the band had worked at Grandmaster and without producer David Bottrill. It was mixed at Bay 7 in North Hollywood, California and mastered at Gateway Mastering Studios in Portland, Maine.", "10.000 Days", 13.95m, "Tool - 10.000 Days" },
                    { 6, 3, "https://upload.wikimedia.org/wikipedia/en/thumb/d/d6/Tool_-_Fear_Inoculum.png/220px-Tool_-_Fear_Inoculum.png", "https://upload.wikimedia.org/wikipedia/en/thumb/d/d6/Tool_-_Fear_Inoculum.png/220px-Tool_-_Fear_Inoculum.png", true, false, "Fear Inoculum is the fifth studio album by American rock band Tool. It was released on August 30, 2019, through Tool Dissectional, Volcano Entertainment, and RCA Records. It is the band's first album in 13 years, due to creative, personal, and legal issues band members encountered since the release of 10,000 Days. The album was released to critical acclaim, with reviewers generally agreeing that the band had successfully refined their established sound. The album topped the US Billboard 200 albums chart, their third album in a row to do so, selling over 270,000 album-equivalent units. The album topped five other national album charts in its opening week as well", "Fear Inoculum", 17.95m, "Tool - Fear Inoculum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
