using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Policy = "AdminPolicy")]
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ManageUsers()
    {
        return View();
    }

    public IActionResult ManageProducts()
    {
        return View();
    }
}
