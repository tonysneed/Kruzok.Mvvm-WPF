using HelloMvvmWpf.Models;
using SimpleMvvmToolkit;
using System.Collections.Generic;

public class CategoryViewModel: ViewModelBase<CategoryViewModel>
{
    private List<Category> _categories;

    public CategoryViewModel()
    {
        _categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Beverages"},
            new Category { CategoryId = 2, CategoryName = "Desserts"},
        };
    }

    public List<Category> Categories
    {
        get { return _categories; }
        set {
            _categories = value;
            NotifyPropertyChanged(e => e.Categories);
        }
    }
}