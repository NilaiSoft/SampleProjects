using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models.ViewModels
{
    public class ProductModel : BaseViewModel
    {
        public string Name { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        [Required(ErrorMessage = "{0} FildIs Required")]
        [Display(Name = "Unit")]
        public int UnitId { get; set; }
        public PictureModel PictureModel { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
