using Newtonsoft.Json;

namespace DiscordBot.Model;

public class ConfigJson
{
    [JsonProperty("token")]
    public  string Token { get; set; }
    [JsonProperty("prefix")]
    public  string Prefix { get; set; }
}