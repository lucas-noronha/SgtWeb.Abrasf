using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfsePorRps
{
    [XmlRoot(elementName: "ConsultarNfseRpsEnvio")]
    public class ConsultarNfseRpsEnvio
    {
        public tcIdentificacaoRps IdentificacaoRps{ get; set; }
        public tcIdentificacaoPrestador Prestador { get; set; }
    }
}
