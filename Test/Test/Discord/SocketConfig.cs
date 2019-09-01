using Discord;
using Discord.WebSocket;

namespace Test.Discord
{
    public static class SocketConfig
    {
        public static DiscordSocketConfig GetDefault()
        {
            return new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Verbose
            };
        }

        public static DiscordSocketConfig GetNewConfig()
        {
            return new DiscordSocketConfig();
        }
    }
}