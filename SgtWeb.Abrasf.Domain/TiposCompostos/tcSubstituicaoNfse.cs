using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcSubstituicaoNfse
    {
        [XmlElement(ElementName = "InfSubstituicaoNfse")]
        public tcInfSubstituicaoNfse InfSubstituicaoNfse { get; set; }
        [XmlElement(ElementName = "Signature")]
        [MaxLength(255)]
        public string Signature { get; set; } //Ver com ricado
        [XmlElement(ElementName = "versao")]

        public string versao { get; set; }
    }


}
