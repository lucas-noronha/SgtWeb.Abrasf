using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcDadosServico
    {
        [XmlElement(ElementName = "Valores")]
        public tcValoresDeclaracaoServico Valores { get; set; }
        [XmlElement(ElementName = "IssRetido")]
        public int IssRetido { get; set; }
        [XmlElement(ElementName = "ResponsavelRetencao")]
        public int ResponsavelRetencao { get; set; }
        [XmlElement(ElementName = "ItemListaServico")]
        [MaxLength(5)]
        public string ItemListaServico { get; set; }
        [XmlElement(ElementName = "CodigoCnae")]
        public long CodigoCnae { get; set; }
        [XmlElement(ElementName = "CodigoTributacaoMunicipio")]
        [MaxLength(20)]
        public string CodigoTributacaoMunicipio { get; set; }
        [XmlElement(ElementName = "CodigoNbs")]
        [MaxLength(9)]
        public string CodigoNbs { get; set; }
        [XmlElement(ElementName = "Discriminacao")]
        [MaxLength(2000)]
        public string Discriminacao { get; set; }
        [XmlElement(ElementName = "CodigoMunicipio")]
        public long CodigoMunicipio { get; set; }
        [XmlElement(ElementName = "CodigoPais")]
        [MaxLength(4)]
        public string CodigoPais { get; set; }
        [XmlElement(ElementName = "ExigibilidadeISS")]
        public int ExigibilidadeISS { get; set; }
        [XmlElement(ElementName = "MunicipioIncidencia")]
        public long MunicipioIncidencia { get; set; }
        [XmlElement(ElementName = "NumeroProcesso")]
        [MinLength(30)]
        public string NumeroProcesso { get; set; }


    }


}
