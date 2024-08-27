using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcDadosConstrucaoCivil
    {
        [XmlElement(ElementName = "CodigoObra")]
        [MaxLength(15)]
        public string CodigoObra { get; set; }
        [XmlElement(ElementName = "Art")]
        [MaxLength(15)]
        public string Art { get; set; }
    }


}
