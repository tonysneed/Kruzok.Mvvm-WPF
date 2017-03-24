using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMvvmWpf
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            CategoryViewModel = new CategoryViewModel();
        }

        public CategoryViewModel CategoryViewModel { get; private set; }
    }
}
