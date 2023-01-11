using Microsoft.AspNetCore.WebUtilities;
using System.Threading.Tasks;

namespace FileUpload.Interfaces
{
    public interface IStreamFileUploadService
    {
        Task<bool> UploadFile(MultipartReader reader, MultipartSection section);
    }
}
