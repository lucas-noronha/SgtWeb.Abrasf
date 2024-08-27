using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfseFaixa
{
    [XmlRoot(elementName: "ConsultarNfseFaixaEnvio")]
    public class ConsultarNfseFaixaEnvio
    {
        public tcIdentificacaoPrestador Prestador { get; set; }
        public int Pagina { get; set; }
    }

    public class Faixa
    {
        public long NumeroNfseInicial { get; set; }    
        public long NumeroNfseFinal { get; set; }

    }
}
