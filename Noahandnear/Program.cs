using System;
using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.Interactivity;

namespace Noahandnear
{
    class program
    {
        static void Main(string[] args)
        {
            var bot = new bot();
            bot.RunAsync().GetAwaiter().GetResult();
            
        }
    }
}
