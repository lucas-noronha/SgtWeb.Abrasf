using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfseFaixa
{
    [XmlRoot(elementName:"ConsultarNfseFaixaResposta")]
    public class ConsultarNfseFaixaResposta
    {
        public ListaNfse ListaNfse { get; set; }
        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }
    }
}
