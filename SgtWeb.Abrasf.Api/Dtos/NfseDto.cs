namespace SgtWeb.Abrasf.Api.Dtos
{
    public class NfseDto
    {
        public string Versao { get; set; }

        public int? PrestadorId { get; set; }

        public int? PrefeituraId { get; set; }

        public DateTime DataServico { get; set; }

        public int? NumeroRps { get; set; }

        public DateTime DataRps { get; set; }

        public EnumTipoEmissaoNfse TipoEmissao { get; set; }

        public int? NotaRef { get; set; }

        public NfseTomadorDto Tomador { get; set; }

        public string DescricaoServico { get; set; }

        public ApuracaoIss ApuracaoIss { get; set; }

        public NfseRetencoesDto Retencoes { get; set; }

        public NfseIntermediarioDto Intermediario { get; set; }

        public NfseDadosObraDto DadosObra { get; set; }

        public string Obs { get; set; }

        public bool Preview { get; set; }
    }

    public class NfseIntermediarioDto
    {
        public string CpfCnpj { get; set; }

        public string Im { get; set; }

        public string Nome { get; set; }

        public int? MunicipioId { get; set; }

        public int? ResponsavelRetencao { get; set; }
    }

    public class NfseDadosObraDto
    {
        public string Codigo { get; set; }

        public string Art { get; set; }
    }

    public class NfseTomadorDto
    {
        public bool Estrangeiro { get; set; }

        public string Documento { get; set; }

        public string Im { get; set; }

        public string Ie { get; set; }

        public string Nome { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public int MunicipioId { get; set; }

        public string Cep { get; set; }

        public string Email { get; set; }

        public int? PaisId { get; set; }

        // Estrageiro

        public string EstrangeiroCidade { get; set; }

        public string EstrangeiroUf { get; set; }
    }

    public class NfseServicoDto
    {
        public string Id => $"{CodigoCnae}-{CodigoServico}";

        public string CodigoCnae { get; set; }

        public string DescricaoCnae { get; set; }

        public string CodigoServico { get; set; }

        public string DescricaoServico { get; set; }

        public decimal Aliquota { get; set; }

        public bool TributacaoNoLocalServico { get; set; }

        public EnumTributacaoExportacao TributacaoExportacao { get; set; }
    }

    public class ApuracaoIss
    {
        public int? Operacao { get; set; }

        public int? LocalDePrestacao { get; set; }

        public string Processo { get; set; }

        public NfseServicoDto Servico { get; set; }

        public decimal Aliquota { get; set; }

        public bool IssRetido { get; set; }

        public decimal ValorNota { get; set; }

        public decimal ValorDeducoes { get; set; }

        public decimal DescontoCondicionado { get; set; }

        public decimal DescontoIncondicionado { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Pais { get; set; }

        public int? PaisBacenId { get; set; }
    }

    public class NfseRetencoesDto
    {
        public decimal ValorInss { get; set; }
        public decimal ValorIrrf { get; set; }
        public decimal ValorCsll { get; set; }
        public decimal ValorPis { get; set; }
        public decimal ValorCofins { get; set; }
        public decimal OutrasRetencoes { get; set; }
    }

    public class OperacaoDto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool AliquotaAberta { get; set; }

        public bool AliquotaZerada { get; set; }

        public bool MunicipioPrestador { get; set; }

        public bool Exterior { get; set; }
    }

    public enum EnumTipoEmissaoNfse
    {
        Emissao = 1,

        Substituicao = 2
    }
    public enum EnumTributacaoExportacao
    {
        ConformeTributacaoNoLocal = 0,

        Tributavel = 1,

        NaoTributavel = 2
    }

}
