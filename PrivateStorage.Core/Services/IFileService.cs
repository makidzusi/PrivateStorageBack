using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateStorage.Core.DTO;

namespace PrivateStorage.Core.Services
{
    public interface IFileService
    {
        Task<DeleteFileResponse> DeleteFileAsync (int id);
        Task<CreateFileResponse> CreateFileAsync(int id);
    }
}
