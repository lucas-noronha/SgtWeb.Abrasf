using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcValoresDeclaracaoServico
    {
        [XmlElement(ElementName = "ValorServicos")]
        public decimal ValorServicos { get; set; }
        [XmlElement(ElementName = "ValorDeducoes")]
        public decimal ValorDeducoes { get; set; }
        [XmlElement(ElementName = "ValorPis")]
        public decimal ValorPis { get; set; }
        [XmlElement(ElementName = "ValorCofins")]
        public decimal ValorCofins { get; set; }
        [XmlElement(ElementName = "ValorInss")]
        public decimal ValorInss { get; set; }
        [XmlElement(ElementName = "ValorIr")]
        public decimal ValorIr { get; set; }
        [XmlElement(ElementName = "ValorCsll")]
        public decimal ValorCsll { get; set; }
        [XmlElement(ElementName = "OutrasRetencoes")]
        public decimal OutrasRetencoes { get; set; }
        [XmlElement(ElementName = "ValTotTributos")]
        public decimal ValTotTributos { get; set; }
        [XmlElement(ElementName = "ValorIss")]
        public decimal ValorIss { get; set; }
        [XmlElement(ElementName = "Aliquota")]
        public decimal Aliquota { get; set; }
        [XmlElement(ElementName = "DescontoIncondicionado")]
        public decimal DescontoIncondicionado { get; set; }
        [XmlElement(ElementName = "DescontoCondicionado")]
        public decimal DescontoCondicionado { get; set; }
    }


}
