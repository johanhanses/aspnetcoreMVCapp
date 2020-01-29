using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shoppen.Models;
using Shoppen.ViewModels;

namespace Shoppen.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly ICategoryRepository _categoryRepository;

        public AlbumController(IAlbumRepository albumRepository, ICategoryRepository categoryRepository)
        {
            this._albumRepository = albumRepository;
            this._categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    AlbumsListViewModel albumsListViewModel = new AlbumsListViewModel();
        //    albumsListViewModel.Albums = this._albumRepository.AllAlbums;

        //    albumsListViewModel.CurrentCategory = "Tool album store";
        //    return View(albumsListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Album> albums;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                albums = _albumRepository.AllAlbums.OrderBy(a => a.AlbumId);
                currentCategory = "All albums";
            }
            else
            {
                albums = _albumRepository.AllAlbums.Where(a => a.Category.CategoryName == category)
                    .OrderBy(a => a.AlbumId);
                currentCategory = _categoryRepository
                    .AllCategories
                    .FirstOrDefault(c => c.CategoryName == category)?
                    .CategoryName;
            }

            return View(new AlbumsListViewModel
            {
                Albums = albums,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var album = this._albumRepository.GetAlbumById(id);
            if (album == null)
                return NotFound();

            return View(album);
        }
    }
}
