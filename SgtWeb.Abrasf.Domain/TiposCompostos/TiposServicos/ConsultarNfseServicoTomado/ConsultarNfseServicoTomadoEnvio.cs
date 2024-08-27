using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfseServicoPrestado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.ConsultarNfseServicoTomado
{
    [XmlRoot(elementName: "ConsultarNfseEnvio")]
    public class ConsultarNfseServicoTomadoEnvio
    {
        public tcIdentificacaoConsulente Consulente { get; set; }
        public long NumeroNfse { get; set; }
        public Periodo PeriodoEmissao { get; set; }
        public Periodo PeriodoCompetencia { get; set; }
        public tcIdentificacaoPrestador Prestador { get; set; }
        public tcIdentificacaoTomador Tomador { get; set; }
        public tcIdentificacaoIntermediario Intermediario { get; set; }
        public int Pagina { get; set; }
    }
}
