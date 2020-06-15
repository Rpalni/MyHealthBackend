using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyHealth.DomainModel
{
    public class Image
    {
        public int ImageId { get; set; }

        public string Title { get; set; }

        public string ImageName { get; set; }

        public string Description { get; set; }
    }
}
