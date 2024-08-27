using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcCompNfse
    {
        [XmlElement(ElementName = "Nfse")]
        public tcNfse Nfse { get; set; }
        [XmlElement(ElementName = "NfseCancelamento")]
        public tcCancelamentoNfse NfseCancelamento { get; set; }
        [XmlElement(ElementName = "NfseSubstituicao")]
        public tcSubstituicaoNfse NfseSubstituicao { get; set; }
    }


}
