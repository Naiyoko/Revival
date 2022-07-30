using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

public class CommandsModule1 : BaseCommandModule
{
    [Command("greet")]
    public async Task GreetCommand(CommandContext ctx)
    {
        await ctx.RespondAsync("Here we aree, responding with some random text.");
    }

    [Command("sayhi")]
    public async Task SayhiCommand(CommandContext ctx, [RemainingText] string name)
    {
        await ctx.RespondAsync($"Helloo, {name}~");
    }

    [Command("rannumber")]
    public async Task RannumberCommand(CommandContext ctx, int min, int max)
    {
        var random = new Random();
        await ctx.RespondAsync($"Your number is: {random.Next(min, max)}");

    }

    [Command("RepTest")]
    public async Task ReptestCommand(CommandContext ctx)
    {
        var msg = await new DiscordMessageBuilder()
            .WithContent($"Testing, testing! Do we have a reply, Nayoko?")
            .WithReply(ctx.Message.Id)
            .SendAsync(ctx.Channel);
    }

    [Command("EmbedTest")]
    public async Task EmbedtestCommand(CommandContext ctx)
    {
        var msg = new DiscordEmbedBuilder()
            .WithAuthor("Test")
            .WithTitle("Another test")
            .WithImageUrl("https://c.tenor.com/BoYBoopIkBcAAAAC/anime-smash.gif");
        await ctx.RespondAsync(msg);
    }
}
//test