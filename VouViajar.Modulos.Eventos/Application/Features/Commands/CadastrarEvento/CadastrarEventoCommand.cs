using System;
using VouViajar.Modulos.Eventos.Domain.Enums;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.CadastrarEvento
{
    public class CadastrarEventoCommand
    {
        public string Nome { get; set; }

        public string Resumo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public string Origem { get; set; }

        public string Destino { get; set; }

        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public int TotalVagas { get; set; }

        public decimal ValorVaga { get; set; }

        public EnumTipoEvento Tipo { get; set; }

        public EnumSituacaoEvento Situacao { get; set; }
    }
}
