using MyHealth.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHealth.DAL.Interface
{
    public interface IImageRepository
    {
        /// <summary>
        /// Return List of All Images Details
        /// </summary>
        /// <returns></returns>
        IEnumerable<Image> GetAllImages();

        /// <summary>
        /// Return Image Details by ImageID
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        Image GetImage(int imageId);

        /// <summary>
        /// Add Image Details
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        Image AddImage(Image image);
    }
}
