using DiscordBot.Bot;

namespace DiscordBot;

public class Program
{

    public static Task Main(string[] args) => new Program().MainAsync();

    public async Task MainAsync()
    {
        var bot = new Bot.Bot();
        
        bot.RunAsyc().GetAwaiter().GetResult();
    }
}