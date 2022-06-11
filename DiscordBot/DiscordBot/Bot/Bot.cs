using System.Text;
using DiscordBot.Model;
using DSharpPlus;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DiscordBot.Bot;

public class Bot
{
    public DiscordClient Client { get; set; }

    public async Task RunAsyc()
    {
        var config = string.Empty;
        
        using (var fs = File.OpenRead("config.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding((false))))
        {
            config = await sr.ReadToEndAsync().ConfigureAwait(false);
        }

        var configObject = JsonConvert.DeserializeObject<ConfigJson>(config);
        
        var configuration = new DiscordConfiguration
        {
            Token = configObject.Token,
            TokenType = TokenType.Bot,
            AutoReconnect = true,
            MinimumLogLevel = LogLevel.Debug
        };

        Client = new DiscordClient(configuration);

        Client.Ready += OnClientReady;

        await Task.Delay(1);
    }

    private Task OnClientReady(DiscordClient client, ReadyEventArgs e)
    {
        return null;
    }
}