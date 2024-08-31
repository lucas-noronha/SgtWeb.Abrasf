using Microsoft.AspNetCore.Server.HttpSys;
using SgtWeb.Abrasf.Domain.TiposCompostos;
using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono;
using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Api.Services
{
    public class SoapService : IMySoapService
    {

        private string RemoverTagXml(string xml)
        {
            int inicioTagXml = xml.IndexOf("<?xml", StringComparison.InvariantCultureIgnoreCase);

            if (inicioTagXml == -1)
                return xml;

            int fimTagXml = xml.IndexOf("?>");
            string valorTag = xml.Substring(inicioTagXml, fimTagXml - inicioTagXml + 2);
            return xml.Replace(valorTag, string.Empty);
        }


        public string GerarNfseEnvio(string user_header, string user_data)
        {
            var cleanedUserData = RemoverTagXml(user_data);

            using var stringReader = new StringReader(cleanedUserData);

            var deserializer = new XmlSerializer(typeof(GerarNfseEnvio));

            if (deserializer.Deserialize(stringReader) is not GerarNfseEnvio request)
                return string.Empty;

            var obj = new GerarNfseResposta()
            {
                ListaNfse = new ListaNfse()
                {
                    CompNfse =
                    [
                        new()
                        {
                            Nfse = new tcNfse()
                            {
                                InfNfse = new tcInfNfse(),
                            },
                        },
                    ],
                    ListaMensagemAlertaRetorno = new ListaMensagemAlertaRetorno()
                    {
                        MensagemRetorno =
                        [
                            new()
                            {
                                Codigo = "1",
                                Mensagem = request.Rps.InfDeclaracaoPrestacaoServico.Rps.IdentificacaoRps.Numero,
                                Correcao = "Correção de teste",
                            },
                        ]
                    }
                },
                ListaMensagemRetorno = new ListaMensagemRetorno()
                {
                    MensagemRetorno =
                    [
                        new tcMensagemRetorno()
                        {
                            Codigo = "1",
                            Mensagem = "Mensagem de teste",
                            Correcao = "Correção de teste",
                        },
                    ]
                }
            };

            using var stringwriter = new StringWriter();

            var serializer = new XmlSerializer(typeof(GerarNfseResposta));
            serializer.Serialize(stringwriter, obj);
            return stringwriter.ToString();
        }

        public string SayHello(string name)
        {
            return $"Hello, {name}";
        }


    }
}
