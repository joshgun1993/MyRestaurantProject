using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ByJoshgunFinalRestaurantProject.Helpers
{
    public static class Extensions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool IsMoreThan400kb(this IFormFile file)
        {
            return file.Length / 1024 > 400;
        }

        public static async Task<string> SaveFileAsync(this IFormFile file, string folder)
        {
            string filename = Guid.NewGuid().ToString() + file.Name;
            string path = Path.Combine(folder, filename);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return filename;
        }
    }
}
