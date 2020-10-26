using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebPortfolio.ViewModels;

namespace WebPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PorfolioItem> _porfolioItem;
        public HomeController(IUnitOfWork<Owner> owner, IUnitOfWork<PorfolioItem> porfolioItem)
        {
            _owner = owner;
            _porfolioItem = porfolioItem;

        }


        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _porfolioItem.Entity.GetAll().ToList()

        };
           
            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
