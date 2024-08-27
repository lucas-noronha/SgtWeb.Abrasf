using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.RecepcaoLoteRPS
{
    [XmlRoot(ElementName = "EnviarLoteRpsResposta")]
    public class EnviarLoteRpsResposta
    {
        public long NumeroLote { get; set; }
        public string DataRecebimento { get; set; }

        public string Protocolo { get; set; }

        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }

    }


}
