using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcIdentificacaoNfse
    {
        [XmlElement(ElementName = "Numero")]
        public long Numero { get; set; }
        [XmlElement(ElementName = "CpfCnpj")]
        public tcCpfCnpj CpfCnpj { get; set; }
        [XmlElement(ElementName = "InscricaoMunicipal")]
        [MaxLength(15)]
        public string InscricaoMunicipal { get; set; }
        [XmlElement(ElementName = "CodigoMunicipio")]
        public long CodigoMunicipio { get; set; }
    }


}
