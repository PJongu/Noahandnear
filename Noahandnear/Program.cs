using System;
using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.Interactivity;

namespace Noahandnear
{

    class Program
    {
        static CommandsNextExtension commands;
        static InteractivityExtension interactivity;
        static DiscordClient discord;
        static SringPrefixes = {";nn"};
        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        {
            

            discord = new DiscordClient(new DiscordConfiguration
            {
                UseInternalLogHandler = true,
                
                LogLevel = LogLevel.Debug,
                Token = "NzQ1NDg2MzUwNDY3MjAzMDgz.XzyeRA.jUqGDTr3XDbbCZrU02Z1ot_k9BA",
                TokenType = TokenType.Bot,
        }) ;
            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower().StartsWith("fuck"))
                    await e.Message.RespondAsync("you :3");
            };
            commands = discord.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefixes[0]
            }) ;
            

            commands.RegisterCommands<NNcommands>();
            

            await discord.ConnectAsync();
            await Task.Delay(-1);
            
            I FUCKING HATE WHITE PEOPLW
        }
    }
}
