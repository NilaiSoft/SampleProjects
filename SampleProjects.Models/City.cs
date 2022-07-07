using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleProjects.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int StateProvinceId { get; set; }

        [ForeignKey(nameof(StateProvinceId))]
        public StateProvince StateProvince { get; set; }
    }
}
