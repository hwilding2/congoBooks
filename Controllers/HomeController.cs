using Congo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Congo.Models.ViewModels;

namespace Congo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICongoRepository _repository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, ICongoRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, int page = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                //Gets appropriate data: filtered by category and page
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(b => b.BookID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    //Fixes page numbering to be accurate based on category selected
                    TotalNumItems = category == null ? _repository.Books.Count() :
                    _repository.Books.Where(x => x.Category == category).Count()
                },
                Category = category
            }) ;
        }
        //Don't currently need a Privacy page but it may be useful in further assignments.
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
