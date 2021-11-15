using System;

namespace VouViajar.Modulos.Eventos.Domain.Entities.Aggregates
{
    public class Evento
    {

        public int IdEvento {get; set;}

        public string Nome { get; set; }

        public string Resumo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public Localidade Origem { get; set; }

        public Localidade Destino { get; set; }

        public int TotalVagas { get; set; }

        public decimal ValorVaga { get; set; }

        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public SituacaoEvento Situacao { get; set; }

        public TipoEvento Tipo { get; set; }

        public DateTime CadastradoEm { get; set; }

    }
}
