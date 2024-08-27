using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.SubstituicaoNfse
{
    [XmlRoot(ElementName = "SubstituirNfseResposta")]
    public class SubstituirNfseResposta
    {
        public RetSubstituicao RetSubstituicao { get; set; }
        public ListaMensagemRetorno ListaMensagemRetorno { get; set; }
    }

    public class RetSubstituicao
    {
        public NfseSubstituida NfseSubstituida { get; set; }
        public NfseSubstituidora NfseSubstituidora { get; set; }
    }

    public class NfseSubstituida
    {
        public tcCompNfse CompNfse { get; set; }
        public ListaMensagemAlertaRetorno ListaMensagemAlertaRetorno { get; set; }
    }

    public class NfseSubstituidora
    {
        public tcCompNfse CompNfse { get; set; }
    }

}
