using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_course_web.Service.Interfaces
{
    public interface ICloudinaryService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file, string publicAddress , string fileName = "");
        Task<DeletionResult> RemoveAsync(string publicId);
        Task<VideoUploadResult> AddVideoAsync(IFormFile file, string publicAddress, string fileName = "");
    }
}
