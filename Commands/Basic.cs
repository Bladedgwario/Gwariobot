using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace DiscordBotTemplate.Commands
{
    public class Basic : BaseCommandModule
    {
        [Command("ping")]
        public async Task PingAsync(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong!!!");
        }
        [Command("test")]
        public async Task TestCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Test Message");
        }
        [Command("add")]
        public async Task Add(CommandContext ctx, int number1, int number2)
        {
            int result = number1 + number2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }
        [Command("subtract")]
        public async Task Subtract(CommandContext ctx, int number1, int number2)
        {
            int result = number1 - number2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }
        [Command("greet")]
        public async Task Greet(CommandContext ctx)
        {
            await ctx.RespondAsync($"Hello {ctx.Member.DisplayName}!");
        }

        [Command("info")]
        public async Task Info(CommandContext ctx)
        {
            await ctx.RespondAsync("I am a chatbot for this channel. You can use !greet to say hi!");
        }

        [Command("live")]
        public async Task Live(CommandContext ctx)
        {
            await ctx.RespondAsync("I am live! Come join me at https://www.twitch.tv/bladedgwario");
        }

        [Command("subscribe")]
        public async Task Subscribe(CommandContext ctx)
        {
            await ctx.RespondAsync("Subscribe to me on Twitch at https://www.twitch.tv/bladedgwario");
        }
    }
}
