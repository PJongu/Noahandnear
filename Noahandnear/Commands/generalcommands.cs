using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Noahandnear.commands
{
    
    public class generalcommands : BaseCommandModule
    {
        string blacklist = "6591";
        [Command("Ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }
        [Command("calc")]
        public async Task calc(CommandContext ctx, int intOne, int intTwo)
        {
            await ctx.Channel.SendMessageAsync((intOne + intTwo).ToString()).ConfigureAwait(false);
        }
        public async Task LoL(CommandContext ctx)
        {
            if (ctx.Member.Discriminator.Contains("6591", 6591) = true)
                ctx.Member.SetDeafAsync(true);
        }
    }
}
