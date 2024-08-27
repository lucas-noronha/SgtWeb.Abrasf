using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono
{
    [XmlRoot(ElementName = "EnviarLoteRpsSincronoResposta")]
    public class EnviarLoteRpsSincronoResposta
    {
        public string NumeroLote { get; set; }
        public string DataRecebimento { get; set; }
        public string Protocolo { get; set; }
        
        public ListaNfse ListaNfse { get; set; }

        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }

        public ListaMensagemRetornoLote ListaMensagemRetornoLote { get; set; }


    }

    public class ListaNfse
    {
        [XmlElement(ElementName = "CompNfse")]
        public List<tcCompNfse> CompNfse { get; set; }
        [XmlElement(ElementName = "ListaMensagemAlertaRetorno")]
        public ListaMensagemAlertaRetorno ListaMensagemAlertaRetorno { get; set; }
    }
}
