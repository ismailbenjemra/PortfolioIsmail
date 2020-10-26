using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortfolio.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<PorfolioItem> PortfolioItems { get; set; }
    }
}
