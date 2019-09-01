using System;
using System.Threading.Tasks;
using Discord.WebSocket;
using Test.Discord;
using Test.Discord.Entities;

namespace Test
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello World!");
            var config = new BotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            var connection = Unity.Resolve<Connection>();


        }
    }
}
