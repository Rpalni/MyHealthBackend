using MyHealth.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealth.BL.Interface
{
    public interface IBLImage
    {
        IEnumerable<Image> GetAllImages();
        Image GetImage(int imageId);

        Image AddImage(Image image);
    }

}
