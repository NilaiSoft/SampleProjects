using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models.ViewModels
{
    public class ProductCategoryModel: BaseViewModel
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
