using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcIdentificacaoRps
    {
        [XmlElement(ElementName = "Tipo")]
        [MaxLength(1)]
        public int Tipo { get; set; }
        [XmlElement(ElementName = "Serie")]
        [MaxLength(5)]
        public string Serie { get; set; }
        [XmlElement(ElementName = "Numero")]
        [MaxLength(15)]
        public string Numero { get; set; }
    }


}
