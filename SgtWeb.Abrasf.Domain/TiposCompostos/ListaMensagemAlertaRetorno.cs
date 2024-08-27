using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class ListaMensagemAlertaRetorno
    {
        [XmlElement(ElementName = "MensagemAlertaRetorno")]
        public List<tcMensagemRetorno> MensagemRetorno { get; set; }
    }


}
