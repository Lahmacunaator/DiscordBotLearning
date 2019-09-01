using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Test.Discord.Entities;

namespace Test.Discord
{
    public class Connection
    {
        internal DiscordSocketClient _client;
        private DiscordLogger _discordLogger;

        public Connection(DiscordLogger discordLogger)
        {
            _discordLogger = discordLogger;
        }

        internal async Task ConnectAsync(BotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            _client.Log += _discordLogger.Log;
        }

        //public Connection(BotConfig config)
        //{
        //    _client = new DiscordSocketClient(config.SocketConfig);
        //}
    }
}