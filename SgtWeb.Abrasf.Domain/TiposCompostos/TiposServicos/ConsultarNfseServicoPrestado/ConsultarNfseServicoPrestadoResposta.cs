using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfseServicoPrestado
{
    [XmlRoot(elementName: "ConsultarNfseResposta")]
    public class ConsultarNfseServicoPrestadoResposta
    {
        public ListaNfse ListaNfse { get; set; }
        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }
    }
}