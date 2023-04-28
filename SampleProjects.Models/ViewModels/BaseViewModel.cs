using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models.ViewModels
{
    public class BaseViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
    }
}
