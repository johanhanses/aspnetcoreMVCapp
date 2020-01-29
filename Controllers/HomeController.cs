using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shoppen.Models;
using Shoppen.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shoppen.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumRepository _albumRepository;

        public HomeController(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AlbumsOfTheWeek = _albumRepository.AlbumsOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
