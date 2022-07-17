using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models.ViewModels
{
    public class CategoryMoedl : BaseEntity
    {
        public string Name { get; set; }
        public Picture Picture { get; set; }
        public int PictureId { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
