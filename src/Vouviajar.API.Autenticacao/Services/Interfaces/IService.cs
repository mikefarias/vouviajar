using System.Net;
using System.Threading.Tasks;

namespace Vouviajar.API.Autenticacao.Services.Interfaces
{
    public interface IService
    {
        Task<ResponseService<T>> GenerateErroServiceResponse<T>(string msg, HttpStatusCode status = HttpStatusCode.BadRequest);
        Task<ResponseService> GenerateErroServiceResponse(string msg, HttpStatusCode status = HttpStatusCode.BadRequest);
        Task<ResponseService<T>> GenerateSuccessServiceResponse<T>(T value, HttpStatusCode status = HttpStatusCode.OK);
        Task<ResponseService> GenerateSuccessServiceResponse(HttpStatusCode status = HttpStatusCode.OK);
    }
}
