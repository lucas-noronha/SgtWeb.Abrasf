using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcConfirmacaoCancelamento
    {
        [XmlElement(ElementName = "Pedido")]
        public tcPedidoCancelamento Pedido { get; set; }
        [MaxLength(19)]
        [XmlElement(ElementName = "DataHora")]
        public string DataHora { get; set; }
        [XmlElement(ElementName = "Id")]
        [MaxLength(255)]
        public string Id { get; set; }
    }


}
