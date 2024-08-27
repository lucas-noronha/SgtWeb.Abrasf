using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcValoresNfse
    {
        [XmlElement(ElementName = "BaseCalculo")]
        public decimal BaseCalculo { get; set; }
        [XmlElement(ElementName = "Aliquota")]
        public decimal Aliquota { get; set; }
        [XmlElement(ElementName = "ValorIss")]
        public decimal ValorIss { get; set; }
        [XmlElement(ElementName = "ValorLiquidoNfse")]
        public decimal ValorLiquidoNfse { get; set; }
    }


}
