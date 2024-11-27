using Refit;
using SgtWeb.Abrasf.Api.Dtos;

namespace SgtWeb.Abrasf.Api.Interfaces
{
    public interface INfseApi
    {
        [Post("/api/nfse/emitir_abrasf")]
        public Task<EmissaoNfseResultado> CadastrarNfse([Body] EmissaoDto nfse);
    }
}
