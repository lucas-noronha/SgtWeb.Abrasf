using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.SubstituicaoNfse
{
    [XmlRoot(ElementName = "SubstituirNfseEnvio")]
    public class SubstituirNfseEnvio
    {
        SubstituicaoNfse SubstituicaoNfse { get; set; }
        [MaxLength(255)]
        public string Signature { get; set; }
    }

    public class SubstituicaoNfse
    {
        tcPedidoCancelamento Pedido { get; set; }
        tcDeclaracaoPrestacaoServico RPS { get; set; }
        [MaxLength(255)]
        public string Id { get; set; }
    }
}
