using ASPControls.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace ASPControls.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // load dropdown using enum
            var categories = Enum.GetValues(typeof(Category))
                .Cast<Category>()
                .Select(c => new SelectListItem
                {
                    Value = ((int)c).ToString(),
                    Text = c.ToString()
                }).ToList();

            // load dropdown using list object
            var languages = new List<Language> {
                new Language { Name= "French", code="fren"},
                new Language { Name= "Spain", code="spain"},
                new Language { Name= "Tamil", code="tam"},
                new Language { Name= "German", code="germ"},
                new Language { Name= "Telugu", code="tel"},
            };


            var studentNames = new List<string> { "Raja", "Vijay", "Parvati", "Viji" };


            var model = new ProductViewModel { Categories = categories, CategoryId = 1, Languages = languages, SelectedLanguageCode = "germ", Category = Category.Electronics, Students = studentNames, selectedStudent="Parvati" };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}