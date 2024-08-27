using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfsePorRps
{
    [XmlRoot(elementName: "ConsultarNfseRpsResposta")]
    public class ConsultarNfseRpsResposta
    {
        public tcCompNfse CompNfse { get; set; }
        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }
    }


}
