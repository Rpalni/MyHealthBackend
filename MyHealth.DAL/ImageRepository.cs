using MyHealth.DomainModel;
using MyHealth.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyHealth.DAL
{
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationContext _context;

        public ImageRepository(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Return List of All Images Details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Image> GetAllImages()
        {
            return _context.Images;
        }

        /// <summary>
        /// Return Image Details by ImageID
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        public Image GetImage(int imageId)
        {
            var image = _context.Images.Find(imageId);
            return image;
        }

        /// <summary>
        /// Add Image Details
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public Image AddImage(Image image)
        {
            _context.Images.Add(image);
            _context.SaveChanges();
            return image;
        }
    }
}

