using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PrivateStorage.Core.Services;
using PrivateStorage.DataAccess;
using System.Net.Http.Headers;

namespace PrivateStorage.API.Controllers
{
    [ApiController]
    [Route("/api/file")]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;
        private readonly PrivateCloudContext _context;
        public FileController(IFileService fileService, PrivateCloudContext context)
        {
            _fileService = fileService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFileAsync(IFormFileCollection files)
        {
            try
            {
                //var files = Request.Form.Files;
                var folderName = Path.Combine("StaticFiles", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (files.Any(f => f.Length == 0))
                {
                    return BadRequest();
                }
                foreach (var file in files)
                {
                    var fileName = "filenmae";
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
                return Ok("All the files are successfully uploaded.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFileAsync()
        {
            return Ok(true);
        }
    }
}
