using Microsoft.AspNetCore.Mvc;
using BethanyPieShopMVC.Models;


namespace BethanyPieShopMVC.Controllers
{
    public class PieController: Controller
    {
        private readonly IPieRepository pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public ViewResult List()
        {
            var pies = pieRepository.AllPies;
            return View(pies);
        }

    }
}
