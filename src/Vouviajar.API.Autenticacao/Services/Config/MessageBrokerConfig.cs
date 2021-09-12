namespace Vouviajar.API.Autenticacao.Services.Config
{
    public class MessageBrokerConfig
    {
        public string Name { get; set; }
        public string ServiceBus { get; set; }
        public string ConnectionString { get; set; }
        public Endpoints Endpoints { get; set; }
    }

    public class Endpoints
    {
        public string PrefixQueue { get; set; }
        public string AnaliseCredito { get; set; }
        public string ContratacaoProduto { get; set; }
        public string ReceberDadosOnboarding { get; set; }
    }
}
