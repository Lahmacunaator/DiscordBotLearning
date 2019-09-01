using Discord.WebSocket;

namespace Test.Discord.Entities
{
    public class BotConfig
    {
        public string Token { get; set; }

        public DiscordSocketConfig SocketConfig { get; set; }
    }
}