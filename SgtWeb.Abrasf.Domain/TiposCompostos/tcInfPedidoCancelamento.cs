using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcInfPedidoCancelamento
    {
        [XmlElement(ElementName = "IdentificacaoNfse")]
        public tcIdentificacaoNfse IdentificacaoNfse { get; set; }
        [XmlElement(ElementName = "CodigoCancelamento")]
        [MaxLength(4)]
        public string CodigoCancalamento { get; set; }
        [XmlElement(ElementName = "Id")]
        [MaxLength(255)]
        public string Id { get; set; }
    }


}
