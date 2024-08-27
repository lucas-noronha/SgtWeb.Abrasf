using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarLoteRps
{
    [XmlRoot(elementName: "ConsultarLoteRpsResposta")]
    public class ConsultarLoteRpsResposta
    {
        public int Situacao { get; set; }
        public ListaNfse ListaNfse { get; set; }
        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }
        public ListaMensagemRetornoLote ListaMensagemRetornoLote { get; set; }
    }
}
