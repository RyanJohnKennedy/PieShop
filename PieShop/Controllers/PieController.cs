using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

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
        PieListViewModel piesListViewModel = new PieListViewModel(pieRepository.AllPies, "Cheese cakes");
        return View(piesListViewModel);
    }
}