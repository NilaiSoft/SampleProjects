using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models
{
    public class Category : BaseEntity
    {
        /// <summary>
        /// Name category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descriptions
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Picture for category
        /// </summary>
        [ForeignKey(nameof(PictureId))]
        public Picture Picture { get; set; }

        /// <summary>
        /// pictureId
        /// </summary>
        public int PictureId { get; set; }
    }
}
