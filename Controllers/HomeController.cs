using Microsoft.AspNetCore.Mvc;
using CorpDataBank.Models;
using System.Linq;

namespace CorpDataBank.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult KaishaForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult KaishaForm(AdminResponse adminResponse)
        {
            // TODO: store response from guest
            if (ModelState.IsValid) {
                Repository.AddResponse(adminResponse);
                return View("Arigato", adminResponse);
            } else
            {
                return View();
            }
            
        }
        public ViewResult ListCompanies()
        {
            return View(Repository.Responses.Where(r => r.Agree == true));
        }
    }
}