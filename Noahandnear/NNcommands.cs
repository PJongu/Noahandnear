using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity;

namespace Noahandnear
{

    public class NNcommands
    {
        
        [Command("hi")]
       

        public async Task Hi(CommandContext ctx)
        {

            await ctx.RespondAsync($"こんにちは！(・ω・)ノ {ctx.User.Mention}");
            var interactivity = ctx.Client.GetInteractivity();
            var msg = await interactivity.WaitForMessageAsync(xm => xm.Author.Id == ctx.User.Id && xm.Content.ToLower() == "how are you?", TimeSpan.FromMinutes(1));
            if (msg != null)
                await ctx.RespondAsync($"I'm fine, thank you!");

        }
        
    }
}
