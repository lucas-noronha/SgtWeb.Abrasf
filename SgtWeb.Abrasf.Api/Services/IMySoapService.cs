using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse;
using System.ServiceModel;

namespace SgtWeb.Abrasf.Api.Services;


[ServiceContract]
public interface IMySoapService
{
    [OperationContract]
    string SayHello(string name);

    [OperationContract]
    GerarNfseResposta GerarNfseEnvio(string Rps);
}
