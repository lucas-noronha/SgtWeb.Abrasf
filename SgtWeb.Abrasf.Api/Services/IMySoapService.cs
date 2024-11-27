using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse;
using SoapCore.Extensibility;
using System.ServiceModel;

namespace SgtWeb.Abrasf.Api.Services;

[ServiceContract]
public interface IMySoapService
{
    [OperationContract]
    string SayHello(string name);

    [OperationContract]
    Task<string> GerarNfseEnvio(string user_header, string user_data);
}

