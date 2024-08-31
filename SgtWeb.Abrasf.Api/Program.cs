using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SgtWeb.Abrasf.Api.Services;
using SoapCore;
using SoapCore.Extensibility;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner.
builder.Services.AddControllers();
builder.Services.AddSoapCore();
builder.Services.AddSingleton<IMySoapService, SoapService>();

var app = builder.Build();

// Configurar o pipeline de requisição HTTP.
app.UseRouting();

app.UseAuthorization();

// Configurar o endpoint SOAP usando middleware
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
    _ = endpoints.UseSoapEndpoint<IMySoapService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();
