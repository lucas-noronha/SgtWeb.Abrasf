using Microsoft.AspNetCore.Server.HttpSys;
using Refit;
using SgtWeb.Abrasf.Api.Dtos;
using SgtWeb.Abrasf.Api.Utils;
using SgtWeb.Abrasf.Domain.TiposCompostos;
using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.EnviarLoteRpsSincrono;
using SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse;
using SoapCore.Meta;
using System.Data;
using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace SgtWeb.Abrasf.Api.Services
{
    public class SoapService : IMySoapService
    {


        public async Task<string> GerarNfseEnvio(string user_header, string user_data)
        {

            var request = DeserializerUtils.DeserializeXML<GerarNfseEnvio>(user_data);
            var header = DeserializerUtils.DeserializeXML<UserHeader>(user_header);
            int notaSubstituida = 0;
            string numeroRpsSubstituido = request.Rps?.InfDeclaracaoPrestacaoServico?.Rps?.RpsSubstituido?.Numero;
            Int32.TryParse(numeroRpsSubstituido, out notaSubstituida);

            int numeroRps = 0;
            string numeroRpsString = request.Rps?.InfDeclaracaoPrestacaoServico?.Rps?.IdentificacaoRps?.Numero;
            Int32.TryParse(numeroRpsString, out numeroRps);
            var dtoNfse = new NfseDto();

            dtoNfse.DataRps = DateTime.Parse(request.Rps.InfDeclaracaoPrestacaoServico.Rps.DataEmissao);
            dtoNfse.DescricaoServico = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Discriminacao;
            dtoNfse.DataServico = DateTime.Parse(request.Rps.InfDeclaracaoPrestacaoServico.Rps.DataEmissao); //vai ser isso ou a competencia do da nota com dia 1?
            dtoNfse.NotaRef = notaSubstituida == 0 ? null : notaSubstituida; //verificar isso
            dtoNfse.TipoEmissao = notaSubstituida != 0 ? EnumTipoEmissaoNfse.Substituicao : EnumTipoEmissaoNfse.Emissao; //verificar isso
            dtoNfse.NumeroRps = numeroRps == 0 ? null : numeroRps;//verificar isso
            dtoNfse.Preview = false; //verificar isso
            dtoNfse.PrestadorId = 0; //verificar isso
            dtoNfse.PrefeituraId = 0; //verificar isso
            dtoNfse.Versao = request.Rps.InfDeclaracaoPrestacaoServico.Rps.IdentificacaoRps.Serie; //??

            dtoNfse.ApuracaoIss = new ApuracaoIss();
            dtoNfse.ApuracaoIss.Aliquota = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.Aliquota;
            dtoNfse.ApuracaoIss.Cidade = request.Rps.InfDeclaracaoPrestacaoServico.Servico.MunicipioIncidencia.ToString();
            dtoNfse.ApuracaoIss.DescontoCondicionado = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.DescontoCondicionado;
            dtoNfse.ApuracaoIss.DescontoIncondicionado = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.DescontoIncondicionado;
            dtoNfse.ApuracaoIss.IssRetido = request.Rps.InfDeclaracaoPrestacaoServico.Servico.IssRetido == 1;
            dtoNfse.ApuracaoIss.LocalDePrestacao = (int)request.Rps.InfDeclaracaoPrestacaoServico.Servico.CodigoMunicipio;
            dtoNfse.ApuracaoIss.Uf = request.Rps.InfDeclaracaoPrestacaoServico.Servico.MunicipioIncidencia.ToString(); //Analisar isso aqui
            dtoNfse.ApuracaoIss.Operacao = request.Rps.InfDeclaracaoPrestacaoServico.Servico.ExigibilidadeISS; //verificar isso
            dtoNfse.ApuracaoIss.PaisBacenId = Convert.ToInt32(request.Rps.InfDeclaracaoPrestacaoServico.Servico.CodigoPais); //verificar isso
            dtoNfse.ApuracaoIss.Processo = request.Rps.InfDeclaracaoPrestacaoServico.Servico.NumeroProcesso;
            dtoNfse.ApuracaoIss.ValorDeducoes = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.ValorDeducoes;
            dtoNfse.ApuracaoIss.ValorNota = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.ValorServicos;

            dtoNfse.ApuracaoIss.Servico = new NfseServicoDto();
            dtoNfse.ApuracaoIss.Servico.Aliquota = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.Aliquota;
            dtoNfse.ApuracaoIss.Servico.CodigoCnae = request.Rps.InfDeclaracaoPrestacaoServico.Servico.CodigoCnae.ToString();
            dtoNfse.ApuracaoIss.Servico.CodigoServico = request.Rps.InfDeclaracaoPrestacaoServico.Servico.ItemListaServico.ToString();
            dtoNfse.ApuracaoIss.Servico.TributacaoExportacao = EnumTributacaoExportacao.ConformeTributacaoNoLocal; //verificar isso
            dtoNfse.ApuracaoIss.Servico.TributacaoNoLocalServico = request.Rps.InfDeclaracaoPrestacaoServico.Servico.IssRetido == 1; //verificar isso,

            dtoNfse.DadosObra = new NfseDadosObraDto();
            dtoNfse.DadosObra.Art = request.Rps?.InfDeclaracaoPrestacaoServico?.ConstrucaoCivil?.Art;
            dtoNfse.DadosObra.Codigo = request.Rps?.InfDeclaracaoPrestacaoServico?.ConstrucaoCivil?.CodigoObra;

            dtoNfse.Intermediario = new NfseIntermediarioDto();
            dtoNfse.Intermediario.CpfCnpj = request?.Rps?.InfDeclaracaoPrestacaoServico?.Intermediario?.IdentificacaoIntermediario?.CpfCnpj.GetCpfCnpj();
            dtoNfse.Intermediario.Im = request?.Rps?.InfDeclaracaoPrestacaoServico?.Intermediario?.IdentificacaoIntermediario?.InscricaoMunicipal;
            dtoNfse.Intermediario.Nome = request.Rps?.InfDeclaracaoPrestacaoServico?.Intermediario?.RazaoSocial;
            dtoNfse.Intermediario.MunicipioId = (int?)request?.Rps?.InfDeclaracaoPrestacaoServico?.Intermediario?.CodigoMunicipio;
            //dtoNfse.Intermediario.ResponsavelRetencao = request.Rps.InfDeclaracaoPrestacaoServico.Intermediario.IdentificacaoIntermediario.res == 1

            dtoNfse.Retencoes = new NfseRetencoesDto();
            dtoNfse.Retencoes.OutrasRetencoes = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.OutrasRetencoes;
            dtoNfse.Retencoes.ValorCofins = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.ValorCofins;
            dtoNfse.Retencoes.ValorInss = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.ValorInss;
            dtoNfse.Retencoes.ValorIrrf = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.ValorIr;
            dtoNfse.Retencoes.ValorPis = request.Rps.InfDeclaracaoPrestacaoServico.Servico.Valores.ValorPis;

            dtoNfse.Tomador = new NfseTomadorDto();
            dtoNfse.Tomador.Bairro = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.Endereco.Bairro;
            dtoNfse.Tomador.Cep = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.Endereco.Cep;
            dtoNfse.Tomador.Complemento = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.Endereco.Complemento;
            dtoNfse.Tomador.Documento = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.IdentificacaoTomador.CpfCnpj.GetCpfCnpj();
            dtoNfse.Tomador.Email = request?.Rps?.InfDeclaracaoPrestacaoServico?.TomadorServico?.Contato?.Email;
            dtoNfse.Tomador.Im = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.IdentificacaoTomador.InscricaoMunicipal;
            dtoNfse.Tomador.Nome = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.RazaoSocial;
            dtoNfse.Tomador.Numero = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.Endereco.Numero;
            dtoNfse.Tomador.Estrangeiro = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.IdentificacaoTomador.CpfCnpj.Cpf == null; // ??
            dtoNfse.Tomador.PaisId = Convert.ToInt32(request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.Endereco.CodigoPais);
            dtoNfse.Tomador.Logradouro = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.Endereco.Logradouro;
            dtoNfse.Tomador.MunicipioId = (int)Convert.ToInt32(request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.Endereco.CodigoMunicipio);
            //dtoNfse.Tomador.Ie = request.Rps.InfDeclaracaoPrestacaoServico.TomadorServico.IdentificacaoTomador.,

            try
            {
                var apiService = new NfseRequestService();
                var dto = new EmissaoDto(dtoNfse, header);
                var response = await apiService.SalvarNfe(dto);
            }
            catch (ApiException ex)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }



            var retorno = new GerarNfseResposta()
            {
                ListaMensagemRetorno = new ListaMensagemRetorno()
                {
                    MensagemRetorno = new List<tcMensagemRetorno>()
                    {
                        new tcMensagemRetorno()
                        {

                        }
                    }
                },
                ListaNfse = new ListaNfse()
                {
                    CompNfse = new List<tcCompNfse>()
                    {
                        new tcCompNfse()
                        {

                        }
                    },
                    ListaMensagemAlertaRetorno = new ListaMensagemAlertaRetorno()
                    {
                        MensagemRetorno = new List<tcMensagemRetorno>()
                        {
                            new tcMensagemRetorno()
                            {

                            }
                        }

                    }

                },

            };

            using var stringwriter = new StringWriter();

            var serializer = new XmlSerializer(typeof(GerarNfseResposta));
            serializer.Serialize(stringwriter, retorno);
            return stringwriter.ToString();
        }

        public string SayHello(string name)
        {
            return $"Hello, {name}";
        }


    }
}
