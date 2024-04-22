using PieShop.Models;

namespace PieShop.ViewModels;

public class PieListViewModel
{
    public IEnumerable<Pie> Pies { get; }
    public string? CurrentCategory { get; }

    public PieListViewModel(IEnumerable<Pie> _pies, string? _currentCategory)
    {
        Pies = _pies;
        CurrentCategory = _currentCategory;
    }
}