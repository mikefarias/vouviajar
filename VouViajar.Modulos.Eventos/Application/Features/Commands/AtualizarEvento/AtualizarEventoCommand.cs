using MediatR;
using System;
using VouViajar.Modulos.Eventos.Domain.Enums;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.AtualizarEvento
{
    public class AtualizarEventoCommand : IRequest
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Resumo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int Origem { get; set; }

        public int Destino { get; set; }

        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public int TotalVagas { get; set; }

        public decimal ValorVaga { get; set; }

        public EnumTipoEvento Tipo { get; set; }

        public EnumSituacaoEvento Situacao { get; set; }
    }
}
