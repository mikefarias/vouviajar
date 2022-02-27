using System;

namespace VouViajar.Modulos.Eventos.Application.Features.Queries.RecuperarEvento
{
    public class RecuperarEventoResult
    {
        public string Nome { get; set; }
        public string Resumo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int TotalVagas { get; set; }
        public decimal ValorVaga { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public DateTime CadastradoEm { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Situacao { get; set; }
        public string Tipo { get; set; }
    }
}
