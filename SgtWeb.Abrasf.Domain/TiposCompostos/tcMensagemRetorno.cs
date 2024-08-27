using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcMensagemRetorno
    {
        [XmlElement(ElementName = "Codigo")]
        [MaxLength(4)]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "Mensagem")]
        [MaxLength(200)]
        public string Mensagem { get; set; }
        [XmlElement(ElementName = "Correcao")]
        [MaxLength(200)]
        public string Correcao { get; set; }
    }


}
