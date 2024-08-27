using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfseServicoPrestado
{
    [XmlRoot(elementName: "ConsultarNfseEnvio")]
    public class ConsultarNfseEnvio
    {
        public tcIdentificacaoPrestador Prestador { get; set; }
        public long NumeroNfse { get; set; }
        public Periodo PeriodoEmissao { get; set; }
        public Periodo PeriodoCompetencia { get; set; }

        public tcIdentificacaoTomador Tomador { get; set; }
        public tcIdentificacaoIntermediario Intermediario { get; set; }
        public int Pagina { get; set; }


    }

    public class Periodo
    {
        public string DataInicial { get; set; }
        public string DataFinal { get; set; }

    }
}
