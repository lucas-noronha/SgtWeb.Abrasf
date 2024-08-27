using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcDadosIntermediario
    {
        [XmlElement(ElementName = "IdentificacaoIntermediario")]
        public tcIdentificacaoIntermediario IdentificacaoIntermediario { get; set; }
        [XmlElement(ElementName = "RazaoSocial")]
        [MaxLength(150)]
        public string RazaoSocial { get; set; }
        [XmlElement(ElementName = "CodigoMunicipio")]
        public long CodigoMunicipio { get; set; }
    }


}
