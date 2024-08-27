using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcIdentificacaoOrgaoGerador
    {
        [XmlElement(ElementName = "CodigoMunicipio")]
        [MaxLength(7)]
        public string CodigoMunicipio { get; set; }
        [XmlElement(ElementName = "Uf")]
        [MaxLength(2)]
        public string Uf { get; set; }
    }
}
