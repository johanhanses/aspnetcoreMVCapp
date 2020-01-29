using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppen.Models
{
    public class AlbumRepository: IAlbumRepository
    {
        private readonly AppDbContext _appDbContext;

        public AlbumRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Album> AllAlbums
        { 
            get
            {
                return _appDbContext.Albums.Include(c => c.Category);
            }
        }

        public IEnumerable<Album> AlbumsOfTheWeek
        {
            get
            {
                return _appDbContext.Albums
                    .Include(c => c.Category)
                    .Where(a => a.IsAlbumOfTheWeek);
            }
        }

        public Album GetAlbumById(int albumId)
        {
            return _appDbContext.Albums.FirstOrDefault(a => a.AlbumId == albumId);
        }
    }
}
