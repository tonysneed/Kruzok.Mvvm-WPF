using SimpleMvvmToolkit;

namespace HelloMvvmWpf.Models
{
    public class Category : ModelBase<Category>
    {
        private int _categoryId;

        public int CategoryId
        {
            get { return _categoryId; }
            set {
                _categoryId = value;
                NotifyPropertyChanged(e => e.CategoryId);
            }
        }

        private string _categoryName;

        public string CategoryName
        {
            get { return _categoryName; }
            set {
                _categoryName = value;
                NotifyPropertyChanged(e => e.CategoryName);
            }
        }

    }
}