using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Models.ViewModels
{
    public class PictureBinaryModel: BaseViewModel
    {
        public byte[] BinaryData { get; set; }
        public int PictureId { get; set; }
    }
}
