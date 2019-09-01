using System.Threading.Tasks;
using Discord;

namespace Test.Discord
{
    public class DiscordLogger
    {
        ILogger _logger;

        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }
        public Task Log(LogMessage logMessage)
        {
            _logger.Log(logMessage.Message);
            return Task.CompletedTask;
        }
    }
}