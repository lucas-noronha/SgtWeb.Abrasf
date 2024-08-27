using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcEndereco
    {
        [XmlElement(ElementName = "Logradouro")]
        [MaxLength(125)]
        public string Logradouro { get; set; }
        [XmlElement(ElementName = "Numero")]
        [MaxLength(10)]
        public string Numero { get; set; }
        [XmlElement(ElementName = "Complemento")]
        [MaxLength(60)]
        public string Complemento { get; set; }
        [XmlElement(ElementName = "Bairro")]
        [MaxLength(60)]
        public string Bairro { get; set; }
        [XmlElement(ElementName = "CodigoMunicipio")]
        [MaxLength(7)]
        public string CodigoMunicipio { get; set; }
        [XmlElement(ElementName = "Uf")]
        [MaxLength(2)]
        public string Uf { get; set; }
        [XmlElement(ElementName = "CodigoPais")]
        [MaxLength(4)]
        public string CodigoPais { get; set; }
        [XmlElement(ElementName = "Cep")]
        [MaxLength(8)]
        public string Cep { get; set; }
    }
}
