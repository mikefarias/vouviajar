namespace VouViajar.Modulos.Evento.Domain.Entities.Aggregates
{
    public class DetalheEvento
    {
        public int IdDetalheEvento { get; set; }

        // propridade para receber imag(em(ens)) do evento
        public int TotalVagas { get; set; }

        public decimal ValorVaga { get; set; }
    }
}
