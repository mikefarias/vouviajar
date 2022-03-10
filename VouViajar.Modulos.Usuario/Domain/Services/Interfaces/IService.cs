﻿using System.Net;
using System.Threading.Tasks;

namespace VouViajar.Modulos.Usuarios.Domain.Services.Interfaces
{
    public interface IService
    {
        public Task<ResponseService<T>> GenerateErroServiceResponse<T>(string msg, HttpStatusCode status = HttpStatusCode.BadRequest);
        Task<ResponseService> GenerateErroServiceResponse(string msg, HttpStatusCode status = HttpStatusCode.BadRequest);
        Task<ResponseService<T>> GenerateSuccessServiceResponse<T>(T value, HttpStatusCode status = HttpStatusCode.OK);
        Task<ResponseService> GenerateSuccessServiceResponse(HttpStatusCode status = HttpStatusCode.OK);
    }
}
