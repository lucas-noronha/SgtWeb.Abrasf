using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcInfSubstituicaoNfse
    {
        [XmlElement(ElementName = "NfseSubstituidora")]
        public long NfseSubstituidora { get; set; }
        [XmlElement(ElementName = "Id")]
        [MaxLength(255)]
        public string Id { get; set; }
    }


}
