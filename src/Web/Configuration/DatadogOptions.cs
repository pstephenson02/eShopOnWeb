namespace Microsoft.eShopWeb.Web.Configuration;

public class DatadogOptions
{
    public const string Datadog = "Datadog";

    public string Site { get; set; } = string.Empty;
    public string Service { get; set; } = string.Empty;
    // When running locally: https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets
    public string ClientToken { get; set; } = string.Empty;
    public string ApplicationId { get; set; } = string.Empty;
}
