using Client.Models;
using Client.Models.Request;
using Client.Models.Response;
using File = Client.Models.File;
using Models_File = Client.Models.File;

namespace Client.Interfaces
{
    public interface IPrintfulFileLibraryClient
    {
        Task<PrintfulResponse<Models_File>> AddNewFile(NewFileRequest requestModel);
        Task<PrintfulResponse<Models_File>> GetFile(int fileId);
        Task<PrintfulResponse<ThreadColorResponse>> AvailableThreadColors(AvailableThreadColorsRequest requestModel);
    }
}