using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHealth.Model;
using MyHealth.BL.Interface;
using MyHealth.DomainModel;
using LoggerService;
using MyHealthLoggerInterface;

namespace MyHealth.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IBLImage blImage;

        public ImageController(IBLImage image, ILoggerManager logger)
        {
            this.blImage = image;
            _logger = logger;
        }

        // GET: api/Image
        [HttpGet]
        public IEnumerable<Image> GetAll()
        {
            var images = blImage.GetAllImages();
            _logger.LogInfo($"Returning  images.");
             
            return images.ToList();
        }

        // GET: api/Image/5
        [HttpGet("{imageId}", Name = "GetImage")]
        public Image GetById(int imageId)
        {
            var image = blImage.GetImage(imageId);

            if (image == null)
            {
                throw new Exception("Exception while fetching image from the storage.");
            }

            _logger.LogInfo($"Returning  image.");
            return image;
        }

        // POST: api/Image
        [HttpPost]
        public Image Create([FromBody] Image image)
        {
            var _image = blImage.AddImage(image);
            _logger.LogInfo($"Returning created image.");
            return _image;
        }
    }
}