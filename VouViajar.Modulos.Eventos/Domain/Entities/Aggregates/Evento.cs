using System;

namespace VouViajar.Modulos.Eventos.Domain.Entities.Aggregates
{
    public class Evento
    {

        public int EventoID {get; set;}
        public int AgenciaID { get; set; }
        public string Nome { get; set; }
        public string Resumo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int TotalVagas { get; set; }
        public decimal ValorVaga { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public DateTime CadastradoEm { get; set; }
        public int OrigemID { get; set; }
        public virtual Localidade OrigemNavegation { get; set; }
        public int DestinoID { get; set; }
        public virtual Localidade DestinoNavegation { get; set; }
        public int SituacaoID { get; set; }
        public virtual Situacao SituacaoNavegatioin { get; set; }
        public int TipoID { get; set; }
        public virtual Tipo TipoNavegation { get; set; }

    }
}
