using Shoppen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppen.ViewModels
{
    public class AlbumsListViewModel
    {
        public IEnumerable<Album> Albums { get; set; }
        public string CurrentCategory { get; set; }
    }
}
