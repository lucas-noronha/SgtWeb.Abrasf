using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcInfNfse
    {
        [XmlElement(ElementName = "Numero")]
        public long Numero { get; set; }
        [XmlElement(ElementName = "CodigoVerificacao")]
        [MaxLength(9)]
        public string CodigoVerificacao { get; set; }
        [XmlElement(ElementName = "DataEmissao")]
        [MaxLength(19)]
        public string DataEmissao { get; set; }
        [XmlElement(ElementName = "NfseSubstituida")]
        public long NfseSubstituida { get; set; }
        [XmlElement(ElementName = "OutrasInformacoes")]
        [MaxLength(255)]
        public string OutrasInformacoes { get; set; }
        [XmlElement(ElementName = "ValoresNfse")]
        public tcValoresNfse ValoresNfse { get; set; }
        [XmlElement(ElementName = "ValorCredito")]
        public decimal ValorCredito { get; set; }
        [XmlElement(ElementName = "PrestadorServico")]
        public tcDadosPrestador PrestadorServico { get; set; }
        [XmlElement(ElementName = "OrgaoGerador")]
        public tcIdentificacaoOrgaoGerador OrgaoGerador { get; set; }
        [XmlElement(ElementName = "DeclaracaoPrestacaoServico")]
        public tcDeclaracaoPrestacaoServico DeclaracaoPrestacaoServico { get; set; }
        [MaxLength(255)]
        public string Id { get; set; }
    }


}
