using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppen.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Metal" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Hard Rock" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Progressive Metal" });

            //seed pies
            modelBuilder.Entity<Album>().HasData(new Album
            {
                AlbumId = 1,
                Name = "Opiate",
                Price = 12.95M,
                ShortDescription = "Tool - Opiate",
                LongDescription = "Opiate is an EP by American rock band Tool. It was produced and engineered by Sylvia Massy and former Minor Threat bassist Steve Hansgen. Released in 1992, it was the result of some two years of the band playing together after their formation in 1990. Opiate preceded Tool's first full-length release, Undertow, by a year. It is named after a quote by Karl Marx: 'religion... is the opiate of the masses'. As of July 7, 2010, Opiate has sold 1,155,000 copies in the US and is certified Platinum by the RIAA. The EP charted on several international charts when Tool released their catalog to online streaming in August 2019",
                CategoryId = 1,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Tool-Opiate.jpg/220px-Tool-Opiate.jpg",
                InStock = true,
                IsAlbumOfTheWeek = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Tool-Opiate.jpg/220px-Tool-Opiate.jpg"
            });

            modelBuilder.Entity<Album>().HasData(new Album
            {
                AlbumId = 2,
                Name = "Undertow",
                Price = 18.95M,
                ShortDescription = "Tool - Undertow",
                LongDescription = "Undertow is the debut studio album by American rock band Tool, released on April 6, 1993 by Zoo Entertainment. Produced by the band and Sylvia Massy, it was recorded from October to December 1992 at Sound City Studios in Van Nuys and Grandmaster Recorders in Hollywood. The album includes some tracks the band decided to not release on their debut EP Opiate",
                CategoryId = 2,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/82/Tool-Undertow.jpg/220px-Tool-Undertow.jpg",
                InStock = true,
                IsAlbumOfTheWeek = true,
                ImageThumbnailUrl =
                    "https://upload.wikimedia.org/wikipedia/en/thumb/8/82/Tool-Undertow.jpg/220px-Tool-Undertow.jpg"
            });

            modelBuilder.Entity<Album>().HasData(new Album
            {
                AlbumId = 3,
                Name = "Aenima",
                Price = 18.95M,
                ShortDescription = "Tool - Aenima",
                LongDescription = "Ænima (/ˈɑːnɪmə/ AH-ni-mə)[5] is the second studio album by American rock band Tool. It was released in vinyl format on September 17, 1996, and in compact disc format on October 1, 1996, through Zoo Entertainment. The album was recorded and cut at Ocean Way in Hollywood and The Hook in North Hollywood from 1995 to 1996. The album was produced by David Bottrill. ",
                CategoryId = 2,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Aenima.jpg/220px-Aenima.jpg",
                InStock = true,
                IsAlbumOfTheWeek = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Aenima.jpg/220px-Aenima.jpg"
            });

            modelBuilder.Entity<Album>().HasData(new Album
            {
                AlbumId = 4,
                Name = "Lateralus",
                Price = 15.95M,
                ShortDescription = "Tool - Lateralus",
                LongDescription = "Lateralus (/ˌlætəˈræləs/) is the third studio album by American rock band Tool. It was released on May 15, 2001 through Volcano Entertainment. The album was recorded at Cello Studios in Hollywood and The Hook, Big Empty Space, and The Lodge, in North Hollywood, between October 2000 and January 2001. David Bottrill, who had produced the band's two previous releases Ænima and Salival, produced the album along with the band.",
                CategoryId = 1,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/63/Tool_-_Lateralus.jpg/220px-Tool_-_Lateralus.jpg",
                InStock = true,
                IsAlbumOfTheWeek = true,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/63/Tool_-_Lateralus.jpg/220px-Tool_-_Lateralus.jpg"
            });

            modelBuilder.Entity<Album>().HasData(new Album
            {
                AlbumId = 5,
                Name = "10.000 Days",
                Price = 13.95M,
                ShortDescription = "Tool - 10.000 Days",
                LongDescription = "10,000 Days is the fourth studio album by American rock band Tool. The album was released by Tool Dissectional and Volcano Entertainment on April 28, 2006 in parts of Europe, April 29, 2006 in Australia, May 1, 2006 in the United Kingdom, and on May 2, 2006 in North America. Recording took place at O'Henry Sound Studios in Burbank, California, The Loft, and Grandmaster Studios (both in Hollywood, California). It marked the first time since recording 1993's Undertow that the band had worked at Grandmaster and without producer David Bottrill. It was mixed at Bay 7 in North Hollywood, California and mastered at Gateway Mastering Studios in Portland, Maine.",
                CategoryId = 3,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f8/10000Days.jpg/220px-10000Days.jpg",
                InStock = true,
                IsAlbumOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://upload.wikimedia.org/wikipedia/en/thumb/f/f8/10000Days.jpg/220px-10000Days.jpg"
            });

            modelBuilder.Entity<Album>().HasData(new Album
            {
                AlbumId = 6,
                Name = "Fear Inoculum",
                Price = 17.95M,
                ShortDescription = "Tool - Fear Inoculum",
                LongDescription = "Fear Inoculum is the fifth studio album by American rock band Tool. It was released on August 30, 2019, through Tool Dissectional, Volcano Entertainment, and RCA Records. It is the band's first album in 13 years, due to creative, personal, and legal issues band members encountered since the release of 10,000 Days. The album was released to critical acclaim, with reviewers generally agreeing that the band had successfully refined their established sound. The album topped the US Billboard 200 albums chart, their third album in a row to do so, selling over 270,000 album-equivalent units. The album topped five other national album charts in its opening week as well",
                CategoryId = 3,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d6/Tool_-_Fear_Inoculum.png/220px-Tool_-_Fear_Inoculum.png",
                InStock = true,
                IsAlbumOfTheWeek = true,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d6/Tool_-_Fear_Inoculum.png/220px-Tool_-_Fear_Inoculum.png"
            });
        }
    }
}
