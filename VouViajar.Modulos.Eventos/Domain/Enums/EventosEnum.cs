using System.ComponentModel;

namespace VouViajar.Modulos.Eventos.Domain.Enums
{
    public enum EnumSituacaoEvento
    {
        [Description("Cadastrado")]
        CADASTRADO = 0,
        [Description("Andamento")]
        ANDAMENTO = 1,
        [Description("Finalizado")]
        FINALIZADO = 2,
        [Description("Cancelamento")]
        CANCELAMENTO = 3,
        [Description("Excluido")]
        EXCLUIDO = 4
    }

    public enum EnumTipoEvento
    {
        [Description("Bate e Volta")]
        BATE_VOLTA = 0,
        [Description("Excursão")]
        EXCURSAO = 1
    }
}
