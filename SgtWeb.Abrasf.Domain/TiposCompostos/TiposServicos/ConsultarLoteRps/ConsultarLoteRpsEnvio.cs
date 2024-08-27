using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarLoteRps
{
    [XmlRoot(elementName: "ConsultarLoteRpsEnvio")]
    public class ConsultarLoteRpsEnvio
    {
        public tcIdentificacaoPrestador Prestador { get; set; }
        public string Protocolo { get; set; }  

    }
}
