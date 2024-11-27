namespace SgtWeb.Abrasf.Api.Dtos
{
    public class EmissaoNfseResultado
    {
        public bool Sucesso { get; set; }

        public string MsgErro { get; set; }

        public string StackTrace { get; set; }

        public object Preview { get; set; }

        public List<NfseErroDto> Erros { get; set; }

        public NfseDto Dto { get; set; }

        public long NfseId { get; set; }

        public long Numero { get; set; }

        public string Cv { get; set; }
        public DateTime? DataEmissao { get; internal set; }
        public decimal ValorNota { get; internal set; }
        public string Tomador { get; internal set; }
        public string EmailTomador { get; internal set; }
    }
}

public class NfseErroDto
{
    public string Codigo { get; set; }

    public string Descricao { get; set; }

    public override string ToString()
    {
        if (string.IsNullOrWhiteSpace(Codigo))
        {
            return Descricao;
        }

        return $"#{Codigo} - {Descricao}";
    }
}