using System.ComponentModel.DataAnnotations;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcMensagemRetornoLote
    {
        public tcIdentificacaoRps IdentificacaoRps { get; set; }
        [MaxLength(4)]
        public string Codigo { get; set; }
        [MaxLength(200)]
        public string Mensagem { get; set; }
    }


}
