﻿using System;
using VouViajar.Modulos.Eventos.Domain.Enums;

namespace VouViajar.Modulos.Eventos.Domain.Entities.Aggregates
{
    public class Evento
    {
        public Evento()
        {

        }
        public Evento(int agenciaID, string nome, string resumo, DateTime dataInicio, DateTime dataFim, int totalVagas, decimal valorVaga, string nomeArquivo, string arquivo, DateTime cadastradoEm, int origemID, int destinoID, int situacaoID, int tipoID)
        {
            Nome = nome;
            Resumo = resumo;
            DataInicio = dataInicio;
            DataFim = dataFim;
            TotalVagas = totalVagas;
            ValorVaga = valorVaga;
            NomeArquivo = nomeArquivo;
            Arquivo = arquivo;
            CadastradoEm = DateTime.Now;
            OrigemID = origemID;
            DestinoID = destinoID;
            SituacaoID = EnumSituacaoEvento.CADASTRADO.GetHashCode();
            TipoID = tipoID;
        }

        public int EventoID { get; set; }
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
        public virtual Localidade Origem { get; set; }
        public int DestinoID { get; set; }
        public virtual Localidade Destino { get; set; }
        public int SituacaoID { get; set; }
        public virtual Situacao Situacao { get; set; }
        public int TipoID { get; set; }
        public virtual Tipo Tipo { get; set; }

    }
}
