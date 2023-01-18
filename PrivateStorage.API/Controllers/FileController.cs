using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PrivateStorage.Core.Services;

namespace PrivateStorage.API.Controllers
{
    [ApiController]
    [Route("/api/file")]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFileAsync(IFormFileCollection files)
        {
            return Ok(files);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFileAsync()
        {
            return Ok(true);
        }
    }
}
