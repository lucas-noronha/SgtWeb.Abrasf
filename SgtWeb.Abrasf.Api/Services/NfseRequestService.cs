

using Refit;
using SgtWeb.Abrasf.Api.Dtos;
using SgtWeb.Abrasf.Api.Interfaces;

namespace SgtWeb.Abrasf.Api.Services
{
    public class NfseRequestService
    {
        private INfseApi nfseApi = RestService.For<INfseApi>("http://localhost:6060");
        public NfseRequestService()
        {
            

        }

        public Task<EmissaoNfseResultado> SalvarNfe(EmissaoDto nfse)
        {
            try
            {
                return nfseApi.CadastrarNfse(nfse);

            }
            catch (ApiException ex)
            {
                throw;
            }
        }
    }
}
