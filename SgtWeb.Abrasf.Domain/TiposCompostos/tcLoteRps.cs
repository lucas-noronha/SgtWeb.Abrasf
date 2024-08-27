using System.ComponentModel.DataAnnotations;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcLoteRps
    {
        public string NumeroLote { get; set; }
        public tcCpfCnpj CpfCnpj { get; set; }
        [MaxLength(15)]
        public string InscricaoMunicipal { get; set; }
        [MaxLength(1)]
        public string QuantidadeRps { get; set; }
        public ListaRps ListaRps { get; set; }
        [MaxLength(255)]
        public string Id { get; set; }
        public string versao { get; set; }
    }


}
