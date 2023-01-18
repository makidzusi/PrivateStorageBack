using PrivateStorage.Core.DTO;
using PrivateStorage.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class FileService : IFileService
    {
        public async Task<CreateFileResponse> CreateFileAsync(int num)
        {
            return new CreateFileResponse();
        }
        public async Task<DeleteFileResponse> DeleteFileAsync(int num)
        {
            return new DeleteFileResponse();
        }
    }
}
