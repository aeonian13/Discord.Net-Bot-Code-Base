using System;
using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Newtonsoft.Json.Linq;

namespace Bot_Boi.Commands
{
    public class Basic_Commands : ModuleBase<SocketCommandContext>
    {
        [Command("say")] //complete
        public async Task Say([Remainder]string message)
        {
            await Context.Message.DeleteAsync();
            await Context.Channel.SendMessageAsync(message.ToString());
        }
    }
}
