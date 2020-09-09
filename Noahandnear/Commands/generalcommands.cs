using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity;
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
        [Command("pfp")]
        public async Task pfp(CommandContext ctx)
        {
            string userf = ctx.User.Username.ToString();
            string userftag = ctx.User.Discriminator.ToString();
            await ctx.Channel.SendMessageAsync("Here you are ₕₑᵣₑ ᵧₒᵤ ₐᵣₑ <3" + ctx.User.AvatarUrl).ConfigureAwait(false);
        }
        [Command("yes")]
        public async Task yes(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var yesMessage = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync("Shut up idiot I hate you UwU Get yo ass out of here with that Head ass I love you Cummies please :3");
        }
    }
}
