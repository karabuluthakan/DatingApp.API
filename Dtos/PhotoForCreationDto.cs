using System;
using Microsoft.AspNetCore.Http;
namespace DatingApp.API.Dtos
{
    public class PhotoForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
    }
}