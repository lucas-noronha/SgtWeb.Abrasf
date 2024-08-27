using SgtWeb.Abrasf.Domain.TiposCompostos;
using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono;
using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse;

namespace SgtWeb.Abrasf.Api.Services
{
    public class SoapService : IMySoapService
    {
        public GerarNfseResposta GerarNfseEnvio(string Rps)
        {

            return new GerarNfseResposta()
            {
                ListaNfse = new ListaNfse()
                {
                    CompNfse = new List<Domain.TiposCompostos.tcCompNfse>()
                    {
                        new Domain.TiposCompostos.tcCompNfse()
                        {
                            Nfse = new Domain.TiposCompostos.tcNfse()
                            {
                                InfNfse = new Domain.TiposCompostos.tcInfNfse(),
                            },
                        },
                    },
                    ListaMensagemAlertaRetorno = new ListaMensagemAlertaRetorno()
                    {
                        MensagemRetorno = new List<tcMensagemRetorno>()
                        {
                            new tcMensagemRetorno()
                            {
                                Codigo = "1",
                                Mensagem = "Mensagem de teste",
                                Correcao = "Correção de teste",
                            },
                        }
                    }
                },
                ListaMensagemRetorno = new ListaMensagemRetorno()
                {
                    MensagemRetorno = new List<tcMensagemRetorno>()
                    {
                        new tcMensagemRetorno()
                        {
                            Codigo = "1",
                            Mensagem = "Mensagem de teste",
                            Correcao = "Correção de teste",
                        },
                    }
                }
            };
        }

        public string SayHello(string name)
        {
            return $"Hello, {name}";
        }


    }
}
