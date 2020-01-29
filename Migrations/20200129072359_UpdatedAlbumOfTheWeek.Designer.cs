﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shoppen.Models;

namespace Shoppen.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200129072359_UpdatedAlbumOfTheWeek")]
    partial class UpdatedAlbumOfTheWeek
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shoppen.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAlbumOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Tool-Opiate.jpg/220px-Tool-Opiate.jpg",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Tool-Opiate.jpg/220px-Tool-Opiate.jpg",
                            InStock = true,
                            IsAlbumOfTheWeek = false,
                            LongDescription = "Opiate is an EP by American rock band Tool. It was produced and engineered by Sylvia Massy and former Minor Threat bassist Steve Hansgen. Released in 1992, it was the result of some two years of the band playing together after their formation in 1990. Opiate preceded Tool's first full-length release, Undertow, by a year. It is named after a quote by Karl Marx: 'religion... is the opiate of the masses'. As of July 7, 2010, Opiate has sold 1,155,000 copies in the US and is certified Platinum by the RIAA. The EP charted on several international charts when Tool released their catalog to online streaming in August 2019",
                            Name = "Opiate",
                            Price = 12.95m,
                            ShortDescription = "Tool - Opiate"
                        },
                        new
                        {
                            AlbumId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/82/Tool-Undertow.jpg/220px-Tool-Undertow.jpg",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/82/Tool-Undertow.jpg/220px-Tool-Undertow.jpg",
                            InStock = true,
                            IsAlbumOfTheWeek = true,
                            LongDescription = "Undertow is the debut studio album by American rock band Tool, released on April 6, 1993 by Zoo Entertainment. Produced by the band and Sylvia Massy, it was recorded from October to December 1992 at Sound City Studios in Van Nuys and Grandmaster Recorders in Hollywood. The album includes some tracks the band decided to not release on their debut EP Opiate",
                            Name = "Undertow",
                            Price = 18.95m,
                            ShortDescription = "Tool - Undertow"
                        },
                        new
                        {
                            AlbumId = 3,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Aenima.jpg/220px-Aenima.jpg",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Aenima.jpg/220px-Aenima.jpg",
                            InStock = true,
                            IsAlbumOfTheWeek = false,
                            LongDescription = "Ænima (/ˈɑːnɪmə/ AH-ni-mə)[5] is the second studio album by American rock band Tool. It was released in vinyl format on September 17, 1996, and in compact disc format on October 1, 1996, through Zoo Entertainment. The album was recorded and cut at Ocean Way in Hollywood and The Hook in North Hollywood from 1995 to 1996. The album was produced by David Bottrill. ",
                            Name = "Aenima",
                            Price = 18.95m,
                            ShortDescription = "Tool - Aenima"
                        },
                        new
                        {
                            AlbumId = 4,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/63/Tool_-_Lateralus.jpg/220px-Tool_-_Lateralus.jpg",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/63/Tool_-_Lateralus.jpg/220px-Tool_-_Lateralus.jpg",
                            InStock = true,
                            IsAlbumOfTheWeek = true,
                            LongDescription = "Lateralus (/ˌlætəˈræləs/) is the third studio album by American rock band Tool. It was released on May 15, 2001 through Volcano Entertainment. The album was recorded at Cello Studios in Hollywood and The Hook, Big Empty Space, and The Lodge, in North Hollywood, between October 2000 and January 2001. David Bottrill, who had produced the band's two previous releases Ænima and Salival, produced the album along with the band.",
                            Name = "Lateralus",
                            Price = 15.95m,
                            ShortDescription = "Tool - Lateralus"
                        },
                        new
                        {
                            AlbumId = 5,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f8/10000Days.jpg/220px-10000Days.jpg",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f8/10000Days.jpg/220px-10000Days.jpg",
                            InStock = true,
                            IsAlbumOfTheWeek = false,
                            LongDescription = "10,000 Days is the fourth studio album by American rock band Tool. The album was released by Tool Dissectional and Volcano Entertainment on April 28, 2006 in parts of Europe, April 29, 2006 in Australia, May 1, 2006 in the United Kingdom, and on May 2, 2006 in North America. Recording took place at O'Henry Sound Studios in Burbank, California, The Loft, and Grandmaster Studios (both in Hollywood, California). It marked the first time since recording 1993's Undertow that the band had worked at Grandmaster and without producer David Bottrill. It was mixed at Bay 7 in North Hollywood, California and mastered at Gateway Mastering Studios in Portland, Maine.",
                            Name = "10.000 Days",
                            Price = 13.95m,
                            ShortDescription = "Tool - 10.000 Days"
                        },
                        new
                        {
                            AlbumId = 6,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d6/Tool_-_Fear_Inoculum.png/220px-Tool_-_Fear_Inoculum.png",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d6/Tool_-_Fear_Inoculum.png/220px-Tool_-_Fear_Inoculum.png",
                            InStock = true,
                            IsAlbumOfTheWeek = true,
                            LongDescription = "Fear Inoculum is the fifth studio album by American rock band Tool. It was released on August 30, 2019, through Tool Dissectional, Volcano Entertainment, and RCA Records. It is the band's first album in 13 years, due to creative, personal, and legal issues band members encountered since the release of 10,000 Days. The album was released to critical acclaim, with reviewers generally agreeing that the band had successfully refined their established sound. The album topped the US Billboard 200 albums chart, their third album in a row to do so, selling over 270,000 album-equivalent units. The album topped five other national album charts in its opening week as well",
                            Name = "Fear Inoculum",
                            Price = 17.95m,
                            ShortDescription = "Tool - Fear Inoculum"
                        });
                });

            modelBuilder.Entity("Shoppen.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Metal"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Hard Rock"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Progressive Metal"
                        });
                });

            modelBuilder.Entity("Shoppen.Models.Album", b =>
                {
                    b.HasOne("Shoppen.Models.Category", "Category")
                        .WithMany("Albums")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
