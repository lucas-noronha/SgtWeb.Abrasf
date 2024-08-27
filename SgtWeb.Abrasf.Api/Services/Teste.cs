using System.ServiceModel;
using System.ServiceModel.Channels;

[MessageContract(IsWrapped = false)]
public class GerarNfseEnvioRequest
{
    [MessageBodyMember(Name = "GerarNfseEnvio", Namespace = "http://tempuri.org/")]
    public string Data { get; set; }
}
