using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcContato
    {
        [XmlElement(ElementName = "Telefone")]
        [MaxLength(20)]
        public string Telefone { get; set; }
        [XmlElement(ElementName = "Email")]
        [MaxLength(80)]
        public string Email { get; set; }
    }
}
