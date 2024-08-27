using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcDadosPrestador
    {
        [XmlElement(ElementName = "IdentificacaoPrestador")]
        public tcIdentificacaoPrestador IdentificacaoPrestador { get; set; }
        [XmlElement(ElementName = "RazaoSocial")]
        [MaxLength(150)]
        public string RazaoSocial { get; set; }
        [XmlElement(ElementName = "NomeFantasia")]
        [MaxLength(150)]
        public string NomeFantasia { get; set; }
        [XmlElement(ElementName = "Endereco")]
        public tcEndereco Endereco { get; set; }
        [XmlElement(ElementName = "Contato")]
        public tcContato Contato { get; set; }

    }


}
