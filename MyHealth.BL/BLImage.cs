using MyHealth.BL.Interface;
using MyHealth.DomainModel;
using MyHealth.DAL.Interface.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealth.BL
{
    public class BLImage : IBLImage
    {
        private readonly IUnitOfWork uow;
        public BLImage(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<Image> GetAllImages()
        {
            return uow.ImageRepo.GetAllImages();
        }
        public Image GetImage(int imageId)
        {
            if (imageId <= default(int))
                    throw new ArgumentException("Invalid image Id");

            return uow.ImageRepo.GetImage(imageId);
        }

        public Image AddImage(Image image)
        {
            if (image == null)
                throw new NullReferenceException("Image provided is a null value");
            var _image = uow.ImageRepo.AddImage(image);
            
            uow.Complete();
           
            return _image;
        }
    }
}
