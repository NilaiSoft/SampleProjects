using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models
{
    [Table(name: "Product_Category_Mapping")]
    public class ProductCategory : BaseEntity
    {
        /// <summary>
        /// product id for mapping
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// category id for mapping
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// category key
        /// </summary>
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        /// <summary>
        /// product key
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
