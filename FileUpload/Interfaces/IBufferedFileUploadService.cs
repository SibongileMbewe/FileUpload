using Microsoft.AspNetCore.WebUtilities;
using System.Threading.Tasks;

namespace FileUpload.Interfaces
{
    public interface IBufferedFileUploadService
    {
        Task<bool> UploadFile(IFormFile file);
    }
}
