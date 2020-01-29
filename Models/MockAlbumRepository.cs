using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppen.Models
{
    public class MockAlbumRepository : IAlbumRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Album> AllAlbums =>
            new List<Album>
            {
                new Album
                {
                    AlbumId = 1,
                    Name="Fear Inoculum",
                    Price=15.95M,
                    ShortDescription="Fear Inoculum",
                    LongDescription="Fear Inoculum 2019",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    InStock=true,
                    IsAlbumOfTheWeek=false,
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"
                },
                new Album
                {
                    AlbumId = 2,
                    Name="10.000 Days",
                    Price=15.95M,
                    ShortDescription="10.000 Days",
                    LongDescription="10.000 Days - 2006",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    InStock=true,
                    IsAlbumOfTheWeek=false,
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"
                },
                new Album
                {
                    AlbumId = 3,
                    Name="Lateralus",
                    Price=15.95M,
                    ShortDescription="Lateralus",
                    LongDescription="Lateralus - 2001",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    InStock=true,
                    IsAlbumOfTheWeek=true,
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"
                },
                new Album
                {
                    AlbumId = 3,
                    Name="Aneima",
                    Price=15.95M,
                    ShortDescription="Aneima",
                    LongDescription="Aneima - 1996",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    InStock=true,
                    IsAlbumOfTheWeek=true,
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"
                }
            };

        public IEnumerable<Album> AlbumsOfTheWeek { get; }

        public Album GetAlbumById(int albumId)
        {
            return AllAlbums.FirstOrDefault(p => p.AlbumId == albumId);
        }
    }
}
