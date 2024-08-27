using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono
{
    [XmlRoot(ElementName = "EnviarLoteRpsSincronoEnvio")]
    public class EnviarLoteRpsSincronoEnvio
    {
        public tcLoteRps LoteRps { get; set; }
        public string Signature { get; set; }  
    }
}
