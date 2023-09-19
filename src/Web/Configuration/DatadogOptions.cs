namespace Microsoft.eShopWeb.Web.Configuration;

public class DatadogOptions
{
    public const string Datadog = "Datadog";

    public string Site { get; set; } = string.Empty;
    public string Service { get; set; } = string.Empty;
    public string ClientToken { get; set; } = string.Empty;
    public string ApplicationId { get; set; } = string.Empty;
}
