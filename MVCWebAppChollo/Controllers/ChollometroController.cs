using Microsoft.AspNetCore.Mvc;
using MVCWebAppChollo.Models;
using MVCWebAppChollo.Repositories;

namespace MVCWebAppChollo.Controllers
{
    public class ChollometroController : Controller
    {
        private RepositoryChollos repo;

        public ChollometroController(RepositoryChollos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Chollo> chollos = await this.repo.GetChollosAsync();
            return View(chollos);
        }
    }
}
