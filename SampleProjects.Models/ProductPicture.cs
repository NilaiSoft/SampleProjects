using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models
{
    [Table(name: "Product_Picture_Mapping")]
    public class ProductPicture : BaseEntity
    {
        /// <summary>
        /// product id for mapping to picture
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// pictureid for mapping to prroduct
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// products
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        /// <summary>
        /// pictures
        /// </summary>
        [ForeignKey(nameof(PictureId))]
        public Picture Picture { get; set; }
    }
}
