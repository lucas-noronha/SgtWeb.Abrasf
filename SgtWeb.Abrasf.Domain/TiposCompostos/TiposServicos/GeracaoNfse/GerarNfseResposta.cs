using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse
{
    [XmlRoot(ElementName = "GerarNfseResposta")]
    public class GerarNfseResposta
    {
        [XmlElement(ElementName = "ListaNfse")]
        public ListaNfse ListaNfse { get; set; }
        [XmlElement(ElementName = "ListaMensagemRetorno")]
        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }
    }
}
