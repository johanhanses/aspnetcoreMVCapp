using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppen.Models
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> AllAlbums { get; }
        IEnumerable<Album> AlbumsOfTheWeek { get; }
        Album GetAlbumById(int albumId);
    }
}
