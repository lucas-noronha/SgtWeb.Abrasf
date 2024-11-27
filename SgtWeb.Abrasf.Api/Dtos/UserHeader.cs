namespace SgtWeb.Abrasf.Api.Dtos
{
    public class UserHeader
    {
        public int TenantId { get; set; }
        public string UserId { get; set; }
        public string SecretAccessKey { get; set; }
    }
}
