using Microsoft.AspNetCore.Mvc;
using PieShop.Models;

namespace PieShop.Controllers;

public class PieController : Controller
{
    private readonly IPieRepository pieRepository;
    private readonly ICategoryRepository categoryRepository;

    public PieController(IPieRepository _pieRepository, ICategoryRepository _categoryRepository)
    {
        pieRepository = _pieRepository;
        categoryRepository = _categoryRepository;
    }

    public IActionResult List()
    {
        ViewBag.CurrentCategory = "Cheese cakes";
        return View(pieRepository.AllPies);
    }
}