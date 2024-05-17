using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Policy = "CollaboratorPolicy")]
public class CollaboratorController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ViewProducts()
    {
        return View();
    }
}
