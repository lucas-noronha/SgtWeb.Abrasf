using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcCpfCnpj
    {
        [XmlElement(ElementName = "Cpf")]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [XmlElement(ElementName = "Cnpj")]
        [MaxLength(14)]
        public string Cnpj { get; set; }


        public string GetCpfCnpj()
        {
            if (!string.IsNullOrEmpty(Cpf))
            {
                return Cpf;
            }
            else
            {
                return Cnpj;
            }
        }
    }
}
