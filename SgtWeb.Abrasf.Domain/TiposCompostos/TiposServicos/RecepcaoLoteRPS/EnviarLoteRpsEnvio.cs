using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.RecepcaoLoteRPS
{
    [XmlRoot(ElementName = "EnviarLoteRpsEnvio")]
    public class EnviarLoteRpsEnvio
    {
        public tcLoteRps LoteRps { get; set; }
        public string Signature { get; set; }
    }
}
