using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcInfRps
    {
        [XmlElement(ElementName = "IdentificacaoRps")]
        public tcIdentificacaoRps IdentificacaoRps { get; set; }
        [XmlElement(ElementName = "DataEmissao")]
        [MaxLength(10)]
        public string DataEmissao { get; set; }
        [XmlElement(ElementName = "Status")]
        public int Status { get; set; }
        [XmlElement(ElementName = "RpsSubstituido")]
        public tcIdentificacaoRps RpsSubstituido { get; set; }
        [XmlElement(ElementName = "Id")]
        [MaxLength(255)]
        public string Id { get; set; }
    }


}
