using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DSharpPlus;
using DSharpPlus.CommandsNext;

namespace Revival
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        internal static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                MinimumLogLevel = LogLevel.Debug,
                LogTimestampFormat = "MMM dd yyyy - hh:mm:ss tt",
                Token = "nope!",
                TokenType = TokenType.Bot,
            });
            var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { ".." }
            });

            commands.RegisterCommands<CommandsModule1>();

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}