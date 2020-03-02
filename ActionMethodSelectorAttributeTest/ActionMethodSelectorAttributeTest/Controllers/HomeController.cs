using Microsoft.AspNetCore.Mvc;

namespace ActionMethodSelectorAttributeTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName(nameof(Index)), FormConstraint("button", null)]
        public IActionResult DefaultClick(object inputModel)
        {
            return Ok(nameof(DefaultClick));
        }

        [HttpPost, ActionName(nameof(Index)), FormConstraint("button", "1")]
        public IActionResult ButtonClick1(object inputModel)
        {
            return Ok(nameof(ButtonClick1));
        }

        [HttpPost, ActionName(nameof(Index)), FormConstraint("button", "2")]
        public IActionResult ButtonClick2(object inputModel)
        {
            return Ok(nameof(ButtonClick2));
        }
    }
}