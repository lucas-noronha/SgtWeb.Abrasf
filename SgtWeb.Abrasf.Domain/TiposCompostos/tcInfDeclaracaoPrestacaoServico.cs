using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcInfDeclaracaoPrestacaoServico
    {
        [XmlElement(ElementName = "Rps")]
        public tcInfRps Rps { get; set; }

        [XmlElement(ElementName = "Competencia")]
        [MaxLength(10)]
        public string Competencia { get; set; }

        [XmlElement(ElementName = "Servico")]
        public tcDadosServico Servico { get; set; }

        [XmlElement(ElementName = "Prestador")]
        public tcDadosPrestador Prestador { get; set; }

        [XmlElement(ElementName = "Tomador")]
        public tcDadosTomador TomadorServico { get; set; }

        [XmlElement(ElementName = "Intermediario")]
        public tcDadosIntermediario Intermediario { get; set; }
        [XmlElement(ElementName = "ConstrucaoCivil")]
        public tcDadosConstrucaoCivil ConstrucaoCivil { get; set; }
        [XmlElement(ElementName = "RegimeEspecialTributacao")]
        public int RegimeEspecialTributacao { get; set; }
        [XmlElement(ElementName = "OptanteSimplesNacional")]
        public int OptanteSimplesNacional { get; set; }
        [XmlElement(ElementName = "IncentivoFiscal")]
        public int IncentivoFiscal { get; set; }
        
        [XmlAttribute(AttributeName = "Id")]
        [MaxLength(255)]
        public string Id { get; set; }
    }


}
