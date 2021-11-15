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

        public DetalheEvento IdDetalheEvento { get; set; }

        public SituacaoEvento Situacao { get; set; }

        public TipoEvento Tipo { get; set; }

    }
}
