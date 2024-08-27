using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.CancelarNfse
{
    [XmlRoot(ElementName = "CancelarNfseResposta")]
    public class CancelarNfseResposta
    {
        public tcRetCancelamento RetCancelamento { get; set; }
        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }
    }
}
