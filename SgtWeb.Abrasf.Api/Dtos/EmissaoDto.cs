namespace SgtWeb.Abrasf.Api.Dtos
{
    public class EmissaoDto
    {
        public EmissaoDto(NfseDto dto, UserHeader header)
        {
            NfseDto = dto;
            TenantId = header.TenantId;
            UserId = header.UserId;
            SecretAccessKey = header.SecretAccessKey;
        }
        public NfseDto NfseDto { get; set; }
        public int TenantId { get; set; }
        public string UserId { get; set; }
        public string SecretAccessKey { get; set; }
    }
}
