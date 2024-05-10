using CloudinaryDotNet;
using Microsoft.Extensions.Options;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using e_course_web.Service.Interfaces;
using e_course_web.Service.Helpers;
using e_course_web.Models;

namespace e_course_web.Service.Services
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(IOptions<CloudinarySettings> config)
        {
            var acc = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
            );

            _cloudinary = new Cloudinary(acc);
        }
        // Upload image to clould
        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file, string publicAddress, string fileName = "")
        {
            var uploadResult = new ImageUploadResult();
            if (file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    PublicId = publicAddress + fileName != null ? fileName : file.FileName ,
                    File = new FileDescription(file.FileName, stream),
                };
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }

            return uploadResult;
        }

        // Upload mp4 to cloud
        public async Task<VideoUploadResult> AddVideoAsync(IFormFile file, string publicAddress, string fileName = "")
        {
            using var stream = file.OpenReadStream();
            var uploadResult = new VideoUploadResult();
            if (file.Length > 0)
            {
                var uploadParams = new VideoUploadParams()
                {
                    EagerAsync = true,
                    File = new FileDescription(file.Name, stream),
                    PublicId = publicAddress + fileName != null ? fileName : file.FileName,
                };
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }
            return uploadResult;
        }

        // Remove image in cloud
        public async Task<DeletionResult> RemoveAsync(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);
            var result = await _cloudinary.DestroyAsync(deleteParams);

            return result;
        }
    }
}
