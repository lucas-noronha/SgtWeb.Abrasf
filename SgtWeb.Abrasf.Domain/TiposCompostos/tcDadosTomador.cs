using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcDadosTomador
    {
        [XmlElement(ElementName = "IdentificacaoTomador")]
        public tcIdentificacaoTomador IdentificacaoTomador { get; set; }
        [XmlElement(ElementName = "NifTomador")]
        [MaxLength(40)]
        public string NifTomador { get; set; }
        [XmlElement(ElementName = "RazaoSocial")]
        [MaxLength(150)]
        public string RazaoSocial { get; set; }
        [XmlElement(ElementName = "Endereco")]
        public tcEndereco Endereco { get; set; }
        [XmlElement(ElementName = "Contato")]
        public tcContato Contato { get; set; }
    }


}
