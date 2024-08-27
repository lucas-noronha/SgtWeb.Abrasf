using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.CancelarNfse
{
    [XmlRoot(ElementName = "CancelarNfseEnvio")]
    public class CancelarNfseEnvio
    {
        public tcPedidoCancelamento Pedido { get; set; }
    }
}
