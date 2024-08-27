using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcIdentificacaoPrestador
    {
        [XmlElement(ElementName = "CpfCnpj")]
        public tcCpfCnpj CpfCnpj { get; set; }
        [XmlElement(ElementName = "InscricaoMunicipal")]
        [MaxLength(20)]
        public string InscricaoMunicipal { get; set; }
    }
}
